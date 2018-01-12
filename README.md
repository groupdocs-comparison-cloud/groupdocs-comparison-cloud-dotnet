# GroupDocs.Comparison Cloud SDK for .NET
This repository contains GroupDocs.Comparison Cloud SDK for .NET source code. This SDK allows you to work with GroupDocs.Comparison Cloud REST APIs in your .NET applications quickly and easily.

## How to use the SDK?
The complete source code is available in this repository folder, you can either directly use it in your project via NuGet package manager. For more details, please visit our [documentation website](https://docs.groupdocs.cloud/display/comparisoncloud/Available+SDKs#AvailableSDKs-.NET).

## Dependencies
- .NET Framework 2.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json)
- [StyleCop.MSBuild](https://www.nuget.org/packages/StyleCop.MSBuild)

NOTE: The DLLs included in the package may not be the latest version. We recommned using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package Newtonsoft.Json
Install-Package StyleCop.MSBuild
``` 

## Getting Started

```csharp
using System;
using System.Diagnostics;
using GroupDocs.Comparison.Cloud.Sdk.Api;
using GroupDocs.Comparison.Cloud.Sdk.Client;
using GroupDocs.Comparison.Cloud.Sdk.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            //TODO: Get your AppSID and AppKey at https://dashboard.groupdocs.cloud (free registration is required).
            var configuration = new Configuration
            {
                AppSid = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX",
                AppKey = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
            };
            
            var apiInstance = new ChangesApi();
            var request = new ComparisonRequest(); // ComparisonRequest | The request. (optional) 
            var categoriesType = categoriesType_example;  // string | Type of the categories. (optional) 

            try
            {
                // Posts the categories changes.
                List<ComparisonChangesCategoryDto> result = apiInstance.PostCategoriesChanges(request, categoriesType);
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
# Licensing
All GroupDocs.Comparison for Cloud SDKs are licensed under [MIT License](LICENSE).

# Resources
+ [**Website**](https://www.groupdocs.cloud)
+ [**Product Home**](https://products.groupdocs.cloud/comparison/cloud)
+ [**Documentation**](https://docs.groupdocs.cloud/display/comparisoncloud/Home)
+ [**Free Support Forum**](https://forum.groupdocs.cloud/c/comparison)
+ [**Blog**](https://blog.groupdocs.cloud/category/groupdocs-comparison-cloud-product-family/)
	     

## Contact Us
Your feedback is very important to us. Please feel free to contact us using our [Support Forums](https://forum.groupdocs.cloud/c/comparison).
