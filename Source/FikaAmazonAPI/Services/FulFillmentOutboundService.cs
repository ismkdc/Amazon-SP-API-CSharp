using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentOutbound;
using FikaAmazonAPI.Parameter.FulFillmentInbound;
using FikaAmazonAPI.Parameter.FulFillmentOutbound;
using FikaAmazonAPI.Utils;
using RestSharp;

namespace FikaAmazonAPI.Services
{
    public class FulFillmentOutboundService : RequestService
    {
        public FulFillmentOutboundService(AmazonCredential amazonCredential) : base(amazonCredential)
        {
        }

        public GetFulfillmentPreviewResult GetFulfillmentPreview(
            GetFulfillmentPreviewRequest getFulfillmentPreviewRequest)
        {
            return Task.Run(() => GetFulfillmentPreviewAsync(getFulfillmentPreviewRequest)).ConfigureAwait(false)
                .GetAwaiter().GetResult();
        }

        public async Task<GetFulfillmentPreviewResult> GetFulfillmentPreviewAsync(
            GetFulfillmentPreviewRequest getFulfillmentPreviewRequest, CancellationToken cancellationToken = default)
        {
            await CreateAuthorizedRequestAsync(FulFillmentOutboundApiUrls.GetFulfillmentPreview, Method.Post,
                postJsonObj: getFulfillmentPreviewRequest, cancellationToken: cancellationToken);

            var response =
                await ExecuteRequestAsync<GetFulfillmentPreviewResponse>(
                    RateLimitType.FulFillmentOutbound_GetFulfillmentPreview, cancellationToken);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public ListAllFulfillmentOrdersResult ListAllFulfillmentOrders(
            ParameterListAllFulfillmentOrders parameterListAllFulfillmentOrders)
        {
            return Task.Run(() => ListAllFulfillmentOrdersAsync(parameterListAllFulfillmentOrders))
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<ListAllFulfillmentOrdersResult> ListAllFulfillmentOrdersAsync(
            ParameterListAllFulfillmentOrders parameterListAllFulfillmentOrders,
            CancellationToken cancellationToken = default)
        {
            var parameter = parameterListAllFulfillmentOrders.getParameters();
            await CreateAuthorizedRequestAsync(FulFillmentOutboundApiUrls.ListAllFulfillmentOrders, Method.Get,
                parameter, cancellationToken: cancellationToken);

            var response =
                await ExecuteRequestAsync<ListAllFulfillmentOrdersResponse>(
                    RateLimitType.FulFillmentOutbound_ListAllFulfillmentOrders, cancellationToken);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public bool CreateFulfillmentOrder(CreateFulfillmentOrderRequest createFulfillmentOrderRequest)
        {
            return Task.Run(() => CreateFulfillmentOrderAsync(createFulfillmentOrderRequest)).ConfigureAwait(false)
                .GetAwaiter().GetResult();
        }

        public async Task<bool> CreateFulfillmentOrderAsync(CreateFulfillmentOrderRequest createFulfillmentOrderRequest,
            CancellationToken cancellationToken = default)
        {
            await CreateAuthorizedRequestAsync(FulFillmentOutboundApiUrls.CreateFulfillmentOrder, Method.Post,
                postJsonObj: createFulfillmentOrderRequest, cancellationToken: cancellationToken);

            var response =
                await ExecuteRequestAsync<CreateFulfillmentOrderResponse>(
                    RateLimitType.FulFillmentOutbound_CreateFulfillmentOrder, cancellationToken);
            if (response != null && response.Errors != null && response.Errors.Count > 0)
                return false;
            return true;
        }

        public PackageTrackingDetails GetPackageTrackingDetails(int packageNumber)
        {
            return Task.Run(() => GetPackageTrackingDetailsAsync(packageNumber)).ConfigureAwait(false).GetAwaiter()
                .GetResult();
        }

        public async Task<PackageTrackingDetails> GetPackageTrackingDetailsAsync(int packageNumber,
            CancellationToken cancellationToken = default)
        {
            var queryParameters = new List<KeyValuePair<string, string>>();
            queryParameters.Add(new KeyValuePair<string, string>("packageNumber", packageNumber.ToString()));

            await CreateAuthorizedRequestAsync(FulFillmentOutboundApiUrls.GetPackageTrackingDetails, Method.Get,
                queryParameters, cancellationToken: cancellationToken);

            var response =
                await ExecuteRequestAsync<GetPackageTrackingDetailsResponse>(
                    RateLimitType.FulFillmentOutbound_GetPackageTrackingDetails, cancellationToken);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public ListReturnReasonCodesResult ListReturnReasonCodes(
            ParameterListReturnReasonCodes parameterListReturnReasonCodes)
        {
            return Task.Run(() => ListReturnReasonCodesAsync(parameterListReturnReasonCodes)).ConfigureAwait(false)
                .GetAwaiter().GetResult();
        }

        public async Task<ListReturnReasonCodesResult> ListReturnReasonCodesAsync(
            ParameterListReturnReasonCodes parameterListReturnReasonCodes,
            CancellationToken cancellationToken = default)
        {
            var parameter = parameterListReturnReasonCodes.getParameters();

            await CreateAuthorizedRequestAsync(FulFillmentOutboundApiUrls.ListReturnReasonCodes, Method.Get, parameter,
                cancellationToken: cancellationToken);

            var response =
                await ExecuteRequestAsync<ListReturnReasonCodesResponse>(
                    RateLimitType.FulFillmentOutbound_ListReturnReasonCodes, cancellationToken);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public CreateFulfillmentReturnResult ListReturnReasonCodes(string sellerFulfillmentOrderId,
            CreateFulfillmentReturnRequest createFulfillmentReturnRequest)
        {
            return Task.Run(() => ListReturnReasonCodesAsync(sellerFulfillmentOrderId, createFulfillmentReturnRequest))
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<CreateFulfillmentReturnResult> ListReturnReasonCodesAsync(string sellerFulfillmentOrderId,
            CreateFulfillmentReturnRequest createFulfillmentReturnRequest,
            CancellationToken cancellationToken = default)
        {
            await CreateAuthorizedRequestAsync(
                FulFillmentOutboundApiUrls.CreateFulfillmentReturn(sellerFulfillmentOrderId), Method.Put,
                postJsonObj: createFulfillmentReturnRequest, cancellationToken: cancellationToken);

            var response =
                await ExecuteRequestAsync<CreateFulfillmentReturnResponse>(
                    RateLimitType.FulFillmentOutbound_ListReturnReasonCodes, cancellationToken);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public GetFulfillmentOrderResult GetFulfillmentOrder(string sellerFulfillmentOrderId)
        {
            return Task.Run(() => GetFulfillmentOrderAsync(sellerFulfillmentOrderId)).ConfigureAwait(false).GetAwaiter()
                .GetResult();
        }

        public async Task<GetFulfillmentOrderResult> GetFulfillmentOrderAsync(string sellerFulfillmentOrderId,
            CancellationToken cancellationToken = default)
        {
            await CreateAuthorizedRequestAsync(FulFillmentOutboundApiUrls.GetFulfillmentOrder(sellerFulfillmentOrderId),
                Method.Get, cancellationToken: cancellationToken);

            var response =
                await ExecuteRequestAsync<GetFulfillmentOrderResponse>(
                    RateLimitType.FulFillmentOutbound_GetFulfillmentOrder, cancellationToken);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public bool UpdateFulfillmentOrder(string sellerFulfillmentOrderId,
            UpdateFulfillmentOrderRequest updateFulfillmentOrderRequest)
        {
            return Task.Run(() => UpdateFulfillmentOrderAsync(sellerFulfillmentOrderId, updateFulfillmentOrderRequest))
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<bool> UpdateFulfillmentOrderAsync(string sellerFulfillmentOrderId,
            UpdateFulfillmentOrderRequest updateFulfillmentOrderRequest, CancellationToken cancellationToken = default)
        {
            await CreateAuthorizedRequestAsync(
                FulFillmentOutboundApiUrls.UpdateFulfillmentOrder(sellerFulfillmentOrderId), Method.Put,
                postJsonObj: updateFulfillmentOrderRequest, cancellationToken: cancellationToken);

            var response =
                await ExecuteRequestAsync<UpdateFulfillmentOrderResponse>(
                    RateLimitType.FulFillmentOutbound_UpdateFulfillmentOrder, cancellationToken);
            if (response != null && response.Errors != null && response.Errors.Count > 0)
                return false;
            return true;
        }

        public bool CancelFulfillmentOrder(string sellerFulfillmentOrderId)
        {
            return Task.Run(() => CancelFulfillmentOrderAsync(sellerFulfillmentOrderId)).ConfigureAwait(false)
                .GetAwaiter().GetResult();
        }

        public async Task<bool> CancelFulfillmentOrderAsync(string sellerFulfillmentOrderId,
            CancellationToken cancellationToken = default)
        {
            await CreateAuthorizedRequestAsync(
                FulFillmentOutboundApiUrls.CancelFulfillmentOrder(sellerFulfillmentOrderId), Method.Put,
                cancellationToken: cancellationToken);

            var response =
                await ExecuteRequestAsync<CancelFulfillmentOrderResponse>(
                    RateLimitType.FulFillmentOutbound_UpdateFulfillmentOrder, cancellationToken);
            if (response != null && response.Errors != null && response.Errors.Count > 0)
                return false;
            return true;
        }

        public GetFeaturesResult GetFeatures()
        {
            return Task.Run(() => GetFeaturesAsync()).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<GetFeaturesResult> GetFeaturesAsync(CancellationToken cancellationToken = default)
        {
            var queryParameters = new List<KeyValuePair<string, string>>();
            queryParameters.Add(new KeyValuePair<string, string>("MarketplaceId", AmazonCredential.MarketPlace.ID));

            await CreateAuthorizedRequestAsync(FulFillmentOutboundApiUrls.GetFeatures, Method.Get, queryParameters,
                cancellationToken: cancellationToken);

            var response = await ExecuteRequestAsync<GetFeaturesResponse>(RateLimitType.FulFillmentOutbound_GetFeatures,
                cancellationToken);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public GetFeatureInventoryResult GetFeatureInventory(string featureName, string nextToken)
        {
            return Task.Run(() => GetFeatureInventoryAsync(featureName, nextToken)).ConfigureAwait(false).GetAwaiter()
                .GetResult();
        }

        public async Task<GetFeatureInventoryResult> GetFeatureInventoryAsync(string featureName, string nextToken,
            CancellationToken cancellationToken = default)
        {
            var queryParameters = new List<KeyValuePair<string, string>>();
            queryParameters.Add(new KeyValuePair<string, string>("MarketplaceId", AmazonCredential.MarketPlace.ID));
            if (string.IsNullOrEmpty(nextToken))
                queryParameters.Add(new KeyValuePair<string, string>("nextToken", nextToken));
            if (string.IsNullOrEmpty(featureName))
                queryParameters.Add(new KeyValuePair<string, string>("featureName", featureName));

            await CreateAuthorizedRequestAsync(FulFillmentOutboundApiUrls.GetFeatureInventory(featureName), Method.Get,
                queryParameters, cancellationToken: cancellationToken);

            var response =
                await ExecuteRequestAsync<GetFeatureInventoryResponse>(
                    RateLimitType.FulFillmentOutbound_GetFeatureInventory, cancellationToken);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public GetFeatureSkuResult GetFeatureSKU(string featureName, string sellerSku, string nextToken)
        {
            return Task.Run(() => GetFeatureSKUAsync(featureName, sellerSku, nextToken)).ConfigureAwait(false)
                .GetAwaiter().GetResult();
        }

        public async Task<GetFeatureSkuResult> GetFeatureSKUAsync(string featureName, string sellerSku,
            string nextToken, CancellationToken cancellationToken = default)
        {
            var queryParameters = new List<KeyValuePair<string, string>>();
            queryParameters.Add(new KeyValuePair<string, string>("MarketplaceId", AmazonCredential.MarketPlace.ID));
            if (string.IsNullOrEmpty(nextToken))
                queryParameters.Add(new KeyValuePair<string, string>("nextToken", nextToken));
            if (string.IsNullOrEmpty(featureName))
                queryParameters.Add(new KeyValuePair<string, string>("featureName", featureName));

            await CreateAuthorizedRequestAsync(FulFillmentOutboundApiUrls.GetFeatureSKU(featureName, sellerSku),
                Method.Get, queryParameters, cancellationToken: cancellationToken);

            var response =
                await ExecuteRequestAsync<GetFeatureSkuResponse>(RateLimitType.FulFillmentOutbound_GetFeatureSKU,
                    cancellationToken);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }
    }
}