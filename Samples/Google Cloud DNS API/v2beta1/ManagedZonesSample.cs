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
// Unoffical sample for the Dns v2beta1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Configures and serves authoritative DNS records.
// API Documentation Link https://developers.google.com/cloud-dns
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Dns/v2beta1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Dns.v2beta1/ 
// Install Command: PM>  Install-Package Google.Apis.Dns.v2beta1
//
//------------------------------------------------------------------------------  
using Google.Apis.Dns.v2beta1;
using Google.Apis.Dns.v2beta1.Data;
using System;

namespace GoogleSamplecSharpSample.Dnsv2beta1.Methods
{
  
    public static class ManagedZonesSample
    {

        public class ManagedZonesCreateOptionalParms
        {
            /// For mutating operation requests only. An optional identifier specified by the client. Must be unique for operation resources in the Operations collection.
            public string ClientOperationId { get; set; }  
        
        }
 
        /// <summary>
        /// Create a new ManagedZone. 
        /// Documentation https://developers.google.com/dns/v2beta1/reference/managedZones/create
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dns service.</param>  
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="body">A valid Dns v2beta1 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ManagedZoneResponse</returns>
        public static ManagedZone Create(DnsService service, string project, ManagedZone body, ManagedZonesCreateOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (project == null)
                    throw new ArgumentNullException(project);

                // Building the initial request.
                var request = service.ManagedZones.Create(body, project);

                // Applying optional parameters to the request.                
                request = (ManagedZonesResource.CreateRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request ManagedZones.Create failed.", ex);
            }
        }
        public class ManagedZonesDeleteOptionalParms
        {
            /// For mutating operation requests only. An optional identifier specified by the client. Must be unique for operation resources in the Operations collection.
            public string ClientOperationId { get; set; }  
        
        }
 
        /// <summary>
        /// Delete a previously created ManagedZone. 
        /// Documentation https://developers.google.com/dns/v2beta1/reference/managedZones/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dns service.</param>  
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="managedZone">Identifies the managed zone addressed by this request. Can be the managed zone name or id.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ManagedZonesDeleteResponseResponse</returns>
        public static ManagedZonesDeleteResponse Delete(DnsService service, string project, string managedZone, ManagedZonesDeleteOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (managedZone == null)
                    throw new ArgumentNullException(managedZone);

                // Building the initial request.
                var request = service.ManagedZones.Delete(project, managedZone);

                // Applying optional parameters to the request.                
                request = (ManagedZonesResource.DeleteRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request ManagedZones.Delete failed.", ex);
            }
        }
        public class ManagedZonesGetOptionalParms
        {
            /// For mutating operation requests only. An optional identifier specified by the client. Must be unique for operation resources in the Operations collection.
            public string ClientOperationId { get; set; }  
        
        }
 
        /// <summary>
        /// Fetch the representation of an existing ManagedZone. 
        /// Documentation https://developers.google.com/dns/v2beta1/reference/managedZones/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dns service.</param>  
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="managedZone">Identifies the managed zone addressed by this request. Can be the managed zone name or id.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ManagedZoneResponse</returns>
        public static ManagedZone Get(DnsService service, string project, string managedZone, ManagedZonesGetOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (managedZone == null)
                    throw new ArgumentNullException(managedZone);

                // Building the initial request.
                var request = service.ManagedZones.Get(project, managedZone);

                // Applying optional parameters to the request.                
                request = (ManagedZonesResource.GetRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request ManagedZones.Get failed.", ex);
            }
        }
        public class ManagedZonesListOptionalParms
        {
            /// Restricts the list to return only zones with this domain name.
            public string DnsName { get; set; }  
            /// Optional. Maximum number of results to be returned. If unspecified, the server will decide how many results to return.
            public int? MaxResults { get; set; }  
            /// Optional. A tag returned by a previous list request that was truncated. Use this parameter to continue a previous list request.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Enumerate ManagedZones that have been created but not yet deleted. 
        /// Documentation https://developers.google.com/dns/v2beta1/reference/managedZones/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dns service.</param>  
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ManagedZonesListResponseResponse</returns>
        public static ManagedZonesListResponse List(DnsService service, string project, ManagedZonesListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);

                // Building the initial request.
                var request = service.ManagedZones.List(project);

                // Applying optional parameters to the request.                
                request = (ManagedZonesResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request ManagedZones.List failed.", ex);
            }
        }
        public class ManagedZonesPatchOptionalParms
        {
            /// For mutating operation requests only. An optional identifier specified by the client. Must be unique for operation resources in the Operations collection.
            public string ClientOperationId { get; set; }  
        
        }
 
        /// <summary>
        /// Update an existing ManagedZone. This method supports patch semantics. 
        /// Documentation https://developers.google.com/dns/v2beta1/reference/managedZones/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dns service.</param>  
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="managedZone">Identifies the managed zone addressed by this request. Can be the managed zone name or id.</param>
        /// <param name="body">A valid Dns v2beta1 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Patch(DnsService service, string project, string managedZone, ManagedZone body, ManagedZonesPatchOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (managedZone == null)
                    throw new ArgumentNullException(managedZone);

                // Building the initial request.
                var request = service.ManagedZones.Patch(body, project, managedZone);

                // Applying optional parameters to the request.                
                request = (ManagedZonesResource.PatchRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request ManagedZones.Patch failed.", ex);
            }
        }
        public class ManagedZonesUpdateOptionalParms
        {
            /// For mutating operation requests only. An optional identifier specified by the client. Must be unique for operation resources in the Operations collection.
            public string ClientOperationId { get; set; }  
        
        }
 
        /// <summary>
        /// Update an existing ManagedZone. 
        /// Documentation https://developers.google.com/dns/v2beta1/reference/managedZones/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dns service.</param>  
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="managedZone">Identifies the managed zone addressed by this request. Can be the managed zone name or id.</param>
        /// <param name="body">A valid Dns v2beta1 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Update(DnsService service, string project, string managedZone, ManagedZone body, ManagedZonesUpdateOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (managedZone == null)
                    throw new ArgumentNullException(managedZone);

                // Building the initial request.
                var request = service.ManagedZones.Update(body, project, managedZone);

                // Applying optional parameters to the request.                
                request = (ManagedZonesResource.UpdateRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request ManagedZones.Update failed.", ex);
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