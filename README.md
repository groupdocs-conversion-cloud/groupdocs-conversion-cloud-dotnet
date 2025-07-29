# GroupDocs.Conversion Cloud SDK for .NET

This repository contains GroupDocs.Conversion Cloud SDK for .NET source code. This SDK has been developed to help you get started with using our document conversion REST API, allowing to seamlessly convert your documents to any format you need. With this single API, you can convert back and forth between over 50 types of documents and images, including all Microsoft Office and OpenDocument file formats, PDF documents, HTML, CAD, raster images and many more.

## How to use the SDK

The complete source code is available in this repository folder, you can either directly use it in your project via NuGet package manager. For more details, please visit our [documentation website](https://docs.groupdocs.cloud/display/conversioncloud/Available+SDKs#AvailableSDKs-.NET).

### Create an account
Creating an account is very simple. Go to Dashboard to create a free account.
We’re using Single Sign On across our websites, therefore, if you already have an account with our services, you can use it to also acccess the [Dashboard](https://dashboard.groupdocs.cloud).

### Create an API client app
Before you can make any requests to GroupDocs Cloud API you need to get a Client Id and a Client Secret. This will will be used to invoke GroupDocs Cloud API. You can get it by creating a new [Application](https://dashboard.groupdocs.cloud/applicationsV).

## Convert document

```csharp
using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Client;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;

namespace ConversionCloudExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // For complete examples and data files, please go to https://github.com/groupdocs-conversion-cloud/groupdocs-conversion-cloud-dotnet-samples
            string MyClientSecret = ""; // Get ClientId and ClientSecret from https://dashboard.groupdocs.cloud
            string MyClientId = ""; // Get ClientId and ClientSecret from https://dashboard.groupdocs.cloud

            var configuration = new Configuration(MyClientId, MyClientSecret);

            // Create necessary API instances
            var apiInstance = new ConvertApi(configuration);

            // Prepare request
            var fileStream = File.Open("myFile.docx", FileMode.Open);
            var request = new ConvertDocumentDirectRequest("pdf", fileStream);

            // Convert to specified format
            var response = apiInstance.ConvertDocumentDirect(request);
            Console.WriteLine("Document converted successfully: " + response.Length);
        }
    }
}

```

## Convert document using cloud storage

```csharp
using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Client;
using GroupDocs.Conversion.Cloud.Sdk.Model;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;

namespace ConversionCloudExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // For complete examples and data files, please go to https://github.com/groupdocs-conversion-cloud/groupdocs-conversion-cloud-dotnet-samples
            string MyClientSecret = ""; // Get ClientId and ClientSecret from https://dashboard.groupdocs.cloud
            string MyClientId = ""; // Get ClientId and ClientSecret from https://dashboard.groupdocs.cloud

            var configuration = new Configuration(MyClientId, MyClientSecret);

            // Create necessary API instances
            var fileApi = new FileApi(configuration);
            var convertApi = new ConvertApi(configuration);

            // Upload file to cloud storage
            var fileStream = File.Open("myFile.docx", FileMode.Open);
            fileApi.UploadFile(new UploadFileRequest("myFile.docx", fileStream));

            // Prepare convert settings
            var settings = new ConvertSettings
            {
                FilePath = "myFile.docx",
                Format = "pdf",
                OutputPath = "converted"
            };

            // Convert to specified format
            convertApi.ConvertDocument(new ConvertDocumentRequest(settings));

            // Download the result

            var response = fileApi.DownloadFile(new DownloadFileRequest("converted/myFile.pdf"));
            Console.WriteLine("Expected response type is Stream: " + response.Length.ToString());
        }
    }
}
```

## Licensing

All GroupDocs.Conversion Cloud SDKs are licensed under [MIT License](LICENSE).

## Resources

+[**Website**](https://www.groupdocs.cloud)
+[**Product Home**](https://products.groupdocs.cloud/conversion)
+[**Documentation**](https://docs.groupdocs.cloud/conversion)
+[**Free Support Forum**](https://forum.groupdocs.cloud/c/conversion)
+[**Blog**](https://blog.groupdocs.cloud/category/conversion)

## Contact Us

Your feedback is very important to us. Please feel free to contact us using our [Support Forums](https://forum.groupdocs.cloud/c/conversion).
