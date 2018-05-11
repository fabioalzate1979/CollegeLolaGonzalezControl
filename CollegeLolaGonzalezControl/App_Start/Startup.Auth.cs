using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using System.Configuration;

namespace CollegeLolaGonzalezControl
{
    public partial class Startup
    {
        public void ConfigureAuthentication(IAppBuilder app)
        {
            int authenticationTimeout = 20;

            //int.TryParse(ConfigurationManager.AppSettings["AgileCode.SociaBPO.CommercialCRM.UI.Web.AuthenticationTimeout"], out authenticationTimeout);

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Security/Login"),
                SlidingExpiration = true,
                ExpireTimeSpan = new TimeSpan(0, authenticationTimeout, 0)
            });
        }
    }
}