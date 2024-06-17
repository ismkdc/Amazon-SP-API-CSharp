using System.Threading;
using System.Threading.Tasks;
using FikaAmazonAPI.AmazonSpApiSDK.Models.ShippingV2;
using FikaAmazonAPI.Utils;
using RestSharp;

namespace FikaAmazonAPI.Services
{
    public class ShippingServiceV2 : RequestService
    {
        public ShippingServiceV2(AmazonCredential amazonCredential) : base(amazonCredential)
        {
        }

        public bool CancelShipment(string shipmentId)
        {
            return Task.Run(() => CancelShipmentAsync(shipmentId)).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<bool> CancelShipmentAsync(string shipmentId, CancellationToken cancellationToken = default)
        {
            await CreateAuthorizedRequestAsync(ShippingApiV2Urls.CancelShipment(shipmentId), Method.Put,
                cancellationToken: cancellationToken);
            var response =
                await ExecuteRequestAsync<CancelShipmentResponse>(RateLimitType.ShippingV2_CancelShipment,
                    cancellationToken);
            if (response != null)
                return true;
            return false;
        }


        public PurchaseShipmentResult PurchaseShipment(PurchaseShipmentRequest purchaseShipmentRequest)
        {
            return Task.Run(() => PurchaseShipmentAsync(purchaseShipmentRequest)).ConfigureAwait(false).GetAwaiter()
                .GetResult();
        }

        public async Task<PurchaseShipmentResult> PurchaseShipmentAsync(PurchaseShipmentRequest purchaseShipmentRequest,
            CancellationToken cancellationToken = default)
        {
            await CreateAuthorizedRequestAsync(ShippingApiV2Urls.PurchaseShipment, Method.Post,
                postJsonObj: purchaseShipmentRequest, cancellationToken: cancellationToken);
            var response =
                await ExecuteRequestAsync<PurchaseShipmentResponse>(RateLimitType.ShippingV2_PurchaseShipment,
                    cancellationToken);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public GetRatesResult GetRates(GetRatesRequest getRatesRequest)
        {
            return Task.Run(() => GetRatesAsync(getRatesRequest)).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<GetRatesResult> GetRatesAsync(GetRatesRequest getRatesRequest,
            CancellationToken cancellationToken = default)
        {
            await CreateAuthorizedRequestAsync(ShippingApiV2Urls.GetRates, Method.Post, postJsonObj: getRatesRequest,
                cancellationToken: cancellationToken);
            var response =
                await ExecuteRequestAsync<GetRatesResponse>(RateLimitType.ShippingV2_GetRates, cancellationToken);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public GetTrackingResult GetTracking(string carrierId, string trackingId)
        {
            return Task.Run(() => GetTrackingAsync(carrierId, trackingId)).ConfigureAwait(false).GetAwaiter()
                .GetResult();
        }

        public async Task<GetTrackingResult> GetTrackingAsync(string carrierId, string trackingId,
            CancellationToken cancellationToken = default)
        {
            await CreateAuthorizedRequestAsync(ShippingApiV2Urls.GetTracking(carrierId, trackingId), Method.Get,
                cancellationToken: cancellationToken);
            var response =
                await ExecuteRequestAsync<GetTrackingResponse>(RateLimitType.ShippingV2_GetTracking, cancellationToken);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }
    }
}