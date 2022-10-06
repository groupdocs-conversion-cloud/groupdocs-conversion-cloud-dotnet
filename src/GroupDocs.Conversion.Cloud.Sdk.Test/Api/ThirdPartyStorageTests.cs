// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd">
//  Copyright (c) 2003-2022 Aspose Pty Ltd
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

using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Client;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Conversion.Cloud.Sdk.Test.Api
{
    using GroupDocs.Conversion.Cloud.Sdk.Test.Api.Internal;
    using Newtonsoft.Json;
    using NUnit.Framework;
    using System.IO;
    using System.Reflection;
    using System.Text;
    using System;
    using GroupDocs.Conversion.Cloud.Sdk.Model;

    public class ThirdPartyStorageTests
    {
        private readonly string _appSid = Config.AppSid;
        private readonly string _appKey = Config.AppKey;
        private readonly string _apiBaseUrl = Config.ApiBaseUrl;

        protected ConvertApi ConvertApi;
        protected InfoApi InfoApi;
        protected FileApi FileApi;
        protected FolderApi FolderApi;
        protected StorageApi StorageApi;

        [OneTimeSetUp]
        public void BeforeAllTests()
        {
            var config = new Configuration(_appSid, _appKey)
            {
                ApiBaseUrl = _apiBaseUrl
            };

            ConvertApi = new ConvertApi(config);
            InfoApi = new InfoApi(config);
            FileApi = new FileApi(config);
            FolderApi = new FolderApi(config);
            StorageApi = new StorageApi(config);
        }

        /// <summary>
        /// Test Conversion using Third Party Storage
        /// </summary>
        [Test]
        public void TestConversionAtThirdPartyStorage()
        {
            var testFile = TestFiles.FourPagesDocx;
            var storageName = "week";
            var targetFormat = "pdf";

            var deleteRequest = new DeleteFileRequest { path = testFile.FullName, storageName = storageName };
            var existsRequest = new ObjectExistsRequest { path = testFile.FullName, storageName = storageName };
            var uploadRequest = new UploadFileRequest(testFile.FullName, GetTestFileStream(testFile), storageName);

            FileApi.DeleteFile(deleteRequest);
            var response = StorageApi.ObjectExists(existsRequest);
            Assert.IsFalse(response.Exists);
            FileApi.UploadFile(uploadRequest);
            response = StorageApi.ObjectExists(existsRequest);
            Assert.IsTrue(response.Exists);

            var settings = new ConvertSettings
            {
                FilePath = testFile.FullName,
                StorageName = storageName,
                Format = targetFormat,
                OutputPath = "converted.pdf"
            };

            var result = ConvertApi.ConvertDocument(new ConvertDocumentRequest(settings));

            Assert.NotNull(result);
            Assert.Greater(result.Count, 0);
            var convertedExtension = Path.GetExtension(result[0].Name);
            Assert.NotNull(convertedExtension);
            Assert.AreEqual(targetFormat, convertedExtension.Substring(1));
            
            var request = new DownloadFileRequest { path = result[0].Path, storageName = storageName };
            
            var dResponse = FileApi.DownloadFile(request);
            Assert.Greater(dResponse.Length, 0);
        }



        ////////////////////////////////////////////////////////////////////////////////////////////////////////
        private byte[] GetTestFileBytes(TestFile file)
        {
            var filePath = Path.Combine(GetTestDataPath(), file.Folder, file.FileName);
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("File not found: " + filePath);
            }

            return File.ReadAllBytes(filePath);
        }

        protected Stream GetTestFileStream(TestFile file)
        {
            var bytes = GetTestFileBytes(file);

            return new MemoryStream(bytes);
        }

        // ReSharper disable once UnusedMember.Global
        protected Stream SerializeObject(object obj)
        {
            var options = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };
            var json = JsonConvert.SerializeObject(obj, options);

            var bytes = Encoding.UTF8.GetBytes(json);

            return new MemoryStream(bytes);
        }

        private static string GetTestDataPath()
        {
            var uri = new Uri(Assembly.GetExecutingAssembly().CodeBase);
            var workingDir = Path.GetDirectoryName(uri.LocalPath) ?? Directory.GetCurrentDirectory();

            var baseDir = Path.Combine(workingDir, "Resources", "TestData");

            return Path.GetFullPath(baseDir);
        }
    }
}