using System;
using System.Configuration;
using System.Threading.Tasks;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;
//using OwinExtensions;

using Microsoft.AspNet.Identity.Owin;

[assembly: OwinStartup(typeof(SRS.REST.App_Start.Startup))]

namespace SRS.REST.App_Start
{
    public class General
    {
        public double AccessTokenExpiryDays = 10;
        public static bool UseHttp
        {
            get
            {
                if (ConfigurationManager.AppSettings["UseHttp"] != null)
                {
                    return Convert.ToBoolean(ConfigurationManager.AppSettings["UseHttp"]);
                }
                else return false;
            }
        }
    }
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           // ConfigureAuth(app);

            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
        }

        public static OAuthAuthorizationServerOptions OAuthOptions { get; private set; }

        static Startup()
        {
            

            OAuthOptions = new OAuthAuthorizationServerOptions
            {
                TokenEndpointPath = new PathString("/api/user"), // TODO
                Provider = new OAuthAppProvider(),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(30),
                AllowInsecureHttp = General.UseHttp
            }; // General.AccessTokenExpiryDays),

        }

        public void ConfigureAuth(IAppBuilder app)
        {
            
            app.UseOAuthBearerTokens(OAuthOptions);
        }
      
    }
}
