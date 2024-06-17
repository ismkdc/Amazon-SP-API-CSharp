namespace FikaAmazonAPI.AmazonSpApiSDK.Models.ShipmentInvoicing
{
    public class ShipmentInvoiceStatusInfo
    {
        public string AmazonShipmentId { get; set; }
        public ShipmentInvoiceStatus InvoiceStatus { get; set; }
    }

    public enum ShipmentInvoiceStatus
    {
        Processing,
        Accepted,
        Errored,
        NotFound
    }
}