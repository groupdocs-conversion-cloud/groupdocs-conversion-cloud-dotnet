// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ConvertApi.cs">
//  Copyright (c) 2003-2023 Aspose Pty Ltd
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

namespace GroupDocs.Conversion.Cloud.Sdk.Api
{
    using System.IO;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using GroupDocs.Conversion.Cloud.Sdk.Client;
    using GroupDocs.Conversion.Cloud.Sdk.Client.RequestHandlers;
    using GroupDocs.Conversion.Cloud.Sdk.Model;
    using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;
    
    /// <summary>
    /// GroupDocs.Conversion Cloud API.
    /// </summary>
    public class ConvertApi
    {        
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;     

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertApi"/> class.
        /// </summary>
        /// <param name="appSid">Application identifier (App SID)</param>
        /// <param name="appKey">Application private key (App Key)</param>
        public ConvertApi(string appSid, string appKey)
            : this(new Configuration(appSid, appKey))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public ConvertApi(Configuration configuration)
        {
            this.configuration = configuration;
            
            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new AuthRequestHandler(this.configuration));
            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            this.apiInvoker = new ApiInvoker(requestHandlers, this.configuration.Timeout);
        }

        /// <summary>
        /// Converts specified input document to format specified in the convertSettings with specified options 
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertDocumentRequest" /></param>
        public List<StoredConvertedResult> ConvertDocument(ConvertDocumentRequest request)
        {
            // verify the required parameter 'convertSettings' is set
            if (request.convertSettings == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'convertSettings' when calling ConvertDocument");
            }
            
            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/conversion";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.convertSettings); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
                
            if (response != null)
            {
                return (List<StoredConvertedResult>) SerializationHelper.Deserialize(response, typeof(List<StoredConvertedResult>));
            }

            return null;
        }

        /// <summary>
        /// Converts specified input document to format specified in the convertSettings with specified options and return result as stream
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertDocumentRequest" /></param>
        public Stream ConvertDocumentDownload(ConvertDocumentRequest request)
        {
            // verify the required parameter 'convertSettings' is set
            if (request.convertSettings == null)
            {
                throw new ApiException(400,
                    "Missing required parameter 'convertSettings' when calling ConvertDocument");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/conversion";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.convertSettings); // http body (model) parameter
            return this.apiInvoker.InvokeBinaryApi(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
        }
        /// <summary>
        /// Converts input document file to format specified 
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertDocumentDirectRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream ConvertDocumentDirect(ConvertDocumentDirectRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling ConvertDocumentDirect");
            }

            // verify the required parameter 'file' is set
            if (request.File == null) 
            {
                throw new ApiException(400, "Missing required parameter 'file' when calling ConvertDocumentDirect");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/conversion";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            
            
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fromPage", request.fromPage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pagesCount", request.pagesCount);
            
            if (request.File != null) 
            {
                formParams.Add("file", this.apiInvoker.ToFileInfo(request.File, "File"));
            }
            
            if (request.loadOptions != null) 
            {
                formParams.Add("loadOptions", request.loadOptions); // form parameter
            }
            
            if (request.convertOptions != null) 
            {
                formParams.Add("convertOptions", request.convertOptions); // form parameter
            }
            
            return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                    "PUT", 
                    null, 
                    null, 
                    formParams);
        }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ConvertDocumentRequest.cs">
//  Copyright (c) 2003-2023 Aspose Pty Ltd
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

namespace GroupDocs.Conversion.Cloud.Sdk.Model.Requests 
{
    using GroupDocs.Conversion.Cloud.Sdk.Model; 

    /// <summary>
    /// Request model for <see cref="GroupDocs.Conversion.Cloud.Sdk.Api.ConvertApi.ConvertDocument" /> operation.
    /// </summary>  
    public class ConvertDocumentRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="ConvertDocumentRequest"/> class.
          /// </summary>        
          public ConvertDocumentRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="ConvertDocumentRequest"/> class.
          /// </summary>
          /// <param name="convertSettings"></param>
          public ConvertDocumentRequest(ConvertSettings convertSettings)             
          {
              this.convertSettings = convertSettings;
          }
          
          /// <summary>
          /// Gets or sets convertSettings
          /// </summary>  
          public ConvertSettings convertSettings { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ConvertDocumentDirectRequest.cs">
//  Copyright (c) 2003-2023 Aspose Pty Ltd
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

namespace GroupDocs.Conversion.Cloud.Sdk.Model.Requests 
{
    using GroupDocs.Conversion.Cloud.Sdk.Model; 

    /// <summary>
    /// Request model for <see cref="GroupDocs.Conversion.Cloud.Sdk.Api.ConvertApi.ConvertDocumentDirect" /> operation.
    /// </summary>  
    public class ConvertDocumentDirectRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="ConvertDocumentDirectRequest"/> class.
          /// </summary>        
          public ConvertDocumentDirectRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="ConvertDocumentDirectRequest"/> class.
          /// </summary>
          /// <param name="format">Requested conversion format</param>
          /// <param name="file">Input file to convert</param>
          /// <param name="fromPage">Page start conversion from</param>
          /// <param name="pagesCount">Number of pages to convert</param>
          /// <param name="loadOptions">Input file load options</param>
          /// <param name="convertOptions">Conversion options</param>
          public ConvertDocumentDirectRequest(string format, System.IO.Stream file, int? fromPage = null, int? pagesCount = null, LoadOptions loadOptions = null, ConvertOptions convertOptions = null)             
          {
              this.format = format;
              this.File = file;
              this.fromPage = fromPage;
              this.pagesCount = pagesCount;
              this.loadOptions = loadOptions;
              this.convertOptions = convertOptions;
          }
          
          /// <summary>
          /// Requested conversion format
          /// </summary>  
          public string format { get; set; }
          
          /// <summary>
          /// Input file to convert
          /// </summary>  
          public System.IO.Stream File { get; set; }
          
          /// <summary>
          /// Page start conversion from
          /// </summary>  
          public int? fromPage { get; set; }
          
          /// <summary>
          /// Number of pages to convert
          /// </summary>  
          public int? pagesCount { get; set; }
          
          /// <summary>
          /// Input file load options
          /// </summary>  
          public LoadOptions loadOptions { get; set; }
          
          /// <summary>
          /// Conversion options
          /// </summary>  
          public ConvertOptions convertOptions { get; set; }
    }
}
