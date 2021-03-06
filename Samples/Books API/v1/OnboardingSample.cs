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
// Unoffical sample for the Books v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Searches for books and manages your Google Books library.
// API Documentation Link https://developers.google.com/books/docs/v1/getting_started
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Books/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Books.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Books.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Books.v1;
using Google.Apis.Books.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Booksv1.Methods
{
  
    public static class OnboardingSample
    {

        public class OnboardingListCategoriesOptionalParms
        {
            /// ISO-639-1 language and ISO-3166-1 country code. Default is en-US if unset.
            public string Locale { get; set; }  
        
        }
 
        /// <summary>
        /// List categories for onboarding experience. 
        /// Documentation https://developers.google.com/books/v1/reference/onboarding/listCategories
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Books service.</param>  
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>CategoryResponse</returns>
        public static Category ListCategories(BooksService service, OnboardingListCategoriesOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.Onboarding.ListCategories();

                // Applying optional parameters to the request.                
                request = (OnboardingResource.ListCategoriesRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Onboarding.ListCategories failed.", ex);
            }
        }
        public class OnboardingListCategoryVolumesOptionalParms
        {
            /// List of category ids requested.
            public string CategoryId { get; set; }  
            /// ISO-639-1 language and ISO-3166-1 country code. Default is en-US if unset.
            public string Locale { get; set; }  
            /// The maximum allowed maturity rating of returned volumes. Books with a higher maturity rating are filtered out.
            public string MaxAllowedMaturityRating { get; set; }  
            /// Number of maximum results per page to be included in the response.
            public int? PageSize { get; set; }  
            /// The value of the nextToken from the previous page.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// List available volumes under categories for onboarding experience. 
        /// Documentation https://developers.google.com/books/v1/reference/onboarding/listCategoryVolumes
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Books service.</param>  
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>Volume2Response</returns>
        public static Volume2 ListCategoryVolumes(BooksService service, OnboardingListCategoryVolumesOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.Onboarding.ListCategoryVolumes();

                // Applying optional parameters to the request.                
                request = (OnboardingResource.ListCategoryVolumesRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Onboarding.ListCategoryVolumes failed.", ex);
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