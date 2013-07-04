using oAuthTwitterWrapper;
using oAuthTwitterWrapper.Configuration;

namespace OAuthTwitterWrapper
{
    public interface IOAuthTwitterWrapper
    {
        string GetMyTimeline();
        string GetSearch();
        string GetStatusList();
    }

    public class OAuthTwitterWrapper : IOAuthTwitterWrapper
    {
        private IOAuthConfiguration _authConfig;
        private ITwitterConfiguration _twitConfig;
        public OAuthTwitterWrapper(IOAuthConfiguration authConfig, ITwitterConfiguration twitConfig)
        {
            _authConfig = authConfig;
            _twitConfig = twitConfig;
        }

        public string GetMyTimeline()
        {
            return MakeRequest(_twitConfig.TimelineUrl);
        }

		public string GetSearch()
		{
		    return MakeRequest(_twitConfig.SearchUrl);
		}

        public string GetStatusList()
        {
            return MakeRequest(_twitConfig.StatusListUrl);
        }

        private TwitAuthenticateResponse Authenticate()
        {
            var authenticate = new Authenticate();
            return authenticate.AuthenticateMe(_authConfig.ConsumerToken, _authConfig.ConsumerSecret, _authConfig.AuthUrl);
        }

        private string MakeRequest(string url)
        {
            var twitAuthResponse = Authenticate();

            var utility = new Utility();
            var searchJson = utility.RequstJson(url, twitAuthResponse.token_type, twitAuthResponse.access_token);

            return searchJson;
        }
    }
}
