// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ChangesApi.cs">
//  Copyright (c) 2003-2017 Aspose Pty Ltd
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
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

namespace GroupDocs.Comparison.Cloud.Sdk
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    using GroupDocs.Comparison.Cloud.Sdk.Api;
    using GroupDocs.Comparison.Cloud.Sdk.Internal;
    using GroupDocs.Comparison.Cloud.Sdk.Internal.RequestHandlers;
    using GroupDocs.Comparison.Cloud.Sdk.Model;
    using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;
    
    
    /// <summary>
    /// GroupDocs.Comparison for Cloud API.
    /// </summary>
    public class ChangesApi
    {        
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;     

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangesApi"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The api Key.
        /// </param>
        /// <param name="appSid">
        /// The app Sid.
        /// </param>
        public ChangesApi(string apiKey, string appSid)
            : this(new Configuration { AppKey = apiKey, AppSid = appSid })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangesApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public ChangesApi(Configuration configuration)
        {
            this.configuration = configuration;
            
            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new OAuthRequestHandler(this.configuration));
            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            requestHandlers.Add(new AuthWithSignatureRequestHandler(this.configuration));
            this.apiInvoker = new ApiInvoker(requestHandlers);
        }                            

        /// <summary>
        /// Posts the categories changes. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostCategoriesChangesRequest" /></param> 
        /// <returns><see cref="List<ComparisonChangesCategoryDto>"/></returns>            
        public List<ComparisonChangesCategoryDto> PostCategoriesChanges(PostCategoriesChangesRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/comparison/compareDocuments/changes/categories";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "categoriesType", request.CategoriesType);
            var postBody = SerializationHelper.Serialize(request.Request); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (List&lt;ComparisonChangesCategoryDto&gt;)SerializationHelper.Deserialize(response, typeof(List&lt;ComparisonChangesCategoryDto&gt;));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Returns json result with set of changes between documents 
        /// </summary>
        /// <param name="request">Request. <see cref="PostChangesRequest" /></param> 
        /// <returns><see cref="List<ComparisonChange>"/></returns>            
        public List<ComparisonChange> PostChanges(PostChangesRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/comparison/compareDocuments/changes";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.Request); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (List&lt;ComparisonChange&gt;)SerializationHelper.Deserialize(response, typeof(List&lt;ComparisonChange&gt;));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Applies changes to the document and returns document with the result of comparison 
        /// </summary>
        /// <param name="request">Request. <see cref="PutChangesDocumentRequest" /></param> 
        /// <returns><see cref="Link"/></returns>            
        public Link PutChangesDocument(PutChangesDocumentRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/comparison/compareDocuments/changes/update";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            var postBody = SerializationHelper.Serialize(request.Request); // http body (model) parameter
            try 
            {                               
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
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Applies changes to the document and returns stream of document with the result of comparison 
        /// </summary>
        /// <param name="request">Request. <see cref="PutChangesDocumentStreamRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutChangesDocumentStream(PutChangesDocumentStreamRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/comparison/compareDocuments/changes/stream";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.Request); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "PUT", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (System.IO.Stream)SerializationHelper.Deserialize(response, typeof(System.IO.Stream));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Applies changes to the document and returns images of document with the result of comparison 
        /// </summary>
        /// <param name="request">Request. <see cref="PutChangesImagesRequest" /></param> 
        /// <returns><see cref="List<Link>"/></returns>            
        public List<Link> PutChangesImages(PutChangesImagesRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/comparison/compareDocuments/changes/images";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outFolder", request.OutFolder);
            var postBody = SerializationHelper.Serialize(request.Request); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "PUT", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (List&lt;Link&gt;)SerializationHelper.Deserialize(response, typeof(List&lt;Link&gt;));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Applies changes to the document and returns image&#39;s streams of document with the result of comparison 
        /// </summary>
        /// <param name="request">Request. <see cref="PutChangesImagesStreamRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutChangesImagesStream(PutChangesImagesStreamRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/comparison/compareDocuments/changes/stream/images";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.Request); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "PUT", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (System.IO.Stream)SerializationHelper.Deserialize(response, typeof(System.IO.Stream));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PostCategoriesChangesRequest.cs">
//  Copyright (c) 2003-2017 Aspose Pty Ltd
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
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
  /// Request model for <see cref="GroupDocs.Comparison.Cloud.Sdk.Api.ComparisonApi.PostCategoriesChanges" /> operation.
  /// </summary>  
  public class PostCategoriesChangesRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostCategoriesChangesRequest"/> class.
        /// </summary>        
        public PostCategoriesChangesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCategoriesChangesRequest"/> class.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="categoriesType">Type of the categories.</param>
        public PostCategoriesChangesRequest(ComparisonRequest request = null, string categoriesType = null)             
        {
            this.Request = request;
            this.CategoriesType = categoriesType;
        }

        /// <summary>
        /// The request.
        /// </summary>  
        public ComparisonRequest Request { get; set; }

        /// <summary>
        /// Type of the categories.
        /// </summary>  
        public string CategoriesType { get; set; }
  }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PostChangesRequest.cs">
//  Copyright (c) 2003-2017 Aspose Pty Ltd
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
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
  /// Request model for <see cref="GroupDocs.Comparison.Cloud.Sdk.Api.ComparisonApi.PostChanges" /> operation.
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
        /// <param name="request">The request.</param>
        public PostChangesRequest(ComparisonRequest request = null)             
        {
            this.Request = request;
        }

        /// <summary>
        /// The request.
        /// </summary>  
        public ComparisonRequest Request { get; set; }
  }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PutChangesDocumentRequest.cs">
//  Copyright (c) 2003-2017 Aspose Pty Ltd
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
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
  /// Request model for <see cref="GroupDocs.Comparison.Cloud.Sdk.Api.ComparisonApi.PutChangesDocument" /> operation.
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
        /// <param name="request">The request.</param>
        /// <param name="outPath">outPath: path to output document on file storage</param>
        public PutChangesDocumentRequest(ComparisonRequest request = null, string outPath = null)             
        {
            this.Request = request;
            this.OutPath = outPath;
        }

        /// <summary>
        /// The request.
        /// </summary>  
        public ComparisonRequest Request { get; set; }

        /// <summary>
        /// outPath: path to output document on file storage
        /// </summary>  
        public string OutPath { get; set; }
  }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PutChangesDocumentStreamRequest.cs">
//  Copyright (c) 2003-2017 Aspose Pty Ltd
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
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
  /// Request model for <see cref="GroupDocs.Comparison.Cloud.Sdk.Api.ComparisonApi.PutChangesDocumentStream" /> operation.
  /// </summary>  
  public class PutChangesDocumentStreamRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutChangesDocumentStreamRequest"/> class.
        /// </summary>        
        public PutChangesDocumentStreamRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutChangesDocumentStreamRequest"/> class.
        /// </summary>
        /// <param name="request">The request.</param>
        public PutChangesDocumentStreamRequest(ComparisonRequest request = null)             
        {
            this.Request = request;
        }

        /// <summary>
        /// The request.
        /// </summary>  
        public ComparisonRequest Request { get; set; }
  }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PutChangesImagesRequest.cs">
//  Copyright (c) 2003-2017 Aspose Pty Ltd
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
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
  /// Request model for <see cref="GroupDocs.Comparison.Cloud.Sdk.Api.ComparisonApi.PutChangesImages" /> operation.
  /// </summary>  
  public class PutChangesImagesRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutChangesImagesRequest"/> class.
        /// </summary>        
        public PutChangesImagesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutChangesImagesRequest"/> class.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="outFolder">outFolder: path to output folder on file storage</param>
        public PutChangesImagesRequest(ComparisonRequest request = null, string outFolder = null)             
        {
            this.Request = request;
            this.OutFolder = outFolder;
        }

        /// <summary>
        /// The request.
        /// </summary>  
        public ComparisonRequest Request { get; set; }

        /// <summary>
        /// outFolder: path to output folder on file storage
        /// </summary>  
        public string OutFolder { get; set; }
  }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PutChangesImagesStreamRequest.cs">
//  Copyright (c) 2003-2017 Aspose Pty Ltd
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
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
  /// Request model for <see cref="GroupDocs.Comparison.Cloud.Sdk.Api.ComparisonApi.PutChangesImagesStream" /> operation.
  /// </summary>  
  public class PutChangesImagesStreamRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutChangesImagesStreamRequest"/> class.
        /// </summary>        
        public PutChangesImagesStreamRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutChangesImagesStreamRequest"/> class.
        /// </summary>
        /// <param name="request">The request.</param>
        public PutChangesImagesStreamRequest(ComparisonRequest request = null)             
        {
            this.Request = request;
        }

        /// <summary>
        /// The request.
        /// </summary>  
        public ComparisonRequest Request { get; set; }
  }
}
