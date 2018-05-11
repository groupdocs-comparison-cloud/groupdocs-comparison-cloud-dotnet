# GroupDocs.Comparison.Cloud.Sdk.Api.ChangesApi

All URIs are relative to *https://api.groupdocs.cloud/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostCategoriesChanges**](ChangesApi.md#postcategorieschanges) | **POST** /comparison/compareDocuments/changes/categories | Posts the categories changes.
[**PostChanges**](ChangesApi.md#postchanges) | **POST** /comparison/compareDocuments/changes | Returns json result with set of changes between documents
[**PutChangesDocument**](ChangesApi.md#putchangesdocument) | **PUT** /comparison/compareDocuments/changes/update | Applies changes to the document and returns document with the result of comparison
[**PutChangesDocumentStream**](ChangesApi.md#putchangesdocumentstream) | **PUT** /comparison/compareDocuments/changes/stream | Applies changes to the document and returns stream of document with the result of comparison
[**PutChangesImages**](ChangesApi.md#putchangesimages) | **PUT** /comparison/compareDocuments/changes/images | Applies changes to the document and returns images of document with the result of comparison
[**PutChangesImagesStream**](ChangesApi.md#putchangesimagesstream) | **PUT** /comparison/compareDocuments/changes/stream/images | Applies changes to the document and returns image&#39;s streams of document with the result of comparison


<a name="postcategorieschanges"></a>
# **PostCategoriesChanges**
> List<ComparisonChangesCategoryDto> PostCategoriesChanges (ComparisonRequest request = null, string categoriesType = null)

Posts the categories changes.

### Example
```csharp
using System;
using System.Diagnostics;
using GroupDocs.Comparison.Cloud.Sdk.Api;
using GroupDocs.Comparison.Cloud.Sdk.Client;
using GroupDocs.Comparison.Cloud.Sdk.Model;

namespace Example
{
    public class PostCategoriesChangesExample
    {
        public void main()
        {
            var apiInstance = new ChangesApi();
            var request = new ComparisonRequest(); // ComparisonRequest | The request. (optional) 
            var categoriesType = categoriesType_example;  // string | Type of the categories. (optional) 

            try
            {
                // Posts the categories changes.
                List&lt;ComparisonChangesCategoryDto&gt; result = apiInstance.PostCategoriesChanges(request, categoriesType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChangesApi.PostCategoriesChanges: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ComparisonRequest**](ComparisonRequest.md)| The request. | [optional] 
 **categoriesType** | **string**| Type of the categories. | [optional] 

### Return type

[**List<ComparisonChangesCategoryDto>**](ComparisonChangesCategoryDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postchanges"></a>
# **PostChanges**
> List<ComparisonChange> PostChanges (ComparisonRequest request = null)

Returns json result with set of changes between documents

### Example
```csharp
using System;
using System.Diagnostics;
using GroupDocs.Comparison.Cloud.Sdk.Api;
using GroupDocs.Comparison.Cloud.Sdk.Client;
using GroupDocs.Comparison.Cloud.Sdk.Model;

namespace Example
{
    public class PostChangesExample
    {
        public void main()
        {
            var apiInstance = new ChangesApi();
            var request = new ComparisonRequest(); // ComparisonRequest | The request. (optional) 

            try
            {
                // Returns json result with set of changes between documents
                List&lt;ComparisonChange&gt; result = apiInstance.PostChanges(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChangesApi.PostChanges: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ComparisonRequest**](ComparisonRequest.md)| The request. | [optional] 

### Return type

[**List<ComparisonChange>**](ComparisonChange.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putchangesdocument"></a>
# **PutChangesDocument**
> Link PutChangesDocument (ComparisonRequest request = null, string outPath = null)

Applies changes to the document and returns document with the result of comparison

### Example
```csharp
using System;
using System.Diagnostics;
using GroupDocs.Comparison.Cloud.Sdk.Api;
using GroupDocs.Comparison.Cloud.Sdk.Client;
using GroupDocs.Comparison.Cloud.Sdk.Model;

namespace Example
{
    public class PutChangesDocumentExample
    {
        public void main()
        {
            var apiInstance = new ChangesApi();
            var request = new ComparisonRequest(); // ComparisonRequest | The request. (optional) 
            var outPath = outPath_example;  // string | outPath: path to output document on file storage (optional) 

            try
            {
                // Applies changes to the document and returns document with the result of comparison
                Link result = apiInstance.PutChangesDocument(request, outPath);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChangesApi.PutChangesDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ComparisonRequest**](ComparisonRequest.md)| The request. | [optional] 
 **outPath** | **string**| outPath: path to output document on file storage | [optional] 

### Return type

[**Link**](Link.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putchangesdocumentstream"></a>
# **PutChangesDocumentStream**
> System.IO.Stream PutChangesDocumentStream (ComparisonRequest request = null)

Applies changes to the document and returns stream of document with the result of comparison

### Example
```csharp
using System;
using System.Diagnostics;
using GroupDocs.Comparison.Cloud.Sdk.Api;
using GroupDocs.Comparison.Cloud.Sdk.Client;
using GroupDocs.Comparison.Cloud.Sdk.Model;

namespace Example
{
    public class PutChangesDocumentStreamExample
    {
        public void main()
        {
            var apiInstance = new ChangesApi();
            var request = new ComparisonRequest(); // ComparisonRequest | The request. (optional) 

            try
            {
                // Applies changes to the document and returns stream of document with the result of comparison
                System.IO.Stream result = apiInstance.PutChangesDocumentStream(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChangesApi.PutChangesDocumentStream: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ComparisonRequest**](ComparisonRequest.md)| The request. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putchangesimages"></a>
# **PutChangesImages**
> List<Link> PutChangesImages (ComparisonRequest request = null, string outFolder = null)

Applies changes to the document and returns images of document with the result of comparison

### Example
```csharp
using System;
using System.Diagnostics;
using GroupDocs.Comparison.Cloud.Sdk.Api;
using GroupDocs.Comparison.Cloud.Sdk.Client;
using GroupDocs.Comparison.Cloud.Sdk.Model;

namespace Example
{
    public class PutChangesImagesExample
    {
        public void main()
        {
            var apiInstance = new ChangesApi();
            var request = new ComparisonRequest(); // ComparisonRequest | The request. (optional) 
            var outFolder = outFolder_example;  // string | outFolder: path to output folder on file storage (optional) 

            try
            {
                // Applies changes to the document and returns images of document with the result of comparison
                List&lt;Link&gt; result = apiInstance.PutChangesImages(request, outFolder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChangesApi.PutChangesImages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ComparisonRequest**](ComparisonRequest.md)| The request. | [optional] 
 **outFolder** | **string**| outFolder: path to output folder on file storage | [optional] 

### Return type

[**List<Link>**](Link.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putchangesimagesstream"></a>
# **PutChangesImagesStream**
> System.IO.Stream PutChangesImagesStream (ComparisonRequest request = null)

Applies changes to the document and returns image's streams of document with the result of comparison

### Example
```csharp
using System;
using System.Diagnostics;
using GroupDocs.Comparison.Cloud.Sdk.Api;
using GroupDocs.Comparison.Cloud.Sdk.Client;
using GroupDocs.Comparison.Cloud.Sdk.Model;

namespace Example
{
    public class PutChangesImagesStreamExample
    {
        public void main()
        {
            var apiInstance = new ChangesApi();
            var request = new ComparisonRequest(); // ComparisonRequest | The request. (optional) 

            try
            {
                // Applies changes to the document and returns image's streams of document with the result of comparison
                System.IO.Stream result = apiInstance.PutChangesImagesStream(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChangesApi.PutChangesImagesStream: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ComparisonRequest**](ComparisonRequest.md)| The request. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

