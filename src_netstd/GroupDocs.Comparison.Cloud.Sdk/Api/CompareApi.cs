// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="CompareApi.cs">
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

using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp.Portable;
using GroupDocs.Comparison.Cloud.Sdk.Client;
using GroupDocs.Comparison.Cloud.Sdk.Model;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Comparison.Cloud.Sdk.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICompareApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Compares source and target documents and returns a link to saved result
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Comparison.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="comparisonOptions">Comparison options</param>
        /// <returns>Link</returns>
        Link Comparisons(ComparisonsRequest request);

        /// <summary>
        /// Compares source and target documents and returns a link to saved result
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Comparison.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="comparisonOptions">Comparison options</param>
        /// <returns>ApiResponse of Link</returns>
        ApiResponse<Link> ComparisonsWithHttpInfo (ComparisonsRequest request);
        /// <summary>
        /// Retrieves a list of changes between source and target documents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Comparison.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="comparisonOptions">Comparison options</param>
        /// <returns>List&lt;ChangeInfo&gt;</returns>
        List<ChangeInfo> PostChanges(PostChangesRequest request);

        /// <summary>
        /// Retrieves a list of changes between source and target documents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Comparison.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="comparisonOptions">Comparison options</param>
        /// <returns>ApiResponse of List&lt;ChangeInfo&gt;</returns>
        ApiResponse<List<ChangeInfo>> PostChangesWithHttpInfo (PostChangesRequest request);
        /// <summary>
        /// Accepts or rejects changes to the resultant document and returns a link to saved result
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Comparison.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="comparisonOptions">Comparison options</param>
        /// <returns>Link</returns>
        Link PutChangesDocument(PutChangesDocumentRequest request);

        /// <summary>
        /// Accepts or rejects changes to the resultant document and returns a link to saved result
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Comparison.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="comparisonOptions">Comparison options</param>
        /// <returns>ApiResponse of Link</returns>
        ApiResponse<Link> PutChangesDocumentWithHttpInfo (PutChangesDocumentRequest request);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Compares source and target documents and returns a link to saved result
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Comparison.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="comparisonOptions">Comparison options</param>
        /// <returns>Task of Link</returns>
        System.Threading.Tasks.Task<Link> ComparisonsAsync(ComparisonsRequest request);

        /// <summary>
        /// Compares source and target documents and returns a link to saved result
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Comparison.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="comparisonOptions">Comparison options</param>
        /// <returns>Task of ApiResponse (Link)</returns>
        System.Threading.Tasks.Task<ApiResponse<Link>> ComparisonsAsyncWithHttpInfo(ComparisonsRequest request);
        /// <summary>
        /// Retrieves a list of changes between source and target documents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Comparison.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="comparisonOptions">Comparison options</param>
        /// <returns>Task of List&lt;ChangeInfo&gt;</returns>
        System.Threading.Tasks.Task<List<ChangeInfo>> PostChangesAsync(PostChangesRequest request);

        /// <summary>
        /// Retrieves a list of changes between source and target documents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Comparison.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="comparisonOptions">Comparison options</param>
        /// <returns>Task of ApiResponse (List&lt;ChangeInfo&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ChangeInfo>>> PostChangesAsyncWithHttpInfo(PostChangesRequest request);
        /// <summary>
        /// Accepts or rejects changes to the resultant document and returns a link to saved result
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Comparison.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="comparisonOptions">Comparison options</param>
        /// <returns>Task of Link</returns>
        System.Threading.Tasks.Task<Link> PutChangesDocumentAsync(PutChangesDocumentRequest request);

        /// <summary>
        /// Accepts or rejects changes to the resultant document and returns a link to saved result
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Comparison.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="comparisonOptions">Comparison options</param>
        /// <returns>Task of ApiResponse (Link)</returns>
        System.Threading.Tasks.Task<ApiResponse<Link>> PutChangesDocumentAsyncWithHttpInfo(PutChangesDocumentRequest request);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CompareApi : ICompareApi
    {
        private GroupDocs.Comparison.Cloud.Sdk.Client.ExceptionFactoryDelegate _exceptionFactory = GroupDocs.Comparison.Cloud.Sdk.Client.ExceptionFactory.Default;
        private GroupDocs.Comparison.Cloud.Sdk.Client.Configuration _configuration;
        private GroupDocs.Comparison.Cloud.Sdk.Client.ApiClient _apiClient;
        private GroupDocs.Comparison.Cloud.Sdk.Client.IAuthorization _authorization;
        private List<Parameter> _defaultParameters = new List<Parameter>
        {
            new Parameter
            {
                Type = ParameterType.HttpHeader,
                Name = "x-groupdocs-client",
                Value = ".net standard sdk"
            },
            new Parameter
            {
                Type = ParameterType.HttpHeader,
                Name = "x-groupdocs-client-version",
                Value = "19.5"
            }
        };

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
        /// Initializes a new instance of the <see cref="CompareApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CompareApi(Configuration configuration)
        {
            this._configuration = configuration;
            this._apiClient = new ApiClient(configuration, _defaultParameters);
            this._authorization = new Auth(configuration, _defaultParameters);
        }

        /// <summary>
        /// Compares source and target documents and returns a link to saved result 
        /// </summary>
        /// <exception cref="GroupDocs.Comparison.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="comparisonOptions">Comparison options</param>
        /// <returns>Link</returns>
        public Link Comparisons(ComparisonsRequest request)
        {
             ApiResponse<Link> localVarResponse = ComparisonsWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Compares source and target documents and returns a link to saved result 
        /// </summary>
        /// <exception cref="GroupDocs.Comparison.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="comparisonOptions">Comparison options</param>
        /// <returns>ApiResponse of Link</returns>
        public ApiResponse<Link> ComparisonsWithHttpInfo(ComparisonsRequest request)
        {
            // verify the required parameter 'Comparisons.comparisonOptions' is set
            if (request.comparisonOptions == null)
                throw new ApiException(400, "Missing required parameter 'Comparisons.comparisonOptions' when calling CompareApi->Comparisons");

            var localVarPath = "./comparison/comparisons";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = _apiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = _apiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (request.comparisonOptions != null && request.comparisonOptions.GetType() != typeof(byte[]))
            {
                localVarPostBody = _apiClient.Serialize(request.comparisonOptions); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request.comparisonOptions; // byte array
            }
            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) _apiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("Comparisons", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<Link>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (Link) _apiClient.Deserialize(localVarResponse, typeof(Link)));
        }

        /// <summary>
        /// Compares source and target documents and returns a link to saved result 
        /// </summary>
        /// <exception cref="GroupDocs.Comparison.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="comparisonOptions">Comparison options</param>
        /// <returns>Task of Link</returns>
        public async System.Threading.Tasks.Task<Link> ComparisonsAsync(ComparisonsRequest request)
        {
             ApiResponse<Link> localVarResponse = await ComparisonsAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Compares source and target documents and returns a link to saved result 
        /// </summary>
        /// <exception cref="GroupDocs.Comparison.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="comparisonOptions">Comparison options</param>
        /// <returns>Task of ApiResponse (Link)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Link>> ComparisonsAsyncWithHttpInfo(ComparisonsRequest request)
        {
            // verify the required parameter 'Comparisons.comparisonOptions' is set
            if (request.comparisonOptions == null)
                throw new ApiException(400, "Missing required parameter 'Comparisons.comparisonOptions' when calling CompareApi->Comparisons");

            var localVarPath = "./comparison/comparisons";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = _apiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = _apiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (request.comparisonOptions != null && request.comparisonOptions.GetType() != typeof(byte[]))
            {
                localVarPostBody = _apiClient.Serialize(request.comparisonOptions); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request.comparisonOptions; // byte array
            }
            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await _apiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("Comparisons", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<Link>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (Link) _apiClient.Deserialize(localVarResponse, typeof(Link)));
        }

        /// <summary>
        /// Retrieves a list of changes between source and target documents 
        /// </summary>
        /// <exception cref="GroupDocs.Comparison.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="comparisonOptions">Comparison options</param>
        /// <returns>List&lt;ChangeInfo&gt;</returns>
        public List<ChangeInfo> PostChanges(PostChangesRequest request)
        {
             ApiResponse<List<ChangeInfo>> localVarResponse = PostChangesWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves a list of changes between source and target documents 
        /// </summary>
        /// <exception cref="GroupDocs.Comparison.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="comparisonOptions">Comparison options</param>
        /// <returns>ApiResponse of List&lt;ChangeInfo&gt;</returns>
        public ApiResponse<List<ChangeInfo>> PostChangesWithHttpInfo(PostChangesRequest request)
        {
            // verify the required parameter 'PostChanges.comparisonOptions' is set
            if (request.comparisonOptions == null)
                throw new ApiException(400, "Missing required parameter 'PostChanges.comparisonOptions' when calling CompareApi->PostChanges");

            var localVarPath = "./comparison/changes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = _apiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = _apiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (request.comparisonOptions != null && request.comparisonOptions.GetType() != typeof(byte[]))
            {
                localVarPostBody = _apiClient.Serialize(request.comparisonOptions); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request.comparisonOptions; // byte array
            }
            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) _apiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("PostChanges", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<List<ChangeInfo>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (List<ChangeInfo>) _apiClient.Deserialize(localVarResponse, typeof(List<ChangeInfo>)));
        }

        /// <summary>
        /// Retrieves a list of changes between source and target documents 
        /// </summary>
        /// <exception cref="GroupDocs.Comparison.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="comparisonOptions">Comparison options</param>
        /// <returns>Task of List&lt;ChangeInfo&gt;</returns>
        public async System.Threading.Tasks.Task<List<ChangeInfo>> PostChangesAsync(PostChangesRequest request)
        {
             ApiResponse<List<ChangeInfo>> localVarResponse = await PostChangesAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieves a list of changes between source and target documents 
        /// </summary>
        /// <exception cref="GroupDocs.Comparison.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="comparisonOptions">Comparison options</param>
        /// <returns>Task of ApiResponse (List&lt;ChangeInfo&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ChangeInfo>>> PostChangesAsyncWithHttpInfo(PostChangesRequest request)
        {
            // verify the required parameter 'PostChanges.comparisonOptions' is set
            if (request.comparisonOptions == null)
                throw new ApiException(400, "Missing required parameter 'PostChanges.comparisonOptions' when calling CompareApi->PostChanges");

            var localVarPath = "./comparison/changes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = _apiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = _apiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (request.comparisonOptions != null && request.comparisonOptions.GetType() != typeof(byte[]))
            {
                localVarPostBody = _apiClient.Serialize(request.comparisonOptions); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request.comparisonOptions; // byte array
            }
            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await _apiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("PostChanges", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<List<ChangeInfo>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (List<ChangeInfo>) _apiClient.Deserialize(localVarResponse, typeof(List<ChangeInfo>)));
        }

        /// <summary>
        /// Accepts or rejects changes to the resultant document and returns a link to saved result 
        /// </summary>
        /// <exception cref="GroupDocs.Comparison.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="comparisonOptions">Comparison options</param>
        /// <returns>Link</returns>
        public Link PutChangesDocument(PutChangesDocumentRequest request)
        {
             ApiResponse<Link> localVarResponse = PutChangesDocumentWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Accepts or rejects changes to the resultant document and returns a link to saved result 
        /// </summary>
        /// <exception cref="GroupDocs.Comparison.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="comparisonOptions">Comparison options</param>
        /// <returns>ApiResponse of Link</returns>
        public ApiResponse<Link> PutChangesDocumentWithHttpInfo(PutChangesDocumentRequest request)
        {
            // verify the required parameter 'PutChangesDocument.comparisonOptions' is set
            if (request.comparisonOptions == null)
                throw new ApiException(400, "Missing required parameter 'PutChangesDocument.comparisonOptions' when calling CompareApi->PutChangesDocument");

            var localVarPath = "./comparison/updates";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = _apiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = _apiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (request.comparisonOptions != null && request.comparisonOptions.GetType() != typeof(byte[]))
            {
                localVarPostBody = _apiClient.Serialize(request.comparisonOptions); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request.comparisonOptions; // byte array
            }
            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) _apiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("PutChangesDocument", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<Link>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (Link) _apiClient.Deserialize(localVarResponse, typeof(Link)));
        }

        /// <summary>
        /// Accepts or rejects changes to the resultant document and returns a link to saved result 
        /// </summary>
        /// <exception cref="GroupDocs.Comparison.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="comparisonOptions">Comparison options</param>
        /// <returns>Task of Link</returns>
        public async System.Threading.Tasks.Task<Link> PutChangesDocumentAsync(PutChangesDocumentRequest request)
        {
             ApiResponse<Link> localVarResponse = await PutChangesDocumentAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Accepts or rejects changes to the resultant document and returns a link to saved result 
        /// </summary>
        /// <exception cref="GroupDocs.Comparison.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="comparisonOptions">Comparison options</param>
        /// <returns>Task of ApiResponse (Link)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Link>> PutChangesDocumentAsyncWithHttpInfo(PutChangesDocumentRequest request)
        {
            // verify the required parameter 'PutChangesDocument.comparisonOptions' is set
            if (request.comparisonOptions == null)
                throw new ApiException(400, "Missing required parameter 'PutChangesDocument.comparisonOptions' when calling CompareApi->PutChangesDocument");

            var localVarPath = "./comparison/updates";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = _apiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = _apiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (request.comparisonOptions != null && request.comparisonOptions.GetType() != typeof(byte[]))
            {
                localVarPostBody = _apiClient.Serialize(request.comparisonOptions); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request.comparisonOptions; // byte array
            }
            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await _apiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("PutChangesDocument", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<Link>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (Link) _apiClient.Deserialize(localVarResponse, typeof(Link)));
        }

    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ComparisonsRequest.cs">
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
          public ComparisonsRequest(Options comparisonOptions)             
          {
              this.comparisonOptions = comparisonOptions;
          }

          /// <summary>
          /// Comparison options
          /// </summary>  
          public Options comparisonOptions { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PostChangesRequest.cs">
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
          public PostChangesRequest(Options comparisonOptions)             
          {
              this.comparisonOptions = comparisonOptions;
          }

          /// <summary>
          /// Comparison options
          /// </summary>  
          public Options comparisonOptions { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PutChangesDocumentRequest.cs">
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
          /// <param name="comparisonOptions">Comparison options</param>
          public PutChangesDocumentRequest(UpdatesOptions comparisonOptions)             
          {
              this.comparisonOptions = comparisonOptions;
          }

          /// <summary>
          /// Comparison options
          /// </summary>  
          public UpdatesOptions comparisonOptions { get; set; }
    }
}
