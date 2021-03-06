![Google Analytics API](https://www.google.com/images/icons/product/analytics-32.png)

# Unoffical Google Analytics API v3 Samples for .NET  

## API Description

Views and manages your Google Analytics data.

[Offical Documentation](https://developers.google.com/analytics/)

## Sample Description

These samples show how to access the [Google Analytics API v3](https://developers.google.com/analytics/) with the Offical [Google .Net client library](https://github.com/google/google-api-dotnet-client)

Tutorials to go along with some of these samples can be found on [www.daimto.com](http://www.daimto.com/)

## Developer Documentation

* [Google API client Library for .NET - Get Started](https://developers.google.com/api-client-library/dotnet/get_started)

* [Supported APIs](https://developers.google.com/api-client-library/dotnet/apis/)

### Installation

NuGet package:

Location: [NuGet Google.Apis.analytics.v3](https://www.nuget.org/packages/Google.Apis.analytics.v3)
Install Command: PM>  Install-Package Google.Apis.analytics.v3

```
PM> Install-Package Google.Apis.analytics.v3
```

### Usage

OAuth2
```
var keyFileLocation = @"C:\Users\Daimto\Documents\DaimtoTestEverythingCredentials\Diamto Test Everything Project-29e50502c19b.json";
var user = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
var scopes = new String[] { Google.Apis.analytics.v3.analyticsService.Scope.analyticsReadonly };
var service = GoogleSamplecSharpSample.analyticsv3.Auth.Oauth2Example.GetanalyticsService(keyFileLocation, user, scopes);
```

Public API Key

```
var apiKey = "XXXX";
var servicePublicKey = GoogleSamplecSharpSample.analyticsv3.Auth.ApiKeyExample.GetService(apiKey);
```

Service Account
```
var serviceAccountKeyFileLocation = @"C:\Users\Daimto\Documents\DaimtoTestEverythingCredentials\Diamto Test Everything Project-29e50502c19b.json";
var serviceAccountEmail = "googledrivemirrornas@daimto-tutorials-101.iam.gserviceaccount.com";
var scopes = new String[] { Google.Apis.analytics.v3.analyticsService.Scope.Calendar };            
var serviceAccountService = GoogleSamplecSharpSample.analyticsv3.Auth.ServiceAccountExample.AuthenticateServiceAccount(serviceAccountKeyFileLocation, serviceAccountEmail, scopes);
```
