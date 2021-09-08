using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreAdvanced_App.Extensions
{
    public static class IdentityExtensions
    {
        public static string GetSpecificClaim(this ClaimsPrincipal claimsPrincipal, string claimsType)
        {
            var claim = claimsPrincipal.Claims.FirstOrDefault(_ => _.Type == claimsType);
            return (claim != null) ? claim.Value : string.Empty;
        }
    }
}
