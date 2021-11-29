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
// Unoffical sample for the Plusdomains v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Builds on top of the Google+ platform for Google Apps Domains.
// API Documentation Link https://developers.google.com/+/domains/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Plusdomains/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Plusdomains.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Plusdomains.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Plusdomains.v1;
using Google.Apis.Plusdomains.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Plusdomainsv1.Methods
{
  
    public static class PeopleSample
    {


        /// <summary>
        /// Get a person's profile. 
        /// Documentation https://developers.google.com/plusdomains/v1/reference/people/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Plusdomains service.</param>  
        /// <param name="userId">The ID of the person to get the profile for. The special value "me" can be used to indicate the authenticated user.</param>
        /// <returns>PersonResponse</returns>
        public static Person Get(PlusdomainsService service, string userId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (userId == null)
                    throw new ArgumentNullException(userId);

                // Make the request.
                return service.People.Get(userId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request People.Get failed.", ex);
            }
        }
        public class PeopleListOptionalParms
        {
            /// The maximum number of people to include in the response, which is used for paging. For any response, the actual number returned might be less than the specified maxResults.
            public int? MaxResults { get; set; }  
            /// The order to return people in.
            public string OrderBy { get; set; }  
            /// The continuation token, which is used to page through large result sets. To get the next page of results, set this parameter to the value of "nextPageToken" from the previous response.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// List all of the people in the specified collection. 
        /// Documentation https://developers.google.com/plusdomains/v1/reference/people/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Plusdomains service.</param>  
        /// <param name="userId">Get the collection of people for the person identified. Use "me" to indicate the authenticated user.</param>
        /// <param name="collection">The collection of people to list.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>PeopleFeedResponse</returns>
        public static PeopleFeed List(PlusdomainsService service, string userId, string collection, PeopleListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (userId == null)
                    throw new ArgumentNullException(userId);
                if (collection == null)
                    throw new ArgumentNullException(collection);

                // Building the initial request.
                var request = service.People.List(userId, collection);

                // Applying optional parameters to the request.                
                request = (PeopleResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request People.List failed.", ex);
            }
        }
        public class PeopleListByActivityOptionalParms
        {
            /// The maximum number of people to include in the response, which is used for paging. For any response, the actual number returned might be less than the specified maxResults.
            public int? MaxResults { get; set; }  
            /// The continuation token, which is used to page through large result sets. To get the next page of results, set this parameter to the value of "nextPageToken" from the previous response.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// List all of the people in the specified collection for a particular activity. 
        /// Documentation https://developers.google.com/plusdomains/v1/reference/people/listByActivity
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Plusdomains service.</param>  
        /// <param name="activityId">The ID of the activity to get the list of people for.</param>
        /// <param name="collection">The collection of people to list.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>PeopleFeedResponse</returns>
        public static PeopleFeed ListByActivity(PlusdomainsService service, string activityId, string collection, PeopleListByActivityOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (activityId == null)
                    throw new ArgumentNullException(activityId);
                if (collection == null)
                    throw new ArgumentNullException(collection);

                // Building the initial request.
                var request = service.People.ListByActivity(activityId, collection);

                // Applying optional parameters to the request.                
                request = (PeopleResource.ListByActivityRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request People.ListByActivity failed.", ex);
            }
        }
        public class PeopleListByCircleOptionalParms
        {
            /// The maximum number of people to include in the response, which is used for paging. For any response, the actual number returned might be less than the specified maxResults.
            public int? MaxResults { get; set; }  
            /// The continuation token, which is used to page through large result sets. To get the next page of results, set this parameter to the value of "nextPageToken" from the previous response.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// List all of the people who are members of a circle. 
        /// Documentation https://developers.google.com/plusdomains/v1/reference/people/listByCircle
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Plusdomains service.</param>  
        /// <param name="circleId">The ID of the circle to get the members of.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>PeopleFeedResponse</returns>
        public static PeopleFeed ListByCircle(PlusdomainsService service, string circleId, PeopleListByCircleOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (circleId == null)
                    throw new ArgumentNullException(circleId);

                // Building the initial request.
                var request = service.People.ListByCircle(circleId);

                // Applying optional parameters to the request.                
                request = (PeopleResource.ListByCircleRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request People.ListByCircle failed.", ex);
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