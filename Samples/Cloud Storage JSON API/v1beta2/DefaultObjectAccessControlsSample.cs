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
// Unoffical sample for the Storage v1beta2 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Lets you store and retrieve potentially-large, immutable data objects.
// API Documentation Link https://developers.google.com/storage/docs/json_api/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Storage/v1beta2/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Storage.v1beta2/ 
// Install Command: PM>  Install-Package Google.Apis.Storage.v1beta2
//
//------------------------------------------------------------------------------  
using Google.Apis.Storage.v1beta2;
using Google.Apis.Storage.v1beta2.Data;
using System;

namespace GoogleSamplecSharpSample.Storagev1beta2.Methods
{
  
    public static class DefaultObjectAccessControlsSample
    {


        /// <summary>
        /// Permanently deletes the default object ACL entry for the specified entity on the specified bucket. 
        /// Documentation https://developers.google.com/storage/v1beta2/reference/defaultObjectAccessControls/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Storage service.</param>  
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="entity">The entity holding the permission. Can be user-userId, user-emailAddress, group-groupId, group-emailAddress, allUsers, or allAuthenticatedUsers.</param>
        public static void Delete(StorageService service, string bucket, string entity)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (bucket == null)
                    throw new ArgumentNullException(bucket);
                if (entity == null)
                    throw new ArgumentNullException(entity);

                // Make the request.
                 service.DefaultObjectAccessControls.Delete(bucket, entity).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request DefaultObjectAccessControls.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Returns the default object ACL entry for the specified entity on the specified bucket. 
        /// Documentation https://developers.google.com/storage/v1beta2/reference/defaultObjectAccessControls/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Storage service.</param>  
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="entity">The entity holding the permission. Can be user-userId, user-emailAddress, group-groupId, group-emailAddress, allUsers, or allAuthenticatedUsers.</param>
        /// <returns>ObjectAccessControlResponse</returns>
        public static ObjectAccessControl Get(StorageService service, string bucket, string entity)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (bucket == null)
                    throw new ArgumentNullException(bucket);
                if (entity == null)
                    throw new ArgumentNullException(entity);

                // Make the request.
                return service.DefaultObjectAccessControls.Get(bucket, entity).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request DefaultObjectAccessControls.Get failed.", ex);
            }
        }

        /// <summary>
        /// Creates a new default object ACL entry on the specified bucket. 
        /// Documentation https://developers.google.com/storage/v1beta2/reference/defaultObjectAccessControls/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Storage service.</param>  
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="body">A valid Storage v1beta2 body.</param>
        /// <returns>ObjectAccessControlResponse</returns>
        public static ObjectAccessControl Insert(StorageService service, string bucket, ObjectAccessControl body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (bucket == null)
                    throw new ArgumentNullException(bucket);

                // Make the request.
                return service.DefaultObjectAccessControls.Insert(body, bucket).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request DefaultObjectAccessControls.Insert failed.", ex);
            }
        }
        public class DefaultObjectAccessControlsListOptionalParms
        {
            /// If present, only return default ACL listing if the bucket's current metageneration matches this value.
            public string IfMetagenerationMatch { get; set; }  
            /// If present, only return default ACL listing if the bucket's current metageneration does not match the given value.
            public string IfMetagenerationNotMatch { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves default object ACL entries on the specified bucket. 
        /// Documentation https://developers.google.com/storage/v1beta2/reference/defaultObjectAccessControls/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Storage service.</param>  
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ObjectAccessControlsResponse</returns>
        public static ObjectAccessControls List(StorageService service, string bucket, DefaultObjectAccessControlsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (bucket == null)
                    throw new ArgumentNullException(bucket);

                // Building the initial request.
                var request = service.DefaultObjectAccessControls.List(bucket);

                // Applying optional parameters to the request.                
                request = (DefaultObjectAccessControlsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request DefaultObjectAccessControls.List failed.", ex);
            }
        }

        /// <summary>
        /// Updates a default object ACL entry on the specified bucket. This method supports patch semantics. 
        /// Documentation https://developers.google.com/storage/v1beta2/reference/defaultObjectAccessControls/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Storage service.</param>  
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="entity">The entity holding the permission. Can be user-userId, user-emailAddress, group-groupId, group-emailAddress, allUsers, or allAuthenticatedUsers.</param>
        /// <param name="body">A valid Storage v1beta2 body.</param>
        /// <returns>ObjectAccessControlResponse</returns>
        public static ObjectAccessControl Patch(StorageService service, string bucket, string entity, ObjectAccessControl body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (bucket == null)
                    throw new ArgumentNullException(bucket);
                if (entity == null)
                    throw new ArgumentNullException(entity);

                // Make the request.
                return service.DefaultObjectAccessControls.Patch(body, bucket, entity).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request DefaultObjectAccessControls.Patch failed.", ex);
            }
        }

        /// <summary>
        /// Updates a default object ACL entry on the specified bucket. 
        /// Documentation https://developers.google.com/storage/v1beta2/reference/defaultObjectAccessControls/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Storage service.</param>  
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="entity">The entity holding the permission. Can be user-userId, user-emailAddress, group-groupId, group-emailAddress, allUsers, or allAuthenticatedUsers.</param>
        /// <param name="body">A valid Storage v1beta2 body.</param>
        /// <returns>ObjectAccessControlResponse</returns>
        public static ObjectAccessControl Update(StorageService service, string bucket, string entity, ObjectAccessControl body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (bucket == null)
                    throw new ArgumentNullException(bucket);
                if (entity == null)
                    throw new ArgumentNullException(entity);

                // Make the request.
                return service.DefaultObjectAccessControls.Update(body, bucket, entity).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request DefaultObjectAccessControls.Update failed.", ex);
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