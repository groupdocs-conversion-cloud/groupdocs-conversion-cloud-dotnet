// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PdfOptimizationOptionsDto.cs">
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
  /// Define Pdf optimization options
  /// </summary>  
  public class PdfOptimizationOptionsDto 
  {                       
        /// <summary>
        /// Link duplcate streams
        /// </summary>  
        public bool? LinkDuplicateStreams { get; set; }

        /// <summary>
        /// Remove unused objects
        /// </summary>  
        public bool? RemoveUnusedObjects { get; set; }

        /// <summary>
        /// Remove unused streams
        /// </summary>  
        public bool? RemoveUnusedStreams { get; set; }

        /// <summary>
        /// If CompressImages set to true, all images in the document are recompressed. The compression is defined by the ImageQuality property.
        /// </summary>  
        public bool? CompressImages { get; set; }

        /// <summary>
        /// Value in percent where 100% is unchanged quality and image size. To decrease the image size, use ImageQuality less than 100             
        /// </summary>  
        public int? ImageQuality { get; set; }

        /// <summary>
        /// Make fonts not embedded if set to true
        /// </summary>  
        public bool? UnembedFonts { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PdfOptimizationOptionsDto {\n");
          sb.Append("  LinkDuplicateStreams: ").Append(this.LinkDuplicateStreams).Append("\n");
          sb.Append("  RemoveUnusedObjects: ").Append(this.RemoveUnusedObjects).Append("\n");
          sb.Append("  RemoveUnusedStreams: ").Append(this.RemoveUnusedStreams).Append("\n");
          sb.Append("  CompressImages: ").Append(this.CompressImages).Append("\n");
          sb.Append("  ImageQuality: ").Append(this.ImageQuality).Append("\n");
          sb.Append("  UnembedFonts: ").Append(this.UnembedFonts).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
