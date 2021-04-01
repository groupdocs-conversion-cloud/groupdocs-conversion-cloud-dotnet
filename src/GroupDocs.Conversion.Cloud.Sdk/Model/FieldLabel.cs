// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="FieldLabel.cs">
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
    /// Represents field label 
    /// </summary>  
    public class FieldLabel 
    {                       
        /// <summary>
        /// The field name
        /// </summary>
        /// <value>The field name</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FieldEnum
        { 
            /// <summary>
            /// Enum Start for "Start"
            /// </summary>            
            Start,
            
            /// <summary>
            /// Enum TabField for "TabField"
            /// </summary>            
            TabField,
            
            /// <summary>
            /// Enum Subject for "Subject"
            /// </summary>            
            Subject,
            
            /// <summary>
            /// Enum ShowTimeAs for "ShowTimeAs"
            /// </summary>            
            ShowTimeAs,
            
            /// <summary>
            /// Enum Sent for "Sent"
            /// </summary>            
            Sent,
            
            /// <summary>
            /// Enum RequiredAttendees for "RequiredAttendees"
            /// </summary>            
            RequiredAttendees,
            
            /// <summary>
            /// Enum RecurrencePattern for "RecurrencePattern"
            /// </summary>            
            RecurrencePattern,
            
            /// <summary>
            /// Enum Recurrence for "Recurrence"
            /// </summary>            
            Recurrence,
            
            /// <summary>
            /// Enum PageHeader for "PageHeader"
            /// </summary>            
            PageHeader,
            
            /// <summary>
            /// Enum Organizer for "Organizer"
            /// </summary>            
            Organizer,
            
            /// <summary>
            /// Enum Location for "Location"
            /// </summary>            
            Location,
            
            /// <summary>
            /// Enum Importance for "Importance"
            /// </summary>            
            Importance,
            
            /// <summary>
            /// Enum From for "From"
            /// </summary>            
            From,
            
            /// <summary>
            /// Enum End for "End"
            /// </summary>            
            End,
            
            /// <summary>
            /// Enum Bcc for "Bcc"
            /// </summary>            
            Bcc,
            
            /// <summary>
            /// Enum Attachments for "Attachments"
            /// </summary>            
            Attachments,
            
            /// <summary>
            /// Enum To for "To"
            /// </summary>            
            To            
        }

        /// <summary>
        /// The field name
        /// </summary>
        public FieldEnum? Field { get; set; }

        /// <summary>
        /// The label e.g. \"Sender\"
        /// </summary>  
        public string Label { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class FieldLabel {\n");
          sb.Append("  Field: ").Append(this.Field).Append("\n");
          sb.Append("  Label: ").Append(this.Label).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
