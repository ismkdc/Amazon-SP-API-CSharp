namespace FikaAmazonAPI.Utils
{
    public class Region
    {
        private Region(string regionName, string hostUrl, string sandboxHostUrl)
        {
            RegionName = regionName;
            HostUrl = hostUrl;
            SandboxHostUrl = sandboxHostUrl;
        }

        public string RegionName { get; set; }
        public string HostUrl { get; set; }
        public string SandboxHostUrl { get; set; }


        public static Region NorthAmerica => new Region("us-east-1", "https://sellingpartnerapi-na.amazon.com",
            "https://sandbox.sellingpartnerapi-na.amazon.com");

        public static Region Europe => new Region("eu-west-1", "https://sellingpartnerapi-eu.amazon.com",
            "https://sandbox.sellingpartnerapi-eu.amazon.com");

        public static Region FarEast => new Region("us-west-2", "https://sellingpartnerapi-fe.amazon.com",
            "https://sandbox.sellingpartnerapi-fe.amazon.com");
    }
}