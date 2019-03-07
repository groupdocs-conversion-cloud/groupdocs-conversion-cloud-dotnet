// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ConversionApi.cs">
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

namespace GroupDocs.Conversion.Cloud.Sdk.Api
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using GroupDocs.Conversion.Cloud.Sdk.Client;
    using GroupDocs.Conversion.Cloud.Sdk.Client.RequestHandlers;
    using GroupDocs.Conversion.Cloud.Sdk.Model;
    using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;
    
    /// <summary>
    /// GroupDocs.Conversion Cloud API.
    /// </summary>
    public class ConversionApi
    {        
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;     

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversionApi"/> class.
        /// </summary>
        /// <param name="appSid">Application identifier (App SID)</param>
        /// <param name="appKey">Application private key (App Key)</param>
        public ConversionApi(string appSid, string appKey)
            : this(new Configuration(appSid, appKey))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversionApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public ConversionApi(Configuration configuration)
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
        public void ConvertDocument(ConvertDocumentRequest request)
        {
            // verify the required parameter 'convertSettings' is set
            if (request.convertSettings == null) 
            {
                throw new ApiException(400, "Missing required parameter 'convertSettings' when calling ConvertDocument");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/conversion";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.convertSettings); // http body (model) parameter
            this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);
        }

        /// <summary>
        /// Returns all supported conversion types 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSupportedConversionTypesRequest" /></param>
        /// <returns><see cref="List<SupportedFormat>"/></returns>
        public List<SupportedFormat> GetSupportedConversionTypes(GetSupportedConversionTypesRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/conversion/formats";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "filePath", request.FilePath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                null);

            if (response != null)
            {
                return (List<SupportedFormat>)SerializationHelper.Deserialize(response, typeof(List<SupportedFormat>));
            }

            return null;
        }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ConvertDocumentRequest.cs">
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

namespace GroupDocs.Conversion.Cloud.Sdk.Model.Requests 
{
    using GroupDocs.Conversion.Cloud.Sdk.Model; 

    /// <summary>
    /// Request model for <see cref="GroupDocs.Conversion.Cloud.Sdk.Api.ConversionApi.ConvertDocument" /> operation.
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
// <copyright company="Aspose Pty Ltd" file="GetSupportedConversionTypesRequest.cs">
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

namespace GroupDocs.Conversion.Cloud.Sdk.Model.Requests 
{
    using GroupDocs.Conversion.Cloud.Sdk.Model; 

    /// <summary>
    /// Request model for <see cref="GroupDocs.Conversion.Cloud.Sdk.Api.ConversionApi.GetSupportedConversionTypes" /> operation.
    /// </summary>  
    public class GetSupportedConversionTypesRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="GetSupportedConversionTypesRequest"/> class.
          /// </summary>        
          public GetSupportedConversionTypesRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="GetSupportedConversionTypesRequest"/> class.
          /// </summary>
          /// <param name="filePath">Absolute path to a document in the storage</param>
          /// <param name="storage">Storage which contains the document</param>
          /// <param name="format">If provided only supported conversions for specified format will be returned</param>
          public GetSupportedConversionTypesRequest(string filePath = null, string storage = null, string format = null)             
          {
              this.FilePath = filePath;
              this.Storage = storage;
              this.format = format;
          }
          
          /// <summary>
          /// Absolute path to a document in the storage
          /// </summary>  
          public string FilePath { get; set; }
          
          /// <summary>
          /// Storage which contains the document
          /// </summary>  
          public string Storage { get; set; }
          
          /// <summary>
          /// If provided only supported conversions for specified format will be returned
          /// </summary>  
          public string format { get; set; }
    }
}
