// Copyright 2017 DAIMTO ([Linda Lawton](https://twitter.com/LindaLawtonDK)) :  [www.daimto.com](http://www.daimto.com/)
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
  
    public static class SitemapsSample
    {


        /// <summary>
        /// Deletes a sitemap from this site. 
        /// Documentation https://developers.google.com/webmasters/v3/reference/sitemaps/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Webmasters service.</param>  
        /// <param name="siteUrl">The site's URL, including protocol. For example: http://www.example.com/</param>
        /// <param name="feedpath">The URL of the actual sitemap. For example: http://www.example.com/sitemap.xml</param>
        public static void Delete(WebmastersService service, string siteUrl, string feedpath)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (siteUrl == null)
                    throw new ArgumentNullException(siteUrl);
                if (feedpath == null)
                    throw new ArgumentNullException(feedpath);

                // Make the request.
                 service.Sitemaps.Delete(siteUrl, feedpath).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Sitemaps.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Retrieves information about a specific sitemap. 
        /// Documentation https://developers.google.com/webmasters/v3/reference/sitemaps/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Webmasters service.</param>  
        /// <param name="siteUrl">The site's URL, including protocol. For example: http://www.example.com/</param>
        /// <param name="feedpath">The URL of the actual sitemap. For example: http://www.example.com/sitemap.xml</param>
        /// <returns>WmxSitemapResponse</returns>
        public static WmxSitemap Get(WebmastersService service, string siteUrl, string feedpath)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (siteUrl == null)
                    throw new ArgumentNullException(siteUrl);
                if (feedpath == null)
                    throw new ArgumentNullException(feedpath);

                // Make the request.
                return service.Sitemaps.Get(siteUrl, feedpath).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Sitemaps.Get failed.", ex);
            }
        }
        public class SitemapsListOptionalParms
        {
            /// A URL of a site's sitemap index. For example: http://www.example.com/sitemapindex.xml
            public string SitemapIndex { get; set; }  
        
        }
 
        /// <summary>
        /// Lists the sitemaps-entries submitted for this site, or included in the sitemap index file (if sitemapIndex is specified in the request). 
        /// Documentation https://developers.google.com/webmasters/v3/reference/sitemaps/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Webmasters service.</param>  
        /// <param name="siteUrl">The site's URL, including protocol. For example: http://www.example.com/</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>SitemapsListResponseResponse</returns>
        public static SitemapsListResponse List(WebmastersService service, string siteUrl, SitemapsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (siteUrl == null)
                    throw new ArgumentNullException(siteUrl);

                // Building the initial request.
                var request = service.Sitemaps.List(siteUrl);

                // Applying optional parameters to the request.                
                request = (SitemapsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Sitemaps.List failed.", ex);
            }
        }

        /// <summary>
        /// Submits a sitemap for a site. 
        /// Documentation https://developers.google.com/webmasters/v3/reference/sitemaps/submit
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Webmasters service.</param>  
        /// <param name="siteUrl">The site's URL, including protocol. For example: http://www.example.com/</param>
        /// <param name="feedpath">The URL of the sitemap to add. For example: http://www.example.com/sitemap.xml</param>
        public static void Submit(WebmastersService service, string siteUrl, string feedpath)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (siteUrl == null)
                    throw new ArgumentNullException(siteUrl);
                if (feedpath == null)
                    throw new ArgumentNullException(feedpath);

                // Make the request.
                 service.Sitemaps.Submit(siteUrl, feedpath).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Sitemaps.Submit failed.", ex);
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