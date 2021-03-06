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
// Unoffical sample for the Classroom v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Manages classes, rosters, and invitations in Google Classroom.
// API Documentation Link https://developers.google.com/classroom/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Classroom/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Classroom.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Classroom.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Classroom.v1;
using Google.Apis.Classroom.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Classroomv1.Methods
{
  
    public static class RegistrationsSample
    {


        /// <summary>
        /// Deletes a `Registration`, causing Classroom to stop sending notificationsfor that `Registration`. 
        /// Documentation https://developers.google.com/classroom/v1/reference/registrations/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Classroom service.</param>  
        /// <param name="registrationId">The `registration_id` of the `Registration` to be deleted.</param>
        /// <returns>EmptyResponse</returns>
        public static Empty Delete(ClassroomService service, string registrationId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (registrationId == null)
                    throw new ArgumentNullException(registrationId);

                // Make the request.
                return service.Registrations.Delete(registrationId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Registrations.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Creates a `Registration`, causing Classroom to start sending notificationsfrom the provided `feed` to the provided `destination`.Returns the created `Registration`. Currently, this will be the same asthe argument, but with server-assigned fields such as `expiry_time` and`id` filled in.Note that any value specified for the `expiry_time` or `id` fields will beignored.While Classroom may validate the `destination` and return errors on a besteffort basis, it is the caller's responsibility to ensure that it existsand that Classroom has permission to publish to it.This method may return the following error codes:* `PERMISSION_DENIED` if:    * the authenticated user does not have permission to receive      notifications from the requested field; or    * the credential provided does not include the appropriate scope for the      requested feed.    * another access error is encountered.* `INVALID_ARGUMENT` if:    * no `destination` is specified, or the specified `destination` is not      valid; or    * no `feed` is specified, or the specified `feed` is not valid.* `NOT_FOUND` if:    * the specified `feed` cannot be located, or the requesting user does not      have permission to determine whether or not it exists; or    * the specified `destination` cannot be located, or Classroom has not      been granted permission to publish to it. 
        /// Documentation https://developers.google.com/classroom/v1/reference/registrations/create
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Classroom service.</param>  
        /// <param name="body">A valid Classroom v1 body.</param>
        /// <returns>RegistrationResponse</returns>
        public static Registration Create(ClassroomService service, Registration body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Registrations.Create(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Registrations.Create failed.", ex);
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