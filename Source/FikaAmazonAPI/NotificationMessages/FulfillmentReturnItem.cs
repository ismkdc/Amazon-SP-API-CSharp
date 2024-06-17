namespace FikaAmazonAPI.NotificationMessages
{
    public class FulfillmentReturnItem
    {
        public EventTime ReceivedDateTime { get; set; }
        public int ReturnedQuantity { get; set; }
        public EventTime SellerSku { get; set; }
    }
}