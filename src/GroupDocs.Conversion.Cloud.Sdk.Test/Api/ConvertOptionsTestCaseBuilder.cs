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
                new TestCaseData(TestFiles.OnePageDocx, "bmp", new BmpConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "gif", new GifConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "ico", new IcoConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "jp2", new Jp2ConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "jpeg", new JpegConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "jpg", new JpgConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "png", new PngConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "psd", new PsdConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "svg", new PDLConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "tif", new TifConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "tiff", new TiffConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "webp", new WebpConvertOptions()),
                
                new TestCaseData(TestFiles.OnePageDocx, "epub", new EBookConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "pdf", new PdfConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "xps", new PDLConvertOptions()),

                new TestCaseData(TestFiles.OnePageDocx, "odp", new OdpConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "otp", new OtpConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "potm", new PotmConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "potx", new PotxConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "pps", new PpsConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "ppsm", new PpsmConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "ppsx", new PpsxConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "ppt", new PptConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "pptm", new PptmConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "pptx", new PptxConvertOptions()),

                new TestCaseData(TestFiles.OnePageDocx, "ods", new OdsConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "tsv", new TsvConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "xlsb", new XlsbConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "xls", new XlsConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "xlsm", new XlsmConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "xlsx", new XlsxConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "xltm", new XltmConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "xltx", new XltxConvertOptions()),

                new TestCaseData(TestFiles.OnePageDocx, "doc", new DocConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "docm", new DocmConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "docx", new DocxConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "dot", new DotConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "dotm", new DotmConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "dotx", new DotxConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "odt", new OdtConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "ott", new OttConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "rtf", new RtfConvertOptions()),
                new TestCaseData(TestFiles.OnePageDocx, "txt", new TxtConvertOptions()),

                new TestCaseData(TestFiles.OnePageDocx, "html", new WebConvertOptions()),
            };
            return result;
        }
    }
}