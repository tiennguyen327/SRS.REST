using System.Linq;
using Microsoft.Owin.Host.SystemWeb;
using System.Web;
using Microsoft.Owin;
using System;

namespace SRS.REST.App_Start
{

    public static class OwinContextExtensions
    {
        public static int GetClientID()
        {
            int result = 0;
            
            var claim = HttpContext.Current.GetOwinContext().Authentication.User.Claims.FirstOrDefault(c => c.Type == "ClientID");
            if (claim != null)
            {
                result = Convert.ToInt32(claim.Value);
            }
            return result;
        }

        public static IOwinContext CurrentContext
        {
            get
            {
                //Microsoft.Owin.Host.SystemWeb
                //Microsoft.Owin
                return  HttpContext.Current.GetOwinContext();

            }
        }
    }
}