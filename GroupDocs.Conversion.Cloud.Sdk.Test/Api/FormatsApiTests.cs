using GroupDocs.Conversion.Cloud.Sdk.Test.Internal;

namespace GroupDocs.Conversion.Cloud.Sdk.Test.Api
{
    using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;
    using NUnit.Framework;

    public class FormatsApiTests : BaseApiTest
    {
        /// <summary>
        /// Test GetSupportedFileFormats
        /// </summary>
        [Test]
        public void GetSupportedFileFormatsTest()
        {
            var request = new GetAllPossibleConversionsRequest();

            var response = ConversionApi.GetAllPossibleConversions(request);

            Assert.IsNotNull(response.Conversions);
            Assert.IsTrue(response.Conversions.Count > 0);

            foreach (var entry in response.Conversions)
            {
                Assert.IsNotEmpty(entry.SourceFileType);
                Assert.IsNotEmpty(entry.PossibleConversions);
            }
        }

        /// <summary>
        /// Test GetSupportedFileFormatsForSpecificFileType
        /// </summary>
        [Test]
        public void GetSupportedFileFormatsForSpecificFileTypeTest()
        {
            var request = new GetPossibleConversionsForFileTypeRequest("docx");

            var response = ConversionApi.GetPossibleConversionsForFileType(request);

            Assert.IsTrue(response.PossibleConversions.Count > 0);
            Assert.AreEqual("docx", response.SourceFileType);
            foreach (var entry in response.PossibleConversions)
            {
                Assert.IsNotEmpty(entry);
            }
        }


        /// <summary>
        /// Test PossibleConversionsForDocument
        /// </summary>
        [Test]
        public void PossibleConversionsForDocumentTest()
        {
            var stream = GetTestFileStream(TestFiles.OnePageDocx);
            var request = new PossibleConversionsForDocumentRequest(stream);

            var response = ConversionApi.PossibleConversionsForDocument(request);

            Assert.IsTrue(response.PossibleConversions.Count > 0);
            Assert.AreEqual("stream", response.SourceFileType);
            foreach (var entry in response.PossibleConversions)
            {
                Assert.IsNotEmpty(entry);
            }
            stream.Dispose();
        }
    }
}