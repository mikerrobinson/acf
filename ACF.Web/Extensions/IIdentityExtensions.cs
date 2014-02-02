using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using ACF.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace ACF.Web.Extensions
{
    public static class IIdentityExtensions
    {
        /// <summary>
        /// Returns a formatted first and last name for the current identity, defaulting to username if both are emtpy
        /// </summary>
        public static string GetDisplayName(this IIdentity identity)
        {
            UserManager<ApplicationUser> userManager = new UserManager<Models.ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
            var user = userManager.FindById(identity.GetUserId());
            if (user != null)
            {
                var name = String.Format("{0} {1}", user.FirstName, user.LastName).Trim();
                if (String.IsNullOrEmpty(name))
                {
                    return user.UserName;
                }
                else
                {
                    return name;
                }
            }
            else
            {
                return "";
            }
        }
    }
}