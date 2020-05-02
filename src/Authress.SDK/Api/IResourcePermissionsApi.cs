using System;
using System.Collections.Generic;
using System.Net.Http;
using Authress.SDK;
using Authress.SDK.DTO;

namespace Authress.SDK.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IResourcePermissionsApi
    {
        /// <summary>
        /// List resource configurations Permissions can be set globally at a resource level. Lists any resources with a globally set resource policy
        /// </summary>
        /// <returns>ResourcePermissionCollection</returns>
        ResourcePermissionCollection V1ResourcesGet ();
        /// <summary>
        /// Get a resource permissions object. Permissions can be set globally at a resource level. This will apply to all users in an account.
        /// </summary>
        /// <param name="resourceUri">The uri path of a resource to validate, must be URL encoded, uri segments are allowed.</param>
        /// <returns>ResourcePermission</returns>
        ResourcePermission V1ResourcesResourceUriGet (string resourceUri);
        /// <summary>
        /// Update a resource permissions object. Updates the global permissions on a resource. This applies to all users in an account.
        /// </summary>
        /// <param name="body">The contents of the permission to set on the resource. Overwrites existing data.</param>
        /// <param name="resourceUri">The uri path of a resource to validate, must be URL encoded, uri segments are allowed.</param>
        /// <returns>Object</returns>
        Object V1ResourcesResourceUriPut (ResourcePermission body, string resourceUri);
    }
}
