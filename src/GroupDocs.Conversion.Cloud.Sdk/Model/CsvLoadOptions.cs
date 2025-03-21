// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="CsvLoadOptions.cs">
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
    /// Csv document load options
    /// </summary>  
    public class CsvLoadOptions : SpreadsheetLoadOptions 
    {                       
        /// <summary>
        /// Delimiter of a Csv file
        /// </summary>  
        public string Separator { get; set; }

        /// <summary>
        /// True means the file contains several encodings
        /// </summary>  
        public bool? IsMultiEncoded { get; set; }

        /// <summary>
        /// Indicates whether text is formula if it starts with \"=\"
        /// </summary>  
        public bool? HasFormula { get; set; }

        /// <summary>
        /// Indicates whether the string in the file is converted to numeric. Default is True
        /// </summary>  
        public bool? ConvertNumericData { get; set; }

        /// <summary>
        /// Indicates whether the string in the file is converted to date. Default is True
        /// </summary>  
        public bool? ConvertDateTimeData { get; set; }

        /// <summary>
        /// File encoding
        /// </summary>  
        public string Encoding { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class CsvLoadOptions {\n");
          sb.Append("  Separator: ").Append(this.Separator).Append("\n");
          sb.Append("  IsMultiEncoded: ").Append(this.IsMultiEncoded).Append("\n");
          sb.Append("  HasFormula: ").Append(this.HasFormula).Append("\n");
          sb.Append("  ConvertNumericData: ").Append(this.ConvertNumericData).Append("\n");
          sb.Append("  ConvertDateTimeData: ").Append(this.ConvertDateTimeData).Append("\n");
          sb.Append("  Encoding: ").Append(this.Encoding).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
