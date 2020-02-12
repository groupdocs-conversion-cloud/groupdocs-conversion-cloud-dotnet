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

using System.IO;
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
    }
}