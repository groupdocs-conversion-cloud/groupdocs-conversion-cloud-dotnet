using GroupDocs.Conversion.Cloud.Sdk.Model;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;
using GroupDocs.Conversion.Cloud.Sdk.Test.Internal;
using NUnit.Framework;

namespace GroupDocs.Conversion.Cloud.Sdk.Test.Api
{
    public class PdfConvertApiTests : BaseApiTest
    {
        /// <summary>
        /// Test ConvertToPdf
        /// </summary>
        [Test]
        public void ConvertToPdf()
        {
            var file = TestFiles.OnePageDocx;

            var request = new ConvertToPdfRequest
            {
                Request = new PdfConversionRequest
                {
                    SourceFile = ToConversionFileInfo(file),
                    Options = new PdfSaveOptionsDto()
                }
            };

            var response = ConversionApi.ConvertToPdf(request);

            Assert.IsNotNull(response);
            Assert.IsTrue(response.Href.EndsWith(".pdf"));
        }

        /// <summary>
        /// Test ConvertToPdfStream
        /// </summary>
        [Test]
        public void ConvertToPdfStream()
        {
            var file = TestFiles.OnePageDocx;

            var request = new ConvertToPdfStreamRequest
            {
                Request = new PdfConversionRequest
                {
                    SourceFile = ToConversionFileInfo(file),
                    Options = new PdfSaveOptionsDto()
                }
            };

            var response = ConversionApi.ConvertToPdfStream(request);

            Assert.IsNotNull(response);
            Assert.Greater(response.Length, 0);
        }
    }
}