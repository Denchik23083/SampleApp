using System.Security.Claims;
using AuthSample.Core;
using Microsoft.AspNetCore.Mvc;

namespace AuthSample.Web.Utilities
{
    public class RequirePermissionAttribute : TypeFilterAttribute
    {
        public RequirePermissionAttribute(PermissionType permissionType) : base(typeof(RequireClaimFilter))
        {
            Arguments = new object[] { new Claim("permission", permissionType.ToString()), };
        }
    }
}
