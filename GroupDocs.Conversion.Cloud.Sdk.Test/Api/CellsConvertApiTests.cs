namespace GroupDocs.Conversion.Cloud.Sdk.Test.Api
{
    using GroupDocs.Conversion.Cloud.Sdk.Model;
    using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;
    using GroupDocs.Conversion.Cloud.Sdk.Test.Internal;
    using NUnit.Framework;

    public class CellsConvertApiTests : BaseApiTest
    {
        /// <summary>
        /// Test ConvertToCells
        /// </summary>
        [Test]
        public void ConvertToCells()
        {
            var file = TestFiles.OnePageDocx;

            var request = new ConvertToCellsRequest
            {
                Settings = new CellsConversionSettings
                {
                    SourceFile = ToConversionFileInfo(file),
                    Options = new CellsSaveOptionsDto()
                }
            };

            var response = ConversionApi.ConvertToCells(request);

            Assert.IsNotNull(response);
            Assert.IsTrue(response.Href.EndsWith(".xlsx"));
        }

        /// <summary>
        /// Test ConvertToCellsStream
        /// </summary>
        [Test]
        public void ConvertToCellsStream()
        {
            var file = TestFiles.OnePageDocx;

            var request = new ConvertToCellsStreamRequest
            {
                Settings = new CellsConversionSettings
                {
                    SourceFile = ToConversionFileInfo(file),
                    Options = new CellsSaveOptionsDto()
                }
            };

            var response = ConversionApi.ConvertToCellsStream(request);

            Assert.IsNotNull(response);
            Assert.Greater(response.Length, 0);
        }
    }
}