// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="InfoApi.cs">
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
    public interface IInfoApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieves supported file formats list 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Comparison.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>FormatsResult</returns>
        FormatsResult GetSupportedFileFormats();

        /// <summary>
        /// Retrieves supported file formats list 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Comparison.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of FormatsResult</returns>
        ApiResponse<FormatsResult> GetSupportedFileFormatsWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Retrieves supported file formats list 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Comparison.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of FormatsResult</returns>
        System.Threading.Tasks.Task<FormatsResult> GetSupportedFileFormatsAsync();

        /// <summary>
        /// Retrieves supported file formats list 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Comparison.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (FormatsResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<FormatsResult>> GetSupportedFileFormatsAsyncWithHttpInfo();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class InfoApi : IInfoApi
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
        /// Initializes a new instance of the <see cref="InfoApi"/> class.
        /// </summary>
        /// <param name="appSid">Application identifier (App SID)</param>
        /// <param name="appKey">Application private key (App Key)</param>
        public InfoApi(string appSid, string appKey)
            : this(new Configuration(appSid, appKey))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public InfoApi(Configuration configuration)
        {
            this._configuration = configuration;
            this._apiClient = new ApiClient(configuration, _defaultParameters);
            this._authorization = new Auth(configuration, _defaultParameters);
        }

        /// <summary>
        /// Retrieves supported file formats list  
        /// </summary>
        /// <exception cref="GroupDocs.Comparison.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>FormatsResult</returns>
        public FormatsResult GetSupportedFileFormats()
        {
             ApiResponse<FormatsResult> localVarResponse = GetSupportedFileFormatsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves supported file formats list  
        /// </summary>
        /// <exception cref="GroupDocs.Comparison.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of FormatsResult</returns>
        public ApiResponse<FormatsResult> GetSupportedFileFormatsWithHttpInfo()
        {

            var localVarPath = "./comparison/formats";
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

            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) _apiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("GetSupportedFileFormats", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<FormatsResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (FormatsResult) _apiClient.Deserialize(localVarResponse, typeof(FormatsResult)));
        }

        /// <summary>
        /// Retrieves supported file formats list  
        /// </summary>
        /// <exception cref="GroupDocs.Comparison.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of FormatsResult</returns>
        public async System.Threading.Tasks.Task<FormatsResult> GetSupportedFileFormatsAsync()
        {
             ApiResponse<FormatsResult> localVarResponse = await GetSupportedFileFormatsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieves supported file formats list  
        /// </summary>
        /// <exception cref="GroupDocs.Comparison.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (FormatsResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FormatsResult>> GetSupportedFileFormatsAsyncWithHttpInfo()
        {

            var localVarPath = "./comparison/formats";
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

            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await _apiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("GetSupportedFileFormats", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<FormatsResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (FormatsResult) _apiClient.Deserialize(localVarResponse, typeof(FormatsResult)));
        }

    }
}
