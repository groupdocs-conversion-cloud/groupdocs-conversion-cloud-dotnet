// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd">
//  Copyright (c) 2003-2019 Aspose Pty Ltd
// </copyright>
// <summary>
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using GroupDocs.Conversion.Cloud.Sdk.Model;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;
using GroupDocs.Conversion.Cloud.Sdk.Test.Api.Internal;

namespace GroupDocs.Conversion.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;

    public class ConversionApiTests : BaseApiTest
    {
        /// <summary>
        /// Test ConvertDocumentTest
        /// </summary>
        [TestCaseSource(typeof(ConvertOptionsTestCaseBuilder), "Conversions")]
        public void ConvertDocumentTest(TestFile testFile, string targetFormat, ConvertOptions convertOptions)
        {
            var format = targetFormat;
            var options = convertOptions;
            var filePath = testFile.FullName;

            var settings = new ConvertSettings
            {
                Storage = string.Empty,
                FilePath = filePath,
                Format = format,
                ConvertOptions = options,
                OutputPath = "converted"
            };

            ConversionApi.ConvertDocument(new ConvertDocumentRequest(settings));

            Assert.IsTrue(true);
        }

        /// <summary>
        /// Test GetSupportedConversionTypes
        /// </summary>
        [Test]
        public void GetSupportedConversionTypesTest()
        {
            var response = ConversionApi.GetSupportedConversionTypes(new GetSupportedConversionTypesRequest());

            Assert.IsTrue(response.Count > 0);
            foreach (var entry in response)
            {
                Assert.IsNotEmpty(entry.SourceFormat);
                Assert.IsTrue(entry.TargetFormats.Count > 0);
            }
        }
    }
}