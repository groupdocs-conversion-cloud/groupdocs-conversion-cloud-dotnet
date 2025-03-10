// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="OperationResult.cs">
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
    /// Operation status result
    /// </summary>  
    public class OperationResult 
    {                       
        /// <summary>
        /// Gets or sets Method
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MethodEnum
        { 
            /// <summary>
            /// Enum Convert for "Convert"
            /// </summary>            
            Convert,
            
            /// <summary>
            /// Enum ConvertAndSave for "ConvertAndSave"
            /// </summary>            
            ConvertAndSave            
        }

        /// <summary>
        /// Gets or sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        { 
            /// <summary>
            /// Enum Created for "Created"
            /// </summary>            
            Created,
            
            /// <summary>
            /// Enum Started for "Started"
            /// </summary>            
            Started,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>            
            Failed,
            
            /// <summary>
            /// Enum Canceled for "Canceled"
            /// </summary>            
            Canceled,
            
            /// <summary>
            /// Enum Finished for "Finished"
            /// </summary>            
            Finished            
        }

        /// <summary>
        /// Gets or sets Method
        /// </summary>
        public MethodEnum? Method { get; set; }

        /// <summary>
        /// Gets or sets Status
        /// </summary>
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Gets or sets Id
        /// </summary>  
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Created
        /// </summary>  
        public DateTime? Created { get; set; }

        /// <summary>
        /// Gets or sets Started
        /// </summary>  
        public DateTime? Started { get; set; }

        /// <summary>
        /// Gets or sets Failed
        /// </summary>  
        public DateTime? Failed { get; set; }

        /// <summary>
        /// Gets or sets Canceled
        /// </summary>  
        public DateTime? Canceled { get; set; }

        /// <summary>
        /// Gets or sets Finished
        /// </summary>  
        public DateTime? Finished { get; set; }

        /// <summary>
        /// Gets or sets Result
        /// </summary>  
        public List<StoredConvertedResult> Result { get; set; }

        /// <summary>
        /// Gets or sets Error
        /// </summary>  
        public string Error { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class OperationResult {\n");
          sb.Append("  Id: ").Append(this.Id).Append("\n");
          sb.Append("  Method: ").Append(this.Method).Append("\n");
          sb.Append("  Status: ").Append(this.Status).Append("\n");
          sb.Append("  Created: ").Append(this.Created).Append("\n");
          sb.Append("  Started: ").Append(this.Started).Append("\n");
          sb.Append("  Failed: ").Append(this.Failed).Append("\n");
          sb.Append("  Canceled: ").Append(this.Canceled).Append("\n");
          sb.Append("  Finished: ").Append(this.Finished).Append("\n");
          sb.Append("  Result: ").Append(this.Result).Append("\n");
          sb.Append("  Error: ").Append(this.Error).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
