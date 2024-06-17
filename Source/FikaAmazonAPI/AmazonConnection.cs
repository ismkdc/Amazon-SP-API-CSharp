using System;
using System.Globalization;
using System.Net.Http;
using System.Threading;
using FikaAmazonAPI.AmazonSpApiSDK.Models.Exceptions;
using FikaAmazonAPI.Services;
using FikaAmazonAPI.Utils;

namespace FikaAmazonAPI
{
    public class AmazonConnection
    {
        private readonly UnauthorizedAccessException _NoCredentials =
            new UnauthorizedAccessException("Error, you cannot make calls to Amazon without credentials!");

        public AmazonConnection(AmazonCredential Credentials, IHttpClientFactory httpClientFactory, string RefNumber = null, CultureInfo? cultureInfo = null)
        {
            Authenticate(Credentials, httpClientFactory);
            this.RefNumber = RefNumber;
            Thread.CurrentThread.CurrentCulture = cultureInfo ?? CultureInfo.CurrentCulture;
        }

        private AmazonCredential Credentials { get; set; }

        public OrderService Orders => _Orders ?? throw _NoCredentials;
        public ReportService Reports => _Reports ?? throw _NoCredentials;
        public SolicitationService Solicitations => _Solicitations ?? throw _NoCredentials;
        public FinancialService Financial => _Financials ?? throw _NoCredentials;
        public CatalogItemService CatalogItem => _CatalogItems ?? throw _NoCredentials;
        public ProductPricingService ProductPricing => _ProductPricing ?? throw _NoCredentials;
        public AuthorizationService Authorization => _Authorization ?? throw _NoCredentials;
        public AplusContentService AplusContent => _AplusContent ?? throw _NoCredentials;
        public FbaInboundEligibilityService FbaInboundEligibility => _FbaInboundEligibility ?? throw _NoCredentials;
        public EasyShip20220323Service EasyShip20220323 => _EasyShip20220323 ?? throw _NoCredentials;
        public FbaInboundService FbaInbound => _FbaInbound ?? throw _NoCredentials;
        public FbaInventoryService FbaInventory => _FbaInventory ?? throw _NoCredentials;
        public FbaOutboundService FbaOutbound => _FbaOutbound ?? throw _NoCredentials;
        public FbaSmallandLightService FbaSmallandLight => _FbaSmallandLight ?? throw _NoCredentials;
        public FeedService Feed => _Feed ?? throw _NoCredentials;
        public ListingsItemService ListingsItem => _ListingsItem ?? throw _NoCredentials;
        public RestrictionService Restrictions => _Restrictions ?? throw _NoCredentials;
        public MerchantFulfillmentService MerchantFulfillment => _MerchantFulfillment ?? throw _NoCredentials;
        public MessagingService Messaging => _Messaging ?? throw _NoCredentials;
        public NotificationService Notification => _Notification ?? throw _NoCredentials;
        public ProductFeeService ProductFee => _ProductFee ?? throw _NoCredentials;
        public ProductTypeService ProductType => _ProductType ?? throw _NoCredentials;
        public SalesService Sales => _Sales ?? throw _NoCredentials;
        public SellerService Seller => _Seller ?? throw _NoCredentials;
        public ServicesService Services => _Services ?? throw _NoCredentials;
        public ShipmentInvoicingService ShipmentInvoicing => _ShipmentInvoicing ?? throw _NoCredentials;
        public ShippingService Shipping => _Shipping ?? throw _NoCredentials;
        public ShippingServiceV2 ShippingV2 => _ShippingV2 ?? throw _NoCredentials;
        public UploadService Upload => _Upload ?? throw _NoCredentials;
        public TokenService Tokens => _Tokens ?? throw _NoCredentials;
        public FulFillmentInboundService FulFillmentInbound => _FulFillmentInbound ?? throw _NoCredentials;
        public FulFillmentOutboundService FulFillmentOutbound => _FulFillmentOutbound ?? throw _NoCredentials;

        public VendorDirectFulfillmentOrderService VendorDirectFulfillmentOrders =>
            _VendorDirectFulfillmentOrders ?? throw _NoCredentials;

        public VendorOrderService VendorOrders => _VendorOrders ?? throw _NoCredentials;

        public VendorTransactionStatusService VendorTransactionStatus =>
            _VendorTransactionStatus ?? throw _NoCredentials;

        private OrderService _Orders { get; set; }
        private ReportService _Reports { get; set; }
        private SolicitationService _Solicitations { get; set; }
        private FinancialService _Financials { get; set; }
        private CatalogItemService _CatalogItems { get; set; }
        private ProductPricingService _ProductPricing { get; set; }
        private AuthorizationService _Authorization { get; set; }
        private AplusContentService _AplusContent { get; set; }
        private FbaInboundEligibilityService _FbaInboundEligibility { get; set; }
        private EasyShip20220323Service _EasyShip20220323 { get; set; }
        private FbaInboundService _FbaInbound { get; set; }
        private FbaInventoryService _FbaInventory { get; set; }
        private FbaOutboundService _FbaOutbound { get; set; }
        private FbaSmallandLightService _FbaSmallandLight { get; set; }
        private FeedService _Feed { get; set; }
        private ListingsItemService _ListingsItem { get; set; }
        private RestrictionService _Restrictions { get; set; }
        private MerchantFulfillmentService _MerchantFulfillment { get; set; }
        private MessagingService _Messaging { get; set; }
        private NotificationService _Notification { get; set; }
        private ProductFeeService _ProductFee { get; set; }
        private ProductTypeService _ProductType { get; set; }
        private SalesService _Sales { get; set; }
        private SellerService _Seller { get; set; }
        private ServicesService _Services { get; set; }
        private ShipmentInvoicingService _ShipmentInvoicing { get; set; }
        private ShippingService _Shipping { get; set; }
        private ShippingServiceV2 _ShippingV2 { get; set; }
        private UploadService _Upload { get; set; }

        private TokenService _Tokens { get; set; }
        private FulFillmentInboundService _FulFillmentInbound { get; set; }
        private FulFillmentOutboundService _FulFillmentOutbound { get; set; }
        private VendorDirectFulfillmentOrderService _VendorDirectFulfillmentOrders { get; set; }
        private VendorOrderService _VendorOrders { get; set; }
        private VendorTransactionStatusService _VendorTransactionStatus { get; set; }

        public string RefNumber { get; set; }
        public MarketPlace GetCurrentMarketplace => Credentials.MarketPlace;
        public string GetCurrentSellerID => Credentials.SellerID;

        private void Authenticate(AmazonCredential Credentials, IHttpClientFactory httpClientFactory)
        {
            if (this.Credentials == default(AmazonCredential))
                Init(Credentials, httpClientFactory);
            else
                throw new InvalidOperationException(
                    "Error, you are already authenticated to amazon in this AmazonConnection, dispose of this connection and create a new one to connect to a different account.");
        }

        private void Init(AmazonCredential Credentials, IHttpClientFactory httpClientFactory)
        {
            ValidateCredentials(Credentials);

            this.Credentials = Credentials;

            _Authorization = new AuthorizationService(this.Credentials, httpClientFactory);
            _Orders = new OrderService(this.Credentials, httpClientFactory);
            _Reports = new ReportService(this.Credentials, httpClientFactory);
            _Solicitations = new SolicitationService(this.Credentials, httpClientFactory);
            _Financials = new FinancialService(this.Credentials, httpClientFactory);
            _CatalogItems = new CatalogItemService(this.Credentials, httpClientFactory);
            _ProductPricing = new ProductPricingService(this.Credentials, httpClientFactory);

            _FbaInbound = new FbaInboundService(this.Credentials, httpClientFactory);
            _FbaInventory = new FbaInventoryService(this.Credentials, httpClientFactory);
            _FbaOutbound = new FbaOutboundService(this.Credentials, httpClientFactory);
            _FbaSmallandLight = new FbaSmallandLightService(this.Credentials, httpClientFactory);
            _FbaInboundEligibility = new FbaInboundEligibilityService(this.Credentials, httpClientFactory);
            _EasyShip20220323 = new EasyShip20220323Service(this.Credentials, httpClientFactory);
            _AplusContent = new AplusContentService(this.Credentials, httpClientFactory);
            _Feed = new FeedService(this.Credentials, httpClientFactory);
            _ListingsItem = new ListingsItemService(this.Credentials, httpClientFactory);
            _Restrictions = new RestrictionService(this.Credentials, httpClientFactory);
            _MerchantFulfillment = new MerchantFulfillmentService(this.Credentials, httpClientFactory);
            _Messaging = new MessagingService(this.Credentials, httpClientFactory);
            _Notification = new NotificationService(this.Credentials, httpClientFactory);
            _ProductFee = new ProductFeeService(this.Credentials, httpClientFactory);
            _ProductType = new ProductTypeService(this.Credentials, httpClientFactory);
            _Sales = new SalesService(this.Credentials, httpClientFactory);
            _Seller = new SellerService(this.Credentials, httpClientFactory);
            _Services = new ServicesService(this.Credentials, httpClientFactory);
            _ShipmentInvoicing = new ShipmentInvoicingService(this.Credentials, httpClientFactory);
            _Shipping = new ShippingService(this.Credentials, httpClientFactory);
            _ShippingV2 = new ShippingServiceV2(this.Credentials, httpClientFactory);
            _Upload = new UploadService(this.Credentials, httpClientFactory);
            _Tokens = new TokenService(this.Credentials, httpClientFactory);
            _FulFillmentInbound = new FulFillmentInboundService(this.Credentials, httpClientFactory);
            _FulFillmentOutbound = new FulFillmentOutboundService(this.Credentials, httpClientFactory);
            _VendorDirectFulfillmentOrders = new VendorDirectFulfillmentOrderService(this.Credentials, httpClientFactory);
            _VendorOrders = new VendorOrderService(this.Credentials, httpClientFactory);
            _VendorTransactionStatus = new VendorTransactionStatusService(this.Credentials, httpClientFactory);

            AmazonCredential.DebugMode = this.Credentials.IsDebugMode;
        }

        private void ValidateCredentials(AmazonCredential Credentials)
        {
            if (Credentials == null)
                throw new AmazonUnauthorizedException("Error, you cannot make calls to Amazon without credentials!");
            //Remove AWS authorization
            //else if (string.IsNullOrEmpty(Credentials.AccessKey))
            //    throw new AmazonInvalidInputException($"InvalidInput, AccessKey cannot be empty!");
            //else if (string.IsNullOrEmpty(Credentials.SecretKey))
            //    throw new AmazonInvalidInputException($"InvalidInput, SecretKey  cannot be empty!");
            //else if (string.IsNullOrEmpty(Credentials.RoleArn))
            //    throw new AmazonInvalidInputException($"InvalidInput, RoleArn cannot be empty!");
            if (string.IsNullOrEmpty(Credentials.ClientId))
                throw new AmazonInvalidInputException("InvalidInput, ClientId cannot be empty!");

            if (string.IsNullOrEmpty(Credentials.ClientSecret))
                throw new AmazonInvalidInputException("InvalidInput, ClientSecret  cannot be empty!");

            if (string.IsNullOrEmpty(Credentials.RefreshToken))
                throw new AmazonInvalidInputException("InvalidInput, RefreshToken cannot be empty!");

            if (Credentials.MarketPlace == null)
            {
                if (string.IsNullOrEmpty(Credentials.MarketPlaceID))
                    throw new AmazonInvalidInputException(
                        "InvalidInput, MarketPlace or MarketPlaceID cannot be null for both!");
                Credentials.MarketPlace = MarketPlace.GetMarketPlaceByID(Credentials.MarketPlaceID);
            }
        }
    }
}