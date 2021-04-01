// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="WordProcessingLoadOptions.cs">
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
    /// WordProcessing document load options
    /// </summary>  
    public class WordProcessingLoadOptions : LoadOptions 
    {                       
        /// <summary>
        /// Default font for Words document. The following font will be used if a font is missing.
        /// </summary>  
        public string DefaultFont { get; set; }

        /// <summary>
        /// If AutoFontSubstitution is disabled, GroupDocs.Conversion uses the DefaultFont for the substitution of missing fonts. If AutoFontSubstitution is enabled, GroupDocs.Conversion evaluates all the related fields in FontInfo (Panose, Sig etc) for the missing font and finds the closest match among the available font sources. Note that font substitution mechanism will override the DefaultFont in cases when FontInfo for the missing font is available in the document. The default value is True.
        /// </summary>  
        public bool? AutoFontSubstitution { get; set; }

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
        /// Hide comments
        /// </summary>  
        public bool? HideComments { get; set; }

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
          sb.Append("class WordProcessingLoadOptions {\n");
          sb.Append("  DefaultFont: ").Append(this.DefaultFont).Append("\n");
          sb.Append("  AutoFontSubstitution: ").Append(this.AutoFontSubstitution).Append("\n");
          sb.Append("  FontSubstitutes: ").Append(this.FontSubstitutes).Append("\n");
          sb.Append("  Password: ").Append(this.Password).Append("\n");
          sb.Append("  HideWordTrackedChanges: ").Append(this.HideWordTrackedChanges).Append("\n");
          sb.Append("  HideComments: ").Append(this.HideComments).Append("\n");
          sb.Append("  BookmarksOutlineLevel: ").Append(this.BookmarksOutlineLevel).Append("\n");
          sb.Append("  HeadingsOutlineLevels: ").Append(this.HeadingsOutlineLevels).Append("\n");
          sb.Append("  ExpandedOutlineLevels: ").Append(this.ExpandedOutlineLevels).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
