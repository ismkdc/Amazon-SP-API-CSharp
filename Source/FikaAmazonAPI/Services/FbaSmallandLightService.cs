using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using FikaAmazonAPI.AmazonSpApiSDK.Models.FbaSmallandLight;
using FikaAmazonAPI.Utils;
using RestSharp;

namespace FikaAmazonAPI.Services
{
    public class FbaSmallandLightService : RequestService
    {
        public FbaSmallandLightService(AmazonCredential amazonCredential, IHttpClientFactory httpClientFactory) : base(
            amazonCredential, httpClientFactory)
        {
        }


        public SmallAndLightEnrollment GetSmallAndLightEnrollmentBySellerSKU(string sellerSKU)
        {
            return Task.Run(() => GetSmallAndLightEnrollmentBySellerSKUAsync(sellerSKU)).ConfigureAwait(false)
                .GetAwaiter().GetResult();
        }

        public async Task<SmallAndLightEnrollment> GetSmallAndLightEnrollmentBySellerSKUAsync(string sellerSKU,
            CancellationToken cancellationToken = default)
        {
            var queryParameters = new List<KeyValuePair<string, string>>();
            queryParameters.Add(new KeyValuePair<string, string>("marketplaceIds", AmazonCredential.MarketPlace.ID));

            await CreateAuthorizedRequestAsync(FBASmallAndLightApiUrls.GetSmallAndLightEnrollmentBySellerSKU(sellerSKU),
                Method.Get, queryParameters, cancellationToken: cancellationToken);

            var response = await ExecuteRequestAsync<SmallAndLightEnrollment>(
                RateLimitType.FbaSmallandLight_GetSmallAndLightEnrollmentBySellerSKU, cancellationToken);

            return response;
        }

        public SmallAndLightEnrollment PutSmallAndLightEnrollmentBySellerSKU(string sellerSKU)
        {
            return Task.Run(() => PutSmallAndLightEnrollmentBySellerSKUAsync(sellerSKU)).ConfigureAwait(false)
                .GetAwaiter().GetResult();
        }

        public async Task<SmallAndLightEnrollment> PutSmallAndLightEnrollmentBySellerSKUAsync(string sellerSKU,
            CancellationToken cancellationToken = default)
        {
            var queryParameters = new List<KeyValuePair<string, string>>();
            queryParameters.Add(new KeyValuePair<string, string>("marketplaceIds", AmazonCredential.MarketPlace.ID));


            await CreateAuthorizedRequestAsync(FBASmallAndLightApiUrls.PutSmallAndLightEnrollmentBySellerSKU(sellerSKU),
                Method.Put, queryParameters, cancellationToken: cancellationToken);

            var response = await ExecuteRequestAsync<SmallAndLightEnrollment>(
                RateLimitType.FbaSmallandLight_PutSmallAndLightEnrollmentBySellerSKU, cancellationToken);

            return response;
        }

        public bool DeleteSmallAndLightEnrollmentBySellerSKU(string sellerSKU)
        {
            return Task.Run(() => DeleteSmallAndLightEnrollmentBySellerSKUAsync(sellerSKU)).ConfigureAwait(false)
                .GetAwaiter().GetResult();
        }

        public async Task<bool> DeleteSmallAndLightEnrollmentBySellerSKUAsync(string sellerSKU,
            CancellationToken cancellationToken = default)
        {
            var queryParameters = new List<KeyValuePair<string, string>>();
            queryParameters.Add(new KeyValuePair<string, string>("marketplaceIds", AmazonCredential.MarketPlace.ID));


            await CreateAuthorizedRequestAsync(
                FBASmallAndLightApiUrls.DeleteSmallAndLightEnrollmentBySellerSKU(sellerSKU), Method.Delete,
                queryParameters, cancellationToken: cancellationToken);

            var response =
                await ExecuteRequestAsync<object>(
                    RateLimitType.FbaSmallandLight_DeleteSmallAndLightEnrollmentBySellerSKU, cancellationToken);

            return true;
        }

        public SmallAndLightEligibility GetSmallAndLightEligibilityBySellerSKU(string sellerSKU)
        {
            return Task.Run(() => GetSmallAndLightEligibilityBySellerSKUAsync(sellerSKU)).ConfigureAwait(false)
                .GetAwaiter().GetResult();
        }

        public async Task<SmallAndLightEligibility> GetSmallAndLightEligibilityBySellerSKUAsync(string sellerSKU,
            CancellationToken cancellationToken = default)
        {
            var queryParameters = new List<KeyValuePair<string, string>>();
            queryParameters.Add(new KeyValuePair<string, string>("marketplaceIds", AmazonCredential.MarketPlace.ID));


            await CreateAuthorizedRequestAsync(
                FBASmallAndLightApiUrls.GetSmallAndLightEligibilityBySellerSKU(sellerSKU), Method.Get, queryParameters,
                cancellationToken: cancellationToken);

            var response = await ExecuteRequestAsync<SmallAndLightEligibility>(
                RateLimitType.FbaSmallandLight_GetSmallAndLightEligibilityBySellerSKU, cancellationToken);

            return response;
        }

        public List<FeePreview> GetSmallAndLightFeePreview(
            SmallAndLightFeePreviewRequest smallAndLightFeePreviewRequest)
        {
            return Task.Run(() => GetSmallAndLightFeePreviewAsync(smallAndLightFeePreviewRequest)).ConfigureAwait(false)
                .GetAwaiter().GetResult();
        }

        public async Task<List<FeePreview>> GetSmallAndLightFeePreviewAsync(
            SmallAndLightFeePreviewRequest smallAndLightFeePreviewRequest,
            CancellationToken cancellationToken = default)
        {
            await CreateAuthorizedRequestAsync(FBASmallAndLightApiUrls.GetSmallAndLightFeePreview, Method.Post,
                postJsonObj: smallAndLightFeePreviewRequest, cancellationToken: cancellationToken);

            var response =
                await ExecuteRequestAsync<SmallAndLightFeePreviews>(
                    RateLimitType.FbaSmallandLight_GetSmallAndLightFeePreview, cancellationToken);
            if (response != null && response.Data != null)
                return response.Data;

            return null;
        }
    }
}