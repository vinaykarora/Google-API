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
// Unoffical sample for the Blogger v3 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: API for access to the data within Blogger.
// API Documentation Link https://developers.google.com/blogger/docs/3.0/getting_started
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Blogger/v3/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Blogger.v3/ 
// Install Command: PM>  Install-Package Google.Apis.Blogger.v3
//
//------------------------------------------------------------------------------  
using Google.Apis.Blogger.v3;
using Google.Apis.Blogger.v3.Data;
using System;

namespace GoogleSamplecSharpSample.Bloggerv3.Methods
{
  
    public static class CommentsSample
    {


        /// <summary>
        /// Marks a comment as not spam. 
        /// Documentation https://developers.google.com/blogger/v3/reference/comments/approve
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Blogger service.</param>  
        /// <param name="blogId">The ID of the Blog.</param>
        /// <param name="postId">The ID of the Post.</param>
        /// <param name="commentId">The ID of the comment to mark as not spam.</param>
        /// <returns>CommentResponse</returns>
        public static Comment Approve(BloggerService service, string blogId, string postId, string commentId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (blogId == null)
                    throw new ArgumentNullException(blogId);
                if (postId == null)
                    throw new ArgumentNullException(postId);
                if (commentId == null)
                    throw new ArgumentNullException(commentId);

                // Make the request.
                return service.Comments.Approve(blogId, postId, commentId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Comments.Approve failed.", ex);
            }
        }

        /// <summary>
        /// Delete a comment by ID. 
        /// Documentation https://developers.google.com/blogger/v3/reference/comments/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Blogger service.</param>  
        /// <param name="blogId">The ID of the Blog.</param>
        /// <param name="postId">The ID of the Post.</param>
        /// <param name="commentId">The ID of the comment to delete.</param>
        public static void Delete(BloggerService service, string blogId, string postId, string commentId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (blogId == null)
                    throw new ArgumentNullException(blogId);
                if (postId == null)
                    throw new ArgumentNullException(postId);
                if (commentId == null)
                    throw new ArgumentNullException(commentId);

                // Make the request.
                 service.Comments.Delete(blogId, postId, commentId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Comments.Delete failed.", ex);
            }
        }
        public class CommentsGetOptionalParms
        {
            /// Access level for the requested comment (default: READER). Note that some comments will require elevated permissions, for example comments where the parent posts which is in a draft state, or comments that are pending moderation.
            public string View { get; set; }  
        
        }
 
        /// <summary>
        /// Gets one comment by ID. 
        /// Documentation https://developers.google.com/blogger/v3/reference/comments/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Blogger service.</param>  
        /// <param name="blogId">ID of the blog to containing the comment.</param>
        /// <param name="postId">ID of the post to fetch posts from.</param>
        /// <param name="commentId">The ID of the comment to get.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>CommentResponse</returns>
        public static Comment Get(BloggerService service, string blogId, string postId, string commentId, CommentsGetOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (blogId == null)
                    throw new ArgumentNullException(blogId);
                if (postId == null)
                    throw new ArgumentNullException(postId);
                if (commentId == null)
                    throw new ArgumentNullException(commentId);

                // Building the initial request.
                var request = service.Comments.Get(blogId, postId, commentId);

                // Applying optional parameters to the request.                
                request = (CommentsResource.GetRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Comments.Get failed.", ex);
            }
        }
        public class CommentsListOptionalParms
        {
            /// Latest date of comment to fetch, a date-time with RFC 3339 formatting.
            public string EndDate { get; set; }  
            /// Whether the body content of the comments is included.
            public bool? FetchBodies { get; set; }  
            /// Maximum number of comments to include in the result.
            public int? MaxResults { get; set; }  
            /// Continuation token if request is paged.
            public string PageToken { get; set; }  
            /// Earliest date of comment to fetch, a date-time with RFC 3339 formatting.
            public string StartDate { get; set; }  
            /// NA
            public string Status { get; set; }  
            /// Access level with which to view the returned result. Note that some fields require elevated access.
            public string View { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves the comments for a post, possibly filtered. 
        /// Documentation https://developers.google.com/blogger/v3/reference/comments/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Blogger service.</param>  
        /// <param name="blogId">ID of the blog to fetch comments from.</param>
        /// <param name="postId">ID of the post to fetch posts from.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>CommentListResponse</returns>
        public static CommentList List(BloggerService service, string blogId, string postId, CommentsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (blogId == null)
                    throw new ArgumentNullException(blogId);
                if (postId == null)
                    throw new ArgumentNullException(postId);

                // Building the initial request.
                var request = service.Comments.List(blogId, postId);

                // Applying optional parameters to the request.                
                request = (CommentsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Comments.List failed.", ex);
            }
        }
        public class CommentsListByBlogOptionalParms
        {
            /// Latest date of comment to fetch, a date-time with RFC 3339 formatting.
            public string EndDate { get; set; }  
            /// Whether the body content of the comments is included.
            public bool? FetchBodies { get; set; }  
            /// Maximum number of comments to include in the result.
            public int? MaxResults { get; set; }  
            /// Continuation token if request is paged.
            public string PageToken { get; set; }  
            /// Earliest date of comment to fetch, a date-time with RFC 3339 formatting.
            public string StartDate { get; set; }  
            /// NA
            public string Status { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves the comments for a blog, across all posts, possibly filtered. 
        /// Documentation https://developers.google.com/blogger/v3/reference/comments/listByBlog
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Blogger service.</param>  
        /// <param name="blogId">ID of the blog to fetch comments from.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>CommentListResponse</returns>
        public static CommentList ListByBlog(BloggerService service, string blogId, CommentsListByBlogOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (blogId == null)
                    throw new ArgumentNullException(blogId);

                // Building the initial request.
                var request = service.Comments.ListByBlog(blogId);

                // Applying optional parameters to the request.                
                request = (CommentsResource.ListByBlogRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Comments.ListByBlog failed.", ex);
            }
        }

        /// <summary>
        /// Marks a comment as spam. 
        /// Documentation https://developers.google.com/blogger/v3/reference/comments/markAsSpam
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Blogger service.</param>  
        /// <param name="blogId">The ID of the Blog.</param>
        /// <param name="postId">The ID of the Post.</param>
        /// <param name="commentId">The ID of the comment to mark as spam.</param>
        /// <returns>CommentResponse</returns>
        public static Comment MarkAsSpam(BloggerService service, string blogId, string postId, string commentId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (blogId == null)
                    throw new ArgumentNullException(blogId);
                if (postId == null)
                    throw new ArgumentNullException(postId);
                if (commentId == null)
                    throw new ArgumentNullException(commentId);

                // Make the request.
                return service.Comments.MarkAsSpam(blogId, postId, commentId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Comments.MarkAsSpam failed.", ex);
            }
        }

        /// <summary>
        /// Removes the content of a comment. 
        /// Documentation https://developers.google.com/blogger/v3/reference/comments/removeContent
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Blogger service.</param>  
        /// <param name="blogId">The ID of the Blog.</param>
        /// <param name="postId">The ID of the Post.</param>
        /// <param name="commentId">The ID of the comment to delete content from.</param>
        /// <returns>CommentResponse</returns>
        public static Comment RemoveContent(BloggerService service, string blogId, string postId, string commentId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (blogId == null)
                    throw new ArgumentNullException(blogId);
                if (postId == null)
                    throw new ArgumentNullException(postId);
                if (commentId == null)
                    throw new ArgumentNullException(commentId);

                // Make the request.
                return service.Comments.RemoveContent(blogId, postId, commentId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Comments.RemoveContent failed.", ex);
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