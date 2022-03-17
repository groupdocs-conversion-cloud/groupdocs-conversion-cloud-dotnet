// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ImageConvertOptions.cs">
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
    /// Options for to Image conversion
    /// </summary>  
    public class ImageConvertOptions : ConvertOptions 
    {                       
        /// <summary>
        /// Image flip mode
        /// </summary>
        /// <value>Image flip mode</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FlipModeEnum
        { 
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum FlipX for "FlipX"
            /// </summary>            
            FlipX,
            
            /// <summary>
            /// Enum FlipY for "FlipY"
            /// </summary>            
            FlipY,
            
            /// <summary>
            /// Enum FlipXY for "FlipXY"
            /// </summary>            
            FlipXY            
        }

        /// <summary>
        /// Image flip mode
        /// </summary>
        public FlipModeEnum? FlipMode { get; set; }

        /// <summary>
        /// Desired image width after conversion
        /// </summary>  
        public int? Width { get; set; }

        /// <summary>
        /// Desired image height after conversion
        /// </summary>  
        public int? Height { get; set; }

        /// <summary>
        /// Desired image horizontal resolution after conversion. The default resolution is the resolution of the input file or 96dpi
        /// </summary>  
        public int? HorizontalResolution { get; set; }

        /// <summary>
        /// Desired image vertical resolution after conversion. The default resolution is the resolution of the input file or 96dpi
        /// </summary>  
        public int? VerticalResolution { get; set; }

        /// <summary>
        /// Convert to grayscale image
        /// </summary>  
        public bool? Grayscale { get; set; }

        /// <summary>
        /// Image rotation angle 
        /// </summary>  
        public int? RotateAngle { get; set; }

        /// <summary>
        /// If true, the input firstly is converted to PDF and after that to desired format
        /// </summary>  
        public bool? UsePdf { get; set; }

        /// <summary>
        /// Watermark specific options
        /// </summary>  
        public WatermarkOptions WatermarkOptions { get; set; }

        /// <summary>
        /// Adjust image brightness
        /// </summary>  
        public int? Brightness { get; set; }

        /// <summary>
        /// Adjust image contrast
        /// </summary>  
        public int? Contrast { get; set; }

        /// <summary>
        /// Adjust image gamma
        /// </summary>  
        public double? Gamma { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ImageConvertOptions {\n");
          sb.Append("  Width: ").Append(this.Width).Append("\n");
          sb.Append("  Height: ").Append(this.Height).Append("\n");
          sb.Append("  HorizontalResolution: ").Append(this.HorizontalResolution).Append("\n");
          sb.Append("  VerticalResolution: ").Append(this.VerticalResolution).Append("\n");
          sb.Append("  Grayscale: ").Append(this.Grayscale).Append("\n");
          sb.Append("  RotateAngle: ").Append(this.RotateAngle).Append("\n");
          sb.Append("  UsePdf: ").Append(this.UsePdf).Append("\n");
          sb.Append("  WatermarkOptions: ").Append(this.WatermarkOptions).Append("\n");
          sb.Append("  Brightness: ").Append(this.Brightness).Append("\n");
          sb.Append("  Contrast: ").Append(this.Contrast).Append("\n");
          sb.Append("  Gamma: ").Append(this.Gamma).Append("\n");
          sb.Append("  FlipMode: ").Append(this.FlipMode).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
