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
// Unoffical sample for the Proximitybeacon v1beta1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Registers, manages, indexes, and searches beacons.
// API Documentation Link https://developers.google.com/beacons/proximity/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Proximitybeacon/v1beta1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Proximitybeacon.v1beta1/ 
// Install Command: PM>  Install-Package Google.Apis.Proximitybeacon.v1beta1
//
//------------------------------------------------------------------------------  
using Google.Apis.Proximitybeacon.v1beta1;
using Google.Apis.Proximitybeacon.v1beta1.Data;
using System;

namespace GoogleSamplecSharpSample.Proximitybeaconv1beta1.Methods
{
  
    public static class BeaconinfoSample
    {


        /// <summary>
        /// Given one or more beacon observations, returns any beacon informationand attachments accessible to your application. Authorize by using the[API key](https://developers.google.com/beacons/proximity/get-started#request_a_browser_api_key)for the application. 
        /// Documentation https://developers.google.com/proximitybeacon/v1beta1/reference/beaconinfo/getforobserved
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Proximitybeacon service.</param>  
        /// <param name="body">A valid Proximitybeacon v1beta1 body.</param>
        /// <returns>GetInfoForObservedBeaconsResponseResponse</returns>
        public static GetInfoForObservedBeaconsResponse Getforobserved(ProximitybeaconService service, GetInfoForObservedBeaconsRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Beaconinfo.Getforobserved(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Beaconinfo.Getforobserved failed.", ex);
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