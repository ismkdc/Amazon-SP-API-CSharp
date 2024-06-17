using System;

namespace FikaAmazonAPI.AmazonSpApiSDK.Services
{
    public static class EnvironemntManager
    {
        public enum Environments
        {
            Sandbox,
            Production
        }

        public static Environments Environemnt { get; set; } = Environments.Production;
    }

    public class ApiUrls
    {
        protected class OAuthUrls
        {
            public static string TokenUrl => "identity/v1/oauth2/token";

            public static string RefreshTokenUrl => "identity/v1/oauth2/token";
        }

        protected class TaxonomyApiUrls
        {
            private static readonly string _resourceBaseUrl = "/commerce/taxonomy/v1_beta";

            public static string getDefaultCategoryTreeIdUrl => $"{_resourceBaseUrl}/get_default_category_tree_id";

            public static string CategoryTreeUrl => $"{_resourceBaseUrl}/category_tree";

            public static string GetItemAspectsForCategory => "/get_item_aspects_for_category";
        }

        protected class FBAInboundEligibiltyApiUrls
        {
            private static readonly string _resourceBaseUrl = "/fba/inbound/v1";

            public static string GetItemEligibilityPreview => $"{_resourceBaseUrl}/eligibility/itemPreview";
        }

        protected class FulFillmentOutboundApiUrls
        {
            private static readonly string _resourceBaseUrl = "/fba/outbound/2020-07-01";

            public static string GetFulfillmentPreview => $"{_resourceBaseUrl}/fulfillmentOrders/preview";

            public static string ListAllFulfillmentOrders => $"{_resourceBaseUrl}/fulfillmentOrders";

            public static string CreateFulfillmentOrder => $"{_resourceBaseUrl}/fulfillmentOrders";

            public static string GetPackageTrackingDetails => $"{_resourceBaseUrl}/tracking";

            public static string ListReturnReasonCodes => $"{_resourceBaseUrl}/returnReasonCodes";

            public static string GetFeatures => $"{_resourceBaseUrl}/features";

            public static string CreateFulfillmentReturn(string sellerFulfillmentOrderId)
            {
                return $"{_resourceBaseUrl}/fulfillmentOrders/{sellerFulfillmentOrderId}/return";
            }

            public static string GetFulfillmentOrder(string sellerFulfillmentOrderId)
            {
                return $"{_resourceBaseUrl}/fulfillmentOrders/{sellerFulfillmentOrderId}";
            }

            public static string UpdateFulfillmentOrder(string sellerFulfillmentOrderId)
            {
                return $"{_resourceBaseUrl}/fulfillmentOrders/{sellerFulfillmentOrderId}";
            }

            public static string CancelFulfillmentOrder(string sellerFulfillmentOrderId)
            {
                return $"{_resourceBaseUrl}/fulfillmentOrders/{sellerFulfillmentOrderId}/cancel";
            }

            public static string GetFeatureInventory(string featureName)
            {
                return $"{_resourceBaseUrl}/features/inventory/{featureName}";
            }

            public static string GetFeatureSKU(string featureName, string sellerSku)
            {
                return $"{_resourceBaseUrl}/features/inventory/{featureName}/{sellerSku}";
            }
        }

        protected class FulFillmentInboundApiUrls
        {
            private static readonly string _resourceBaseUrl = "/fba/inbound/v0";

            public static string GetInboundGuidance => $"{_resourceBaseUrl}/itemsGuidance";

            public static string CreateInboundShipmentPlan => $"{_resourceBaseUrl}/plans";

            public static string GetPrepInstructions => $"{_resourceBaseUrl}/prepInstructions";

            public static string GetShipments => $"{_resourceBaseUrl}/shipments";

            public static string GetShipmentItems => $"{_resourceBaseUrl}/shipmentItems";

            public static string UpdateInboundShipment(string shipmentId)
            {
                return $"{_resourceBaseUrl}/shipments/{shipmentId}";
            }

            public static string CreateInboundShipment(string shipmentId)
            {
                return $"{_resourceBaseUrl}/shipments/{shipmentId}";
            }

            public static string GetPreorderInfo(string shipmentId)
            {
                return $"{_resourceBaseUrl}/shipments/{shipmentId}/preorder";
            }

            public static string ConfirmPreorder(string shipmentId)
            {
                return $"{_resourceBaseUrl}/shipments/{shipmentId}/preorder/confirm";
            }

            public static string GetTransportDetails(string shipmentId)
            {
                return $"{_resourceBaseUrl}/shipments/{shipmentId}/transport";
            }

            public static string PutTransportDetails(string shipmentId)
            {
                return $"{_resourceBaseUrl}/shipments/{shipmentId}/transport";
            }

            public static string VoidTransport(string shipmentId)
            {
                return $"{_resourceBaseUrl}/shipments/{shipmentId}/transport/void";
            }

            public static string EstimateTransport(string shipmentId)
            {
                return $"{_resourceBaseUrl}/shipments/{shipmentId}/transport/estimate";
            }

            public static string ConfirmTransport(string shipmentId)
            {
                return $"{_resourceBaseUrl}/shipments/{shipmentId}/transport/confirm";
            }

            public static string GetLabels(string shipmentId)
            {
                return $"{_resourceBaseUrl}/shipments/{shipmentId}/labels";
            }

            public static string GetBillOfLading(string shipmentId)
            {
                return $"{_resourceBaseUrl}/shipments/{shipmentId}/billOfLading";
            }

            public static string GetShipmentItemsByShipmentId(string shipmentId)
            {
                return $"{_resourceBaseUrl}/shipments/{shipmentId}/items";
            }
        }

        protected class ShippingApiUrls
        {
            private static readonly string _resourceBaseUrl = "/shipping/v1";

            public static string CreateShipment => $"{_resourceBaseUrl}/shipments";

            public static string PurchaseShipment => $"{_resourceBaseUrl}/purchaseShipment";

            public static string GetRates => $"{_resourceBaseUrl}/rates";

            public static string GetAccount => $"{_resourceBaseUrl}/account";

            public static string GetShipment(string shipmentId)
            {
                return $"{_resourceBaseUrl}/shipments/{shipmentId}";
            }

            public static string CancelShipment(string shipmentId)
            {
                return $"{_resourceBaseUrl}/shipments/{shipmentId}/cancel";
            }

            public static string PurchaseLabels(string shipmentId)
            {
                return $"{_resourceBaseUrl}/shipments/{shipmentId}/purchaseLabels";
            }

            public static string RetrieveShippingLabel(string shipmentId, string trackingId)
            {
                return $"{_resourceBaseUrl}/shipments/{shipmentId}/containers/{trackingId}/label";
            }

            public static string GetTrackingInformation(string trackingId)
            {
                return $"{_resourceBaseUrl}/tracking/{trackingId}";
            }
        }

        protected class ShippingApiV2Urls
        {
            private static readonly string _resourceBaseUrl = "/shipping/v2";

            public static string GetRates => $"{_resourceBaseUrl}/shipments/rates";

            public static string PurchaseShipment => $"{_resourceBaseUrl}/shipments";

            public static string GetTracking(string carrierId, string trackingId)
            {
                return $"{_resourceBaseUrl}/tracking?carrierId={carrierId}&trackingId={trackingId}";
            }

            public static string GetShipmentDocuments(string shipmentId, string packageClientReferenceId, string format)
            {
                return
                    $"{_resourceBaseUrl}/shipments/{shipmentId}/documents?packageClientReferenceId={packageClientReferenceId}&format={format}";
            }

            public static string CancelShipment(string shipmentId)
            {
                return $"{_resourceBaseUrl}/shipments/{shipmentId}/cancel";
            }
        }

        protected class MessaginApiUrls
        {
            private static readonly string _resourceBaseUrl = "/messaging/v1";

            public static string GetMessagingActionsForOrder(string amazonOrderId)
            {
                return $"{_resourceBaseUrl}/orders/{amazonOrderId}";
            }

            public static string ConfirmCustomizationDetails(string amazonOrderId)
            {
                return $"{_resourceBaseUrl}/orders/{amazonOrderId}/messages/confirmCustomizationDetails";
            }

            public static string CreateConfirmDeliveryDetails(string amazonOrderId)
            {
                return $"{_resourceBaseUrl}/orders/{amazonOrderId}/messages/confirmDeliveryDetails";
            }

            public static string CreateLegalDisclosure(string amazonOrderId)
            {
                return $"{_resourceBaseUrl}/orders/{amazonOrderId}/messages/legalDisclosure";
            }

            public static string CreateNegativeFeedbackRemoval(string amazonOrderId)
            {
                return $"{_resourceBaseUrl}/orders/{amazonOrderId}/messages/negativeFeedbackRemoval";
            }

            public static string CreateConfirmOrderDetails(string amazonOrderId)
            {
                return $"{_resourceBaseUrl}/orders/{amazonOrderId}/messages/confirmOrderDetails";
            }

            public static string CreateConfirmServiceDetails(string amazonOrderId)
            {
                return $"{_resourceBaseUrl}/orders/{amazonOrderId}/messages/confirmServiceDetails";
            }

            public static string CreateAmazonMotors(string amazonOrderId)
            {
                return $"{_resourceBaseUrl}/orders/{amazonOrderId}/messages/amazonMotors";
            }

            public static string CreateWarranty(string amazonOrderId)
            {
                return $"{_resourceBaseUrl}/orders/{amazonOrderId}/messages/warranty";
            }

            public static string GetAttributes(string amazonOrderId)
            {
                return $"{_resourceBaseUrl}/orders/{amazonOrderId}/attributes";
            }

            public static string CreateDigitalAccessKey(string amazonOrderId)
            {
                return $"{_resourceBaseUrl}/orders/{amazonOrderId}/messages/digitalAccessKey";
            }

            public static string CreateUnexpectedProblem(string amazonOrderId)
            {
                return $"{_resourceBaseUrl}/orders/{amazonOrderId}/messages/unexpectedProblem";
            }

            public static string SendInvoice(string amazonOrderId)
            {
                return $"{_resourceBaseUrl}/orders/{amazonOrderId}/messages/invoice";
            }
        }

        protected class EasyShip20220323
        {
            private static readonly string _resourceBaseUrl = "/easyShip/2022-03-23";

            public static string ListHandoverSlots => $"{_resourceBaseUrl}/timeSlot";

            public static string GetScheduledPackage => $"{_resourceBaseUrl}/package";

            public static string CreateScheduledPackage => $"{_resourceBaseUrl}/package";

            public static string UpdateScheduledPackages => $"{_resourceBaseUrl}/package";
        }

        protected class FBASmallAndLightApiUrls
        {
            private static readonly string _resourceBaseUrl = "/fba/smallAndLight/v1";

            public static string GetSmallAndLightFeePreview => $"{_resourceBaseUrl}/feePreviews";

            public static string GetSmallAndLightEnrollmentBySellerSKU(string sellerSKU)
            {
                return $"{_resourceBaseUrl}/enrollments/{Uri.EscapeDataString(sellerSKU)}";
            }

            public static string PutSmallAndLightEnrollmentBySellerSKU(string sellerSKU)
            {
                return $"{_resourceBaseUrl}/enrollments/{Uri.EscapeDataString(sellerSKU)}";
            }

            public static string DeleteSmallAndLightEnrollmentBySellerSKU(string sellerSKU)
            {
                return $"{_resourceBaseUrl}/enrollments/{Uri.EscapeDataString(sellerSKU)}";
            }

            public static string GetSmallAndLightEligibilityBySellerSKU(string sellerSKU)
            {
                return $"{_resourceBaseUrl}/eligibilities/{Uri.EscapeDataString(sellerSKU)}";
            }
        }

        protected class MerchantFulfillmentApiUrls
        {
            private static readonly string _resourceBaseUrl = "/mfn/v0";

            public static string GetEligibleShipmentServicesOld => $"{_resourceBaseUrl}/eligibleServices";

            public static string GetEligibleShipmentServices => $"{_resourceBaseUrl}/eligibleShippingServices";

            public static string CreateShipment => $"{_resourceBaseUrl}/shipments";

            public static string GetAdditionalSellerInputsOld => $"{_resourceBaseUrl}/sellerInputs";

            public static string GetAdditionalSellerInputs => $"{_resourceBaseUrl}/additionalSellerInputs";

            public static string GetShipment(string shipmentId)
            {
                return $"{_resourceBaseUrl}/shipments/{shipmentId}";
            }

            public static string CancelShipment(string shipmentId)
            {
                return $"{_resourceBaseUrl}/shipments/{shipmentId}";
            }

            public static string CancelShipmentOld(string shipmentId)
            {
                return $"{_resourceBaseUrl}/shipments/{shipmentId}/cancel";
            }
        }

        protected class NotificationApiUrls
        {
            private static readonly string _resourceBaseUrl = "/notifications/v1";

            public static string GetDestinations => $"{_resourceBaseUrl}/destinations";

            public static string CreateDestination => $"{_resourceBaseUrl}/destinations";

            public static string GetSubscription(string notificationType)
            {
                return $"{_resourceBaseUrl}/subscriptions/{notificationType}";
            }

            public static string CreateSubscription(string notificationType)
            {
                return $"{_resourceBaseUrl}/subscriptions/{notificationType}";
            }

            public static string GetSubscriptionById(string notificationType, string subscriptionId)
            {
                return $"{_resourceBaseUrl}/subscriptions/{notificationType}/{subscriptionId}";
            }

            public static string DeleteSubscriptionById(string notificationType, string subscriptionId)
            {
                return $"{_resourceBaseUrl}/subscriptions/{notificationType}/{subscriptionId}";
            }

            public static string GetDestination(string destinationId)
            {
                return $"{_resourceBaseUrl}/destinations/{destinationId}";
            }

            public static string DeleteDestination(string destinationId)
            {
                return $"{_resourceBaseUrl}/destinations/{destinationId}";
            }
        }

        protected class SalesApiUrls
        {
            private static readonly string _resourceBaseUrl = "/sales/v1";

            public static string GetOrderMetrics => $"{_resourceBaseUrl}/orderMetrics";
        }

        protected class RestrictionsApiUrls
        {
            private static readonly string _resourceBaseUrl = "/listings/2021-08-01";

            public static string GetListingsRestrictions => $"{_resourceBaseUrl}/restrictions";
        }

        protected class AuthorizationsApiUrls
        {
            private static readonly string _resourceBaseUrl = "/authorization/v1";

            public static string GetAuthorizationCode => $"{_resourceBaseUrl}/authorizationCode";
        }

        protected class SellersApiUrls
        {
            private static readonly string _resourceBaseUrl = "/sellers/v1";

            public static string GetMarketplaceParticipations => $"{_resourceBaseUrl}/marketplaceParticipations";
        }

        internal class ProductPricingApiUrls
        {
            private static readonly string _resourceBaseUrl = "/products/pricing/v0";

            public static string GetPricing => $"{_resourceBaseUrl}/price";

            public static string GetCompetitivePricing => $"{_resourceBaseUrl}/competitivePrice";

            public static string GetBatchItemOffers => $"/batches{_resourceBaseUrl}/itemOffers";

            public static string GetBatchListingOffers => $"/batches{_resourceBaseUrl}/listingOffers";

            public static string GetListingOffersBySellerSku(string SellerSKU)
            {
                return $"{_resourceBaseUrl}/listings/{Uri.EscapeDataString(SellerSKU)}/offers";
            }

            public static string GetItemOffers(string Asin)
            {
                return $"{_resourceBaseUrl}/items/{Asin}/offers";
            }

            public static string GetListingOffers(string sellerSKU)
            {
                return $"{_resourceBaseUrl}/listings/{Uri.EscapeDataString(sellerSKU)}/offers";
            }

            #region v2022-05-01

            private static readonly string _resourceBaseUrl_v20220501 = "/products/pricing/2022-05-01";

            public static string FeaturedOfferExpectedPriceUri =>
                $"{_resourceBaseUrl_v20220501}/offer/featuredOfferExpectedPrice";

            public static string GetFeaturedOfferExpectedPriceBatch => $"/batches{FeaturedOfferExpectedPriceUri}";

            #endregion
        }

        protected class ProductTypeApiUrls
        {
            private static readonly string _resourceBaseUrl = "/definitions/2020-09-01";

            public static string SearchDefinitionsProductTypes => $"{_resourceBaseUrl}/productTypes";

            public static string GetDefinitionsProductType(string productType)
            {
                return $"{_resourceBaseUrl}/productTypes/{productType}";
            }
        }

        protected class ReportApiUrls
        {
            private static readonly string _resourceBaseUrl = "/reports/2021-06-30";

            public static string CreateReport => $"{_resourceBaseUrl}/reports";

            public static string GetReports => $"{_resourceBaseUrl}/reports";

            public static string GetReportSchedules => $"{_resourceBaseUrl}/schedules";

            public static string CreateReportSchedule => $"{_resourceBaseUrl}/schedules";

            public static string GetReport(string reportId)
            {
                return $"{_resourceBaseUrl}/reports/{reportId}";
            }

            public static string CancelReport(string reportId)
            {
                return $"{_resourceBaseUrl}/reports/{reportId}";
            }

            public static string GetReportSchedule(string reportScheduleId)
            {
                return $"{_resourceBaseUrl}/schedules/{reportScheduleId}";
            }

            public static string CancelReportSchedule(string reportScheduleId)
            {
                return $"{_resourceBaseUrl}/schedules/{reportScheduleId}";
            }

            public static string GetReportDocument(string reportDocumentId)
            {
                return $"{_resourceBaseUrl}/documents/{reportDocumentId}";
            }
        }

        protected class VendorDirectFulfillmentOrdersApiUrls
        {
            private static readonly string _resourceBaseUrl = "/vendor/directFulfillment/orders/v1";

            public static string GetOrders => $"{_resourceBaseUrl}/purchaseOrders";

            public static string SubmitAcknowledgement => $"{_resourceBaseUrl}/acknowledgements";

            public static string GetOrder(string purchaseOrderNumber)
            {
                return $"{_resourceBaseUrl}/purchaseOrders/{purchaseOrderNumber}";
            }
        }

        protected class VendorOrdersApiUrls
        {
            private static readonly string _resourceBaseUrl = "/vendor/orders/v1";

            public static string GetPurchaseOrders => $"{_resourceBaseUrl}/purchaseOrders";

            public static string SubmitAcknowledgement => $"{_resourceBaseUrl}/acknowledgements";

            public static string GetPurchaseOrdersStatus => $"{_resourceBaseUrl}/purchaseOrdersStatus";

            public static string GetPurchaseOrder(string purchaseOrderNumber)
            {
                return $"{_resourceBaseUrl}/purchaseOrders/{purchaseOrderNumber}";
            }
        }

        protected class VendorTransactionStatusApiUrls
        {
            private static readonly string _resourceBaseUrl = "/vendor/transactions/v1";

            public static string GetTransaction(string transactionId)
            {
                return $"{_resourceBaseUrl}/transactions/{transactionId}";
            }
        }

        protected class UploadApiUrls
        {
            private static readonly string _resourceBaseUrl = "/uploads/2020-11-01";

            public static string CreateUploadDestinationForResource(string resource)
            {
                return $"{_resourceBaseUrl}/uploadDestinations/{resource}";
            }
        }

        protected class InventoryApiUrls
        {
            private static readonly string _resourceBaseUrl = "/sell/inventory/v1";

            public static string bulkCreateOrReplaceInventoryItemUrl =>
                $"{_resourceBaseUrl}/bulk_create_or_replace_inventory_item";

            public static string InventoryItemUrl => $"{_resourceBaseUrl}/inventory_item";

            public static string InventoryItemGroupUrl => $"{_resourceBaseUrl}/inventory_item_group";

            public static string Offer => $"{_resourceBaseUrl}/offer";

            public static string BulkCreateOffer => $"{_resourceBaseUrl}/bulk_create_offer";

            public static string BulkPublishOffer => $"{_resourceBaseUrl}/bulk_publish_offer";

            public static string PublishByInventoryItemGroup => $"{_resourceBaseUrl}/publish_by_inventory_item_group";

            public static string WithdrawByInventoryItemGroup => $"{_resourceBaseUrl}/withdraw_by_inventory_item_group";

            public static string Location => $"{_resourceBaseUrl}/location";
        }

        protected class FinanceApiUrls
        {
            private static readonly string _resourceBaseUrl = "/finances/v0";

            public static string ListFinancialEventGroups => $"{_resourceBaseUrl}/financialEventGroups";

            public static string ListFinancialEvents => $"{_resourceBaseUrl}/financialEvents";

            public static string ListFinancialEventsByGroupId(string eventGroupId)
            {
                return $"{_resourceBaseUrl}/financialEventGroups/{eventGroupId}/financialEvents";
            }

            public static string ListFinancialEventsByOrderId(string orderId)
            {
                return $"{_resourceBaseUrl}/orders/{orderId}/financialEvents";
            }
        }

        protected class AccountApiUrls
        {
            private static readonly string _resourceBaseUrl = "/sell/account/v1";

            public static string returnPolicy => $"{_resourceBaseUrl}/return_policy";

            public static string FulfillmentPolicy => $"{_resourceBaseUrl}/fulfillment_policy";

            public static string PayementPolicy => $"{_resourceBaseUrl}/payment_policy";

            public static string Privilege => $"{_resourceBaseUrl}/privilege";
        }

        protected class ShipmentInvoicingApiUrls
        {
            private static readonly string _resourceBaseUrl = "/fba/outbound/brazil/v0";

            public static string GetShipmentDetails(string shipmentId)
            {
                return $"{_resourceBaseUrl}/shipments/{shipmentId}";
            }

            public static string SubmitInvoice(string shipmentId)
            {
                return $"{_resourceBaseUrl}/shipments/{shipmentId}/invoice";
            }

            public static string GetInvoiceStatus(string shipmentId)
            {
                return $"{_resourceBaseUrl}/shipments/{shipmentId}/invoice/status";
            }
        }

        protected class ProductFeeApiUrls
        {
            private static readonly string _resourceBaseUrl = "/products/fees/v0";

            public static string GetMyFeesEstimate => $"{_resourceBaseUrl}/feesEstimate";

            public static string GetMyFeesEstimateForSKU(string SellerSKU)
            {
                return $"{_resourceBaseUrl}/listings/{Uri.EscapeDataString(SellerSKU)}/feesEstimate";
            }

            public static string GetMyFeesEstimateForASIN(string Asin)
            {
                return $"{_resourceBaseUrl}/items/{Asin}/feesEstimate";
            }
        }

        protected class TokenApiUrls
        {
            private static readonly string _resourceBaseUrl = "/tokens/2021-03-01";

            public static string RestrictedDataToken => $"{_resourceBaseUrl}/restrictedDataToken";
        }

        protected class SolicitationsApiUrls
        {
            private static readonly string _resourceBaseUrl = "/solicitations/v1";

            public static string GetSolicitationActionsForOrder(string amazonOrderId)
            {
                return $"{_resourceBaseUrl}/orders/{amazonOrderId}";
            }

            public static string CreateProductReviewAndSellerFeedbackSolicitation(string amazonOrderId)
            {
                return $"{_resourceBaseUrl}/orders/{amazonOrderId}/solicitations/productReviewAndSellerFeedback";
            }
        }

        protected class FeedsApiUrls
        {
            private static readonly string _resourceBaseUrl = "/feeds/2021-06-30";

            public static string GetFeeds => $"{_resourceBaseUrl}/feeds";

            public static string CreateFeed => $"{_resourceBaseUrl}/feeds";

            public static string CreateFeedDocument => $"{_resourceBaseUrl}/documents";

            public static string GetFeedDocument(string feedDocumentId)
            {
                return $"{_resourceBaseUrl}/documents/{feedDocumentId}";
            }

            public static string GetFeed(string feedId)
            {
                return $"{_resourceBaseUrl}/feeds/{feedId}";
            }

            public static string CancelFeed(string feedId)
            {
                return $"{_resourceBaseUrl}/feeds/{feedId}";
            }
        }

        protected class FbaInventoriesApiUrls
        {
            private static readonly string _resourceBaseUrl = "/fba/inventory/v1";

            public static string GetInventorySummaries => $"{_resourceBaseUrl}/summaries";
        }

        public class OrdersApiUrls
        {
            private static readonly string _resourceBaseUrl = "/orders/v0";

            public static string Orders => $"{_resourceBaseUrl}/orders";

            public static string Order(string orderId)
            {
                return $"{_resourceBaseUrl}/orders/{orderId}";
            }

            public static string OrderItems(string orderId)
            {
                return $"{_resourceBaseUrl}/orders/{orderId}/orderItems";
            }

            public static string OrderBuyerInfo(string orderId)
            {
                return $"{_resourceBaseUrl}/orders/{orderId}/buyerInfo";
            }

            public static string OrderItemsBuyerInfo(string orderId)
            {
                return $"{_resourceBaseUrl}/orders/{orderId}/orderItems/buyerInfo";
            }

            public static string OrderShipmentInfo(string orderId)
            {
                return $"{_resourceBaseUrl}/orders/{orderId}/address";
            }

            public static string UpdateShipmentStatus(string orderId)
            {
                return $"{_resourceBaseUrl}/orders/{orderId}/shipment";
            }

            public static string GetOrderRegulatedInfo(string orderId)
            {
                return $"{_resourceBaseUrl}/orders/{orderId}/regulatedInfo";
            }

            public static string UpdateVerificationStatus(string orderId)
            {
                return $"{_resourceBaseUrl}/orders/{orderId}/regulatedInfo";
            }

            public static string GetOrderItemsApprovals(string orderId)
            {
                return $"{_resourceBaseUrl}/orders/{orderId}/approvals";
            }

            public static string UpdateOrderItemsApprovals(string orderId)
            {
                return $"{_resourceBaseUrl}/orders/{orderId}/approvals";
            }

            public static string ConfirmShipment(string orderId)
            {
                return $"{_resourceBaseUrl}/orders/{orderId}/shipmentConfirmation";
            }
        }

        protected class CategoryApiUrls
        {
            private static readonly string _resourceBaseUrl = "/catalog/v0";

            private static readonly string _202012resourceBaseUrl = "/catalog/2020-12-01";

            private static readonly string _202204resourceBaseUrl = "/catalog/2022-04-01";


            public static string ListCatalogItems => $"{_resourceBaseUrl}/items";

            public static string ListCatalogCategories => $"{_resourceBaseUrl}/categories";

            public static string SearchCatalogItems => $"{_202012resourceBaseUrl}/items";

            public static string SearchCatalogItems202204 => $"{_202204resourceBaseUrl}/items";

            public static string GetCatalogItem(string asin)
            {
                return $"{_resourceBaseUrl}/items/{asin}";
            }

            public static string GetCatalogItem202012(string asin)
            {
                return $"{_202012resourceBaseUrl}/items/{asin}";
            }

            public static string GetCatalogItem202204(string asin)
            {
                return $"{_202204resourceBaseUrl}/items/{asin}";
            }
        }

        protected class ListingsItemsApiUrls
        {
            private static readonly string _resourceBaseUrl = "/listings/2021-08-01";

            //https://stackoverflow.com/questions/575440/url-encoding-using-c-sharp/21771206#21771206
            public static string GetListingItem(string seller, string sku)
            {
                return $"{_resourceBaseUrl}/items/{seller}/{Uri.EscapeDataString(sku)}";
            }

            public static string PutListingItem(string seller, string sku)
            {
                return $"{_resourceBaseUrl}/items/{seller}/{Uri.EscapeDataString(sku)}";
            }

            public static string DeleteListingItem(string seller, string sku)
            {
                return $"{_resourceBaseUrl}/items/{seller}/{Uri.EscapeDataString(sku)}";
            }

            public static string PatchListingItem(string seller, string sku)
            {
                return $"{_resourceBaseUrl}/items/{seller}/{Uri.EscapeDataString(sku)}";
            }
        }

        protected class ListingsRestrictionsApi
        {
            private static readonly string _resourceBaseUrl = "/listings/2021-08-01";

            public static string GetListingsRestrictions()
            {
                return $"{_resourceBaseUrl}/restrictions";
            }
        }

        protected class ProductTypeDefinitionsApi
        {
            private static readonly string _resourceBaseUrl = "/definitions/2020-09-01/productTypes";
            public static string SearchDefinitionsProductTypes => $"{_resourceBaseUrl}";

            public static string GetDefinitionsProductType(string productType)
            {
                return $"{_resourceBaseUrl}/{productType}";
            }
        }
    }
}