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
// Unoffical sample for the Sqladmin v1beta4 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Creates and configures Cloud SQL instances, which provide fully-managed MySQL databases.
// API Documentation Link https://cloud.google.com/sql/docs/reference/latest
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Sqladmin/v1beta4/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Sqladmin.v1beta4/ 
// Install Command: PM>  Install-Package Google.Apis.Sqladmin.v1beta4
//
//------------------------------------------------------------------------------  
using Google.Apis.Sqladmin.v1beta4;
using Google.Apis.Sqladmin.v1beta4.Data;
using System;

namespace GoogleSamplecSharpSample.Sqladminv1beta4.Methods
{
  
    public static class InstancesSample
    {


        /// <summary>
        /// Creates a Cloud SQL instance as a clone of the source instance. The API is not ready for Second Generation instances yet. 
        /// Documentation https://developers.google.com/sqladmin/v1beta4/reference/instances/clone
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Sqladmin service.</param>  
        /// <param name="project">Project ID of the source as well as the clone Cloud SQL instance.</param>
        /// <param name="instance">The ID of the Cloud SQL instance to be cloned (source). This does not include the project ID.</param>
        /// <param name="body">A valid Sqladmin v1beta4 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Clone(SqladminService service, string project, string instance, InstancesCloneRequest body)
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
                if (instance == null)
                    throw new ArgumentNullException(instance);

                // Make the request.
                return service.Instances.Clone(body, project, instance).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Instances.Clone failed.", ex);
            }
        }

        /// <summary>
        /// Deletes a Cloud SQL instance. 
        /// Documentation https://developers.google.com/sqladmin/v1beta4/reference/instances/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Sqladmin service.</param>  
        /// <param name="project">Project ID of the project that contains the instance to be deleted.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Delete(SqladminService service, string project, string instance)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (instance == null)
                    throw new ArgumentNullException(instance);

                // Make the request.
                return service.Instances.Delete(project, instance).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Instances.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Exports data from a Cloud SQL instance to a Google Cloud Storage bucket as a MySQL dump file. 
        /// Documentation https://developers.google.com/sqladmin/v1beta4/reference/instances/export
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Sqladmin service.</param>  
        /// <param name="project">Project ID of the project that contains the instance to be exported.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        /// <param name="body">A valid Sqladmin v1beta4 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Export(SqladminService service, string project, string instance, InstancesExportRequest body)
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
                if (instance == null)
                    throw new ArgumentNullException(instance);

                // Make the request.
                return service.Instances.Export(body, project, instance).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Instances.Export failed.", ex);
            }
        }

        /// <summary>
        /// Failover the instance to its failover replica instance. 
        /// Documentation https://developers.google.com/sqladmin/v1beta4/reference/instances/failover
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Sqladmin service.</param>  
        /// <param name="project">ID of the project that contains the read replica.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        /// <param name="body">A valid Sqladmin v1beta4 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Failover(SqladminService service, string project, string instance, InstancesFailoverRequest body)
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
                if (instance == null)
                    throw new ArgumentNullException(instance);

                // Make the request.
                return service.Instances.Failover(body, project, instance).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Instances.Failover failed.", ex);
            }
        }

        /// <summary>
        /// Retrieves a resource containing information about a Cloud SQL instance. 
        /// Documentation https://developers.google.com/sqladmin/v1beta4/reference/instances/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Sqladmin service.</param>  
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Database instance ID. This does not include the project ID.</param>
        /// <returns>DatabaseInstanceResponse</returns>
        public static DatabaseInstance Get(SqladminService service, string project, string instance)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (instance == null)
                    throw new ArgumentNullException(instance);

                // Make the request.
                return service.Instances.Get(project, instance).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Instances.Get failed.", ex);
            }
        }

        /// <summary>
        /// Imports data into a Cloud SQL instance from a MySQL dump file in Google Cloud Storage. 
        /// Documentation https://developers.google.com/sqladmin/v1beta4/reference/instances/import
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Sqladmin service.</param>  
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        /// <param name="body">A valid Sqladmin v1beta4 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Import(SqladminService service, string project, string instance, InstancesImportRequest body)
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
                if (instance == null)
                    throw new ArgumentNullException(instance);

                // Make the request.
                return service.Instances.Import(body, project, instance).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Instances.Import failed.", ex);
            }
        }

        /// <summary>
        /// Creates a new Cloud SQL instance. 
        /// Documentation https://developers.google.com/sqladmin/v1beta4/reference/instances/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Sqladmin service.</param>  
        /// <param name="project">Project ID of the project to which the newly created Cloud SQL instances should belong.</param>
        /// <param name="body">A valid Sqladmin v1beta4 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Insert(SqladminService service, string project, DatabaseInstance body)
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

                // Make the request.
                return service.Instances.Insert(body, project).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Instances.Insert failed.", ex);
            }
        }
        public class InstancesListOptionalParms
        {
            /// An expression for filtering the results of the request, such as by name or label.
            public string Filter { get; set; }  
            /// The maximum number of results to return per response.
            public int? MaxResults { get; set; }  
            /// A previously-returned page token representing part of the larger set of results to view.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Lists instances under a given project in the alphabetical order of the instance name. 
        /// Documentation https://developers.google.com/sqladmin/v1beta4/reference/instances/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Sqladmin service.</param>  
        /// <param name="project">Project ID of the project for which to list Cloud SQL instances.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>InstancesListResponseResponse</returns>
        public static InstancesListResponse List(SqladminService service, string project, InstancesListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);

                // Building the initial request.
                var request = service.Instances.List(project);

                // Applying optional parameters to the request.                
                request = (InstancesResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Instances.List failed.", ex);
            }
        }

        /// <summary>
        /// Updates settings of a Cloud SQL instance. Caution: This is not a partial update, so you must include values for all the settings that you want to retain. For partial updates, use patch.. This method supports patch semantics. 
        /// Documentation https://developers.google.com/sqladmin/v1beta4/reference/instances/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Sqladmin service.</param>  
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        /// <param name="body">A valid Sqladmin v1beta4 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Patch(SqladminService service, string project, string instance, DatabaseInstance body)
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
                if (instance == null)
                    throw new ArgumentNullException(instance);

                // Make the request.
                return service.Instances.Patch(body, project, instance).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Instances.Patch failed.", ex);
            }
        }

        /// <summary>
        /// Promotes the read replica instance to be a stand-alone Cloud SQL instance. 
        /// Documentation https://developers.google.com/sqladmin/v1beta4/reference/instances/promoteReplica
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Sqladmin service.</param>  
        /// <param name="project">ID of the project that contains the read replica.</param>
        /// <param name="instance">Cloud SQL read replica instance name.</param>
        /// <returns>OperationResponse</returns>
        public static Operation PromoteReplica(SqladminService service, string project, string instance)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (instance == null)
                    throw new ArgumentNullException(instance);

                // Make the request.
                return service.Instances.PromoteReplica(project, instance).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Instances.PromoteReplica failed.", ex);
            }
        }

        /// <summary>
        /// Deletes all client certificates and generates a new server SSL certificate for the instance. The changes will not take effect until the instance is restarted. Existing instances without a server certificate will need to call this once to set a server certificate. 
        /// Documentation https://developers.google.com/sqladmin/v1beta4/reference/instances/resetSslConfig
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Sqladmin service.</param>  
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        /// <returns>OperationResponse</returns>
        public static Operation ResetSslConfig(SqladminService service, string project, string instance)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (instance == null)
                    throw new ArgumentNullException(instance);

                // Make the request.
                return service.Instances.ResetSslConfig(project, instance).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Instances.ResetSslConfig failed.", ex);
            }
        }

        /// <summary>
        /// Restarts a Cloud SQL instance. 
        /// Documentation https://developers.google.com/sqladmin/v1beta4/reference/instances/restart
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Sqladmin service.</param>  
        /// <param name="project">Project ID of the project that contains the instance to be restarted.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Restart(SqladminService service, string project, string instance)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (instance == null)
                    throw new ArgumentNullException(instance);

                // Make the request.
                return service.Instances.Restart(project, instance).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Instances.Restart failed.", ex);
            }
        }

        /// <summary>
        /// Restores a backup of a Cloud SQL instance. 
        /// Documentation https://developers.google.com/sqladmin/v1beta4/reference/instances/restoreBackup
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Sqladmin service.</param>  
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        /// <param name="body">A valid Sqladmin v1beta4 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation RestoreBackup(SqladminService service, string project, string instance, InstancesRestoreBackupRequest body)
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
                if (instance == null)
                    throw new ArgumentNullException(instance);

                // Make the request.
                return service.Instances.RestoreBackup(body, project, instance).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Instances.RestoreBackup failed.", ex);
            }
        }

        /// <summary>
        /// Starts the replication in the read replica instance. 
        /// Documentation https://developers.google.com/sqladmin/v1beta4/reference/instances/startReplica
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Sqladmin service.</param>  
        /// <param name="project">ID of the project that contains the read replica.</param>
        /// <param name="instance">Cloud SQL read replica instance name.</param>
        /// <returns>OperationResponse</returns>
        public static Operation StartReplica(SqladminService service, string project, string instance)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (instance == null)
                    throw new ArgumentNullException(instance);

                // Make the request.
                return service.Instances.StartReplica(project, instance).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Instances.StartReplica failed.", ex);
            }
        }

        /// <summary>
        /// Stops the replication in the read replica instance. 
        /// Documentation https://developers.google.com/sqladmin/v1beta4/reference/instances/stopReplica
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Sqladmin service.</param>  
        /// <param name="project">ID of the project that contains the read replica.</param>
        /// <param name="instance">Cloud SQL read replica instance name.</param>
        /// <returns>OperationResponse</returns>
        public static Operation StopReplica(SqladminService service, string project, string instance)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (instance == null)
                    throw new ArgumentNullException(instance);

                // Make the request.
                return service.Instances.StopReplica(project, instance).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Instances.StopReplica failed.", ex);
            }
        }

        /// <summary>
        /// Truncate MySQL general and slow query log tables 
        /// Documentation https://developers.google.com/sqladmin/v1beta4/reference/instances/truncateLog
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Sqladmin service.</param>  
        /// <param name="project">Project ID of the Cloud SQL project.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        /// <param name="body">A valid Sqladmin v1beta4 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation TruncateLog(SqladminService service, string project, string instance, InstancesTruncateLogRequest body)
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
                if (instance == null)
                    throw new ArgumentNullException(instance);

                // Make the request.
                return service.Instances.TruncateLog(body, project, instance).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Instances.TruncateLog failed.", ex);
            }
        }

        /// <summary>
        /// Updates settings of a Cloud SQL instance. Caution: This is not a partial update, so you must include values for all the settings that you want to retain. For partial updates, use patch. 
        /// Documentation https://developers.google.com/sqladmin/v1beta4/reference/instances/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Sqladmin service.</param>  
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        /// <param name="body">A valid Sqladmin v1beta4 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Update(SqladminService service, string project, string instance, DatabaseInstance body)
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
                if (instance == null)
                    throw new ArgumentNullException(instance);

                // Make the request.
                return service.Instances.Update(body, project, instance).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Instances.Update failed.", ex);
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