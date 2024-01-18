// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="EBookConvertOptions.cs">
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
    /// Ebook convert options
    /// </summary>  
    public class EBookConvertOptions : ConvertOptions 
    {                       
        /// <summary>
        /// Specifies page size
        /// </summary>
        /// <value>Specifies page size</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PageSizeEnum
        { 
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>            
            Default,
            
            /// <summary>
            /// Enum A3 for "A3"
            /// </summary>            
            A3,
            
            /// <summary>
            /// Enum Statement for "Statement"
            /// </summary>            
            Statement,
            
            /// <summary>
            /// Enum Quarto for "Quarto"
            /// </summary>            
            Quarto,
            
            /// <summary>
            /// Enum Paper11x17 for "Paper11x17"
            /// </summary>            
            Paper11x17,
            
            /// <summary>
            /// Enum Paper10x14 for "Paper10x14"
            /// </summary>            
            Paper10x14,
            
            /// <summary>
            /// Enum Letter for "Letter"
            /// </summary>            
            Letter,
            
            /// <summary>
            /// Enum Legal for "Legal"
            /// </summary>            
            Legal,
            
            /// <summary>
            /// Enum Ledger for "Ledger"
            /// </summary>            
            Ledger,
            
            /// <summary>
            /// Enum Folio for "Folio"
            /// </summary>            
            Folio,
            
            /// <summary>
            /// Enum Executive for "Executive"
            /// </summary>            
            Executive,
            
            /// <summary>
            /// Enum EnvelopeDL for "EnvelopeDL"
            /// </summary>            
            EnvelopeDL,
            
            /// <summary>
            /// Enum Custom for "Custom"
            /// </summary>            
            Custom,
            
            /// <summary>
            /// Enum B5 for "B5"
            /// </summary>            
            B5,
            
            /// <summary>
            /// Enum B4 for "B4"
            /// </summary>            
            B4,
            
            /// <summary>
            /// Enum A5 for "A5"
            /// </summary>            
            A5,
            
            /// <summary>
            /// Enum A4 for "A4"
            /// </summary>            
            A4,
            
            /// <summary>
            /// Enum Tabloid for "Tabloid"
            /// </summary>            
            Tabloid            
        }

        /// <summary>
        /// Specifies page orientation
        /// </summary>
        /// <value>Specifies page orientation</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PageOrientationEnum
        { 
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>            
            Default,
            
            /// <summary>
            /// Enum Landscape for "Landscape"
            /// </summary>            
            Landscape,
            
            /// <summary>
            /// Enum Portrait for "Portrait"
            /// </summary>            
            Portrait            
        }

        /// <summary>
        /// Specifies page size
        /// </summary>
        public PageSizeEnum? PageSize { get; set; }

        /// <summary>
        /// Specifies page orientation
        /// </summary>
        public PageOrientationEnum? PageOrientation { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class EBookConvertOptions {\n");
          sb.Append("  PageSize: ").Append(this.PageSize).Append("\n");
          sb.Append("  PageOrientation: ").Append(this.PageOrientation).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
