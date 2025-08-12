// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PdfLoadOptions.cs">
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
    /// Pdf document load options
    /// </summary>  
    public class PdfLoadOptions : LoadOptions 
    {                       
        /// <summary>
        /// Clear built-in document properties
        /// </summary>  
        public bool? ClearBuiltInDocumentProperties { get; set; }

        /// <summary>
        /// Clear custom document properties
        /// </summary>  
        public bool? ClearCustomDocumentProperties { get; set; }

        /// <summary>
        /// Enable or disable generation of page numbering in converted document. Default:     false
        /// </summary>  
        public bool? PageNumbering { get; set; }

        /// <summary>
        /// Flatten all the fields of the PDF form
        /// </summary>  
        public bool? FlattenAllFields { get; set; }

        /// <summary>
        /// Hide annotations in Pdf documents
        /// </summary>  
        public bool? HidePdfAnnotations { get; set; }

        /// <summary>
        /// Default font for Pdf document. The following font will be used if a font is missing.
        /// </summary>  
        public string DefaultFont { get; set; }

        /// <summary>
        /// Set password to unprotect protected document
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Remove javascript
        /// </summary>  
        public bool? RemoveJavascript { get; set; }

        /// <summary>
        /// Remove embedded files
        /// </summary>  
        public bool? RemoveEmbeddedFiles { get; set; }

        /// <summary>
        /// Substitute specific fonts when converting Words document.
        /// </summary>  
        public Dictionary<string, string> FontSubstitutes { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PdfLoadOptions {\n");
          sb.Append("  ClearBuiltInDocumentProperties: ").Append(this.ClearBuiltInDocumentProperties).Append("\n");
          sb.Append("  ClearCustomDocumentProperties: ").Append(this.ClearCustomDocumentProperties).Append("\n");
          sb.Append("  PageNumbering: ").Append(this.PageNumbering).Append("\n");
          sb.Append("  FlattenAllFields: ").Append(this.FlattenAllFields).Append("\n");
          sb.Append("  HidePdfAnnotations: ").Append(this.HidePdfAnnotations).Append("\n");
          sb.Append("  DefaultFont: ").Append(this.DefaultFont).Append("\n");
          sb.Append("  Password: ").Append(this.Password).Append("\n");
          sb.Append("  RemoveJavascript: ").Append(this.RemoveJavascript).Append("\n");
          sb.Append("  RemoveEmbeddedFiles: ").Append(this.RemoveEmbeddedFiles).Append("\n");
          sb.Append("  FontSubstitutes: ").Append(this.FontSubstitutes).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
