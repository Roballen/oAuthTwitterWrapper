using System.Configuration;

namespace oAuthTwitterWrapper.Configuration
{
    public class TwitterApplicationConfiguration : ITwitterConfiguration
    {
        private static string _screenname = ConfigurationManager.AppSettings["screenname"];
        private static string _include_rts = ConfigurationManager.AppSettings["include_rts"];
        private static string _exclude_replies = ConfigurationManager.AppSettings["exclude_replies"];
        private static string _count = ConfigurationManager.AppSettings["count"];
        private static string _timelineFormat = ConfigurationManager.AppSettings["timelineFormat"];
        private static string _timelineUrl = "";
        private static string _searchFormat = ConfigurationManager.AppSettings["searchFormat"];
        private static string _searchQuery = ConfigurationManager.AppSettings["searchQuery"];
        private static string _searchUrl = "";

        public string ScreenName
        {
            get { return _screenname; }
            set { _screenname = value; }
        }

        public string IncludeRts
        {
            get { return _include_rts; }
            set { _include_rts = value; }
        }

        public string ExcludeReplies
        {
            get { return _exclude_replies; }
            set { _exclude_replies = value; }
        }

        public string Count
        {
            get { return _count; }
            set { _count = value; }
        }

        public string TimelineFormat
        {
            get { return _timelineFormat; }
            set { _timelineFormat = value; }
        }

        public string TimelineUrl
        {
            get
            {
                return string.Format(TimelineFormat, ScreenName, IncludeRts, ExcludeReplies, Count);
            }
        }

        public string SearchFormat
        {
            get { return _searchFormat; }
            set { _searchFormat = value; }
        }

        public string SearchQuery
        {
            get { return _searchQuery; }
            set { _searchQuery = value; }
        }

        public string SearchUrl
        {
            get
            {
                return string.Format(SearchFormat, SearchQuery);
            }
        }
    }
}
