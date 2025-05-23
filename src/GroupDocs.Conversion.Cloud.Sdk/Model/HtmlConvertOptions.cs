// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="HtmlConvertOptions.cs">
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
    /// Options for to Html conversion
    /// </summary>  
    public class HtmlConvertOptions : ConvertOptions 
    {                       
        /// <summary>
        /// If true, the input firstly is converted to PDF and after that to desired format
        /// </summary>  
        public bool? UsePdf { get; set; }

        /// <summary>
        /// If true fixed layout will be used e.g. absolutely positioned html elements Default:  true
        /// </summary>  
        public bool? FixedLayout { get; set; }

        /// <summary>
        /// Show page borders when converting to fixed layout. Default is True
        /// </summary>  
        public bool? FixedLayoutShowBorders { get; set; }

        /// <summary>
        /// Specifies the zoom level in percentage. Default is 100.
        /// </summary>  
        public int? Zoom { get; set; }

        /// <summary>
        /// Watermark specific options
        /// </summary>  
        public WatermarkOptions WatermarkOptions { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class HtmlConvertOptions {\n");
          sb.Append("  UsePdf: ").Append(this.UsePdf).Append("\n");
          sb.Append("  FixedLayout: ").Append(this.FixedLayout).Append("\n");
          sb.Append("  FixedLayoutShowBorders: ").Append(this.FixedLayoutShowBorders).Append("\n");
          sb.Append("  Zoom: ").Append(this.Zoom).Append("\n");
          sb.Append("  WatermarkOptions: ").Append(this.WatermarkOptions).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
