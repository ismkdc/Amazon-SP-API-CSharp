using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using FikaAmazonAPI.AmazonSpApiSDK.Models.MerchantFulfillment;
using FikaAmazonAPI.AmazonSpApiSDK.Models.Token;
using FikaAmazonAPI.Search;
using FikaAmazonAPI.Utils;
using Method = RestSharp.Method;

namespace FikaAmazonAPI.Services
{
    public class MerchantFulfillmentService : RequestService
    {
        public MerchantFulfillmentService(AmazonCredential amazonCredential, IHttpClientFactory httpClientFactory) : base(
            amazonCredential, httpClientFactory)
        {
        }


        public GetEligibleShipmentServicesResult GetEligibleShipmentServicesOld(
            GetEligibleShipmentServicesRequest getEligibleShipmentServicesRequest)
        {
            return Task.Run(() => GetEligibleShipmentServicesOldAsync(getEligibleShipmentServicesRequest))
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<GetEligibleShipmentServicesResult> GetEligibleShipmentServicesOldAsync(
            GetEligibleShipmentServicesRequest getEligibleShipmentServicesRequest,
            CancellationToken cancellationToken = default)
        {
            await CreateAuthorizedRequestAsync(MerchantFulfillmentApiUrls.GetEligibleShipmentServicesOld, Method.Post,
                postJsonObj: getEligibleShipmentServicesRequest, cancellationToken: cancellationToken);

            var response = await ExecuteRequestAsync<GetEligibleShipmentServicesResponse>(
                RateLimitType.MerchantFulFillment_GetEligibleShipmentServicesOld, cancellationToken);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public GetEligibleShipmentServicesResult GetEligibleShipmentServices(
            GetEligibleShipmentServicesRequest getEligibleShipmentServicesRequest)
        {
            return Task.Run(() => GetEligibleShipmentServicesAsync(getEligibleShipmentServicesRequest))
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<GetEligibleShipmentServicesResult> GetEligibleShipmentServicesAsync(
            GetEligibleShipmentServicesRequest getEligibleShipmentServicesRequest,
            CancellationToken cancellationToken = default)
        {
            await CreateAuthorizedRequestAsync(MerchantFulfillmentApiUrls.GetEligibleShipmentServices, Method.Post,
                postJsonObj: getEligibleShipmentServicesRequest, cancellationToken: cancellationToken);

            var response =
                await ExecuteRequestAsync<GetEligibleShipmentServicesResponse>(
                    RateLimitType.MerchantFulFillment_GetEligibleShipmentServices, cancellationToken);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public Shipment GetShipment(string shipmentId, IParameterBasedPII ParameterBasedPII = null)
        {
            return Task.Run(() => GetShipmentAsync(shipmentId, ParameterBasedPII = null)).ConfigureAwait(false)
                .GetAwaiter().GetResult();
        }

        public async Task<Shipment> GetShipmentAsync(string shipmentId, IParameterBasedPII ParameterBasedPII = null,
            CancellationToken cancellationToken = default)
        {
            if (ParameterBasedPII != null && ParameterBasedPII.IsNeedRestrictedDataToken &&
                ParameterBasedPII.RestrictedDataTokenRequest == null)
            {
                var restrictedResource = new RestrictedResource();
                restrictedResource.method = AmazonSpApiSDK.Models.Token.Method.GET.ToString();
                restrictedResource.path = MerchantFulfillmentApiUrls.GetShipment(shipmentId);

                var createRDT = new CreateRestrictedDataTokenRequest
                {
                    restrictedResources = new List<RestrictedResource> { restrictedResource }
                };
                ParameterBasedPII.RestrictedDataTokenRequest = createRDT;
            }

            await CreateAuthorizedRequestAsync(MerchantFulfillmentApiUrls.GetShipment(shipmentId), Method.Get,
                parameter: ParameterBasedPII, cancellationToken: cancellationToken);

            var response = await ExecuteRequestAsync<GetShipmentResponse>(RateLimitType.MerchantFulFillment_GetShipment,
                cancellationToken);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public Shipment CancelShipment(string shipmentId, IParameterBasedPII parameterBasedPII = null)
        {
            return Task.Run(() => CancelShipmentAsync(shipmentId, parameterBasedPII)).ConfigureAwait(false).GetAwaiter()
                .GetResult();
        }

        public async Task<Shipment> CancelShipmentAsync(string shipmentId, IParameterBasedPII parameterBasedPII = null,
            CancellationToken cancellationToken = default)
        {
            if (parameterBasedPII != null && parameterBasedPII.IsNeedRestrictedDataToken &&
                parameterBasedPII.RestrictedDataTokenRequest == null)
            {
                var restrictedResource = new RestrictedResource();
                restrictedResource.method = AmazonSpApiSDK.Models.Token.Method.DELETE.ToString();
                restrictedResource.path = MerchantFulfillmentApiUrls.GetShipment(shipmentId);

                var createRDT = new CreateRestrictedDataTokenRequest
                {
                    restrictedResources = new List<RestrictedResource> { restrictedResource }
                };
                parameterBasedPII.RestrictedDataTokenRequest = createRDT;
            }

            await CreateAuthorizedRequestAsync(MerchantFulfillmentApiUrls.GetShipment(shipmentId), Method.Delete,
                parameter: parameterBasedPII, cancellationToken: cancellationToken);

            var response =
                await ExecuteRequestAsync<GetShipmentResponse>(RateLimitType.MerchantFulFillment_CancelShipment,
                    cancellationToken);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public Shipment CancelShipmentOld(string shipmentId, IParameterBasedPII parameterBasedPII = null)
        {
            return Task.Run(() => CancelShipmentOldAsync(shipmentId, parameterBasedPII)).ConfigureAwait(false)
                .GetAwaiter().GetResult();
        }

        public async Task<Shipment> CancelShipmentOldAsync(string shipmentId,
            IParameterBasedPII parameterBasedPII = null, CancellationToken cancellationToken = default)
        {
            if (parameterBasedPII != null && parameterBasedPII.IsNeedRestrictedDataToken &&
                parameterBasedPII.RestrictedDataTokenRequest == null)
            {
                var restrictedResource = new RestrictedResource();
                restrictedResource.method = AmazonSpApiSDK.Models.Token.Method.PUT.ToString();
                restrictedResource.path = MerchantFulfillmentApiUrls.CancelShipmentOld(shipmentId);

                var createRDT = new CreateRestrictedDataTokenRequest
                {
                    restrictedResources = new List<RestrictedResource> { restrictedResource }
                };
                parameterBasedPII.RestrictedDataTokenRequest = createRDT;
            }

            await CreateAuthorizedRequestAsync(MerchantFulfillmentApiUrls.CancelShipmentOld(shipmentId), Method.Put,
                parameter: parameterBasedPII, cancellationToken: cancellationToken);

            var response =
                await ExecuteRequestAsync<GetShipmentResponse>(RateLimitType.MerchantFulFillment_CancelShipmentOld,
                    cancellationToken);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public Shipment CreateShipment(CreateShipmentRequest createShipmentRequest,
            IParameterBasedPII parameterBasedPII = null)
        {
            return Task.Run(() => CreateShipmentAsync(createShipmentRequest, parameterBasedPII)).ConfigureAwait(false)
                .GetAwaiter().GetResult();
        }

        public async Task<Shipment> CreateShipmentAsync(CreateShipmentRequest createShipmentRequest,
            IParameterBasedPII parameterBasedPII = null, CancellationToken cancellationToken = default)
        {
            if (parameterBasedPII != null && parameterBasedPII.IsNeedRestrictedDataToken &&
                parameterBasedPII.RestrictedDataTokenRequest == null)
            {
                var restrictedResource = new RestrictedResource();
                restrictedResource.method = AmazonSpApiSDK.Models.Token.Method.POST.ToString();
                restrictedResource.path = MerchantFulfillmentApiUrls.CreateShipment;

                var createRDT = new CreateRestrictedDataTokenRequest
                {
                    restrictedResources = new List<RestrictedResource> { restrictedResource }
                };
                parameterBasedPII.RestrictedDataTokenRequest = createRDT;
            }

            await CreateAuthorizedRequestAsync(MerchantFulfillmentApiUrls.CreateShipment, Method.Post,
                postJsonObj: createShipmentRequest, parameter: parameterBasedPII, cancellationToken: cancellationToken);

            var response =
                await ExecuteRequestAsync<CreateShipmentResponse>(RateLimitType.MerchantFulFillment_CreateShipment,
                    cancellationToken);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public GetAdditionalSellerInputsResult GetAdditionalSellerInputsOld(
            GetAdditionalSellerInputsRequest getAdditionalSellerInputsRequest)
        {
            return Task.Run(() => GetAdditionalSellerInputsOldAsync(getAdditionalSellerInputsRequest))
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<GetAdditionalSellerInputsResult> GetAdditionalSellerInputsOldAsync(
            GetAdditionalSellerInputsRequest getAdditionalSellerInputsRequest,
            CancellationToken cancellationToken = default)
        {
            await CreateAuthorizedRequestAsync(MerchantFulfillmentApiUrls.GetAdditionalSellerInputsOld, Method.Post,
                postJsonObj: getAdditionalSellerInputsRequest, cancellationToken: cancellationToken);

            var response =
                await ExecuteRequestAsync<GetAdditionalSellerInputsResponse>(
                    RateLimitType.MerchantFulFillment_GetAdditionalSellerInputsOld, cancellationToken);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }

        public GetAdditionalSellerInputsResult GetAdditionalSellerInputs(
            GetAdditionalSellerInputsRequest getAdditionalSellerInputsRequest)
        {
            return Task.Run(() => GetAdditionalSellerInputsAsync(getAdditionalSellerInputsRequest))
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<GetAdditionalSellerInputsResult> GetAdditionalSellerInputsAsync(
            GetAdditionalSellerInputsRequest getAdditionalSellerInputsRequest,
            CancellationToken cancellationToken = default)
        {
            await CreateAuthorizedRequestAsync(MerchantFulfillmentApiUrls.GetAdditionalSellerInputs, Method.Post,
                postJsonObj: getAdditionalSellerInputsRequest, cancellationToken: cancellationToken);

            var response =
                await ExecuteRequestAsync<GetAdditionalSellerInputsResponse>(
                    RateLimitType.MerchantFulFillment_GetAdditionalSellerInputs, cancellationToken);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }
    }
}