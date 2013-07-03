namespace oAuthTwitterWrapper.Configuration
{
    public interface ITwitterConfiguration
    {
        /// <summary>
        /// The username or twitter handle
        /// </summary>
        string ScreenName { get; set; }
        /// <summary>
        /// When set to false, the timeline will strip any native retweets (though they will still count toward both the maximal length of the timeline and the slice selected by the count parameter). Note: If you're using the trim_user parameter in conjunction with include_rts, the retweets will still contain a full user object.
        /// </summary>
        string IncludeRts { get; set; }
        /// <summary>
        /// This parameter will prevent replies from appearing in the returned timeline. Using exclude_replies with the count parameter will mean you will receive up-to count tweets — this is because the count parameter retrieves that many tweets before filtering out retweets and replies. This parameter is only supported for JSON and XML responses.
        /// </summary>
        string ExcludeReplies { get; set; }
        /// <summary>
        /// Specifies the number of tweets to try and retrieve, up to a maximum of 200 per distinct request. The value of count is best thought of as a limit to the number of tweets to return because suspended or deleted content is removed after the count has been applied. We include retweets in the count, even if include_rts is not supplied. It is recommended you always send include_rts=1 when using this API method.
        /// </summary>
        string Count { get; set; }

        string TimelineFormat { get; set; }
        string TimelineUrl { get;  }
        string SearchFormat { get; set; }
        string SearchQuery { get; set; }
        string SearchUrl { get; }
    }
}