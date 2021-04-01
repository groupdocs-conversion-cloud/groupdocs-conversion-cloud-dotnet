// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="EmailLoadOptions.cs">
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
    /// Options for loading Email documents
    /// </summary>  
    public class EmailLoadOptions : LoadOptions 
    {                       
        /// <summary>
        /// Option to display or hide the email header. Default: true
        /// </summary>  
        public bool? DisplayHeader { get; set; }

        /// <summary>
        /// Option to display or hide \"from\" email address. Default: true
        /// </summary>  
        public bool? DisplayFromEmailAddress { get; set; }

        /// <summary>
        /// Option to display or hide email address. Default: true
        /// </summary>  
        public bool? DisplayEmailAddress { get; set; }

        /// <summary>
        /// Option to display or hide \"to\" email address. Default: true
        /// </summary>  
        public bool? DisplayToEmailAddress { get; set; }

        /// <summary>
        /// Option to display or hide \"Cc\" email address. Default: false
        /// </summary>  
        public bool? DisplayCcEmailAddress { get; set; }

        /// <summary>
        /// Option to display or hide \"Bcc\" email address. Default: false
        /// </summary>  
        public bool? DisplayBccEmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the Coordinated Universal Time (UTC) offset for the message dates. This property defines the time zone difference, between the localtime and UTC.
        /// </summary>  
        public string TimeZoneOffset { get; set; }

        /// <summary>
        /// Option to convert attachments in source email or not. Default: false.
        /// </summary>  
        public bool? ConvertAttachments { get; set; }

        /// <summary>
        /// The mapping between email message field and field text representation
        /// </summary>  
        public List<FieldLabel> FieldLabels { get; set; }

        /// <summary>
        /// Defines whether need to keep original date header string in mail message when saving or not (Default value is true)
        /// </summary>  
        public bool? PreserveOriginalDate { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class EmailLoadOptions {\n");
          sb.Append("  DisplayHeader: ").Append(this.DisplayHeader).Append("\n");
          sb.Append("  DisplayFromEmailAddress: ").Append(this.DisplayFromEmailAddress).Append("\n");
          sb.Append("  DisplayEmailAddress: ").Append(this.DisplayEmailAddress).Append("\n");
          sb.Append("  DisplayToEmailAddress: ").Append(this.DisplayToEmailAddress).Append("\n");
          sb.Append("  DisplayCcEmailAddress: ").Append(this.DisplayCcEmailAddress).Append("\n");
          sb.Append("  DisplayBccEmailAddress: ").Append(this.DisplayBccEmailAddress).Append("\n");
          sb.Append("  TimeZoneOffset: ").Append(this.TimeZoneOffset).Append("\n");
          sb.Append("  ConvertAttachments: ").Append(this.ConvertAttachments).Append("\n");
          sb.Append("  FieldLabels: ").Append(this.FieldLabels).Append("\n");
          sb.Append("  PreserveOriginalDate: ").Append(this.PreserveOriginalDate).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
