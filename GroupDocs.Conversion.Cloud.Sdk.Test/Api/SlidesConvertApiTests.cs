using GroupDocs.Conversion.Cloud.Sdk.Model;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;
using GroupDocs.Conversion.Cloud.Sdk.Test.Internal;
using NUnit.Framework;

namespace GroupDocs.Conversion.Cloud.Sdk.Test.Api
{
    public class SlidesConvertApiTests : BaseApiTest
    {
        /// <summary>
        /// Test ConvertToSlides
        /// </summary>
        [Test]
        public void ConvertToSlides()
        {
            var file = TestFiles.OnePageDocx;

            var request = new ConvertToSlidesRequest
            {
                Request = new SlidesConversionRequest
                {
                    SourceFile = ToConversionFileInfo(file),
                    Options = new SlidesSaveOptionsDto()
                }
            };

            var response = ConversionApi.ConvertToSlides(request);

            Assert.IsNotNull(response);
            Assert.IsTrue(response.Href.EndsWith(".pptx"));
        }

        /// <summary>
        /// Test ConvertToSlidesStream
        /// </summary>
        [Test]
        public void ConvertToSlidesStream()
        {
            var file = TestFiles.OnePageDocx;

            var request = new ConvertToSlidesStreamRequest
            {
                Request = new SlidesConversionRequest
                {
                    SourceFile = ToConversionFileInfo(file),
                    Options = new SlidesSaveOptionsDto()
                }
            };

            var response = ConversionApi.ConvertToSlidesStream(request);

            Assert.IsNotNull(response);
            Assert.Greater(response.Length, 0);
        }
    }
}