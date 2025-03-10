// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="CadLoadOptions.cs">
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
    /// Options for loading CAD documents
    /// </summary>  
    public class CadLoadOptions : LoadOptions 
    {                       
        /// <summary>
        /// Gets or sets type of drawing.
        /// </summary>
        /// <value>Gets or sets type of drawing.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DrawTypeEnum
        { 
            /// <summary>
            /// Enum UseDrawColor for "UseDrawColor"
            /// </summary>            
            UseDrawColor,
            
            /// <summary>
            /// Enum UseObjectColor for "UseObjectColor"
            /// </summary>            
            UseObjectColor            
        }

        /// <summary>
        /// Gets or sets type of drawing.
        /// </summary>
        public DrawTypeEnum? DrawType { get; set; }

        /// <summary>
        /// Render specific CAD layouts
        /// </summary>  
        public List<string> LayoutNames { get; set; }

        /// <summary>
        /// Gets or sets a background color.
        /// </summary>  
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class CadLoadOptions {\n");
          sb.Append("  LayoutNames: ").Append(this.LayoutNames).Append("\n");
          sb.Append("  BackgroundColor: ").Append(this.BackgroundColor).Append("\n");
          sb.Append("  DrawType: ").Append(this.DrawType).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
