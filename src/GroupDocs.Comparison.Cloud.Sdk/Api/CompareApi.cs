// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="CompareApi.cs">
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

namespace GroupDocs.Comparison.Cloud.Sdk.Api
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using System.IO;
    using GroupDocs.Comparison.Cloud.Sdk.Client;
    using GroupDocs.Comparison.Cloud.Sdk.Client.RequestHandlers;
    using GroupDocs.Comparison.Cloud.Sdk.Model;
    using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;
    
    /// <summary>
    /// GroupDocs.Comparison.Cloud.Sdk API.
    /// </summary>
    public class CompareApi
    {        
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;     

        /// <summary>
        /// Initializes a new instance of the <see cref="CompareApi"/> class.
        /// </summary>
        /// <param name="appSid">Application identifier (App SID)</param>
        /// <param name="appKey">Application private key (App Key)</param>
        public CompareApi(string appSid, string appKey)
            : this(new Configuration(appSid, appKey))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompareApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public CompareApi(Configuration configuration)
        {
            this.configuration = configuration;
            
            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new AuthRequestHandler(this.configuration));
            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            this.apiInvoker = new ApiInvoker(requestHandlers, this.configuration.Timeout);
        }                            

        /// <summary>
        /// Compares source and target documents and returns a link to saved result 
        /// </summary>
        /// <param name="request">Request. <see cref="ComparisonsRequest" /></param>
        /// <returns><see cref="Link"/></returns>
        public Link Comparisons(ComparisonsRequest request)
        {
            // verify the required parameter 'comparisonOptions' is set
            if (request.comparisonOptions == null) 
            {
                throw new ApiException(400, "Missing required parameter 'comparisonOptions' when calling Comparisons");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/comparison/comparisons";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.comparisonOptions); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (Link)SerializationHelper.Deserialize(response, typeof(Link));
            }

            return null;
        }

        /// <summary>
        /// Retrieves a list of changes between source and target documents 
        /// </summary>
        /// <param name="request">Request. <see cref="PostChangesRequest" /></param>
        /// <returns><see cref="List<ChangeInfo>"/></returns>
        public List<ChangeInfo> PostChanges(PostChangesRequest request)
        {
            // verify the required parameter 'comparisonOptions' is set
            if (request.comparisonOptions == null) 
            {
                throw new ApiException(400, "Missing required parameter 'comparisonOptions' when calling PostChanges");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/comparison/changes";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.comparisonOptions); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (List<ChangeInfo>)SerializationHelper.Deserialize(response, typeof(List<ChangeInfo>));
            }

            return null;
        }

        /// <summary>
        /// Accepts or rejects changes to the resultant document and returns a link to saved result 
        /// </summary>
        /// <param name="request">Request. <see cref="PutChangesDocumentRequest" /></param>
        /// <returns><see cref="Link"/></returns>
        public Link PutChangesDocument(PutChangesDocumentRequest request)
        {
            // verify the required parameter 'updatesOptions' is set
            if (request.updatesOptions == null) 
            {
                throw new ApiException(400, "Missing required parameter 'updatesOptions' when calling PutChangesDocument");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/comparison/updates";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.updatesOptions); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "PUT", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (Link)SerializationHelper.Deserialize(response, typeof(Link));
            }

            return null;
        }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ComparisonsRequest.cs">
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

namespace GroupDocs.Comparison.Cloud.Sdk.Model.Requests 
{
    using GroupDocs.Comparison.Cloud.Sdk.Model; 

    /// <summary>
    /// Request model for <see cref="GroupDocs.Comparison.Cloud.Sdk.Api.CompareApi.Comparisons" /> operation.
    /// </summary>  
    public class ComparisonsRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="ComparisonsRequest"/> class.
          /// </summary>        
          public ComparisonsRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="ComparisonsRequest"/> class.
          /// </summary>
          /// <param name="comparisonOptions">Comparison options</param>
          public ComparisonsRequest(ComparisonOptions comparisonOptions)             
          {
              this.comparisonOptions = comparisonOptions;
          }
          
          /// <summary>
          /// Comparison options
          /// </summary>  
          public ComparisonOptions comparisonOptions { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PostChangesRequest.cs">
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

namespace GroupDocs.Comparison.Cloud.Sdk.Model.Requests 
{
    using GroupDocs.Comparison.Cloud.Sdk.Model; 

    /// <summary>
    /// Request model for <see cref="GroupDocs.Comparison.Cloud.Sdk.Api.CompareApi.PostChanges" /> operation.
    /// </summary>  
    public class PostChangesRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="PostChangesRequest"/> class.
          /// </summary>        
          public PostChangesRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="PostChangesRequest"/> class.
          /// </summary>
          /// <param name="comparisonOptions">Comparison options</param>
          public PostChangesRequest(ComparisonOptions comparisonOptions)             
          {
              this.comparisonOptions = comparisonOptions;
          }
          
          /// <summary>
          /// Comparison options
          /// </summary>  
          public ComparisonOptions comparisonOptions { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PutChangesDocumentRequest.cs">
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

namespace GroupDocs.Comparison.Cloud.Sdk.Model.Requests 
{
    using GroupDocs.Comparison.Cloud.Sdk.Model; 

    /// <summary>
    /// Request model for <see cref="GroupDocs.Comparison.Cloud.Sdk.Api.CompareApi.PutChangesDocument" /> operation.
    /// </summary>  
    public class PutChangesDocumentRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="PutChangesDocumentRequest"/> class.
          /// </summary>        
          public PutChangesDocumentRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="PutChangesDocumentRequest"/> class.
          /// </summary>
          /// <param name="updatesOptions">Comparison options</param>
          public PutChangesDocumentRequest(UpdatesOptions updatesOptions)             
          {
              this.updatesOptions = updatesOptions;
          }
          
          /// <summary>
          /// Comparison options
          /// </summary>  
          public UpdatesOptions updatesOptions { get; set; }
    }
}
