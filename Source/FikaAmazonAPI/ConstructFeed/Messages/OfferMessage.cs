namespace FikaAmazonAPI.ConstructFeed.Messages
{
    public class OfferMessage
    {
        public string SKU { get; set; }

        public StandardProductID StandardProductID { get; set; }

        public Condition Condition { get; set; }
    }
}