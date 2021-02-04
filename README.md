![](https://img.shields.io/badge/api-v2.0-lightgrey) ![Nuget](https://img.shields.io/nuget/v/GroupDocs.Comparison-Cloud) ![Nuget](https://img.shields.io/nuget/dt/GroupDocs.Comparison-Cloud) [![GitHub license](https://img.shields.io/github/license/groupdocs-comparison-cloud/groupdocs-comparison-cloud-dotnet)](https://github.com/groupdocs-comparison-cloud/groupdocs-comparison-cloud-dotnet/blob/master/LICENSE)

# .NET SDK to Compare Documents in the Cloud

[GroupDocs.Comparison Cloud SDK for .NET](https://products.groupdocs.cloud/comparison/net) wraps GroupDocs.Comparison RESTful APIs so you may integrate **Document Comparison** features in your own apps with zero initial cost.

GroupDocs.Comparison Cloud API allows the developers to build corporate document comparison tools using REST API. Works as a comprehensive solution for all major file formats.

## Document Comparison REST API

- Compare documents.
- Get list of changes.
- Update changes (Accept or Reject changes).
- Get list of document revisions.
- Update document revisions (Accept or Reject revisions).
- Extract metadata & basic information about the source document.
- Obtain all supported comparison formats list.
- Integrated storage API.


Check out the [Developer's Guide](https://docs.groupdocs.cloud/comparison/developer-guide/) to know more about GroupDocs.Comparison REST API.

## Microsoft File Formats

**Microsoft Word:** DOC, DOCX, DOT, DOTX, DOCM, DOTM, RTF\
**Microsoft Excel:** XLS, XLSX, XLSM, XLSB, XLS2003\
**Microsoft PowerPoint:** PPT, PPTX, PPS, PPSX\
**Microsoft Project:** MPP, MPT\
**Microsoft Outlook:** EML, EMLX, MSG\

## Other Formats

**OpenDocument:** ODT, OTT, ODS, ODP, OTP\
**Web:** HTM, HTML, MHTML\
**Fixed Layout:** PDF\
**Image Files:** JPEG, BMP, PNG, GIF\
**Text:** TXT and other text formats with different extensions\
**Others:** DJVU, DICOM, PDF, CSV\

## New Features & Enhancements Version 20.12
- Added the Review API that enables you to work with revisions of the DOCX documents. Now it has the ability to Accept or Reject all changes in a single Word Document.
- Availability of Docker image of [GroupDocs.Comparison Cloud at the Dock Hub](https://hub.docker.com/r/groupdocs/comparison-cloud).


## Get Started with GroupDocs.Comparison Cloud SDK for .NET

First create an account at [GroupDocs for Cloud](https://dashboard.groupdocs.cloud/) and get your application information. Next,  execute `Install-Package GroupDocs.Comparison-Cloud` from Package Manager Console in Visual Studio to fetch & reference the SDK in your project. If you already have the package and wish to upgrade it, please execute `Update-Package GroupDocs.Comparison-Cloud` to get the latest version.

### Dependencies

- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json)

## Get Supported File Formats for Comparison

```csharp
// Get Client Id and Client Secret from https://dashboard.groupdocs.cloud
string MyClientId = "";
string MyClientSecret = "";

// Create instance of the API
var configuration = new Configuration(MyClientId, MyClientSecret);
var api = new InfoApi(configuration);

// Get supported file formats
var response = api.GetSupportedFileFormats();

foreach (var format in response.Formats)
{
	Debug.Print(format.ToString());
}
```

## GroupDocs.Comparison Cloud SDKs in Popular Languages

| .NET | Java | PHP | Python | Ruby | Node.js | Android |
|---|---|---|---|---|---|---|
| [GitHub](https://github.com/groupdocs-comparison-cloud/groupdocs-comparison-cloud-dotnet) | [GitHub](https://github.com/groupdocs-comparison-cloud/groupdocs-comparison-cloud-java) | [GitHub](https://github.com/groupdocs-comparison-cloud/groupdocs-comparison-cloud-php) | [GitHub](https://github.com/groupdocs-comparison-cloud/groupdocs-comparison-cloud-python) | [GitHub](https://github.com/groupdocs-comparison-cloud/groupdocs-comparison-cloud-ruby)  | [GitHub](https://github.com/groupdocs-comparison-cloud/groupdocs-comparison-cloud-node) | [GitHub](https://github.com/groupdocs-comparison-cloud/groupdocs-comparison-cloud-android) |
| [NuGet](https://www.nuget.org/packages/GroupDocs.Comparison-Cloud/) | [Maven](https://repository.groupdocs.cloud/webapp/#/artifacts/browse/tree/General/repo/com/groupdocs/groupdocs-comparison-cloud) | [Composer](https://packagist.org/packages/groupdocscloud/groupdocs-comparison-cloud) | [PIP](https://pypi.org/project/groupdocs-comparison-cloud/) | [GEM](https://rubygems.org/gems/groupdocs_comparison_cloud)  | [NPM](https://www.npmjs.com/package/groupdocs-comparison-cloud) |[Maven](https://repository.groupdocs.cloud/webapp/#/artifacts/browse/tree/General/repo/com/groupdocs/groupdocs-comparison-cloud-android)  |

[Home](https://www.groupdocs.cloud/) | [Product Page](https://products.groupdocs.cloud/comparison/net) | [Documentation](https://docs.groupdocs.cloud/comparison/) | [Live Demo](https://products.groupdocs.app/comparison/total) | [API Reference](https://apireference.groupdocs.cloud/comparison/) | [Code Samples](https://github.com/groupdocs-comparison-cloud/groupdocs-comparison-cloud-dotnet-samples) | [Blog](https://blog.groupdocs.cloud/category/comparison/) | [Free Support](https://forum.groupdocs.cloud/c/comparison) | [Free Trial](https://dashboard.groupdocs.cloud)
