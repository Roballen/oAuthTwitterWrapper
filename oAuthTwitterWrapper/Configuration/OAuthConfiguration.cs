namespace oAuthTwitterWrapper.Configuration
{
    public interface IOAuthConfiguration
    {
        string ConsumerToken { get; set; }
        string ConsumerSecret { get; set; }
        string AuthUrl { get; set; }
    }

    public class OAuthConfiguration : IOAuthConfiguration
    {
        public string ConsumerToken { get; set; }
        public string ConsumerSecret { get; set; }
        public string AuthUrl { get; set; }
    }
}
