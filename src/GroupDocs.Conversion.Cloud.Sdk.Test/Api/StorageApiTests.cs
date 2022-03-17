﻿// --------------------------------------------------------------------------------------------------------------------
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

using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;
using GroupDocs.Conversion.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Conversion.Cloud.Sdk.Test.Api
{
    public class StorageApiTests : BaseApiTest
    {
        private const string StorageName = "First Storage";

        [Test]
        public void TestGetDiscUsage()
        {
            // Arrange
            var request = new GetDiscUsageRequest();

            // Act & Assert 
            var response = StorageApi.GetDiscUsage(request);

            Assert.NotNull(response);
            Assert.Greater(response.TotalSize, 0);
            Assert.Greater(response.UsedSize, 0);
        }

        [Test]
        public void TestStorageExist()
        {
            // Arrange
            var request = new StorageExistsRequest {storageName = StorageName};

            // Act & Assert 
            var response = StorageApi.StorageExists(request);

            Assert.NotNull(response);
            Assert.IsTrue(response.Exists);            
        }

        [Test]
        public void TestGetFileVersions()
        {
            // Arrange
            var testFile = TestFiles.OnePageDocx;
            var request = new GetFileVersionsRequest { path = testFile.FullName };

            // Act & Assert 
            var response = StorageApi.GetFileVersions(request);

            Assert.NotNull(response);
            Assert.Greater(response.Value.Count, 0);
        }

        [Test]
        public void TestObjectExists()
        {
            // Arrange
            var testFile = TestFiles.OnePageDocx;
            var request = new ObjectExistsRequest { path = testFile.FullName };

            // Act & Assert 
            var response = StorageApi.ObjectExists(request);

            Assert.NotNull(response);
            Assert.IsTrue(response.Exists);
            Assert.IsFalse(response.IsFolder);
        }
    }
}
