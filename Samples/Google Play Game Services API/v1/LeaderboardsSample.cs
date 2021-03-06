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
// Unoffical sample for the Games v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: The API for Google Play Game Services.
// API Documentation Link https://developers.google.com/games/services/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Games/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Games.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Games.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Games.v1;
using Google.Apis.Games.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Gamesv1.Methods
{
  
    public static class LeaderboardsSample
    {

        public class LeaderboardsGetOptionalParms
        {
            /// The last-seen mutation timestamp.
            public string ConsistencyToken { get; set; }  
            /// The preferred language to use for strings returned by this method.
            public string Language { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves the metadata of the leaderboard with the given ID. 
        /// Documentation https://developers.google.com/games/v1/reference/leaderboards/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Games service.</param>  
        /// <param name="leaderboardId">The ID of the leaderboard.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>LeaderboardResponse</returns>
        public static Leaderboard Get(GamesService service, string leaderboardId, LeaderboardsGetOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (leaderboardId == null)
                    throw new ArgumentNullException(leaderboardId);

                // Building the initial request.
                var request = service.Leaderboards.Get(leaderboardId);

                // Applying optional parameters to the request.                
                request = (LeaderboardsResource.GetRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Leaderboards.Get failed.", ex);
            }
        }
        public class LeaderboardsListOptionalParms
        {
            /// The last-seen mutation timestamp.
            public string ConsistencyToken { get; set; }  
            /// The preferred language to use for strings returned by this method.
            public string Language { get; set; }  
            /// The maximum number of leaderboards to return in the response. For any response, the actual number of leaderboards returned may be less than the specified maxResults.
            public int? MaxResults { get; set; }  
            /// The token returned by the previous request.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Lists all the leaderboard metadata for your application. 
        /// Documentation https://developers.google.com/games/v1/reference/leaderboards/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Games service.</param>  
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>LeaderboardListResponseResponse</returns>
        public static LeaderboardListResponse List(GamesService service, LeaderboardsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.Leaderboards.List();

                // Applying optional parameters to the request.                
                request = (LeaderboardsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Leaderboards.List failed.", ex);
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