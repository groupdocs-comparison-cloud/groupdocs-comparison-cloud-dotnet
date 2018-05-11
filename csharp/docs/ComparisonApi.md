# GroupDocs.Comparison.Cloud.Sdk.Api.ComparisonApi

All URIs are relative to *https://api.groupdocs.cloud/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Comparison**](ComparisonApi.md#comparison) | **POST** /comparison/compareDocuments | Returns document with the result of comparison
[**ComparisonImages**](ComparisonApi.md#comparisonimages) | **POST** /comparison/compareDocuments/images | Returns images of document with the result of comparison
[**ComparisonImagesStream**](ComparisonApi.md#comparisonimagesstream) | **POST** /comparison/compareDocuments/stream/images | Returns image&#39;s streams of document with the result of comparison
[**ComparisonStream**](ComparisonApi.md#comparisonstream) | **POST** /comparison/compareDocuments/stream | Returns stream of document with the result of comparison


<a name="comparison"></a>
# **Comparison**
> Link Comparison (ComparisonRequest request = null, string outPath = null)

Returns document with the result of comparison

### Example
```csharp
using System;
using System.Diagnostics;
using GroupDocs.Comparison.Cloud.Sdk.Api;
using GroupDocs.Comparison.Cloud.Sdk.Client;
using GroupDocs.Comparison.Cloud.Sdk.Model;

namespace Example
{
    public class ComparisonExample
    {
        public void main()
        {
            var apiInstance = new ComparisonApi();
            var request = new ComparisonRequest(); // ComparisonRequest | The request. (optional) 
            var outPath = outPath_example;  // string | outPath: path to output document on file storage (optional) 

            try
            {
                // Returns document with the result of comparison
                Link result = apiInstance.Comparison(request, outPath);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ComparisonApi.Comparison: " + e.Message );
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

<a name="comparisonimages"></a>
# **ComparisonImages**
> List<Link> ComparisonImages (ComparisonRequest request = null, string outFolder = null)

Returns images of document with the result of comparison

### Example
```csharp
using System;
using System.Diagnostics;
using GroupDocs.Comparison.Cloud.Sdk.Api;
using GroupDocs.Comparison.Cloud.Sdk.Client;
using GroupDocs.Comparison.Cloud.Sdk.Model;

namespace Example
{
    public class ComparisonImagesExample
    {
        public void main()
        {
            var apiInstance = new ComparisonApi();
            var request = new ComparisonRequest(); // ComparisonRequest | The request. (optional) 
            var outFolder = outFolder_example;  // string | outFolder: path to output folder on file storage (optional) 

            try
            {
                // Returns images of document with the result of comparison
                List&lt;Link&gt; result = apiInstance.ComparisonImages(request, outFolder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ComparisonApi.ComparisonImages: " + e.Message );
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

<a name="comparisonimagesstream"></a>
# **ComparisonImagesStream**
> System.IO.Stream ComparisonImagesStream (ComparisonRequest request = null)

Returns image's streams of document with the result of comparison

### Example
```csharp
using System;
using System.Diagnostics;
using GroupDocs.Comparison.Cloud.Sdk.Api;
using GroupDocs.Comparison.Cloud.Sdk.Client;
using GroupDocs.Comparison.Cloud.Sdk.Model;

namespace Example
{
    public class ComparisonImagesStreamExample
    {
        public void main()
        {
            var apiInstance = new ComparisonApi();
            var request = new ComparisonRequest(); // ComparisonRequest | The request. (optional) 

            try
            {
                // Returns image's streams of document with the result of comparison
                System.IO.Stream result = apiInstance.ComparisonImagesStream(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ComparisonApi.ComparisonImagesStream: " + e.Message );
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

<a name="comparisonstream"></a>
# **ComparisonStream**
> System.IO.Stream ComparisonStream (ComparisonRequest request = null)

Returns stream of document with the result of comparison

### Example
```csharp
using System;
using System.Diagnostics;
using GroupDocs.Comparison.Cloud.Sdk.Api;
using GroupDocs.Comparison.Cloud.Sdk.Client;
using GroupDocs.Comparison.Cloud.Sdk.Model;

namespace Example
{
    public class ComparisonStreamExample
    {
        public void main()
        {
            var apiInstance = new ComparisonApi();
            var request = new ComparisonRequest(); // ComparisonRequest | The request. (optional) 

            try
            {
                // Returns stream of document with the result of comparison
                System.IO.Stream result = apiInstance.ComparisonStream(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ComparisonApi.ComparisonStream: " + e.Message );
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

