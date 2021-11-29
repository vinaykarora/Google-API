﻿// Copyright 2017 DAIMTO ([Linda Lawton](https://twitter.com/LindaLawtonDK)) :  [www.daimto.com](http://www.daimto.com/)
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by DAIMTO-Google-apis-Sample-generator 1.0.0
//     Template File Name:  methodTemplate.tt
//     Build date: 2017-10-08
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------  
// About 
// 
// Unoffical sample for the Webmasters v3 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: View Google Search Console data for your verified sites.
// API Documentation Link https://developers.google.com/webmaster-tools/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Webmasters/v3/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Webmasters.v3/ 
// Install Command: PM>  Install-Package Google.Apis.Webmasters.v3
//
//------------------------------------------------------------------------------  
using Google.Apis.Webmasters.v3;
using Google.Apis.Webmasters.v3.Data;
using System;

namespace GoogleSamplecSharpSample.Webmastersv3.Methods
{
  
    public static class UrlcrawlerrorssamplesSample
    {


        /// <summary>
        /// Retrieves details about crawl errors for a site's sample URL. 
        /// Documentation https://developers.google.com/webmasters/v3/reference/urlcrawlerrorssamples/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Webmasters service.</param>  
        /// <param name="siteUrl">The site's URL, including protocol. For example: http://www.example.com/</param>
        /// <param name="url">The relative path (without the site) of the sample URL. It must be one of the URLs returned by list(). For example, for the URL https://www.example.com/pagename on the site https://www.example.com/, the url value is pagename</param>
        /// <param name="category">The crawl error category. For example: authPermissions</param>
        /// <param name="platform">The user agent type (platform) that made the request. For example: web</param>
        /// <returns>UrlCrawlErrorsSampleResponse</returns>
        public static UrlCrawlErrorsSample Get(WebmastersService service, string siteUrl, string url, string category, string platform)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (siteUrl == null)
                    throw new ArgumentNullException(siteUrl);
                if (url == null)
                    throw new ArgumentNullException(url);
                if (category == null)
                    throw new ArgumentNullException(category);
                if (platform == null)
                    throw new ArgumentNullException(platform);

                // Make the request.
                return service.Urlcrawlerrorssamples.Get(siteUrl, url, category, platform).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Urlcrawlerrorssamples.Get failed.", ex);
            }
        }

        /// <summary>
        /// Lists a site's sample URLs for the specified crawl error category and platform. 
        /// Documentation https://developers.google.com/webmasters/v3/reference/urlcrawlerrorssamples/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Webmasters service.</param>  
        /// <param name="siteUrl">The site's URL, including protocol. For example: http://www.example.com/</param>
        /// <param name="category">The crawl error category. For example: authPermissions</param>
        /// <param name="platform">The user agent type (platform) that made the request. For example: web</param>
        /// <returns>UrlCrawlErrorsSamplesListResponseResponse</returns>
        public static UrlCrawlErrorsSamplesListResponse List(WebmastersService service, string siteUrl, string category, string platform)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (siteUrl == null)
                    throw new ArgumentNullException(siteUrl);
                if (category == null)
                    throw new ArgumentNullException(category);
                if (platform == null)
                    throw new ArgumentNullException(platform);

                // Make the request.
                return service.Urlcrawlerrorssamples.List(siteUrl, category, platform).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Urlcrawlerrorssamples.List failed.", ex);
            }
        }

        /// <summary>
        /// Marks the provided site's sample URL as fixed, and removes it from the samples list. 
        /// Documentation https://developers.google.com/webmasters/v3/reference/urlcrawlerrorssamples/markAsFixed
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Webmasters service.</param>  
        /// <param name="siteUrl">The site's URL, including protocol. For example: http://www.example.com/</param>
        /// <param name="url">The relative path (without the site) of the sample URL. It must be one of the URLs returned by list(). For example, for the URL https://www.example.com/pagename on the site https://www.example.com/, the url value is pagename</param>
        /// <param name="category">The crawl error category. For example: authPermissions</param>
        /// <param name="platform">The user agent type (platform) that made the request. For example: web</param>
        public static void MarkAsFixed(WebmastersService service, string siteUrl, string url, string category, string platform)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (siteUrl == null)
                    throw new ArgumentNullException(siteUrl);
                if (url == null)
                    throw new ArgumentNullException(url);
                if (category == null)
                    throw new ArgumentNullException(category);
                if (platform == null)
                    throw new ArgumentNullException(platform);

                // Make the request.
                 service.Urlcrawlerrorssamples.MarkAsFixed(siteUrl, url, category, platform).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Urlcrawlerrorssamples.MarkAsFixed failed.", ex);
            }
        }
        
        }

        public static class SampleHelpers
        {

        /// <summary>
        /// Using reflection to apply optional parameters to the request.  
        /// 
        /// If the optonal parameters are null then we will just return the request as is.
        /// </summary>
        /// <param name="request">The request. </param>
        /// <param name="optional">The optional parameters. </param>
        /// <returns></returns>
        public static object ApplyOptionalParms(object request, object optional)
        {
            if (optional == null)
                return request;

            System.Reflection.PropertyInfo[] optionalProperties = (optional.GetType()).GetProperties();

            foreach (System.Reflection.PropertyInfo property in optionalProperties)
            {
                // Copy value from optional parms to the request.  They should have the same names and datatypes.
                System.Reflection.PropertyInfo piShared = (request.GetType()).GetProperty(property.Name);
				if (property.GetValue(optional, null) != null) // TODO Test that we do not add values for items that are null
					piShared.SetValue(request, property.GetValue(optional, null), null);
            }

            return request;
        }
    }
}