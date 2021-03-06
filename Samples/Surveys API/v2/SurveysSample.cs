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
// Unoffical sample for the Surveys v2 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Creates and conducts surveys, lists the surveys that an authenticated user owns, and retrieves survey results and information about specified surveys.
// API Documentation Link https://www.google.com/search?q=Surveys
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Surveys/v2/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Surveys.v2/ 
// Install Command: PM>  Install-Package Google.Apis.Surveys.v2
//
//------------------------------------------------------------------------------  
using Google.Apis.Surveys.v2;
using Google.Apis.Surveys.v2.Data;
using System;

namespace GoogleSamplecSharpSample.Surveysv2.Methods
{
  
    public static class SurveysSample
    {


        /// <summary>
        /// Removes a survey from view in all user GET requests. 
        /// Documentation https://developers.google.com/surveys/v2/reference/surveys/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Surveys service.</param>  
        /// <param name="surveyUrlId">External URL ID for the survey.</param>
        /// <returns>SurveysDeleteResponseResponse</returns>
        public static SurveysDeleteResponse Delete(SurveysService service, string surveyUrlId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (surveyUrlId == null)
                    throw new ArgumentNullException(surveyUrlId);

                // Make the request.
                return service.Surveys.Delete(surveyUrlId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Surveys.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Retrieves information about the specified survey. 
        /// Documentation https://developers.google.com/surveys/v2/reference/surveys/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Surveys service.</param>  
        /// <param name="surveyUrlId">External URL ID for the survey.</param>
        /// <returns>SurveyResponse</returns>
        public static Survey Get(SurveysService service, string surveyUrlId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (surveyUrlId == null)
                    throw new ArgumentNullException(surveyUrlId);

                // Make the request.
                return service.Surveys.Get(surveyUrlId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Surveys.Get failed.", ex);
            }
        }

        /// <summary>
        /// Creates a survey. 
        /// Documentation https://developers.google.com/surveys/v2/reference/surveys/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Surveys service.</param>  
        /// <param name="body">A valid Surveys v2 body.</param>
        /// <returns>SurveyResponse</returns>
        public static Survey Insert(SurveysService service, Survey body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Surveys.Insert(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Surveys.Insert failed.", ex);
            }
        }
        public class SurveysListOptionalParms
        {
            /// NA
            public int? MaxResults { get; set; }  
            /// NA
            public int? StartIndex { get; set; }  
            /// NA
            public string Token { get; set; }  
        
        }
 
        /// <summary>
        /// Lists the surveys owned by the authenticated user. 
        /// Documentation https://developers.google.com/surveys/v2/reference/surveys/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Surveys service.</param>  
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>SurveysListResponseResponse</returns>
        public static SurveysListResponse List(SurveysService service, SurveysListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.Surveys.List();

                // Applying optional parameters to the request.                
                request = (SurveysResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Surveys.List failed.", ex);
            }
        }

        /// <summary>
        /// Begins running a survey. 
        /// Documentation https://developers.google.com/surveys/v2/reference/surveys/start
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Surveys service.</param>  
        /// <param name="resourceId">NA</param>
        /// <param name="body">A valid Surveys v2 body.</param>
        /// <returns>SurveysStartResponseResponse</returns>
        public static SurveysStartResponse Start(SurveysService service, string resourceId, SurveysStartRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (resourceId == null)
                    throw new ArgumentNullException(resourceId);

                // Make the request.
                return service.Surveys.Start(body, resourceId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Surveys.Start failed.", ex);
            }
        }

        /// <summary>
        /// Stops a running survey. 
        /// Documentation https://developers.google.com/surveys/v2/reference/surveys/stop
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Surveys service.</param>  
        /// <param name="resourceId">NA</param>
        /// <returns>SurveysStopResponseResponse</returns>
        public static SurveysStopResponse Stop(SurveysService service, string resourceId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (resourceId == null)
                    throw new ArgumentNullException(resourceId);

                // Make the request.
                return service.Surveys.Stop(resourceId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Surveys.Stop failed.", ex);
            }
        }

        /// <summary>
        /// Updates a survey. Currently the only property that can be updated is the owners property. 
        /// Documentation https://developers.google.com/surveys/v2/reference/surveys/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Surveys service.</param>  
        /// <param name="surveyUrlId">External URL ID for the survey.</param>
        /// <param name="body">A valid Surveys v2 body.</param>
        /// <returns>SurveyResponse</returns>
        public static Survey Update(SurveysService service, string surveyUrlId, Survey body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (surveyUrlId == null)
                    throw new ArgumentNullException(surveyUrlId);

                // Make the request.
                return service.Surveys.Update(body, surveyUrlId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Surveys.Update failed.", ex);
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