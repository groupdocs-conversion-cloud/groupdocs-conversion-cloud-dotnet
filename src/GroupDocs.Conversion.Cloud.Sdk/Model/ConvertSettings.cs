// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ConvertSettings.cs">
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
    /// Defines conversion request
    /// </summary>  
    public class ConvertSettings 
    {                       
        /// <summary>
        /// StorageName which contains the file
        /// </summary>  
        public string StorageName { get; set; }

        /// <summary>
        /// Gets or sets absolute path to a file in the storage
        /// </summary>  
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets requested conversion format
        /// </summary>  
        public string Format { get; set; }

        /// <summary>
        /// Gets or sets format specific load options for source file
        /// </summary>  
        public LoadOptions LoadOptions { get; set; }

        /// <summary>
        /// Gets or sets format specific convert options for output file
        /// </summary>  
        public ConvertOptions ConvertOptions { get; set; }

        /// <summary>
        /// Gets or sets converted file save path
        /// </summary>  
        public string OutputPath { get; set; }

        /// <summary>
        /// The path to directory containing custom fonts in storage
        /// </summary>  
        public string FontsPath { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ConvertSettings {\n");
          sb.Append("  StorageName: ").Append(this.StorageName).Append("\n");
          sb.Append("  FilePath: ").Append(this.FilePath).Append("\n");
          sb.Append("  Format: ").Append(this.Format).Append("\n");
          sb.Append("  LoadOptions: ").Append(this.LoadOptions).Append("\n");
          sb.Append("  ConvertOptions: ").Append(this.ConvertOptions).Append("\n");
          sb.Append("  OutputPath: ").Append(this.OutputPath).Append("\n");
          sb.Append("  FontsPath: ").Append(this.FontsPath).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
