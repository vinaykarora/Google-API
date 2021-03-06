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
// Unoffical sample for the Deploymentmanagerv2beta v2beta API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: The Deployment Manager API allows users to declaratively configure, deploy and run complex solutions on the Google Cloud Platform.
// API Documentation Link https://developers.google.com/deployment-manager/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Deploymentmanagerv2beta/v2beta/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Deploymentmanagerv2beta.v2beta/ 
// Install Command: PM>  Install-Package Google.Apis.Deploymentmanagerv2beta.v2beta
//
//------------------------------------------------------------------------------  
using Google.Apis.Deploymentmanagerv2beta.v2beta;
using Google.Apis.Deploymentmanagerv2beta.v2beta.Data;
using System;

namespace GoogleSamplecSharpSample.Deploymentmanagerv2betav2beta.Methods
{
  
    public static class DeploymentsSample
    {


        /// <summary>
        /// Cancels and removes the preview currently associated with the deployment. 
        /// Documentation https://developers.google.com/deploymentmanagerv2beta/v2beta/reference/deployments/cancelPreview
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Deploymentmanagerv2beta service.</param>  
        /// <param name="project">The project ID for this request.</param>
        /// <param name="deployment">The name of the deployment for this request.</param>
        /// <param name="body">A valid Deploymentmanagerv2beta v2beta body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation CancelPreview(Deploymentmanagerv2betaService service, string project, string deployment, DeploymentsCancelPreviewRequest body)
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
                if (deployment == null)
                    throw new ArgumentNullException(deployment);

                // Make the request.
                return service.Deployments.CancelPreview(body, project, deployment).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Deployments.CancelPreview failed.", ex);
            }
        }
        public class DeploymentsDeleteOptionalParms
        {
            /// Sets the policy to use for deleting resources.
            public string DeletePolicy { get; set; }  
        
        }
 
        /// <summary>
        /// Deletes a deployment and all of the resources in the deployment. 
        /// Documentation https://developers.google.com/deploymentmanagerv2beta/v2beta/reference/deployments/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Deploymentmanagerv2beta service.</param>  
        /// <param name="project">The project ID for this request.</param>
        /// <param name="deployment">The name of the deployment for this request.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Delete(Deploymentmanagerv2betaService service, string project, string deployment, DeploymentsDeleteOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (deployment == null)
                    throw new ArgumentNullException(deployment);

                // Building the initial request.
                var request = service.Deployments.Delete(project, deployment);

                // Applying optional parameters to the request.                
                request = (DeploymentsResource.DeleteRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Deployments.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Gets information about a specific deployment. 
        /// Documentation https://developers.google.com/deploymentmanagerv2beta/v2beta/reference/deployments/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Deploymentmanagerv2beta service.</param>  
        /// <param name="project">The project ID for this request.</param>
        /// <param name="deployment">The name of the deployment for this request.</param>
        /// <returns>DeploymentResponse</returns>
        public static Deployment Get(Deploymentmanagerv2betaService service, string project, string deployment)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (deployment == null)
                    throw new ArgumentNullException(deployment);

                // Make the request.
                return service.Deployments.Get(project, deployment).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Deployments.Get failed.", ex);
            }
        }

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists. 
        /// Documentation https://developers.google.com/deploymentmanagerv2beta/v2beta/reference/deployments/getIamPolicy
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Deploymentmanagerv2beta service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="resource">Name of the resource for this request.</param>
        /// <returns>PolicyResponse</returns>
        public static Policy GetIamPolicy(Deploymentmanagerv2betaService service, string project, string resource)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (resource == null)
                    throw new ArgumentNullException(resource);

                // Make the request.
                return service.Deployments.GetIamPolicy(project, resource).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Deployments.GetIamPolicy failed.", ex);
            }
        }
        public class DeploymentsInsertOptionalParms
        {
            /// If set to true, creates a deployment and creates "shell" resources but does not actually instantiate these resources. This allows you to preview what your deployment looks like. After previewing a deployment, you can deploy your resources by making a request with the update() method or you can use the cancelPreview() method to cancel the preview altogether. Note that the deployment will still exist after you cancel the preview and you must separately delete this deployment if you want to remove it.
            public bool? Preview { get; set; }  
        
        }
 
        /// <summary>
        /// Creates a deployment and all of the resources described by the deployment manifest. 
        /// Documentation https://developers.google.com/deploymentmanagerv2beta/v2beta/reference/deployments/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Deploymentmanagerv2beta service.</param>  
        /// <param name="project">The project ID for this request.</param>
        /// <param name="body">A valid Deploymentmanagerv2beta v2beta body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Insert(Deploymentmanagerv2betaService service, string project, Deployment body, DeploymentsInsertOptionalParms optional = null)
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
                var request = service.Deployments.Insert(body, project);

                // Applying optional parameters to the request.                
                request = (DeploymentsResource.InsertRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Deployments.Insert failed.", ex);
            }
        }
        public class DeploymentsListOptionalParms
        {
            /// Sets a filter {expression} for filtering listed resources. Your {expression} must be in the format: field_name comparison_string literal_string.The field_name is the name of the field you want to compare. Only atomic field types are supported (string, number, boolean). The comparison_string must be either eq (equals) or ne (not equals). The literal_string is the string value to filter to. The literal value must be valid for the type of field you are filtering by (string, number, boolean). For string fields, the literal value is interpreted as a regular expression using RE2 syntax. The literal value must match the entire field.For example, to filter for instances that do not have a name of example-instance, you would use name ne example-instance.You can filter on nested fields. For example, you could filter on instances that have set the scheduling.automaticRestart field to true. Use filtering on nested fields to take advantage of labels to organize and search for results based on label values.To filter on multiple expressions, provide each separate expression within parentheses. For example, (scheduling.automaticRestart eq true) (zone eq us-central1-f). Multiple expressions are treated as AND expressions, meaning that resources must match all expressions to pass the filters.
            public string Filter { get; set; }  
            /// The maximum number of results per page that should be returned. If the number of available results is larger than maxResults, Compute Engine returns a nextPageToken that can be used to get the next page of results in subsequent list requests. Acceptable values are 0 to 500, inclusive. (Default: 500)
            public int? MaxResults { get; set; }  
            /// Sorts list results by a certain order. By default, results are returned in alphanumerical order based on the resource name.You can also sort results in descending order based on the creation timestamp using orderBy="creationTimestamp desc". This sorts results based on the creationTimestamp field in reverse chronological order (newest result first). Use this to sort resources like operations so that the newest operation is returned first.Currently, only sorting by name or creationTimestamp desc is supported.
            public string OrderBy { get; set; }  
            /// Specifies a page token to use. Set pageToken to the nextPageToken returned by a previous list request to get the next page of results.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Lists all deployments for a given project. 
        /// Documentation https://developers.google.com/deploymentmanagerv2beta/v2beta/reference/deployments/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Deploymentmanagerv2beta service.</param>  
        /// <param name="project">The project ID for this request.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>DeploymentsListResponseResponse</returns>
        public static DeploymentsListResponse List(Deploymentmanagerv2betaService service, string project, DeploymentsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);

                // Building the initial request.
                var request = service.Deployments.List(project);

                // Applying optional parameters to the request.                
                request = (DeploymentsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Deployments.List failed.", ex);
            }
        }
        public class DeploymentsPatchOptionalParms
        {
            /// Sets the policy to use for creating new resources.
            public string CreatePolicy { get; set; }  
            /// Sets the policy to use for deleting resources.
            public string DeletePolicy { get; set; }  
            /// If set to true, updates the deployment and creates and updates the "shell" resources but does not actually alter or instantiate these resources. This allows you to preview what your deployment will look like. You can use this intent to preview how an update would affect your deployment. You must provide a target.config with a configuration if this is set to true. After previewing a deployment, you can deploy your resources by making a request with the update() or you can cancelPreview() to remove the preview altogether. Note that the deployment will still exist after you cancel the preview and you must separately delete this deployment if you want to remove it.
            public bool? Preview { get; set; }  
        
        }
 
        /// <summary>
        /// Updates a deployment and all of the resources described by the deployment manifest. This method supports patch semantics. 
        /// Documentation https://developers.google.com/deploymentmanagerv2beta/v2beta/reference/deployments/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Deploymentmanagerv2beta service.</param>  
        /// <param name="project">The project ID for this request.</param>
        /// <param name="deployment">The name of the deployment for this request.</param>
        /// <param name="body">A valid Deploymentmanagerv2beta v2beta body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Patch(Deploymentmanagerv2betaService service, string project, string deployment, Deployment body, DeploymentsPatchOptionalParms optional = null)
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
                if (deployment == null)
                    throw new ArgumentNullException(deployment);

                // Building the initial request.
                var request = service.Deployments.Patch(body, project, deployment);

                // Applying optional parameters to the request.                
                request = (DeploymentsResource.PatchRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Deployments.Patch failed.", ex);
            }
        }

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy. 
        /// Documentation https://developers.google.com/deploymentmanagerv2beta/v2beta/reference/deployments/setIamPolicy
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Deploymentmanagerv2beta service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="resource">Name of the resource for this request.</param>
        /// <param name="body">A valid Deploymentmanagerv2beta v2beta body.</param>
        /// <returns>PolicyResponse</returns>
        public static Policy SetIamPolicy(Deploymentmanagerv2betaService service, string project, string resource, Policy body)
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
                if (resource == null)
                    throw new ArgumentNullException(resource);

                // Make the request.
                return service.Deployments.SetIamPolicy(body, project, resource).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Deployments.SetIamPolicy failed.", ex);
            }
        }

        /// <summary>
        /// Stops an ongoing operation. This does not roll back any work that has already been completed, but prevents any new work from being started. 
        /// Documentation https://developers.google.com/deploymentmanagerv2beta/v2beta/reference/deployments/stop
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Deploymentmanagerv2beta service.</param>  
        /// <param name="project">The project ID for this request.</param>
        /// <param name="deployment">The name of the deployment for this request.</param>
        /// <param name="body">A valid Deploymentmanagerv2beta v2beta body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Stop(Deploymentmanagerv2betaService service, string project, string deployment, DeploymentsStopRequest body)
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
                if (deployment == null)
                    throw new ArgumentNullException(deployment);

                // Make the request.
                return service.Deployments.Stop(body, project, deployment).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Deployments.Stop failed.", ex);
            }
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource. 
        /// Documentation https://developers.google.com/deploymentmanagerv2beta/v2beta/reference/deployments/testIamPermissions
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Deploymentmanagerv2beta service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="resource">Name of the resource for this request.</param>
        /// <param name="body">A valid Deploymentmanagerv2beta v2beta body.</param>
        /// <returns>TestPermissionsResponseResponse</returns>
        public static TestPermissionsResponse TestIamPermissions(Deploymentmanagerv2betaService service, string project, string resource, TestPermissionsRequest body)
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
                if (resource == null)
                    throw new ArgumentNullException(resource);

                // Make the request.
                return service.Deployments.TestIamPermissions(body, project, resource).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Deployments.TestIamPermissions failed.", ex);
            }
        }
        public class DeploymentsUpdateOptionalParms
        {
            /// Sets the policy to use for creating new resources.
            public string CreatePolicy { get; set; }  
            /// Sets the policy to use for deleting resources.
            public string DeletePolicy { get; set; }  
            /// If set to true, updates the deployment and creates and updates the "shell" resources but does not actually alter or instantiate these resources. This allows you to preview what your deployment will look like. You can use this intent to preview how an update would affect your deployment. You must provide a target.config with a configuration if this is set to true. After previewing a deployment, you can deploy your resources by making a request with the update() or you can cancelPreview() to remove the preview altogether. Note that the deployment will still exist after you cancel the preview and you must separately delete this deployment if you want to remove it.
            public bool? Preview { get; set; }  
        
        }
 
        /// <summary>
        /// Updates a deployment and all of the resources described by the deployment manifest. 
        /// Documentation https://developers.google.com/deploymentmanagerv2beta/v2beta/reference/deployments/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Deploymentmanagerv2beta service.</param>  
        /// <param name="project">The project ID for this request.</param>
        /// <param name="deployment">The name of the deployment for this request.</param>
        /// <param name="body">A valid Deploymentmanagerv2beta v2beta body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Update(Deploymentmanagerv2betaService service, string project, string deployment, Deployment body, DeploymentsUpdateOptionalParms optional = null)
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
                if (deployment == null)
                    throw new ArgumentNullException(deployment);

                // Building the initial request.
                var request = service.Deployments.Update(body, project, deployment);

                // Applying optional parameters to the request.                
                request = (DeploymentsResource.UpdateRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Deployments.Update failed.", ex);
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