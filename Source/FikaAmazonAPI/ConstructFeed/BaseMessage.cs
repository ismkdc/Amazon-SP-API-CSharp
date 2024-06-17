using System.Xml.Serialization;
using FikaAmazonAPI.ConstructFeed.Messages;
using static FikaAmazonAPI.Utils.Constants;

namespace FikaAmazonAPI.ConstructFeed
{
    public class BaseMessage
    {
        public int MessageID { get; set; }

        public OperationType OperationType { get; set; }

        public PriceMessage Price { get; set; }

        public InventoryMessage Inventory { get; set; }
        public ProductMessage Product { get; set; }


        public AmazonAppMessage AmazonApp { get; set; }
        public CatPILMessage CatPIL { get; set; }
        public AutoPartsItemMessage AutoPartsItem { get; set; }
        public CharacterDataMessage CharacterData { get; set; }
        public CustomerMessage Customer { get; set; }
        public CustomerReportMessage CustomerReport { get; set; }
        public EnhancedContentMessage EnhancedContent { get; set; }
        public ExternalCustomerMessage ExternalCustomer { get; set; }
        public ExternalOrderMessage ExternalOrder { get; set; }
        public FulfillmentCenterMessage FulfillmentCenter { get; set; }
        public FulfillmentOrderRequestMessage FulfillmentOrderRequest { get; set; }
        public FulfillmentOrderCancellationRequestMessage FulfillmentOrderCancellationRequest { get; set; }
        public CartonContentsRequest CartonContentsRequest { get; set; }
        public ImageMessage Image { get; set; }
        public LocalMessage Local { get; set; }
        public InvoiceConfirmationMessage InvoiceConfirmation { get; set; }
        public ItemMessage Item { get; set; }
        public MSVatMessage MSVat { get; set; }
        public LoyaltyMessage Loyalty { get; set; }
        public MultiChannelOrderReportMessage MultiChannelOrderReport { get; set; }
        public NavigationReportMessage NavigationReport { get; set; }
        public OfferMessage Offer { get; set; }
        public OrderAcknowledgementMessage OrderAcknowledgement { get; set; }
        public OrderAdjustmentMessage OrderAdjustment { get; set; }
        public OrderFulfillmentMessage OrderFulfillment { get; set; }
        public OrderSourcingOnDemandMessage OrderSourcingOnDemand { get; set; }
        public OrderNotificationReportMessage OrderNotificationReport { get; set; }
        public OrderReportMessage OrderReport { get; set; }
        public OverrideMessage Override { get; set; }
        public PointOfSaleMessage PointOfSale { get; set; }
        public TradeInPriceMessage TradeInPrice { get; set; }
        public ProcessingReportMessage ProcessingReport { get; set; }
        public ProductImageMessage ProductImage { get; set; }
        public PromotionRequestMessage PromotionRequest { get; set; }
        public RelationshipMessage Relationship { get; set; }
        public ReverseItemMessage ReverseItem { get; set; }
        public RichContentMessage RichContent { get; set; }
        public SettlementReportMessage SettlementReport { get; set; }
        public SalesHistoryMessage SalesHistory { get; set; }
        public StandardProductMessage StandardProduct { get; set; }
        public TestOrderRequestMessage TestOrderRequest { get; set; }
        public StoreMessage Store { get; set; }
        public StoreStockMovementMessage StoreStockMovement { get; set; }
        public WebstoreItemMessage WebstoreItem { get; set; }
        public PendingOrderReportMessage PendingOrderReport { get; set; }
        public PurchaseConfirmationMessage PurchaseConfirmation { get; set; }
        public SalesAdjustmentMessage SalesAdjustment { get; set; }
        public EasyShipDocumentMessage EasyShipDocument { get; set; }


        [XmlIgnore] public bool InventorySpecified => Inventory != null;

        [XmlIgnore] public bool PriceSpecified => Price != null;

        [XmlIgnore] public bool AmazonAppSpecified => AmazonApp != null;
        [XmlIgnore] public bool CatPILSpecified => CatPIL != null;
        [XmlIgnore] public bool AutoPartsItemSpecified => AutoPartsItem != null;
        [XmlIgnore] public bool CharacterDataSpecified => CharacterData != null;
        [XmlIgnore] public bool CustomerSpecified => Customer != null;
        [XmlIgnore] public bool CustomerReportSpecified => CustomerReport != null;
        [XmlIgnore] public bool EnhancedContentSpecified => EnhancedContent != null;
        [XmlIgnore] public bool ExternalCustomerSpecified => ExternalCustomer != null;
        [XmlIgnore] public bool ExternalOrderSpecified => ExternalOrder != null;
        [XmlIgnore] public bool FulfillmentCenterSpecified => FulfillmentCenter != null;
        [XmlIgnore] public bool FulfillmentOrderRequestSpecified => FulfillmentOrderRequest != null;

        [XmlIgnore]
        public bool FulfillmentOrderCancellationRequestSpecified => FulfillmentOrderCancellationRequest != null;

        [XmlIgnore] public bool CartonContentsRequestSpecified => CartonContentsRequest != null;
        [XmlIgnore] public bool ImageSpecified => Image != null;
        [XmlIgnore] public bool LocalSpecified => Local != null;
        [XmlIgnore] public bool InvoiceConfirmationSpecified => InvoiceConfirmation != null;
        [XmlIgnore] public bool ItemSpecified => Item != null;
        [XmlIgnore] public bool MSVatSpecified => MSVat != null;
        [XmlIgnore] public bool LoyaltySpecified => Loyalty != null;
        [XmlIgnore] public bool MultiChannelOrderReportSpecified => MultiChannelOrderReport != null;
        [XmlIgnore] public bool NavigationReportSpecified => NavigationReport != null;
        [XmlIgnore] public bool OfferSpecified => Offer != null;
        [XmlIgnore] public bool OrderAcknowledgementSpecified => OrderAcknowledgement != null;
        [XmlIgnore] public bool OrderAdjustmentSpecified => OrderAdjustment != null;
        [XmlIgnore] public bool OrderFulfillmentSpecified => OrderFulfillment != null;
        [XmlIgnore] public bool OrderSourcingOnDemandSpecified => OrderSourcingOnDemand != null;
        [XmlIgnore] public bool OrderNotificationReportSpecified => OrderNotificationReport != null;
        [XmlIgnore] public bool OrderReportSpecified => OrderReport != null;
        [XmlIgnore] public bool OverrideSpecified => Override != null;
        [XmlIgnore] public bool PointOfSaleSpecified => PointOfSale != null;
        [XmlIgnore] public bool TradeInPriceSpecified => TradeInPrice != null;
        [XmlIgnore] public bool ProcessingReportSpecified => ProcessingReport != null;
        [XmlIgnore] public bool ProductSpecified => Product != null;
        [XmlIgnore] public bool ProductImageSpecified => ProductImage != null;
        [XmlIgnore] public bool PromotionRequestSpecified => PromotionRequest != null;
        [XmlIgnore] public bool RelationshipSpecified => Relationship != null;
        [XmlIgnore] public bool ReverseItemSpecified => ReverseItem != null;
        [XmlIgnore] public bool RichContentSpecified => RichContent != null;
        [XmlIgnore] public bool SettlementReportSpecified => SettlementReport != null;
        [XmlIgnore] public bool SalesHistorySpecified => SalesHistory != null;
        [XmlIgnore] public bool StandardProductSpecified => StandardProduct != null;
        [XmlIgnore] public bool TestOrderRequestSpecified => TestOrderRequest != null;
        [XmlIgnore] public bool StoreSpecified => Store != null;
        [XmlIgnore] public bool StoreStockMovementSpecified => StoreStockMovement != null;
        [XmlIgnore] public bool WebstoreItemSpecified => WebstoreItem != null;
        [XmlIgnore] public bool PendingOrderReportSpecified => PendingOrderReport != null;
        [XmlIgnore] public bool PurchaseConfirmationSpecified => PurchaseConfirmation != null;
        [XmlIgnore] public bool SalesAdjustmentSpecified => SalesAdjustment != null;
        [XmlIgnore] public bool EasyShipDocumentSpecified => EasyShipDocument != null;
    }
}