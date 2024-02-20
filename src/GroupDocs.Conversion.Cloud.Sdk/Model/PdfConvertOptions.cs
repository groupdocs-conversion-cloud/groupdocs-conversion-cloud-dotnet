// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PdfConvertOptions.cs">
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
    /// Options for to PDF conversion
    /// </summary>  
    public class PdfConvertOptions : ConvertOptions 
    {                       
        /// <summary>
        /// Set the pdf format of the converted document.
        /// </summary>
        /// <value>Set the pdf format of the converted document.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PdfFormatEnum
        { 
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>            
            Default,
            
            /// <summary>
            /// Enum PdfA1A for "PdfA_1A"
            /// </summary>            
            PdfA1A,
            
            /// <summary>
            /// Enum PdfA1B for "PdfA_1B"
            /// </summary>            
            PdfA1B,
            
            /// <summary>
            /// Enum PdfA2A for "PdfA_2A"
            /// </summary>            
            PdfA2A,
            
            /// <summary>
            /// Enum PdfA3A for "PdfA_3A"
            /// </summary>            
            PdfA3A,
            
            /// <summary>
            /// Enum PdfA2B for "PdfA_2B"
            /// </summary>            
            PdfA2B,
            
            /// <summary>
            /// Enum PdfA2U for "PdfA_2U"
            /// </summary>            
            PdfA2U,
            
            /// <summary>
            /// Enum PdfA3B for "PdfA_3B"
            /// </summary>            
            PdfA3B,
            
            /// <summary>
            /// Enum PdfA3U for "PdfA_3U"
            /// </summary>            
            PdfA3U,
            
            /// <summary>
            /// Enum V13 for "v1_3"
            /// </summary>            
            V13,
            
            /// <summary>
            /// Enum V14 for "v1_4"
            /// </summary>            
            V14,
            
            /// <summary>
            /// Enum V15 for "v1_5"
            /// </summary>            
            V15,
            
            /// <summary>
            /// Enum V16 for "v1_6"
            /// </summary>            
            V16,
            
            /// <summary>
            /// Enum V17 for "v1_7"
            /// </summary>            
            V17,
            
            /// <summary>
            /// Enum PdfX1A for "PdfX_1A"
            /// </summary>            
            PdfX1A,
            
            /// <summary>
            /// Enum PdfX3 for "PdfX3"
            /// </summary>            
            PdfX3            
        }

        /// <summary>
        /// Sets reading order of text: L2R (left to right) or R2L (right to left). Default: L2R.
        /// </summary>
        /// <value>Sets reading order of text: L2R (left to right) or R2L (right to left). Default: L2R.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DirectionEnum
        { 
            /// <summary>
            /// Enum L2R for "L2R"
            /// </summary>            
            L2R,
            
            /// <summary>
            /// Enum R2L for "R2L"
            /// </summary>            
            R2L            
        }

        /// <summary>
        /// Sets page mode, specifying how to display the document on exiting full-screen mode.
        /// </summary>
        /// <value>Sets page mode, specifying how to display the document on exiting full-screen mode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NonFullScreenPageModeEnum
        { 
            /// <summary>
            /// Enum UseNone for "UseNone"
            /// </summary>            
            UseNone,
            
            /// <summary>
            /// Enum UseOutlines for "UseOutlines"
            /// </summary>            
            UseOutlines,
            
            /// <summary>
            /// Enum UseThumbs for "UseThumbs"
            /// </summary>            
            UseThumbs,
            
            /// <summary>
            /// Enum FullScreen for "FullScreen"
            /// </summary>            
            FullScreen,
            
            /// <summary>
            /// Enum UseOC for "UseOC"
            /// </summary>            
            UseOC,
            
            /// <summary>
            /// Enum UseAttachments for "UseAttachments"
            /// </summary>            
            UseAttachments            
        }

        /// <summary>
        /// Sets page layout which shall be used when the document is opened.
        /// </summary>
        /// <value>Sets page layout which shall be used when the document is opened.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PageLayoutEnum
        { 
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>            
            Default,
            
            /// <summary>
            /// Enum SinglePage for "SinglePage"
            /// </summary>            
            SinglePage,
            
            /// <summary>
            /// Enum OneColumn for "OneColumn"
            /// </summary>            
            OneColumn,
            
            /// <summary>
            /// Enum TwoColumnLeft for "TwoColumnLeft"
            /// </summary>            
            TwoColumnLeft,
            
            /// <summary>
            /// Enum TwoColumnRight for "TwoColumnRight"
            /// </summary>            
            TwoColumnRight,
            
            /// <summary>
            /// Enum TwoPageLeft for "TwoPageLeft"
            /// </summary>            
            TwoPageLeft,
            
            /// <summary>
            /// Enum TwoPageRight for "TwoPageRight"
            /// </summary>            
            TwoPageRight            
        }

        /// <summary>
        /// Sets page mode, specifying how document should be displayed when opened.
        /// </summary>
        /// <value>Sets page mode, specifying how document should be displayed when opened.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PageModeEnum
        { 
            /// <summary>
            /// Enum UseNone for "UseNone"
            /// </summary>            
            UseNone,
            
            /// <summary>
            /// Enum UseOutlines for "UseOutlines"
            /// </summary>            
            UseOutlines,
            
            /// <summary>
            /// Enum UseThumbs for "UseThumbs"
            /// </summary>            
            UseThumbs,
            
            /// <summary>
            /// Enum FullScreen for "FullScreen"
            /// </summary>            
            FullScreen,
            
            /// <summary>
            /// Enum UseOC for "UseOC"
            /// </summary>            
            UseOC,
            
            /// <summary>
            /// Enum UseAttachments for "UseAttachments"
            /// </summary>            
            UseAttachments            
        }

        /// <summary>
        /// Rotate page
        /// </summary>
        /// <value>Rotate page</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RotateEnum
        { 
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum On90 for "On90"
            /// </summary>            
            On90,
            
            /// <summary>
            /// Enum On180 for "On180"
            /// </summary>            
            On180,
            
            /// <summary>
            /// Enum On270 for "On270"
            /// </summary>            
            On270            
        }

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
        /// Set the pdf format of the converted document.
        /// </summary>
        public PdfFormatEnum? PdfFormat { get; set; }

        /// <summary>
        /// Sets reading order of text: L2R (left to right) or R2L (right to left). Default: L2R.
        /// </summary>
        public DirectionEnum? Direction { get; set; }

        /// <summary>
        /// Sets page mode, specifying how to display the document on exiting full-screen mode.
        /// </summary>
        public NonFullScreenPageModeEnum? NonFullScreenPageMode { get; set; }

        /// <summary>
        /// Sets page layout which shall be used when the document is opened.
        /// </summary>
        public PageLayoutEnum? PageLayout { get; set; }

        /// <summary>
        /// Sets page mode, specifying how document should be displayed when opened.
        /// </summary>
        public PageModeEnum? PageMode { get; set; }

        /// <summary>
        /// Rotate page
        /// </summary>
        public RotateEnum? Rotate { get; set; }

        /// <summary>
        /// Specifies page size
        /// </summary>
        public PageSizeEnum? PageSize { get; set; }

        /// <summary>
        /// Specifies page orientation
        /// </summary>
        public PageOrientationEnum? PageOrientation { get; set; }

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
        public int? Dpi { get; set; }

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
        public bool? HideMenuBar { get; set; }

        /// <summary>
        /// Specifying whether toolbar should be hidden when document is active. Default: false.
        /// </summary>  
        public bool? HideToolBar { get; set; }

        /// <summary>
        /// Specify whether user interface elements should be hidden when document is active. Default: false.
        /// </summary>  
        public bool? HideWindowUI { get; set; }

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
          sb.Append("  PdfFormat: ").Append(this.PdfFormat).Append("\n");
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
          sb.Append("  Direction: ").Append(this.Direction).Append("\n");
          sb.Append("  DisplayDocTitle: ").Append(this.DisplayDocTitle).Append("\n");
          sb.Append("  FitWindow: ").Append(this.FitWindow).Append("\n");
          sb.Append("  HideMenuBar: ").Append(this.HideMenuBar).Append("\n");
          sb.Append("  HideToolBar: ").Append(this.HideToolBar).Append("\n");
          sb.Append("  HideWindowUI: ").Append(this.HideWindowUI).Append("\n");
          sb.Append("  NonFullScreenPageMode: ").Append(this.NonFullScreenPageMode).Append("\n");
          sb.Append("  PageLayout: ").Append(this.PageLayout).Append("\n");
          sb.Append("  PageMode: ").Append(this.PageMode).Append("\n");
          sb.Append("  Rotate: ").Append(this.Rotate).Append("\n");
          sb.Append("  PageSize: ").Append(this.PageSize).Append("\n");
          sb.Append("  PageOrientation: ").Append(this.PageOrientation).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
