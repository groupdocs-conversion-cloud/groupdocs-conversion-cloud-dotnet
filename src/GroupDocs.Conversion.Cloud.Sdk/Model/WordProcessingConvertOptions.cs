// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="WordProcessingConvertOptions.cs">
//  Copyright (c) 2003-2021 Aspose Pty Ltd
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
    /// Options for to word processing conversion
    /// </summary>  
    public class WordProcessingConvertOptions : ConvertOptions 
    {                       
        /// <summary>
        /// Recognition mode when converting from pdf
        /// </summary>
        /// <value>Recognition mode when converting from pdf</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PdfRecognitionModeEnum
        { 
            /// <summary>
            /// Enum Textbox for "Textbox"
            /// </summary>            
            Textbox,
            
            /// <summary>
            /// Enum Flow for "Flow"
            /// </summary>            
            Flow            
        }

        /// <summary>
        /// Recognition mode when converting from pdf
        /// </summary>
        public PdfRecognitionModeEnum? PdfRecognitionMode { get; set; }

        /// <summary>
        /// Desired page width after conversion
        /// </summary>  
        public int? Width { get; set; }

        /// <summary>
        /// Desired page height after conversion
        /// </summary>  
        public int? Height { get; set; }

        /// <summary>
        /// Desired page DPI after conversion. The default resolution is: 96dpi
        /// </summary>  
        public double? Dpi { get; set; }

        /// <summary>
        /// Set this property if you want to protect the converted document with a password
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Specifies the zoom level in percentage. Default is 100. Default zoom is supported till Microsoft Word 2010. Starting from Microsoft Word 2013 default zoom is no longer set to document, instead it appears to use the zoom factor of the last document that was opened.
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
          sb.Append("class WordProcessingConvertOptions {\n");
          sb.Append("  Width: ").Append(this.Width).Append("\n");
          sb.Append("  Height: ").Append(this.Height).Append("\n");
          sb.Append("  Dpi: ").Append(this.Dpi).Append("\n");
          sb.Append("  Password: ").Append(this.Password).Append("\n");
          sb.Append("  Zoom: ").Append(this.Zoom).Append("\n");
          sb.Append("  WatermarkOptions: ").Append(this.WatermarkOptions).Append("\n");
          sb.Append("  PdfRecognitionMode: ").Append(this.PdfRecognitionMode).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
