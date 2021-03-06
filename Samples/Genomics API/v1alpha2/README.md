![Genomics API](http://www.google.com/images/icons/product/search-32.gif)

# Unoffical Genomics API v1alpha2 Samples for .NET  

## API Description

Upload, process, query, and search Genomics data in the cloud.

[Offical Documentation](https://cloud.google.com/genomics)

## Sample Description

These samples show how to access the [Genomics API v1alpha2](https://cloud.google.com/genomics) with the Offical [Google .Net client library](https://github.com/google/google-api-dotnet-client)

Tutorials to go along with some of these samples can be found on [www.daimto.com](http://www.daimto.com/)

## Developer Documentation

* [Google API client Library for .NET - Get Started](https://developers.google.com/api-client-library/dotnet/get_started)

* [Supported APIs](https://developers.google.com/api-client-library/dotnet/apis/)

### Installation

NuGet package:

Location: [NuGet Google.Apis.genomics.v1alpha2](https://www.nuget.org/packages/Google.Apis.genomics.v1alpha2)
Install Command: PM>  Install-Package Google.Apis.genomics.v1alpha2

```
PM> Install-Package Google.Apis.genomics.v1alpha2
```

### Usage

OAuth2
```
var keyFileLocation = @"C:\Users\Daimto\Documents\DaimtoTestEverythingCredentials\Diamto Test Everything Project-29e50502c19b.json";
var user = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
var scopes = new String[] { Google.Apis.genomics.v1alpha2.genomicsService.Scope.genomicsReadonly };
var service = GoogleSamplecSharpSample.genomicsv1alpha2.Auth.Oauth2Example.GetgenomicsService(keyFileLocation, user, scopes);
```

Public API Key

```
var apiKey = "XXXX";
var servicePublicKey = GoogleSamplecSharpSample.genomicsv1alpha2.Auth.ApiKeyExample.GetService(apiKey);
```

Service Account
```
var serviceAccountKeyFileLocation = @"C:\Users\Daimto\Documents\DaimtoTestEverythingCredentials\Diamto Test Everything Project-29e50502c19b.json";
var serviceAccountEmail = "googledrivemirrornas@daimto-tutorials-101.iam.gserviceaccount.com";
var scopes = new String[] { Google.Apis.genomics.v1alpha2.genomicsService.Scope.Calendar };            
var serviceAccountService = GoogleSamplecSharpSample.genomicsv1alpha2.Auth.ServiceAccountExample.AuthenticateServiceAccount(serviceAccountKeyFileLocation, serviceAccountEmail, scopes);
```
