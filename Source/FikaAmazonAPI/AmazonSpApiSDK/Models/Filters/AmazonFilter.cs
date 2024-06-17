namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Filters
{
    public class AmazonFilter
    {
        public AmazonFilter(int limit, string href = null)
        {
            Limit = limit;
            NextPage = href;
        }

        public int Limit { get; set; }
        public string NextPage { get; set; }
    }
}