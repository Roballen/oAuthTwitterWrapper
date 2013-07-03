using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using OAuthTwitterWrapper;
using oAuthTwitterWrapper;
using oAuthTwitterWrapper.Configuration;

namespace WebFormsApplication
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static string GetTwitterFeed()
        {
            var oAuth = new OAuthConfiguration()
            {
                ConsumerToken = "GPdZTjmPRVXP2cgYgjMQ",
                ConsumerSecret = "LDh41edDBODdRXrvfAjaK5niYGjiaLilaSPDPYOH6LI"
            };
            var twitconfig = new TwitterConfiguration()
            {
                ScreenName = "freshupdates"
            };
            var oAuthTwitterWrapper = new OAuthTwitterWrapper.OAuthTwitterWrapper(oAuth,twitconfig);
			return oAuthTwitterWrapper.GetMyTimeline();
        }
    }
}