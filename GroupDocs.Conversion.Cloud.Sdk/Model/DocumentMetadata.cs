// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="DocumentMetadata.cs">
//  Copyright (c) 2003-2019 Aspose Pty Ltd
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
    /// Contains a document metadata 
    /// </summary>  
    public class DocumentMetadata 
    {                       
        /// <summary>
        /// Document file type
        /// </summary>  
        public string FileType { get; set; }

        /// <summary>
        /// Gets pages count if applicable to the current document format
        /// </summary>  
        public int? PageCount { get; set; }

        /// <summary>
        /// Document bytes size
        /// </summary>  
        public long? Size { get; set; }

        /// <summary>
        /// Returns detected width if applicable to the current document format
        /// </summary>  
        public int? Width { get; set; }

        /// <summary>
        /// Returns detected height if applicable to the current document format
        /// </summary>  
        public int? Height { get; set; }

        /// <summary>
        /// Returns detected horizontal resolution if applicable to the current document format
        /// </summary>  
        public int? HorizontalResolution { get; set; }

        /// <summary>
        /// Returns detected vertical resolution if applicable to the current document format
        /// </summary>  
        public int? VerticalResolution { get; set; }

        /// <summary>
        /// Returns detected bits per pixel if applicable to the current document format
        /// </summary>  
        public int? BitsPerPixel { get; set; }

        /// <summary>
        /// Returns document title width if applicable to the current document format
        /// </summary>  
        public string Title { get; set; }

        /// <summary>
        /// Returns detected document author if applicable to the current document format
        /// </summary>  
        public string Author { get; set; }

        /// <summary>
        /// Returns detected document creation date if it's applicable to the current document format
        /// </summary>  
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Returns detected document modification date if applicable to the current document format
        /// </summary>  
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Returns list of layer names if applicable to the current document format
        /// </summary>  
        public List<string> Layers { get; set; }

        /// <summary>
        /// Is document password protected
        /// </summary>  
        public bool? IsPasswordProtected { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class DocumentMetadata {\n");
          sb.Append("  FileType: ").Append(this.FileType).Append("\n");
          sb.Append("  PageCount: ").Append(this.PageCount).Append("\n");
          sb.Append("  Size: ").Append(this.Size).Append("\n");
          sb.Append("  Width: ").Append(this.Width).Append("\n");
          sb.Append("  Height: ").Append(this.Height).Append("\n");
          sb.Append("  HorizontalResolution: ").Append(this.HorizontalResolution).Append("\n");
          sb.Append("  VerticalResolution: ").Append(this.VerticalResolution).Append("\n");
          sb.Append("  BitsPerPixel: ").Append(this.BitsPerPixel).Append("\n");
          sb.Append("  Title: ").Append(this.Title).Append("\n");
          sb.Append("  Author: ").Append(this.Author).Append("\n");
          sb.Append("  CreatedDate: ").Append(this.CreatedDate).Append("\n");
          sb.Append("  ModifiedDate: ").Append(this.ModifiedDate).Append("\n");
          sb.Append("  Layers: ").Append(this.Layers).Append("\n");
          sb.Append("  IsPasswordProtected: ").Append(this.IsPasswordProtected).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
