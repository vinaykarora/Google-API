![Google Play Developer API](https://www.google.com/images/icons/product/android-32.png)

# Unoffical Google Play Developer API v2 Samples for .NET  

## API Description

Lets Android application developers access their Google Play accounts.

[Offical Documentation](https://developers.google.com/android-publisher)

## Sample Description

These samples show how to access the [Google Play Developer API v2](https://developers.google.com/android-publisher) with the Offical [Google .Net client library](https://github.com/google/google-api-dotnet-client)

Tutorials to go along with some of these samples can be found on [www.daimto.com](http://www.daimto.com/)

## Developer Documentation

* [Google API client Library for .NET - Get Started](https://developers.google.com/api-client-library/dotnet/get_started)

* [Supported APIs](https://developers.google.com/api-client-library/dotnet/apis/)

### Installation

NuGet package:

Location: [NuGet Google.Apis.AndroidPublisher.v2](https://www.nuget.org/packages/Google.Apis.AndroidPublisher.v2)
Install Command: PM>  Install-Package Google.Apis.AndroidPublisher.v2

```
PM> Install-Package Google.Apis.AndroidPublisher.v2
```

### Usage

OAuth2
```
var keyFileLocation = @"C:\Users\Daimto\Documents\DaimtoTestEverythingCredentials\Diamto Test Everything Project-29e50502c19b.json";
var user = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
var scopes = new String[] { Google.Apis.AndroidPublisher.v2.AndroidPublisherService.Scope.AndroidPublisherReadonly };
var service = GoogleSamplecSharpSample.AndroidPublisherv2.Auth.Oauth2Example.GetAndroidPublisherService(keyFileLocation, user, scopes);
```

Public API Key

```
var apiKey = "XXXX";
var servicePublicKey = GoogleSamplecSharpSample.AndroidPublisherv2.Auth.ApiKeyExample.GetService(apiKey);
```

Service Account
```
var serviceAccountKeyFileLocation = @"C:\Users\Daimto\Documents\DaimtoTestEverythingCredentials\Diamto Test Everything Project-29e50502c19b.json";
var serviceAccountEmail = "googledrivemirrornas@daimto-tutorials-101.iam.gserviceaccount.com";
var scopes = new String[] { Google.Apis.AndroidPublisher.v2.AndroidPublisherService.Scope.Calendar };            
var serviceAccountService = GoogleSamplecSharpSample.AndroidPublisherv2.Auth.ServiceAccountExample.AuthenticateServiceAccount(serviceAccountKeyFileLocation, serviceAccountEmail, scopes);
```
