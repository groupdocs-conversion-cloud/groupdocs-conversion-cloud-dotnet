// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="WordProcessingLoadOptions.cs">
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
    /// WordProcessing document load options
    /// </summary>  
    public class WordProcessingLoadOptions : LoadOptions 
    {                       
        /// <summary>
        /// Specifies how comments should be displayed in the output document. Default is Balloon.
        /// </summary>
        /// <value>Specifies how comments should be displayed in the output document. Default is Balloon.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CommentDisplayModeEnum
        { 
            /// <summary>
            /// Enum Hidden for "Hidden"
            /// </summary>            
            Hidden,
            
            /// <summary>
            /// Enum Balloon for "Balloon"
            /// </summary>            
            Balloon,
            
            /// <summary>
            /// Enum Annotation for "Annotation"
            /// </summary>            
            Annotation            
        }

        /// <summary>
        /// Specifies how comments should be displayed in the output document. Default is Balloon.
        /// </summary>
        public CommentDisplayModeEnum? CommentDisplayMode { get; set; }

        /// <summary>
        /// Default font for Words document. The following font will be used if a font is missing.
        /// </summary>  
        public string DefaultFont { get; set; }

        /// <summary>
        /// Substitute specific fonts when converting Words document.
        /// </summary>  
        public Dictionary<string, string> FontSubstitutes { get; set; }

        /// <summary>
        /// Set password to unprotect protected document
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Hide markup and track changes for Word documents
        /// </summary>  
        public bool? HideWordTrackedChanges { get; set; }

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
        /// Clear custom document properties. Default is false.
        /// </summary>  
        public bool? ClearCustomDocumentProperties { get; set; }

        /// <summary>
        /// Clear built-in document properties. Default is false.
        /// </summary>  
        public bool? ClearBuiltInDocumentProperties { get; set; }

        /// <summary>
        /// Option to control how many levels in depth to perform conversion. Default: 1.
        /// </summary>  
        public int? Depth { get; set; }

        /// <summary>
        /// Option to control whether the owned documents in the documents container must be converted
        /// </summary>  
        public bool? ConvertOwned { get; set; }

        /// <summary>
        /// Option to control whether the documents container itself must be converted If this property is true the documents container will be the first converted document. Default is true.
        /// </summary>  
        public bool? ConvertOwner { get; set; }

        /// <summary>
        /// Gets or sets value determining whether automatic hyphenation is turned on for the document. Default value for this property is false.
        /// </summary>  
        public bool? AutoHyphenation { get; set; }

        /// <summary>
        /// Gets or sets value determining whether words written in all capital letters are hyphenated. Default value for this property is true.
        /// </summary>  
        public bool? HyphenateCaps { get; set; }

        /// <summary>
        /// Enable or disable generation of page numbering in converted document. Default: false
        /// </summary>  
        public bool? PageNumbering { get; set; }

        /// <summary>
        /// Determines whether the document structure should be preserved when converting to PDF (default is false).
        /// </summary>  
        public bool? PreserveDocumentStructure { get; set; }

        /// <summary>
        /// If true all external resource will not be loading. Default is true.
        /// </summary>  
        public bool? SkipExternalResources { get; set; }

        /// <summary>
        /// Specifies whether to use a text shaper for better kerning display. Default is false.
        /// </summary>  
        public bool? UseTextShaper { get; set; }

        /// <summary>
        /// Specifies whether to preserve Microsoft Word form fields as form fields in PDF or convert them to text. Default is false.
        /// </summary>  
        public bool? PreserveFormFields { get; set; }

        /// <summary>
        /// Keep original value of date field. Default: false
        /// </summary>  
        public bool? KeepDateFieldOriginalValue { get; set; }

        /// <summary>
        /// Update fields after loading. Default: false
        /// </summary>  
        public bool? UpdateFields { get; set; }

        /// <summary>
        /// Update page layout after loading. Default: false
        /// </summary>  
        public bool? UpdatePageLayout { get; set; }

        /// <summary>
        /// If EmbedTrueTypeFonts is true, GroupDocs.Conversion Cloud embed true type fonts in the output document. Default: true
        /// </summary>  
        public bool? EmbedTrueTypeFonts { get; set; }

        /// <summary>
        /// Automatically substitutes missing fonts based on FontInfo in the document. Default: false.
        /// </summary>  
        public bool? FontInfoSubstitutionEnabled { get; set; }

        /// <summary>
        /// Automatically substitutes missing fonts based on FontConfig in the system. Default: false.
        /// </summary>  
        public bool? FontConfigSubstitutionEnabled { get; set; }

        /// <summary>
        /// Automatically substitutes missing fonts based on the font name. Default: false.
        /// </summary>  
        public bool? FontNameSubstitutionEnabled { get; set; }

        /// <summary>
        /// Show full commenter name in comments. Default is false.
        /// </summary>  
        public bool? ShowFullCommenterName { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class WordProcessingLoadOptions {\n");
          sb.Append("  DefaultFont: ").Append(this.DefaultFont).Append("\n");
          sb.Append("  FontSubstitutes: ").Append(this.FontSubstitutes).Append("\n");
          sb.Append("  Password: ").Append(this.Password).Append("\n");
          sb.Append("  HideWordTrackedChanges: ").Append(this.HideWordTrackedChanges).Append("\n");
          sb.Append("  BookmarksOutlineLevel: ").Append(this.BookmarksOutlineLevel).Append("\n");
          sb.Append("  HeadingsOutlineLevels: ").Append(this.HeadingsOutlineLevels).Append("\n");
          sb.Append("  ExpandedOutlineLevels: ").Append(this.ExpandedOutlineLevels).Append("\n");
          sb.Append("  ClearCustomDocumentProperties: ").Append(this.ClearCustomDocumentProperties).Append("\n");
          sb.Append("  ClearBuiltInDocumentProperties: ").Append(this.ClearBuiltInDocumentProperties).Append("\n");
          sb.Append("  Depth: ").Append(this.Depth).Append("\n");
          sb.Append("  ConvertOwned: ").Append(this.ConvertOwned).Append("\n");
          sb.Append("  ConvertOwner: ").Append(this.ConvertOwner).Append("\n");
          sb.Append("  AutoHyphenation: ").Append(this.AutoHyphenation).Append("\n");
          sb.Append("  HyphenateCaps: ").Append(this.HyphenateCaps).Append("\n");
          sb.Append("  PageNumbering: ").Append(this.PageNumbering).Append("\n");
          sb.Append("  PreserveDocumentStructure: ").Append(this.PreserveDocumentStructure).Append("\n");
          sb.Append("  SkipExternalResources: ").Append(this.SkipExternalResources).Append("\n");
          sb.Append("  UseTextShaper: ").Append(this.UseTextShaper).Append("\n");
          sb.Append("  PreserveFormFields: ").Append(this.PreserveFormFields).Append("\n");
          sb.Append("  CommentDisplayMode: ").Append(this.CommentDisplayMode).Append("\n");
          sb.Append("  KeepDateFieldOriginalValue: ").Append(this.KeepDateFieldOriginalValue).Append("\n");
          sb.Append("  UpdateFields: ").Append(this.UpdateFields).Append("\n");
          sb.Append("  UpdatePageLayout: ").Append(this.UpdatePageLayout).Append("\n");
          sb.Append("  EmbedTrueTypeFonts: ").Append(this.EmbedTrueTypeFonts).Append("\n");
          sb.Append("  FontInfoSubstitutionEnabled: ").Append(this.FontInfoSubstitutionEnabled).Append("\n");
          sb.Append("  FontConfigSubstitutionEnabled: ").Append(this.FontConfigSubstitutionEnabled).Append("\n");
          sb.Append("  FontNameSubstitutionEnabled: ").Append(this.FontNameSubstitutionEnabled).Append("\n");
          sb.Append("  ShowFullCommenterName: ").Append(this.ShowFullCommenterName).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
