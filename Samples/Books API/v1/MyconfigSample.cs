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
  
    public static class MyconfigSample
    {


        /// <summary>
        /// Gets the current settings for the user. 
        /// Documentation https://developers.google.com/books/v1/reference/myconfig/getUserSettings
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Books service.</param>  
        /// <returns>UsersettingsResponse</returns>
        public static Usersettings GetUserSettings(BooksService service)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Make the request.
                return service.Myconfig.GetUserSettings().Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Myconfig.GetUserSettings failed.", ex);
            }
        }
        public class MyconfigReleaseDownloadAccessOptionalParms
        {
            /// ISO-639-1, ISO-3166-1 codes for message localization, i.e. en_US.
            public string Locale { get; set; }  
            /// String to identify the originator of this request.
            public string Source { get; set; }  
        
        }
 
        /// <summary>
        /// Release downloaded content access restriction. 
        /// Documentation https://developers.google.com/books/v1/reference/myconfig/releaseDownloadAccess
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Books service.</param>  
        /// <param name="volumeIds">The volume(s) to release restrictions for.</param>
        /// <param name="cpksver">The device/version ID from which to release the restriction.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>DownloadAccessesResponse</returns>
        public static DownloadAccesses ReleaseDownloadAccess(BooksService service, string volumeIds, string cpksver, MyconfigReleaseDownloadAccessOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (volumeIds == null)
                    throw new ArgumentNullException(volumeIds);
                if (cpksver == null)
                    throw new ArgumentNullException(cpksver);

                // Building the initial request.
                var request = service.Myconfig.ReleaseDownloadAccess(volumeIds, cpksver);

                // Applying optional parameters to the request.                
                request = (MyconfigResource.ReleaseDownloadAccessRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Myconfig.ReleaseDownloadAccess failed.", ex);
            }
        }
        public class MyconfigRequestAccessOptionalParms
        {
            /// The type of access license to request. If not specified, the default is BOTH.
            public string LicenseTypes { get; set; }  
            /// ISO-639-1, ISO-3166-1 codes for message localization, i.e. en_US.
            public string Locale { get; set; }  
        
        }
 
        /// <summary>
        /// Request concurrent and download access restrictions. 
        /// Documentation https://developers.google.com/books/v1/reference/myconfig/requestAccess
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Books service.</param>  
        /// <param name="source">String to identify the originator of this request.</param>
        /// <param name="volumeId">The volume to request concurrent/download restrictions for.</param>
        /// <param name="nonce">The client nonce value.</param>
        /// <param name="cpksver">The device/version ID from which to request the restrictions.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>RequestAccessResponse</returns>
        public static RequestAccess RequestAccess(BooksService service, string source, string volumeId, string nonce, string cpksver, MyconfigRequestAccessOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (source == null)
                    throw new ArgumentNullException(source);
                if (volumeId == null)
                    throw new ArgumentNullException(volumeId);
                if (nonce == null)
                    throw new ArgumentNullException(nonce);
                if (cpksver == null)
                    throw new ArgumentNullException(cpksver);

                // Building the initial request.
                var request = service.Myconfig.RequestAccess(source, volumeId, nonce, cpksver);

                // Applying optional parameters to the request.                
                request = (MyconfigResource.RequestAccessRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Myconfig.RequestAccess failed.", ex);
            }
        }
        public class MyconfigSyncVolumeLicensesOptionalParms
        {
            /// List of features supported by the client, i.e., 'RENTALS'
            public string Features { get; set; }  
            /// Set to true to include non-comics series. Defaults to false.
            public bool? IncludeNonComicsSeries { get; set; }  
            /// ISO-639-1, ISO-3166-1 codes for message localization, i.e. en_US.
            public string Locale { get; set; }  
            /// Set to true to show pre-ordered books. Defaults to false.
            public bool? ShowPreorders { get; set; }  
            /// The volume(s) to request download restrictions for.
            public string VolumeIds { get; set; }  
        
        }
 
        /// <summary>
        /// Request downloaded content access for specified volumes on the My eBooks shelf. 
        /// Documentation https://developers.google.com/books/v1/reference/myconfig/syncVolumeLicenses
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Books service.</param>  
        /// <param name="source">String to identify the originator of this request.</param>
        /// <param name="nonce">The client nonce value.</param>
        /// <param name="cpksver">The device/version ID from which to release the restriction.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>VolumesResponse</returns>
        public static Volumes SyncVolumeLicenses(BooksService service, string source, string nonce, string cpksver, MyconfigSyncVolumeLicensesOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (source == null)
                    throw new ArgumentNullException(source);
                if (nonce == null)
                    throw new ArgumentNullException(nonce);
                if (cpksver == null)
                    throw new ArgumentNullException(cpksver);

                // Building the initial request.
                var request = service.Myconfig.SyncVolumeLicenses(source, nonce, cpksver);

                // Applying optional parameters to the request.                
                request = (MyconfigResource.SyncVolumeLicensesRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Myconfig.SyncVolumeLicenses failed.", ex);
            }
        }

        /// <summary>
        /// Sets the settings for the user. If a sub-object is specified, it will overwrite the existing sub-object stored in the server. Unspecified sub-objects will retain the existing value. 
        /// Documentation https://developers.google.com/books/v1/reference/myconfig/updateUserSettings
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Books service.</param>  
        /// <param name="body">A valid Books v1 body.</param>
        /// <returns>UsersettingsResponse</returns>
        public static Usersettings UpdateUserSettings(BooksService service, Usersettings body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Myconfig.UpdateUserSettings(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Myconfig.UpdateUserSettings failed.", ex);
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