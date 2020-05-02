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
    public interface IUserPermissionsApi
    {
        /// <summary>
        /// Get the permissions a user has to a resource. Get a summary of the permissions a user has to a particular resource.
        /// </summary>
        /// <param name="userId">The user to check permissions on</param>
        /// <param name="resourceUri">The uri path of a resource to validate, must be URL encoded, uri segments are allowed.</param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 V1UsersUserIdResourcesResourceUriPermissionsGet (string userId, string resourceUri);
        /// <summary>
        /// Check to see if a user has permissions to a resource. Does the user have the specified permissions to the resource?
        /// </summary>
        /// <param name="userId">The user to check permissions on</param>
        /// <param name="resourceUri">The uri path of a resource to validate, must be URL encoded, uri segments are allowed, the resource must be a full path, and permissions are not inhereted by sub resources.</param>
        /// <param name="permission">Permission to check, &#x27;*&#x27; and scoped permissions can also be checked here.</param>
        /// <returns>Object</returns>
        Object V1UsersUserIdResourcesResourceUriPermissionsPermissionGet (string userId, string resourceUri, string permission);
    }
}
