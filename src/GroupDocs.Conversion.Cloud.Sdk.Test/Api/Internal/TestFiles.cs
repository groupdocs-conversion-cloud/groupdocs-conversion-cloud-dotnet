// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="TestFiles.cs">
//  Copyright (c) 2003-2021 Aspose Pty Ltd
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

namespace GroupDocs.Conversion.Cloud.Sdk.Test.Api.Internal
{
    public static class TestFiles
    {
        public static readonly TestFile OnePageDocx = new TestFile("one-page.docx", "WordProcessing\\");
        public static readonly TestFile NotExist = new TestFile("NotExist.docx", "some-folder/");
        public static readonly TestFile PasswordProtectedDocx = new TestFile("password-protected.docx", "WordProcessing\\")
        {
            Password = "password"
        };
        public static readonly TestFile FourPagesDocx = new TestFile("four-pages.docx", "WordProcessing\\");

        public static IEnumerable<TestFile> TestFilesList
        {
            get
            {
                yield return OnePageDocx;
                yield return PasswordProtectedDocx;
                yield return FourPagesDocx;
            }
        }
    }
}
