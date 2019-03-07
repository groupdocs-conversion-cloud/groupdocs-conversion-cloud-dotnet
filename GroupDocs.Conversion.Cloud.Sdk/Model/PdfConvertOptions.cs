// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PdfConvertOptions.cs">
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
    /// Options for to PDF conversion
    /// </summary>  
    public class PdfConvertOptions : ConvertOptions 
    {                       
        /// <summary>
        /// Desired page width in pixels after conversion
        /// </summary>  
        public int? Width { get; set; }

        /// <summary>
        /// Desired page height in pixels after conversion
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
        /// Desired page top margin in pixels after conversion
        /// </summary>  
        public int? MarginTop { get; set; }

        /// <summary>
        /// Desired page bottom margin in pixels after conversion
        /// </summary>  
        public int? MarginBottom { get; set; }

        /// <summary>
        /// Desired page left margin in pixels after conversion
        /// </summary>  
        public int? MarginLeft { get; set; }

        /// <summary>
        /// Desired page right margin in pixels after conversion
        /// </summary>  
        public int? MarginRight { get; set; }

        /// <summary>
        /// Remove Pdf-A Compliance
        /// </summary>  
        public bool? RemovePdfaCompliance { get; set; }

        /// <summary>
        /// Specifies the zoom level in percentage. Default is 100.
        /// </summary>  
        public int? Zoom { get; set; }

        /// <summary>
        /// Linearize PDF Document for the Web
        /// </summary>  
        public bool? Linearize { get; set; }

        /// <summary>
        /// Link duplicate streams
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
        /// Convert a PDF from RGB colorspace to Grayscale
        /// </summary>  
        public bool? Grayscale { get; set; }

        /// <summary>
        /// Specify whether position of the document's window will be centered on the screen. Default: false.
        /// </summary>  
        public bool? CenterWindow { get; set; }

        /// <summary>
        /// Specifying whether document's window title bar should display document title. Default: false.
        /// </summary>  
        public bool? DisplayDocTitle { get; set; }

        /// <summary>
        /// Specify whether document window must be resized to fit the first displayed page. Default: false.
        /// </summary>  
        public bool? FitWindow { get; set; }

        /// <summary>
        /// Specify whether menu bar should be hidden when document is active. Default: false.
        /// </summary>  
        public bool? HideMenubar { get; set; }

        /// <summary>
        /// Specifying whether toolbar should be hidden when document is active. Default: false.
        /// </summary>  
        public bool? HideToolBar { get; set; }

        /// <summary>
        /// Specify whether user interface elements should be hidden when document is active. Default: false.
        /// </summary>  
        public bool? HideWindowUI { get; set; }

        /// <summary>
        /// Specifies the default level in the document outline at which to display Word bookmarks. Default is 0. Valid range is 0 to 9.
        /// </summary>  
        public int? BookmarksOutlineLevel { get; set; }

        /// <summary>
        /// Specifies how many levels of headings (paragraphs formatted with the Heading styles) to include in the document outline. Default is 0. Valid range is 0 to 9.
        /// </summary>  
        public int? HeadingsOutlineLevels { get; set; }

        /// <summary>
        /// Specifies how many levels in the document outline to show expanded when the file is viewed. Default is 0. Valid range is 0 to 9. Note that this options will not work when saving to XPS.
        /// </summary>  
        public int? ExpandedOutlineLevels { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PdfConvertOptions {\n");
          sb.Append("  Width: ").Append(this.Width).Append("\n");
          sb.Append("  Height: ").Append(this.Height).Append("\n");
          sb.Append("  Dpi: ").Append(this.Dpi).Append("\n");
          sb.Append("  Password: ").Append(this.Password).Append("\n");
          sb.Append("  MarginTop: ").Append(this.MarginTop).Append("\n");
          sb.Append("  MarginBottom: ").Append(this.MarginBottom).Append("\n");
          sb.Append("  MarginLeft: ").Append(this.MarginLeft).Append("\n");
          sb.Append("  MarginRight: ").Append(this.MarginRight).Append("\n");
          sb.Append("  RemovePdfaCompliance: ").Append(this.RemovePdfaCompliance).Append("\n");
          sb.Append("  Zoom: ").Append(this.Zoom).Append("\n");
          sb.Append("  Linearize: ").Append(this.Linearize).Append("\n");
          sb.Append("  LinkDuplicateStreams: ").Append(this.LinkDuplicateStreams).Append("\n");
          sb.Append("  RemoveUnusedObjects: ").Append(this.RemoveUnusedObjects).Append("\n");
          sb.Append("  RemoveUnusedStreams: ").Append(this.RemoveUnusedStreams).Append("\n");
          sb.Append("  CompressImages: ").Append(this.CompressImages).Append("\n");
          sb.Append("  ImageQuality: ").Append(this.ImageQuality).Append("\n");
          sb.Append("  UnembedFonts: ").Append(this.UnembedFonts).Append("\n");
          sb.Append("  Grayscale: ").Append(this.Grayscale).Append("\n");
          sb.Append("  CenterWindow: ").Append(this.CenterWindow).Append("\n");
          sb.Append("  DisplayDocTitle: ").Append(this.DisplayDocTitle).Append("\n");
          sb.Append("  FitWindow: ").Append(this.FitWindow).Append("\n");
          sb.Append("  HideMenubar: ").Append(this.HideMenubar).Append("\n");
          sb.Append("  HideToolBar: ").Append(this.HideToolBar).Append("\n");
          sb.Append("  HideWindowUI: ").Append(this.HideWindowUI).Append("\n");
          sb.Append("  BookmarksOutlineLevel: ").Append(this.BookmarksOutlineLevel).Append("\n");
          sb.Append("  HeadingsOutlineLevels: ").Append(this.HeadingsOutlineLevels).Append("\n");
          sb.Append("  ExpandedOutlineLevels: ").Append(this.ExpandedOutlineLevels).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
