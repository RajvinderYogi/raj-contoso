using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

//add refernces for asp.net identity
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security.Cookies;

[assembly: OwinStartup(typeof(week6.Startup))]

namespace week6
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //set up cookie configuration to track authenticated users
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/login.aspx")
            });
        }
    }
}
