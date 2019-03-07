// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="WatermarkOptions.cs">
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
    /// Options for settings watermark to the converted document
    /// </summary>  
    public class WatermarkOptions 
    {                       
        /// <summary>
        /// Watermark text
        /// </summary>  
        public string Text { get; set; }

        /// <summary>
        /// Watermark font name if text watermark is applied
        /// </summary>  
        public string FontName { get; set; }

        /// <summary>
        /// Watermark font name if text watermark is applied
        /// </summary>  
        public int? FontSize { get; set; }

        /// <summary>
        /// Watermark font color if text watermark is applied
        /// </summary>  
        public string Color { get; set; }

        /// <summary>
        /// Watermark width
        /// </summary>  
        public int? Width { get; set; }

        /// <summary>
        /// Watermark height
        /// </summary>  
        public int? Height { get; set; }

        /// <summary>
        /// Watermark top position
        /// </summary>  
        public int? Top { get; set; }

        /// <summary>
        /// Watermark left position
        /// </summary>  
        public int? Left { get; set; }

        /// <summary>
        /// Watermark rotation angle
        /// </summary>  
        public int? RotationAngle { get; set; }

        /// <summary>
        /// Watermark transparency. Value between 0 and 1. Value 0 is fully visible, value 1 is invisible.
        /// </summary>  
        public double? Transparency { get; set; }

        /// <summary>
        /// Indicates that the watermark is stamped as background. If the value is true, the watermark is layed at the bottom. By default is false and the watermark is layed on top.
        /// </summary>  
        public bool? Background { get; set; }

        /// <summary>
        /// Image watermark
        /// </summary>  
        public string Image { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class WatermarkOptions {\n");
          sb.Append("  Text: ").Append(this.Text).Append("\n");
          sb.Append("  FontName: ").Append(this.FontName).Append("\n");
          sb.Append("  FontSize: ").Append(this.FontSize).Append("\n");
          sb.Append("  Color: ").Append(this.Color).Append("\n");
          sb.Append("  Width: ").Append(this.Width).Append("\n");
          sb.Append("  Height: ").Append(this.Height).Append("\n");
          sb.Append("  Top: ").Append(this.Top).Append("\n");
          sb.Append("  Left: ").Append(this.Left).Append("\n");
          sb.Append("  RotationAngle: ").Append(this.RotationAngle).Append("\n");
          sb.Append("  Transparency: ").Append(this.Transparency).Append("\n");
          sb.Append("  Background: ").Append(this.Background).Append("\n");
          sb.Append("  Image: ").Append(this.Image).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
