﻿namespace oAuthTwitterWrapper.Configuration
{
    public class TwitterConfiguration : ITwitterConfiguration
    {
        public TwitterConfiguration()
        {
            ScreenName = "";
            IncludeRts = "false";
            ExcludeReplies = "true";
            Count = "10";
            TimelineFormat =
                "https://api.twitter.com/1.1/statuses/user_timeline.json?screen_name={0}&amp;include_rts={1}&amp;exclude_replies={2}&amp;count={3}";
            SearchFormat = "https://api.twitter.com/1.1/search/tweets.json?q={0}";
            SearchQuery = "%23test";
            StatusListFormat =
                "https://api.twitter.com/1.1/lists/statuses.json?list_id={0}&amp;count={1}&amp;include_rts={2}";
        }

        public string ListId { get; set; }
        public string ScreenName { get; set; }

        public string IncludeRts { get; set; }
        public string ExcludeReplies { get; set; }
        public string Count { get; set; }
        public string TimelineFormat { get; set; }
        public string StatusListFormat { get; set; }
        public string TimelineUrl
        {
            get
            {
                return string.Format(TimelineFormat, ScreenName, IncludeRts, ExcludeReplies, Count);
            }
        }
        public string SearchFormat { get; set; }
        public string SearchQuery { get; set; }
        public string SearchUrl
        {
            get
            {
                return string.Format(SearchFormat, SearchQuery);
            }
        }

        public string StatusListUrl
        {
            get { return string.Format(StatusListFormat, ListId, Count, IncludeRts); }
        }
    }
}
