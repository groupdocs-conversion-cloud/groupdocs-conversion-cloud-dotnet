// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="AsyncApi.cs">
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
    public class AsyncApi
    {        
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;     

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncApi"/> class.
        /// </summary>
        /// <param name="appSid">Application identifier (App SID)</param>
        /// <param name="appKey">Application private key (App Key)</param>
        public AsyncApi(string appSid, string appKey)
            : this(new Configuration(appSid, appKey))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public AsyncApi(Configuration configuration)
        {
            this.configuration = configuration;
            
            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new AuthRequestHandler(this.configuration));
            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            this.apiInvoker = new ApiInvoker(requestHandlers, this.configuration.Timeout);
        }

        /// <summary>
        /// Get async operation result 
        /// </summary>
        /// <param name="request">Request. <see cref="GetOperationResultRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream GetOperationResult(GetOperationResultRequest request)
        {
            // verify the required parameter 'id' is set
            if (request.id == null) 
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling GetOperationResult");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/conversion/async/result";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "id", request.id);
            
            return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
        }
        /// <summary>
        /// Get async operation status 
        /// </summary>
        /// <param name="request">Request. <see cref="GetOperationStatusRequest" /></param>
        /// <returns><see cref="OperationResult"/></returns>
        public OperationResult GetOperationStatus(GetOperationStatusRequest request)
        {
            // verify the required parameter 'id' is set
            if (request.id == null) 
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling GetOperationStatus");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/conversion/async";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "id", request.id);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                null);
            
            if (response != null)
            {
                return (OperationResult)SerializationHelper.Deserialize(response, typeof(OperationResult));
            }

            return null;
        }
        /// <summary>
        /// Starts async conversion specified input document, from request body, to format specified 
        /// </summary>
        /// <param name="request">Request. <see cref="StartConvertRequest" /></param>
        /// <returns><see cref="string"/></returns>
        public string StartConvert(StartConvertRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling StartConvert");
            }

            // verify the required parameter 'file' is set
            if (request.File == null) 
            {
                throw new ApiException(400, "Missing required parameter 'file' when calling StartConvert");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/conversion/async";
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
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "PUT", 
                null, 
                null, 
                formParams);
            
            if (response != null)
            {
                return (string)SerializationHelper.Deserialize(response, typeof(string));
            }

            return null;
        }
        /// <summary>
        /// Starts async conversion specified input document to format specified in the convertSettings with specified options 
        /// </summary>
        /// <param name="request">Request. <see cref="StartConvertAndSaveRequest" /></param>
        /// <returns><see cref="string"/></returns>
        public string StartConvertAndSave(StartConvertAndSaveRequest request)
        {
            // verify the required parameter 'convertSettings' is set
            if (request.convertSettings == null) 
            {
                throw new ApiException(400, "Missing required parameter 'convertSettings' when calling StartConvertAndSave");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/conversion/async";
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
                return (string)SerializationHelper.Deserialize(response, typeof(string));
            }

            return null;
        }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="GetOperationResultRequest.cs">
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

namespace GroupDocs.Conversion.Cloud.Sdk.Model.Requests 
{
    using GroupDocs.Conversion.Cloud.Sdk.Model; 

    /// <summary>
    /// Request model for <see cref="GroupDocs.Conversion.Cloud.Sdk.Api.AsyncApi.GetOperationResult" /> operation.
    /// </summary>  
    public class GetOperationResultRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="GetOperationResultRequest"/> class.
          /// </summary>        
          public GetOperationResultRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="GetOperationResultRequest"/> class.
          /// </summary>
          /// <param name="id"></param>
          public GetOperationResultRequest(string id)             
          {
              this.id = id;
          }
          
          /// <summary>
          /// Gets or sets id
          /// </summary>  
          public string id { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="GetOperationStatusRequest.cs">
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

namespace GroupDocs.Conversion.Cloud.Sdk.Model.Requests 
{
    using GroupDocs.Conversion.Cloud.Sdk.Model; 

    /// <summary>
    /// Request model for <see cref="GroupDocs.Conversion.Cloud.Sdk.Api.AsyncApi.GetOperationStatus" /> operation.
    /// </summary>  
    public class GetOperationStatusRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="GetOperationStatusRequest"/> class.
          /// </summary>        
          public GetOperationStatusRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="GetOperationStatusRequest"/> class.
          /// </summary>
          /// <param name="id"></param>
          public GetOperationStatusRequest(string id)             
          {
              this.id = id;
          }
          
          /// <summary>
          /// Gets or sets id
          /// </summary>  
          public string id { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="StartConvertRequest.cs">
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

namespace GroupDocs.Conversion.Cloud.Sdk.Model.Requests 
{
    using GroupDocs.Conversion.Cloud.Sdk.Model; 

    /// <summary>
    /// Request model for <see cref="GroupDocs.Conversion.Cloud.Sdk.Api.AsyncApi.StartConvert" /> operation.
    /// </summary>  
    public class StartConvertRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="StartConvertRequest"/> class.
          /// </summary>        
          public StartConvertRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="StartConvertRequest"/> class.
          /// </summary>
          /// <param name="format">Requested conversion format</param>
          /// <param name="file">Input file to convert</param>
          /// <param name="fromPage">Page start conversion from</param>
          /// <param name="pagesCount">Number of pages to convert</param>
          public StartConvertRequest(string format, System.IO.Stream file, int? fromPage = null, int? pagesCount = null)             
          {
              this.format = format;
              this.File = file;
              this.fromPage = fromPage;
              this.pagesCount = pagesCount;
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
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="StartConvertAndSaveRequest.cs">
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

namespace GroupDocs.Conversion.Cloud.Sdk.Model.Requests 
{
    using GroupDocs.Conversion.Cloud.Sdk.Model; 

    /// <summary>
    /// Request model for <see cref="GroupDocs.Conversion.Cloud.Sdk.Api.AsyncApi.StartConvertAndSave" /> operation.
    /// </summary>  
    public class StartConvertAndSaveRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="StartConvertAndSaveRequest"/> class.
          /// </summary>        
          public StartConvertAndSaveRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="StartConvertAndSaveRequest"/> class.
          /// </summary>
          /// <param name="convertSettings">Conversion settings</param>
          public StartConvertAndSaveRequest(ConvertSettings convertSettings)             
          {
              this.convertSettings = convertSettings;
          }
          
          /// <summary>
          /// Conversion settings
          /// </summary>  
          public ConvertSettings convertSettings { get; set; }
    }
}
