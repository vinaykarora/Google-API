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
// Unoffical sample for the Resourceviews v1beta2 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: The Resource View API allows users to create and manage logical sets of Google Compute Engine instances.
// API Documentation Link https://developers.google.com/compute/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Resourceviews/v1beta2/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Resourceviews.v1beta2/ 
// Install Command: PM>  Install-Package Google.Apis.Resourceviews.v1beta2
//
//------------------------------------------------------------------------------  
using Google.Apis.Resourceviews.v1beta2;
using Google.Apis.Resourceviews.v1beta2.Data;
using System;

namespace GoogleSamplecSharpSample.Resourceviewsv1beta2.Methods
{
  
    public static class ZoneViewsSample
    {


        /// <summary>
        /// Add resources to the view. 
        /// Documentation https://developers.google.com/resourceviews/v1beta2/reference/zoneViews/addResources
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Resourceviews service.</param>  
        /// <param name="project">The project name of the resource view.</param>
        /// <param name="zone">The zone name of the resource view.</param>
        /// <param name="resourceView">The name of the resource view.</param>
        /// <param name="body">A valid Resourceviews v1beta2 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation AddResources(ResourceviewsService service, string project, string zone, string resourceView, ZoneViewsAddResourcesRequest body)
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
                if (zone == null)
                    throw new ArgumentNullException(zone);
                if (resourceView == null)
                    throw new ArgumentNullException(resourceView);

                // Make the request.
                return service.ZoneViews.AddResources(body, project, zone, resourceView).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request ZoneViews.AddResources failed.", ex);
            }
        }

        /// <summary>
        /// Delete a resource view. 
        /// Documentation https://developers.google.com/resourceviews/v1beta2/reference/zoneViews/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Resourceviews service.</param>  
        /// <param name="project">The project name of the resource view.</param>
        /// <param name="zone">The zone name of the resource view.</param>
        /// <param name="resourceView">The name of the resource view.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Delete(ResourceviewsService service, string project, string zone, string resourceView)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (zone == null)
                    throw new ArgumentNullException(zone);
                if (resourceView == null)
                    throw new ArgumentNullException(resourceView);

                // Make the request.
                return service.ZoneViews.Delete(project, zone, resourceView).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request ZoneViews.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Get the information of a zonal resource view. 
        /// Documentation https://developers.google.com/resourceviews/v1beta2/reference/zoneViews/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Resourceviews service.</param>  
        /// <param name="project">The project name of the resource view.</param>
        /// <param name="zone">The zone name of the resource view.</param>
        /// <param name="resourceView">The name of the resource view.</param>
        /// <returns>ResourceViewResponse</returns>
        public static ResourceView Get(ResourceviewsService service, string project, string zone, string resourceView)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (zone == null)
                    throw new ArgumentNullException(zone);
                if (resourceView == null)
                    throw new ArgumentNullException(resourceView);

                // Make the request.
                return service.ZoneViews.Get(project, zone, resourceView).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request ZoneViews.Get failed.", ex);
            }
        }
        public class ZoneViewsGetServiceOptionalParms
        {
            /// The name of the resource if user wants to get the service information of the resource.
            public string ResourceName { get; set; }  
        
        }
 
        /// <summary>
        /// Get the service information of a resource view or a resource. 
        /// Documentation https://developers.google.com/resourceviews/v1beta2/reference/zoneViews/getService
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Resourceviews service.</param>  
        /// <param name="project">The project name of the resource view.</param>
        /// <param name="zone">The zone name of the resource view.</param>
        /// <param name="resourceView">The name of the resource view.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ZoneViewsGetServiceResponseResponse</returns>
        public static ZoneViewsGetServiceResponse GetService(ResourceviewsService service, string project, string zone, string resourceView, ZoneViewsGetServiceOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (zone == null)
                    throw new ArgumentNullException(zone);
                if (resourceView == null)
                    throw new ArgumentNullException(resourceView);

                // Building the initial request.
                var request = service.ZoneViews.GetService(project, zone, resourceView);

                // Applying optional parameters to the request.                
                request = (ZoneViewsResource.GetServiceRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request ZoneViews.GetService failed.", ex);
            }
        }

        /// <summary>
        /// Create a resource view. 
        /// Documentation https://developers.google.com/resourceviews/v1beta2/reference/zoneViews/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Resourceviews service.</param>  
        /// <param name="project">The project name of the resource view.</param>
        /// <param name="zone">The zone name of the resource view.</param>
        /// <param name="body">A valid Resourceviews v1beta2 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Insert(ResourceviewsService service, string project, string zone, ResourceView body)
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
                if (zone == null)
                    throw new ArgumentNullException(zone);

                // Make the request.
                return service.ZoneViews.Insert(body, project, zone).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request ZoneViews.Insert failed.", ex);
            }
        }
        public class ZoneViewsListOptionalParms
        {
            /// Maximum count of results to be returned. Acceptable values are 0 to 5000, inclusive. (Default: 5000)
            public int? MaxResults { get; set; }  
            /// Specifies a nextPageToken returned by a previous list request. This token can be used to request the next page of results from a previous list request.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// List resource views. 
        /// Documentation https://developers.google.com/resourceviews/v1beta2/reference/zoneViews/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Resourceviews service.</param>  
        /// <param name="project">The project name of the resource view.</param>
        /// <param name="zone">The zone name of the resource view.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ZoneViewsListResponse</returns>
        public static ZoneViewsList List(ResourceviewsService service, string project, string zone, ZoneViewsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (zone == null)
                    throw new ArgumentNullException(zone);

                // Building the initial request.
                var request = service.ZoneViews.List(project, zone);

                // Applying optional parameters to the request.                
                request = (ZoneViewsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request ZoneViews.List failed.", ex);
            }
        }
        public class ZoneViewsListResourcesOptionalParms
        {
            /// The requested format of the return value. It can be URL or URL_PORT. A JSON object will be included in the response based on the format. The default format is NONE, which results in no JSON in the response.
            public string Format { get; set; }  
            /// The state of the instance to list. By default, it lists all instances.
            public string ListState { get; set; }  
            /// Maximum count of results to be returned. Acceptable values are 0 to 5000, inclusive. (Default: 5000)
            public int? MaxResults { get; set; }  
            /// Specifies a nextPageToken returned by a previous list request. This token can be used to request the next page of results from a previous list request.
            public string PageToken { get; set; }  
            /// The service name to return in the response. It is optional and if it is not set, all the service end points will be returned.
            public string ServiceName { get; set; }  
        
        }
 
        /// <summary>
        /// List the resources of the resource view. 
        /// Documentation https://developers.google.com/resourceviews/v1beta2/reference/zoneViews/listResources
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Resourceviews service.</param>  
        /// <param name="project">The project name of the resource view.</param>
        /// <param name="zone">The zone name of the resource view.</param>
        /// <param name="resourceView">The name of the resource view.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ZoneViewsListResourcesResponseResponse</returns>
        public static ZoneViewsListResourcesResponse ListResources(ResourceviewsService service, string project, string zone, string resourceView, ZoneViewsListResourcesOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (zone == null)
                    throw new ArgumentNullException(zone);
                if (resourceView == null)
                    throw new ArgumentNullException(resourceView);

                // Building the initial request.
                var request = service.ZoneViews.ListResources(project, zone, resourceView);

                // Applying optional parameters to the request.                
                request = (ZoneViewsResource.ListResourcesRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request ZoneViews.ListResources failed.", ex);
            }
        }

        /// <summary>
        /// Remove resources from the view. 
        /// Documentation https://developers.google.com/resourceviews/v1beta2/reference/zoneViews/removeResources
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Resourceviews service.</param>  
        /// <param name="project">The project name of the resource view.</param>
        /// <param name="zone">The zone name of the resource view.</param>
        /// <param name="resourceView">The name of the resource view.</param>
        /// <param name="body">A valid Resourceviews v1beta2 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation RemoveResources(ResourceviewsService service, string project, string zone, string resourceView, ZoneViewsRemoveResourcesRequest body)
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
                if (zone == null)
                    throw new ArgumentNullException(zone);
                if (resourceView == null)
                    throw new ArgumentNullException(resourceView);

                // Make the request.
                return service.ZoneViews.RemoveResources(body, project, zone, resourceView).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request ZoneViews.RemoveResources failed.", ex);
            }
        }

        /// <summary>
        /// Update the service information of a resource view or a resource. 
        /// Documentation https://developers.google.com/resourceviews/v1beta2/reference/zoneViews/setService
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Resourceviews service.</param>  
        /// <param name="project">The project name of the resource view.</param>
        /// <param name="zone">The zone name of the resource view.</param>
        /// <param name="resourceView">The name of the resource view.</param>
        /// <param name="body">A valid Resourceviews v1beta2 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation SetService(ResourceviewsService service, string project, string zone, string resourceView, ZoneViewsSetServiceRequest body)
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
                if (zone == null)
                    throw new ArgumentNullException(zone);
                if (resourceView == null)
                    throw new ArgumentNullException(resourceView);

                // Make the request.
                return service.ZoneViews.SetService(body, project, zone, resourceView).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request ZoneViews.SetService failed.", ex);
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