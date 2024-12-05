using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;



namespace ThemeIntegration.Helpers.Helper
{
    da
    public class SessionHelper
    {
        public static string Password
        {
            get
            {
                return HttpContext.Current.Session["Password"] == null ? "" : (string)HttpContext.Current.Session["Password"];
            }
            set { HttpContext.Current.Session["Password"] = value; }
        }
        public static string EmailAddress
        {
            get
            {
                return HttpContext.Current.Session["EmailAddress"] == null ? "" : (string)HttpContext.Current.Session["EmailAddress"];



            }
            set { HttpContext.Current.Session["EmailAddress"] = value; }
        }
    }
}