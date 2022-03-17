// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PdfLoadOptions.cs">
//  Copyright (c) 2003-2022 Aspose Pty Ltd
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
        /// Remove embedded files
        /// </summary>  
        public bool? RemoveEmbeddedFiles { get; set; }

        /// <summary>
        /// Set password to unprotect protected document
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Hide annotations in Pdf documents
        /// </summary>  
        public bool? HidePdfAnnotations { get; set; }

        /// <summary>
        /// Flatten all the fields of the PDF form
        /// </summary>  
        public bool? FlattenAllFields { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PdfLoadOptions {\n");
          sb.Append("  RemoveEmbeddedFiles: ").Append(this.RemoveEmbeddedFiles).Append("\n");
          sb.Append("  Password: ").Append(this.Password).Append("\n");
          sb.Append("  HidePdfAnnotations: ").Append(this.HidePdfAnnotations).Append("\n");
          sb.Append("  FlattenAllFields: ").Append(this.FlattenAllFields).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
