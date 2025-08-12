// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="SpreadsheetLoadOptions.cs">
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

namespace GroupDocs.Conversion.Cloud.Sdk.Model 
{
    using System;  
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    
    /// <summary>
    /// Spreadsheet document load options
    /// </summary>  
    public class SpreadsheetLoadOptions : LoadOptions 
    {                       
        /// <summary>
        /// Represents the way comments are printed with the sheet. Default is PrintNoComments.
        /// </summary>
        /// <value>Represents the way comments are printed with the sheet. Default is PrintNoComments.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PrintCommentsEnum
        { 
            /// <summary>
            /// Enum PrintInPlace for "PrintInPlace"
            /// </summary>            
            PrintInPlace,
            
            /// <summary>
            /// Enum PrintNoComments for "PrintNoComments"
            /// </summary>            
            PrintNoComments,
            
            /// <summary>
            /// Enum PrintSheetEnd for "PrintSheetEnd"
            /// </summary>            
            PrintSheetEnd,
            
            /// <summary>
            /// Enum PrintWithThreadedComments for "PrintWithThreadedComments"
            /// </summary>            
            PrintWithThreadedComments            
        }

        /// <summary>
        /// Represents the way comments are printed with the sheet. Default is PrintNoComments.
        /// </summary>
        public PrintCommentsEnum? PrintComments { get; set; }

        /// <summary>
        /// Clear custom document properties. Default is false.
        /// </summary>  
        public bool? ClearCustomDocumentProperties { get; set; }

        /// <summary>
        /// Clear built-in document properties. Default is false.
        /// </summary>  
        public bool? ClearBuiltInDocumentProperties { get; set; }

        /// <summary>
        /// Split a worksheet into pages by rows. Default is 0, no pagination.
        /// </summary>  
        public int? RowsPerPage { get; set; }

        /// <summary>
        /// Split a worksheet into pages by columns. Default is 0, no pagination.
        /// </summary>  
        public int? ColumnsPerPage { get; set; }

        /// <summary>
        /// Autofits all rows when converting
        /// </summary>  
        public bool? AutoFitRows { get; set; }

        /// <summary>
        /// If AllColumnsInOnePagePerSheet is true, all column content of one sheet will output to only one page in result. The width of paper size of pagesetup will be invalid, and the other settings of pagesetup will still take effect.             
        /// </summary>  
        public bool? AllColumnsInOnePagePerSheet { get; set; }

        /// <summary>
        /// System culture info at the time file is loaded
        /// </summary>  
        public string CultureInfo { get; set; }

        /// <summary>
        /// Whether check restriction of excel file when user modify cells related objects. For example, excel does not allow inputting string value longer than 32K. When you input a value longer than 32K, if this property is true, you will get an Exception. If this property is false, we will accept your input string value as the cell's value so that later you can output the complete string value for other file formats such as CSV. However, if you have set such kind of value that is invalid for excel file format, you should not save the workbook as excel file format later. Otherwise there may be unexpected error for the generated excel file.             
        /// </summary>  
        public bool? CheckExcelRestriction { get; set; }

        /// <summary>
        /// Set password to unprotect protected document
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Skips empty rows and columns when converting. Default is True.
        /// </summary>  
        public bool? SkipEmptyRowsAndColumns { get; set; }

        /// <summary>
        /// Convert specific range when converting to other than cells format. Example: \"D1:F8\"
        /// </summary>  
        public string ConvertRange { get; set; }

        /// <summary>
        /// If True and converting to Pdf the conversion is optimized for better file size than print quality.             
        /// </summary>  
        public bool? OptimizePdfSize { get; set; }

        /// <summary>
        /// If OnePagePerSheet is true the content of the sheet will be converted to one page in the PDF document. Default value is true.
        /// </summary>  
        public bool? OnePagePerSheet { get; set; }

        /// <summary>
        /// Show hidden sheets when converting Excel files
        /// </summary>  
        public bool? ShowHiddenSheets { get; set; }

        /// <summary>
        /// Show grid lines when converting Excel files
        /// </summary>  
        public bool? ShowGridLines { get; set; }

        /// <summary>
        /// Substitute specific fonts when converting Cells document.
        /// </summary>  
        public Dictionary<string, string> FontSubstitutes { get; set; }

        /// <summary>
        /// Default font for Cells document. The following font will be used if a font is missing.
        /// </summary>  
        public string DefaultFont { get; set; }

        /// <summary>
        /// List of sheet indexes to convert. The indexes must be zero-based
        /// </summary>  
        public List<int?> SheetIndexes { get; set; }

        /// <summary>
        /// List of sheet names to convert
        /// </summary>  
        public List<string> Sheets { get; set; }

        /// <summary>
        /// Reset font folders before loading document
        /// </summary>  
        public bool? ResetFontFolders { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SpreadsheetLoadOptions {\n");
          sb.Append("  ClearCustomDocumentProperties: ").Append(this.ClearCustomDocumentProperties).Append("\n");
          sb.Append("  ClearBuiltInDocumentProperties: ").Append(this.ClearBuiltInDocumentProperties).Append("\n");
          sb.Append("  RowsPerPage: ").Append(this.RowsPerPage).Append("\n");
          sb.Append("  ColumnsPerPage: ").Append(this.ColumnsPerPage).Append("\n");
          sb.Append("  AutoFitRows: ").Append(this.AutoFitRows).Append("\n");
          sb.Append("  AllColumnsInOnePagePerSheet: ").Append(this.AllColumnsInOnePagePerSheet).Append("\n");
          sb.Append("  CultureInfo: ").Append(this.CultureInfo).Append("\n");
          sb.Append("  CheckExcelRestriction: ").Append(this.CheckExcelRestriction).Append("\n");
          sb.Append("  Password: ").Append(this.Password).Append("\n");
          sb.Append("  SkipEmptyRowsAndColumns: ").Append(this.SkipEmptyRowsAndColumns).Append("\n");
          sb.Append("  ConvertRange: ").Append(this.ConvertRange).Append("\n");
          sb.Append("  OptimizePdfSize: ").Append(this.OptimizePdfSize).Append("\n");
          sb.Append("  OnePagePerSheet: ").Append(this.OnePagePerSheet).Append("\n");
          sb.Append("  ShowHiddenSheets: ").Append(this.ShowHiddenSheets).Append("\n");
          sb.Append("  ShowGridLines: ").Append(this.ShowGridLines).Append("\n");
          sb.Append("  FontSubstitutes: ").Append(this.FontSubstitutes).Append("\n");
          sb.Append("  DefaultFont: ").Append(this.DefaultFont).Append("\n");
          sb.Append("  SheetIndexes: ").Append(this.SheetIndexes).Append("\n");
          sb.Append("  Sheets: ").Append(this.Sheets).Append("\n");
          sb.Append("  PrintComments: ").Append(this.PrintComments).Append("\n");
          sb.Append("  ResetFontFolders: ").Append(this.ResetFontFolders).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
