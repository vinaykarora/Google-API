![DoubleClick Search API](https://www.gstatic.com/images/branding/product/1x/googleg_32dp.png)

# Unoffical DoubleClick Search API v2 Samples for .NET  

## API Description

Reports and modifies your advertising data in DoubleClick Search (for example, campaigns, ad groups, keywords, and conversions).

[Offical Documentation](https://developers.google.com/doubleclick-search/)

## Sample Description

These samples show how to access the [DoubleClick Search API v2](https://developers.google.com/doubleclick-search/) with the Offical [Google .Net client library](https://github.com/google/google-api-dotnet-client)

Tutorials to go along with some of these samples can be found on [www.daimto.com](http://www.daimto.com/)

## Developer Documentation

* [Google API client Library for .NET - Get Started](https://developers.google.com/api-client-library/dotnet/get_started)

* [Supported APIs](https://developers.google.com/api-client-library/dotnet/apis/)

### Installation

NuGet package:

Location: [NuGet Google.Apis.doubleclicksearch.v2](https://www.nuget.org/packages/Google.Apis.doubleclicksearch.v2)
Install Command: PM>  Install-Package Google.Apis.doubleclicksearch.v2

```
PM> Install-Package Google.Apis.doubleclicksearch.v2
```

### Usage

OAuth2
```
var keyFileLocation = @"C:\Users\Daimto\Documents\DaimtoTestEverythingCredentials\Diamto Test Everything Project-29e50502c19b.json";
var user = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
var scopes = new String[] { Google.Apis.doubleclicksearch.v2.doubleclicksearchService.Scope.doubleclicksearchReadonly };
var service = GoogleSamplecSharpSample.doubleclicksearchv2.Auth.Oauth2Example.GetdoubleclicksearchService(keyFileLocation, user, scopes);
```

Public API Key

```
var apiKey = "XXXX";
var servicePublicKey = GoogleSamplecSharpSample.doubleclicksearchv2.Auth.ApiKeyExample.GetService(apiKey);
```

Service Account
```
var serviceAccountKeyFileLocation = @"C:\Users\Daimto\Documents\DaimtoTestEverythingCredentials\Diamto Test Everything Project-29e50502c19b.json";
var serviceAccountEmail = "googledrivemirrornas@daimto-tutorials-101.iam.gserviceaccount.com";
var scopes = new String[] { Google.Apis.doubleclicksearch.v2.doubleclicksearchService.Scope.Calendar };            
var serviceAccountService = GoogleSamplecSharpSample.doubleclicksearchv2.Auth.ServiceAccountExample.AuthenticateServiceAccount(serviceAccountKeyFileLocation, serviceAccountEmail, scopes);
```
