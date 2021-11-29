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
// Unoffical sample for the Doubleclicksearch v2 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Reports and modifies your advertising data in DoubleClick Search (for example, campaigns, ad groups, keywords, and conversions).
// API Documentation Link https://developers.google.com/doubleclick-search/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Doubleclicksearch/v2/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Doubleclicksearch.v2/ 
// Install Command: PM>  Install-Package Google.Apis.Doubleclicksearch.v2
//
//------------------------------------------------------------------------------  
using Google.Apis.Doubleclicksearch.v2;
using Google.Apis.Doubleclicksearch.v2.Data;
using System;

namespace GoogleSamplecSharpSample.Doubleclicksearchv2.Methods
{
  
    public static class ConversionSample
    {

        public class ConversionGetOptionalParms
        {
            /// Numeric ID of the ad group.
            public string AdGroupId { get; set; }  
            /// Numeric ID of the ad.
            public string AdId { get; set; }  
            /// Numeric ID of the campaign.
            public string CampaignId { get; set; }  
            /// Numeric ID of the criterion.
            public string CriterionId { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves a list of conversions from a DoubleClick Search engine account. 
        /// Documentation https://developers.google.com/doubleclicksearch/v2/reference/conversion/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Doubleclicksearch service.</param>  
        /// <param name="agencyId">Numeric ID of the agency.</param>
        /// <param name="advertiserId">Numeric ID of the advertiser.</param>
        /// <param name="engineAccountId">Numeric ID of the engine account.</param>
        /// <param name="endDate">Last date (inclusive) on which to retrieve conversions. Format is yyyymmdd.</param>
        /// <param name="rowCount">The number of conversions to return per call.</param>
        /// <param name="startDate">First date (inclusive) on which to retrieve conversions. Format is yyyymmdd.</param>
        /// <param name="startRow">The 0-based starting index for retrieving conversions results.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ConversionListResponse</returns>
        public static ConversionList Get(DoubleclicksearchService service, string agencyId, string advertiserId, string engineAccountId, int? endDate, int? rowCount, int? startDate, int? startRow, ConversionGetOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (agencyId == null)
                    throw new ArgumentNullException(agencyId);
                if (advertiserId == null)
                    throw new ArgumentNullException(advertiserId);
                if (engineAccountId == null)
                    throw new ArgumentNullException(engineAccountId);
                if (endDate == null)
                    throw new ArgumentNullException(endDate);
                if (rowCount == null)
                    throw new ArgumentNullException(rowCount);
                if (startDate == null)
                    throw new ArgumentNullException(startDate);
                if (startRow == null)
                    throw new ArgumentNullException(startRow);

                // Building the initial request.
                var request = service.Conversion.Get(agencyId, advertiserId, engineAccountId, endDate, rowCount, startDate, startRow);

                // Applying optional parameters to the request.                
                request = (ConversionResource.GetRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Conversion.Get failed.", ex);
            }
        }

        /// <summary>
        /// Inserts a batch of new conversions into DoubleClick Search. 
        /// Documentation https://developers.google.com/doubleclicksearch/v2/reference/conversion/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Doubleclicksearch service.</param>  
        /// <param name="body">A valid Doubleclicksearch v2 body.</param>
        /// <returns>ConversionListResponse</returns>
        public static ConversionList Insert(DoubleclicksearchService service, ConversionList body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Conversion.Insert(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Conversion.Insert failed.", ex);
            }
        }

        /// <summary>
        /// Updates a batch of conversions in DoubleClick Search. This method supports patch semantics. 
        /// Documentation https://developers.google.com/doubleclicksearch/v2/reference/conversion/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Doubleclicksearch service.</param>  
        /// <param name="advertiserId">Numeric ID of the advertiser.</param>
        /// <param name="agencyId">Numeric ID of the agency.</param>
        /// <param name="endDate">Last date (inclusive) on which to retrieve conversions. Format is yyyymmdd.</param>
        /// <param name="engineAccountId">Numeric ID of the engine account.</param>
        /// <param name="rowCount">The number of conversions to return per call.</param>
        /// <param name="startDate">First date (inclusive) on which to retrieve conversions. Format is yyyymmdd.</param>
        /// <param name="startRow">The 0-based starting index for retrieving conversions results.</param>
        /// <param name="body">A valid Doubleclicksearch v2 body.</param>
        /// <returns>ConversionListResponse</returns>
        public static ConversionList Patch(DoubleclicksearchService service, string advertiserId, string agencyId, int? endDate, string engineAccountId, int? rowCount, int? startDate, int? startRow, ConversionList body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (advertiserId == null)
                    throw new ArgumentNullException(advertiserId);
                if (agencyId == null)
                    throw new ArgumentNullException(agencyId);
                if (endDate == null)
                    throw new ArgumentNullException(endDate);
                if (engineAccountId == null)
                    throw new ArgumentNullException(engineAccountId);
                if (rowCount == null)
                    throw new ArgumentNullException(rowCount);
                if (startDate == null)
                    throw new ArgumentNullException(startDate);
                if (startRow == null)
                    throw new ArgumentNullException(startRow);

                // Make the request.
                return service.Conversion.Patch(body, advertiserId, agencyId, endDate, engineAccountId, rowCount, startDate, startRow).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Conversion.Patch failed.", ex);
            }
        }

        /// <summary>
        /// Updates a batch of conversions in DoubleClick Search. 
        /// Documentation https://developers.google.com/doubleclicksearch/v2/reference/conversion/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Doubleclicksearch service.</param>  
        /// <param name="body">A valid Doubleclicksearch v2 body.</param>
        /// <returns>ConversionListResponse</returns>
        public static ConversionList Update(DoubleclicksearchService service, ConversionList body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Conversion.Update(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Conversion.Update failed.", ex);
            }
        }

        /// <summary>
        /// Updates the availabilities of a batch of floodlight activities in DoubleClick Search. 
        /// Documentation https://developers.google.com/doubleclicksearch/v2/reference/conversion/updateAvailability
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Doubleclicksearch service.</param>  
        /// <param name="body">A valid Doubleclicksearch v2 body.</param>
        /// <returns>UpdateAvailabilityResponseResponse</returns>
        public static UpdateAvailabilityResponse UpdateAvailability(DoubleclicksearchService service, UpdateAvailabilityRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Conversion.UpdateAvailability(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Conversion.UpdateAvailability failed.", ex);
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