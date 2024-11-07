// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="WebLoadOptions.cs">
//  Copyright (c) 2003-2024 Aspose Pty Ltd
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
    /// Html document load options
    /// </summary>  
    public class WebLoadOptions : LoadOptions 
    {                       
        /// <summary>
        /// Controls how HTML content is rendered. Default: AbsolutePositioning
        /// </summary>
        /// <value>Controls how HTML content is rendered. Default: AbsolutePositioning</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RenderingModeEnum
        { 
            /// <summary>
            /// Enum Flow for "Flow"
            /// </summary>            
            Flow,
            
            /// <summary>
            /// Enum AbsolutePositioning for "AbsolutePositioning"
            /// </summary>            
            AbsolutePositioning            
        }

        /// <summary>
        /// Controls how HTML content is rendered. Default: AbsolutePositioning
        /// </summary>
        public RenderingModeEnum? RenderingMode { get; set; }

        /// <summary>
        /// Enable or disable generation of page numbering in converted document. Default: false
        /// </summary>  
        public bool? PageNumbering { get; set; }

        /// <summary>
        /// Get or sets the encoding to be used when loading the web document. If the property is null the encoding will be determined from document character set attribute
        /// </summary>  
        public string Encoding { get; set; }

        /// <summary>
        /// Use pdf for the conversion. Default: false
        /// </summary>  
        public bool? UsePdf { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class WebLoadOptions {\n");
          sb.Append("  PageNumbering: ").Append(this.PageNumbering).Append("\n");
          sb.Append("  Encoding: ").Append(this.Encoding).Append("\n");
          sb.Append("  UsePdf: ").Append(this.UsePdf).Append("\n");
          sb.Append("  RenderingMode: ").Append(this.RenderingMode).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
