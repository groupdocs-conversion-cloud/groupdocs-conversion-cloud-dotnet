// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="InfoApi.cs">
//  Copyright (c) 2003-2020 Aspose Pty Ltd
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
    public class InfoApi
    {        
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;     

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoApi"/> class.
        /// </summary>
        /// <param name="appSid">Application identifier (App SID)</param>
        /// <param name="appKey">Application private key (App Key)</param>
        public InfoApi(string appSid, string appKey)
            : this(new Configuration(appSid, appKey))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public InfoApi(Configuration configuration)
        {
            this.configuration = configuration;
            
            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new AuthRequestHandler(this.configuration));
            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            this.apiInvoker = new ApiInvoker(requestHandlers, this.configuration.Timeout);
        }

        /// <summary>
        /// Returns metadata for provided document 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentMetadataRequest" /></param>
        /// <returns><see cref="DocumentMetadata"/></returns>
        public DocumentMetadata GetDocumentMetadata(GetDocumentMetadataRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/conversion/info";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "filePath", request.FilePath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.StorageName);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                null);
            
            if (response != null)
            {
                return (DocumentMetadata)SerializationHelper.Deserialize(response, typeof(DocumentMetadata));
            }

            return null;
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.StorageName);
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
// <copyright company="Aspose Pty Ltd" file="GetDocumentMetadataRequest.cs">
//  Copyright (c) 2003-2020 Aspose Pty Ltd
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
    /// Request model for <see cref="GroupDocs.Conversion.Cloud.Sdk.Api.InfoApi.GetDocumentMetadata" /> operation.
    /// </summary>  
    public class GetDocumentMetadataRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="GetDocumentMetadataRequest"/> class.
          /// </summary>        
          public GetDocumentMetadataRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="GetDocumentMetadataRequest"/> class.
          /// </summary>
          /// <param name="filePath">Absolute path to a document in the storage</param>
          /// <param name="storageName">StorageName which contains the document</param>
          public GetDocumentMetadataRequest(string filePath = null, string storageName = null)             
          {
              this.FilePath = filePath;
              this.StorageName = storageName;
          }
          
          /// <summary>
          /// Absolute path to a document in the storage
          /// </summary>  
          public string FilePath { get; set; }
          
          /// <summary>
          /// StorageName which contains the document
          /// </summary>  
          public string StorageName { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="GetSupportedConversionTypesRequest.cs">
//  Copyright (c) 2003-2020 Aspose Pty Ltd
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
    /// Request model for <see cref="GroupDocs.Conversion.Cloud.Sdk.Api.InfoApi.GetSupportedConversionTypes" /> operation.
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
          /// <param name="storageName">StorageName which contains the document</param>
          /// <param name="format">If provided only supported conversions for specified format will be returned</param>
          public GetSupportedConversionTypesRequest(string filePath = null, string storageName = null, string format = null)             
          {
              this.FilePath = filePath;
              this.StorageName = storageName;
              this.format = format;
          }
          
          /// <summary>
          /// Absolute path to a document in the storage
          /// </summary>  
          public string FilePath { get; set; }
          
          /// <summary>
          /// StorageName which contains the document
          /// </summary>  
          public string StorageName { get; set; }
          
          /// <summary>
          /// If provided only supported conversions for specified format will be returned
          /// </summary>  
          public string format { get; set; }
    }
}
