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
// Unoffical sample for the Bigquery v2 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: A data platform for customers to create, manage, share and query data.
// API Documentation Link https://cloud.google.com/bigquery/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Bigquery/v2/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Bigquery.v2/ 
// Install Command: PM>  Install-Package Google.Apis.Bigquery.v2
//
//------------------------------------------------------------------------------  
using Google.Apis.Bigquery.v2;
using Google.Apis.Bigquery.v2.Data;
using System;

namespace GoogleSamplecSharpSample.Bigqueryv2.Methods
{
  
    public static class JobsSample
    {


        /// <summary>
        /// Requests that a job be cancelled. This call will return immediately, and the client will need to poll for the job status to see if the cancel completed successfully. Cancelled jobs may still incur costs. 
        /// Documentation https://developers.google.com/bigquery/v2/reference/jobs/cancel
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Bigquery service.</param>  
        /// <param name="projectId">[Required] Project ID of the job to cancel</param>
        /// <param name="jobId">[Required] Job ID of the job to cancel</param>
        /// <returns>JobCancelResponseResponse</returns>
        public static JobCancelResponse Cancel(BigqueryService service, string projectId, string jobId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (projectId == null)
                    throw new ArgumentNullException(projectId);
                if (jobId == null)
                    throw new ArgumentNullException(jobId);

                // Make the request.
                return service.Jobs.Cancel(projectId, jobId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Jobs.Cancel failed.", ex);
            }
        }

        /// <summary>
        /// Returns information about a specific job. Job information is available for a six month period after creation. Requires that you're the person who ran the job, or have the Is Owner project role. 
        /// Documentation https://developers.google.com/bigquery/v2/reference/jobs/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Bigquery service.</param>  
        /// <param name="projectId">[Required] Project ID of the requested job</param>
        /// <param name="jobId">[Required] Job ID of the requested job</param>
        /// <returns>JobResponse</returns>
        public static Job Get(BigqueryService service, string projectId, string jobId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (projectId == null)
                    throw new ArgumentNullException(projectId);
                if (jobId == null)
                    throw new ArgumentNullException(jobId);

                // Make the request.
                return service.Jobs.Get(projectId, jobId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Jobs.Get failed.", ex);
            }
        }
        public class JobsGetQueryResultsOptionalParms
        {
            /// Maximum number of results to read
            public int? MaxResults { get; set; }  
            /// Page token, returned by a previous call, to request the next page of results
            public string PageToken { get; set; }  
            /// Zero-based index of the starting row
            public string StartIndex { get; set; }  
            /// How long to wait for the query to complete, in milliseconds, before returning. Default is 10 seconds. If the timeout passes before the job completes, the 'jobComplete' field in the response will be false
            public int? TimeoutMs { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves the results of a query job. 
        /// Documentation https://developers.google.com/bigquery/v2/reference/jobs/getQueryResults
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Bigquery service.</param>  
        /// <param name="projectId">[Required] Project ID of the query job</param>
        /// <param name="jobId">[Required] Job ID of the query job</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>GetQueryResultsResponseResponse</returns>
        public static GetQueryResultsResponse GetQueryResults(BigqueryService service, string projectId, string jobId, JobsGetQueryResultsOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (projectId == null)
                    throw new ArgumentNullException(projectId);
                if (jobId == null)
                    throw new ArgumentNullException(jobId);

                // Building the initial request.
                var request = service.Jobs.GetQueryResults(projectId, jobId);

                // Applying optional parameters to the request.                
                request = (JobsResource.GetQueryResultsRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Jobs.GetQueryResults failed.", ex);
            }
        }

        /// <summary>
        /// Starts a new asynchronous job. Requires the Can View project role. 
        /// Documentation https://developers.google.com/bigquery/v2/reference/jobs/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Bigquery service.</param>  
        /// <param name="projectId">Project ID of the project that will be billed for the job</param>
        /// <param name="body">A valid Bigquery v2 body.</param>
        /// <returns>JobResponse</returns>
        public static Job Insert(BigqueryService service, string projectId, Job body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (projectId == null)
                    throw new ArgumentNullException(projectId);

                // Make the request.
                return service.Jobs.Insert(body, projectId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Jobs.Insert failed.", ex);
            }
        }
        public class JobsListOptionalParms
        {
            /// Whether to display jobs owned by all users in the project. Default false
            public bool? AllUsers { get; set; }  
            /// Maximum number of results to return
            public int? MaxResults { get; set; }  
            /// Page token, returned by a previous call, to request the next page of results
            public string PageToken { get; set; }  
            /// Restrict information returned to a set of selected fields
            public string Projection { get; set; }  
            /// Filter for job state
            public string StateFilter { get; set; }  
        
        }
 
        /// <summary>
        /// Lists all jobs that you started in the specified project. Job information is available for a six month period after creation. The job list is sorted in reverse chronological order, by job creation time. Requires the Can View project role, or the Is Owner project role if you set the allUsers property. 
        /// Documentation https://developers.google.com/bigquery/v2/reference/jobs/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Bigquery service.</param>  
        /// <param name="projectId">Project ID of the jobs to list</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>JobListResponse</returns>
        public static JobList List(BigqueryService service, string projectId, JobsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (projectId == null)
                    throw new ArgumentNullException(projectId);

                // Building the initial request.
                var request = service.Jobs.List(projectId);

                // Applying optional parameters to the request.                
                request = (JobsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Jobs.List failed.", ex);
            }
        }

        /// <summary>
        /// Runs a BigQuery SQL query synchronously and returns query results if the query completes within a specified timeout. 
        /// Documentation https://developers.google.com/bigquery/v2/reference/jobs/query
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Bigquery service.</param>  
        /// <param name="projectId">Project ID of the project billed for the query</param>
        /// <param name="body">A valid Bigquery v2 body.</param>
        /// <returns>QueryResponseResponse</returns>
        public static QueryResponse Query(BigqueryService service, string projectId, QueryRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (projectId == null)
                    throw new ArgumentNullException(projectId);

                // Make the request.
                return service.Jobs.Query(body, projectId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Jobs.Query failed.", ex);
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