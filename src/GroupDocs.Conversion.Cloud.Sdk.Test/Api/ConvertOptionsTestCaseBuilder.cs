using System.Collections.Generic;
using GroupDocs.Conversion.Cloud.Sdk.Model;
using GroupDocs.Conversion.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Conversion.Cloud.Sdk.Test.Api
{
    internal class ConvertOptionsTestCaseBuilder
    {
        public static IEnumerable<TestCaseData> Conversions()
        {
            var result = new List<TestCaseData>
            {
                new TestCaseData(TestFiles.OnePageDocx, "bmp", new ImageConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "gif", new ImageConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "ico", new ImageConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "jp2", new ImageConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "jpeg", new ImageConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "jpg", new ImageConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "png", new ImageConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "psd", new ImageConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "svg", new PDLConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "tif", new ImageConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "tiff", new ImageConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "webp", new ImageConvertOptions()),
                
                new TestCaseData(TestFiles.OnePageDocx, "epub", new EBookConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "pdf", new PdfConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "xps", new PDLConvertOptions()),

                new TestCaseData(TestFiles.OnePageDocx, "odp", new PresentationConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "otp", new PresentationConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "potm", new PresentationConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "potx", new PresentationConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "pps", new PresentationConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "ppsm", new PresentationConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "ppsx", new PresentationConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "ppt", new PresentationConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "pptm", new PresentationConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "pptx", new PresentationConvertOptions()),

                new TestCaseData(TestFiles.OnePageDocx, "ods", new SpreadsheetConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "tsv", new SpreadsheetConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "xlsb", new SpreadsheetConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "xls", new SpreadsheetConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "xlsm", new SpreadsheetConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "xlsx", new SpreadsheetConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "xltm", new SpreadsheetConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "xltx", new SpreadsheetConvertOptions()),

                new TestCaseData(TestFiles.OnePageDocx, "doc", new WordProcessingConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "docm", new WordProcessingConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "docx", new WordProcessingConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "dot", new WordProcessingConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "dotm", new WordProcessingConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "dotx", new WordProcessingConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "odt", new WordProcessingConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "ott", new WordProcessingConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "rtf", new WordProcessingConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "txt", new WordProcessingConvertOptions()),

                new TestCaseData(TestFiles.OnePageDocx, "html", new WebConvertOptions()),
            };
            return result;
        }
    }
}