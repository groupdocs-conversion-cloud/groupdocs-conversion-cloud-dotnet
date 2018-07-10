// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="CellsOptionsDto.cs">
//  Copyright (c) 2003-2018 Aspose Pty Ltd
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
  /// Options for converting Cells documents
  /// </summary>  
  public class CellsOptionsDto 
  {                       
        /// <summary>
        /// Show grid lines when converting Excel files
        /// </summary>  
        public bool? ShowGridLines { get; set; }

        /// <summary>
        /// Show hidden sheets when converting Excel files
        /// </summary>  
        public bool? ShowHiddenSheets { get; set; }

        /// <summary>
        /// If OnePagePerSheet is true the content of the sheet will be converted to one page in the PDF document. Default value is true.
        /// </summary>  
        public bool? OnePagePerSheet { get; set; }

        /// <summary>
        /// If True and converting to Pdf the conversion is optimized for better file size than print quality
        /// </summary>  
        public bool? OptimizePdfSize { get; set; }

        /// <summary>
        /// Convert specific range when converting to other than cells format. Example: \"D1:F8\"
        /// </summary>  
        public string ConvertRange { get; set; }

        /// <summary>
        /// Skips empty rows and columns when converting. Default is True.
        /// </summary>  
        public bool? SkipEmptyRowsAndColumns { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class CellsOptionsDto {\n");
          sb.Append("  ShowGridLines: ").Append(this.ShowGridLines).Append("\n");
          sb.Append("  ShowHiddenSheets: ").Append(this.ShowHiddenSheets).Append("\n");
          sb.Append("  OnePagePerSheet: ").Append(this.OnePagePerSheet).Append("\n");
          sb.Append("  OptimizePdfSize: ").Append(this.OptimizePdfSize).Append("\n");
          sb.Append("  ConvertRange: ").Append(this.ConvertRange).Append("\n");
          sb.Append("  SkipEmptyRowsAndColumns: ").Append(this.SkipEmptyRowsAndColumns).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
