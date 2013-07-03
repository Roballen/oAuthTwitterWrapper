using System;
using oAuthTwitterWrapper;
using oAuthTwitterWrapper.Configuration;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            var oAuth = new OAuthConfiguration()
                            {
                                ConsumerToken = "GPdZTjmPRVXP2cgYgjMQ",
                                ConsumerSecret = "LDh41edDBODdRXrvfAjaK5niYGjiaLilaSPDPYOH6LI",
                                AuthUrl = "https://api.twitter.com/oauth2/token"
                            };
            var twitconfig = new TwitterConfiguration()
                                 {
                                     ScreenName = "freshupdates"
                                 };

            var oAuthTwitterWrapper = new OAuthTwitterWrapper.OAuthTwitterWrapper(oAuth,twitconfig);
			Console.Write("**** Time Line *****\n");
			Console.Write(oAuthTwitterWrapper.GetMyTimeline() + "\n\n");
			Console.Write("**** Search *****\n");
			Console.Write(oAuthTwitterWrapper.GetSearch() + "\n\n");
            Console.ReadLine();
        }
    }
}
