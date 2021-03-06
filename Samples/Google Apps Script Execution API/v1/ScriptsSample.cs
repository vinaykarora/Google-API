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
// Unoffical sample for the Script v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: An API for managing and executing Google Apps Script projects.
// API Documentation Link https://developers.google.com/apps-script/execution/rest/v1/scripts/run
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Script/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Script.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Script.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Script.v1;
using Google.Apis.Script.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Scriptv1.Methods
{
  
    public static class ScriptsSample
    {


        /// <summary>
        /// Runs a function in an Apps Script project. The project must be deployedfor use with the Apps Script Execution API.This method requires authorization with an OAuth 2.0 token that includes atleast one of the scopes listed in the [Authorization](#authorization)section; script projects that do not require authorization cannot beexecuted through this API. To find the correct scopes to include in theauthentication token, open the project in the script editor, then select**File > Project properties** and click the **Scopes** tab. 
        /// Documentation https://developers.google.com/script/v1/reference/scripts/run
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Script service.</param>  
        /// <param name="scriptId">The script ID of the script to be executed. To find the script ID, openthe project in the script editor and select **File > Project properties**.</param>
        /// <param name="body">A valid Script v1 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Run(ScriptService service, string scriptId, ExecutionRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (scriptId == null)
                    throw new ArgumentNullException(scriptId);

                // Make the request.
                return service.Scripts.Run(body, scriptId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Scripts.Run failed.", ex);
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