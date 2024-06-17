namespace FikaAmazonAPI.NotificationMessages
{
    public class FbaOutboundShipmentStatusNotification
    {
        public string SellerId { get; set; }
        public string AmazonOrderId { get; set; }
        public string AmazonShipmentId { get; set; }
        public string ShipmentStatus { get; set; }
    }
}