# GroupDocs.Conversion Cloud SDK for .NET
This repository contains GroupDocs.Conversion Cloud SDK for .NET source code. This SDK allows you to work with GroupDocs.Conversion Cloud REST APIs in your .NET applications.

## How to use the SDK?
The complete source code is available in this repository folder, you can either directly use it in your project via NuGet package manager. For more details, please visit our [documentation website](https://docs.groupdocs.cloud/conversion/available-sdks/).

## Dependencies
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json)

## Getting Started

```csharp
using System;
using System.Diagnostics;
using GroupDocs.Conversion.Cloud.Sdk.Api;

namespace Example
{
    public class Example
    {
        public void Main()
        {
            //TODO: Get your AppSID and AppKey at https://dashboard.groupdocs.cloud (free registration is required).
            var appSid = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX";
            var appKey = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";

            var api = new InfoApi(appSid, appKey);

            try
            {
                // Get supported file formats
                var formats = api.GetSupportedConversionTypes(new GetSupportedConversionTypesRequest());

                foreach (var format in formats)
                {
                    Debug.Print(format.SourceFormat);
                }
            }
            catch (Exception e)
            {
                Debug.Print("Something went wrong: " + e.Message);
            }
        }
    }
}
```

## Licensing
All GroupDocs.Conversion Cloud SDKs are licensed under [MIT License](LICENSE).

[Home](https://www.groupdocs.cloud/) | [Product Page](https://products.groupdocs.cloud/conversion/net) | [Docs](https://docs.groupdocs.cloud/conversion/) | [Demo](https://products.groupdocs.app/conversion/family) | [API Reference](https://apireference.groupdocs.cloud/conversion/) | [Examples](https://github.com/groupdocs-conversion-cloud/groupdocs-conversion-cloud-dotnet) | [Blog](https://blog.groupdocs.cloud/category/conversion/) | [Free Support](https://forum.groupdocs.cloud/c/conversion) | [Free Trial](https://purchase.groupdocs.cloud/trial)
