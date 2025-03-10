// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="TxtLoadOptions.cs">
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
    /// Txt document load options
    /// </summary>  
    public class TxtLoadOptions : LoadOptions 
    {                       
        /// <summary>
        /// Gets or sets preferred option of a trailing space handling. Default value is Trim.
        /// </summary>
        /// <value>Gets or sets preferred option of a trailing space handling. Default value is Trim.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TrailingSpacesOptionsEnum
        { 
            /// <summary>
            /// Enum Preserve for "Preserve"
            /// </summary>            
            Preserve,
            
            /// <summary>
            /// Enum Trim for "Trim"
            /// </summary>            
            Trim            
        }

        /// <summary>
        /// Gets or sets preferred option of a leading space handling. Default value is ConvertToIndent.
        /// </summary>
        /// <value>Gets or sets preferred option of a leading space handling. Default value is ConvertToIndent.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LeadingSpacesOptionsEnum
        { 
            /// <summary>
            /// Enum ConvertToIndent for "ConvertToIndent"
            /// </summary>            
            ConvertToIndent,
            
            /// <summary>
            /// Enum Preserve for "Preserve"
            /// </summary>            
            Preserve,
            
            /// <summary>
            /// Enum Trim for "Trim"
            /// </summary>            
            Trim            
        }

        /// <summary>
        /// Gets or sets preferred option of a trailing space handling. Default value is Trim.
        /// </summary>
        public TrailingSpacesOptionsEnum? TrailingSpacesOptions { get; set; }

        /// <summary>
        /// Gets or sets preferred option of a leading space handling. Default value is ConvertToIndent.
        /// </summary>
        public LeadingSpacesOptionsEnum? LeadingSpacesOptions { get; set; }

        /// <summary>
        /// Allows to specify how numbered list items are recognized when plain text document is converted. The default value is true.
        /// </summary>  
        public bool? DetectNumberingWithWhitespaces { get; set; }

        /// <summary>
        /// Gets or sets the encoding that will be used when loading Txt document. Can be null. Default is null.
        /// </summary>  
        public string Encoding { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class TxtLoadOptions {\n");
          sb.Append("  DetectNumberingWithWhitespaces: ").Append(this.DetectNumberingWithWhitespaces).Append("\n");
          sb.Append("  TrailingSpacesOptions: ").Append(this.TrailingSpacesOptions).Append("\n");
          sb.Append("  LeadingSpacesOptions: ").Append(this.LeadingSpacesOptions).Append("\n");
          sb.Append("  Encoding: ").Append(this.Encoding).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
