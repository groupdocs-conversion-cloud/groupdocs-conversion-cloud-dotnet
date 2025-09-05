// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd">
//  Copyright (c) Aspose Pty Ltd
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

using System.Collections.Generic;
using System.IO;
using GroupDocs.Conversion.Cloud.Sdk.Client;
using GroupDocs.Conversion.Cloud.Sdk.Model;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;
using GroupDocs.Conversion.Cloud.Sdk.Test.Api.Internal;

namespace GroupDocs.Conversion.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;

    public class ConvertApiTests : BaseApiTest
    {
        /// <summary>
        /// Test ConvertDocumentTest
        /// </summary>
        [TestCaseSource(typeof(ConvertOptionsTestCaseBuilder), nameof(ConvertOptionsTestCaseBuilder.Conversions))]
        public void ConvertDocumentTest(TestFile testFile, string targetFormat, ConvertOptions convertOptions)
        {
            var format = targetFormat;
            var options = convertOptions;
            var filePath = testFile.FullName;

            var settings = new ConvertSettings
            {
                FilePath = filePath,
                Format = format,
                ConvertOptions = options,
                OutputPath = "converted"
            };

            var result = ConvertApi.ConvertDocument(new ConvertDocumentRequest(settings));

            Assert.NotNull(result);
            Assert.Greater(result.Count, 0);
            var convertedExtension = Path.GetExtension(result[0].Name);
            Assert.NotNull(convertedExtension);
            Assert.AreEqual(targetFormat, convertedExtension.Substring(1));
        }


        /// <summary>
        /// Test ConvertDocumentTest
        /// </summary>
        [TestCaseSource(typeof(ConvertOptionsTestCaseBuilder), nameof(ConvertOptionsTestCaseBuilder.Conversions))]
        public void ConvertDocumentDownloadTest(TestFile testFile, string targetFormat, ConvertOptions convertOptions)
        {
            var format = targetFormat;
            var options = convertOptions;
            var filePath = testFile.FullName;

            var settings = new ConvertSettings
            {
                FilePath = filePath,
                Format = format,
                ConvertOptions = options
            };

            var result = ConvertApi.ConvertDocumentDownload(new ConvertDocumentRequest(settings));

            Assert.IsNotNull(result);
            Assert.Greater(result.Length, 0);
        }

        [Test]
        public void ConvertDocumentDirectTest()
        {
            var format = "pdf";
            var testFile = TestFiles.FourPagesDocx;

            var request = new ConvertDocumentDirectRequest(format, GetTestFileStream(testFile));
            var result = ConvertApi.ConvertDocumentDirect(request);

            Assert.IsNotNull(result);
            Assert.Greater(result.Length, 0);
        }

        [Test]
        public void TestConvertMissingSettings()
        {
            // Arrange
            var request = new ConvertDocumentRequest(null);

            // Act & Assert    
            var ex = Assert.Throws<ApiException>(() =>
            {
                ConvertApi.ConvertDocumentDownload(request);
            });
            Assert.True(ex.Message.Contains("Missing required parameter 'convertSettings'"));
        }

        [Test]
        public void TestConversionFileNotFound()
        {
            var settings = new ConvertSettings
            {
                FilePath = TestFiles.NotExist.FullName,
                Format = "pdf"
            };

            // Arrange
            var request = new ConvertDocumentRequest(settings);

            // Act & Assert    
            var ex = Assert.Throws<ApiException>(() =>
            {
                ConvertApi.ConvertDocumentDownload(request);
            });
            Assert.True(ex.Message.Contains("The specified key does not exist") || ex.Message.Contains("some-folder/NotExist.docx"));
        }

        [Test]
        // https://issue.lisbon.dynabic.com/issues/CONVERSIONNET-4591
        public void TestConversionFontSubs()
        {
            // Prepare convert settings
            var loadOptions = new OneLoadOptions
            {
                FontSubstitutes = new Dictionary<string, string>
                {
                    {"Tahoma", "Arial"}, {"Times New Roman", "Arial"}
                }
            };

            var settings = new ConvertSettings
            {
                FilePath = TestFiles.OneNote.FullName,
                Format = "pdf",
                LoadOptions = loadOptions,
                OutputPath = "converted"
            };


            // Convert to specified format
            var response = ConvertApi.ConvertDocument(new ConvertDocumentRequest(settings));
        }

        [Test]
        public void ConvertDocumentDirectTestWithOptions()
        {
            var format = "pdf";
            var testFile = TestFiles.PasswordProtectedDocx;

            var loadOptions = new WordProcessingLoadOptions
            {
                Format = "docx",
                Password = TestFiles.PasswordProtectedDocx.Password
            };
            var convertOptions = new PdfConvertOptions();

            var request = new ConvertDocumentDirectRequest(format, GetTestFileStream(testFile), null, null, loadOptions, convertOptions);
            var result = ConvertApi.ConvertDocumentDirect(request);

            Assert.IsNotNull(result);
            Assert.Greater(result.Length, 0);
        }
    }
}
