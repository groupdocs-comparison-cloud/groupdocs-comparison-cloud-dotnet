// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ReviewApi.cs">
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
    public class ReviewApi
    {        
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;     

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewApi"/> class.
        /// </summary>
        /// <param name="appSid">Application identifier (App SID)</param>
        /// <param name="appKey">Application private key (App Key)</param>
        public ReviewApi(string appSid, string appKey)
            : this(new Configuration(appSid, appKey))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public ReviewApi(Configuration configuration)
        {
            this.configuration = configuration;
            
            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new AuthRequestHandler(this.configuration));
            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            this.apiInvoker = new ApiInvoker(requestHandlers, this.configuration.Timeout);
        }                            

        /// <summary>
        /// Accepts or rejects revisions in DOCX document 
        /// </summary>
        /// <param name="request">Request. <see cref="ApplyRevisionsRequest" /></param>
        /// <returns><see cref="Link"/></returns>
        public Link ApplyRevisions(ApplyRevisionsRequest request)
        {
            // verify the required parameter 'revisionOptions' is set
            if (request.revisionOptions == null) 
            {
                throw new ApiException(400, "Missing required parameter 'revisionOptions' when calling ApplyRevisions");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/comparison/revisions";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.revisionOptions); // http body (model) parameter
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

        /// <summary>
        /// Get list of DOCX document revisions.  
        /// </summary>
        /// <param name="request">Request. <see cref="GetRevisionsRequest" /></param>
        /// <returns><see cref="List<RevisionInfo>"/></returns>
        public List<RevisionInfo> GetRevisions(GetRevisionsRequest request)
        {
            // verify the required parameter 'fileInfo' is set
            if (request.fileInfo == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileInfo' when calling GetRevisions");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/comparison/revisions";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.fileInfo); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (List<RevisionInfo>)SerializationHelper.Deserialize(response, typeof(List<RevisionInfo>));
            }

            return null;
        }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ApplyRevisionsRequest.cs">
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

namespace GroupDocs.Comparison.Cloud.Sdk.Model.Requests 
{
    using GroupDocs.Comparison.Cloud.Sdk.Model; 

    /// <summary>
    /// Request model for <see cref="GroupDocs.Comparison.Cloud.Sdk.Api.ReviewApi.ApplyRevisions" /> operation.
    /// </summary>  
    public class ApplyRevisionsRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="ApplyRevisionsRequest"/> class.
          /// </summary>        
          public ApplyRevisionsRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="ApplyRevisionsRequest"/> class.
          /// </summary>
          /// <param name="revisionOptions">Apply revisions options</param>
          public ApplyRevisionsRequest(ApplyRevisionsOptions revisionOptions)             
          {
              this.revisionOptions = revisionOptions;
          }
          
          /// <summary>
          /// Apply revisions options
          /// </summary>  
          public ApplyRevisionsOptions revisionOptions { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="GetRevisionsRequest.cs">
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

namespace GroupDocs.Comparison.Cloud.Sdk.Model.Requests 
{
    using GroupDocs.Comparison.Cloud.Sdk.Model; 

    /// <summary>
    /// Request model for <see cref="GroupDocs.Comparison.Cloud.Sdk.Api.ReviewApi.GetRevisions" /> operation.
    /// </summary>  
    public class GetRevisionsRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="GetRevisionsRequest"/> class.
          /// </summary>        
          public GetRevisionsRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="GetRevisionsRequest"/> class.
          /// </summary>
          /// <param name="fileInfo">File information</param>
          public GetRevisionsRequest(FileInfo fileInfo)             
          {
              this.fileInfo = fileInfo;
          }
          
          /// <summary>
          /// File information
          /// </summary>  
          public FileInfo fileInfo { get; set; }
    }
}
