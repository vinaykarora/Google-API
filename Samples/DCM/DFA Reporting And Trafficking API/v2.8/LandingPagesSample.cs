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
// Unoffical sample for the Dfareporting v2.8 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Manages your DoubleClick Campaign Manager ad campaigns and reports.
// API Documentation Link https://developers.google.com/doubleclick-advertisers/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Dfareporting/v2_8/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Dfareporting.v2_8/ 
// Install Command: PM>  Install-Package Google.Apis.Dfareporting.v2_8
//
//------------------------------------------------------------------------------  
using Google.Apis.Dfareporting.v2_8;
using Google.Apis.Dfareporting.v2_8.Data;
using System;

namespace GoogleSamplecSharpSample.Dfareportingv2_8.Methods
{
  
    public static class LandingPagesSample
    {


        /// <summary>
        /// Deletes an existing campaign landing page. 
        /// Documentation https://developers.google.com/dfareporting/v2.8/reference/landingPages/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="campaignId">Landing page campaign ID.</param>
        /// <param name="id">Landing page ID.</param>
        public static void Delete(DfareportingService service, string profileId, string campaignId, string id)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (profileId == null)
                    throw new ArgumentNullException(profileId);
                if (campaignId == null)
                    throw new ArgumentNullException(campaignId);
                if (id == null)
                    throw new ArgumentNullException(id);

                // Make the request.
                 service.LandingPages.Delete(profileId, campaignId, id).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request LandingPages.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Gets one campaign landing page by ID. 
        /// Documentation https://developers.google.com/dfareporting/v2.8/reference/landingPages/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="campaignId">Landing page campaign ID.</param>
        /// <param name="id">Landing page ID.</param>
        /// <returns>LandingPageResponse</returns>
        public static LandingPage Get(DfareportingService service, string profileId, string campaignId, string id)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (profileId == null)
                    throw new ArgumentNullException(profileId);
                if (campaignId == null)
                    throw new ArgumentNullException(campaignId);
                if (id == null)
                    throw new ArgumentNullException(id);

                // Make the request.
                return service.LandingPages.Get(profileId, campaignId, id).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request LandingPages.Get failed.", ex);
            }
        }

        /// <summary>
        /// Inserts a new landing page for the specified campaign. 
        /// Documentation https://developers.google.com/dfareporting/v2.8/reference/landingPages/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="campaignId">Landing page campaign ID.</param>
        /// <param name="body">A valid Dfareporting v2.8 body.</param>
        /// <returns>LandingPageResponse</returns>
        public static LandingPage Insert(DfareportingService service, string profileId, string campaignId, LandingPage body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (profileId == null)
                    throw new ArgumentNullException(profileId);
                if (campaignId == null)
                    throw new ArgumentNullException(campaignId);

                // Make the request.
                return service.LandingPages.Insert(body, profileId, campaignId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request LandingPages.Insert failed.", ex);
            }
        }

        /// <summary>
        /// Retrieves the list of landing pages for the specified campaign. 
        /// Documentation https://developers.google.com/dfareporting/v2.8/reference/landingPages/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="campaignId">Landing page campaign ID.</param>
        /// <returns>LandingPagesListResponseResponse</returns>
        public static LandingPagesListResponse List(DfareportingService service, string profileId, string campaignId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (profileId == null)
                    throw new ArgumentNullException(profileId);
                if (campaignId == null)
                    throw new ArgumentNullException(campaignId);

                // Make the request.
                return service.LandingPages.List(profileId, campaignId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request LandingPages.List failed.", ex);
            }
        }

        /// <summary>
        /// Updates an existing campaign landing page. This method supports patch semantics. 
        /// Documentation https://developers.google.com/dfareporting/v2.8/reference/landingPages/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="campaignId">Landing page campaign ID.</param>
        /// <param name="id">Landing page ID.</param>
        /// <param name="body">A valid Dfareporting v2.8 body.</param>
        /// <returns>LandingPageResponse</returns>
        public static LandingPage Patch(DfareportingService service, string profileId, string campaignId, string id, LandingPage body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (profileId == null)
                    throw new ArgumentNullException(profileId);
                if (campaignId == null)
                    throw new ArgumentNullException(campaignId);
                if (id == null)
                    throw new ArgumentNullException(id);

                // Make the request.
                return service.LandingPages.Patch(body, profileId, campaignId, id).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request LandingPages.Patch failed.", ex);
            }
        }

        /// <summary>
        /// Updates an existing campaign landing page. 
        /// Documentation https://developers.google.com/dfareporting/v2.8/reference/landingPages/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="campaignId">Landing page campaign ID.</param>
        /// <param name="body">A valid Dfareporting v2.8 body.</param>
        /// <returns>LandingPageResponse</returns>
        public static LandingPage Update(DfareportingService service, string profileId, string campaignId, LandingPage body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (profileId == null)
                    throw new ArgumentNullException(profileId);
                if (campaignId == null)
                    throw new ArgumentNullException(campaignId);

                // Make the request.
                return service.LandingPages.Update(body, profileId, campaignId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request LandingPages.Update failed.", ex);
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