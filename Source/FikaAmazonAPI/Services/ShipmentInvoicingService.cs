using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using FikaAmazonAPI.AmazonSpApiSDK.Models.ShipmentInvoicing;
using FikaAmazonAPI.Parameter;
using FikaAmazonAPI.Utils;
using RestSharp;

namespace FikaAmazonAPI.Services
{
    public class ShipmentInvoicingService : RequestService
    {
        public ShipmentInvoicingService(AmazonCredential amazonCredential, IHttpClientFactory httpClientFactory) : base(
            amazonCredential, httpClientFactory)
        {
        }

        public ShipmentDetail GetShipmentDetails(string shipmentId, ParameterBasedPII parameterBasedPII)
        {
            return Task.Run(() => GetShipmentDetailsAsync(shipmentId, parameterBasedPII)).ConfigureAwait(false)
                .GetAwaiter().GetResult();
        }

        public async Task<ShipmentDetail> GetShipmentDetailsAsync(string shipmentId,
            ParameterBasedPII parameterBasedPII, CancellationToken cancellationToken = default)
        {
            await CreateAuthorizedRequestAsync(ShipmentInvoicingApiUrls.GetShipmentDetails(shipmentId), Method.Get,
                parameter: parameterBasedPII, cancellationToken: cancellationToken);
            var response =
                await ExecuteRequestAsync<GetShipmentDetailsResponse>(
                    RateLimitType.ShipmentInvoicing_GetShipmentDetails, cancellationToken);

            if (response != null && response.Payload != null)
                return response.Payload;

            return null;
        }

        public bool SubmitInvoice(string shipmentId, SubmitInvoiceRequest submitInvoiceRequest)
        {
            return Task.Run(() => SubmitInvoiceAsync(shipmentId, submitInvoiceRequest)).ConfigureAwait(false)
                .GetAwaiter().GetResult();
        }

        public async Task<bool> SubmitInvoiceAsync(string shipmentId, SubmitInvoiceRequest submitInvoiceRequest,
            CancellationToken cancellationToken = default)
        {
            await CreateAuthorizedRequestAsync(ShipmentInvoicingApiUrls.SubmitInvoice(shipmentId), Method.Post,
                postJsonObj: submitInvoiceRequest, cancellationToken: cancellationToken);
            var response =
                await ExecuteRequestAsync<SubmitInvoiceResponse>(RateLimitType.ShipmentInvoicing_SubmitInvoice,
                    cancellationToken);

            return true;
        }

        public ShipmentInvoiceStatusInfo GetInvoiceStatus(string shipmentId)
        {
            return Task.Run(() => GetInvoiceStatusAsync(shipmentId)).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<ShipmentInvoiceStatusInfo> GetInvoiceStatusAsync(string shipmentId,
            CancellationToken cancellationToken = default)
        {
            await CreateAuthorizedRequestAsync(ShipmentInvoicingApiUrls.GetInvoiceStatus(shipmentId), Method.Get,
                cancellationToken: cancellationToken);
            var response =
                await ExecuteRequestAsync<GetInvoiceStatusResponse>(RateLimitType.ShipmentInvoicing_GetInvoiceStatus,
                    cancellationToken);

            if (response != null && response.Payload != null)
                return response.Payload;

            return null;
        }
    }
}