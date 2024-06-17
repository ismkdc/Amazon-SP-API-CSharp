using System.Threading;
using System.Threading.Tasks;
using FikaAmazonAPI.AmazonSpApiSDK.Models.FbaInbound;
using FikaAmazonAPI.Parameter.FbaInboundEligibility;
using FikaAmazonAPI.Utils;
using RestSharp;

namespace FikaAmazonAPI.Services
{
    public class FbaInboundEligibilityService : RequestService
    {
        public FbaInboundEligibilityService(AmazonCredential amazonCredential) : base(amazonCredential)
        {
        }

        public ItemEligibilityPreview GetItemEligibilityPreview(
            ParameterGetItemEligibilityPreview parameterGetItemEligibilityPreview)
        {
            return Task.Run(() => GetItemEligibilityPreviewAsync(parameterGetItemEligibilityPreview))
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<ItemEligibilityPreview> GetItemEligibilityPreviewAsync(
            ParameterGetItemEligibilityPreview parameterGetItemEligibilityPreview,
            CancellationToken cancellationToken = default)
        {
            var parameter = parameterGetItemEligibilityPreview.getParameters();
            await CreateAuthorizedRequestAsync(FBAInboundEligibiltyApiUrls.GetItemEligibilityPreview, Method.Get,
                parameter, cancellationToken: cancellationToken);
            var response =
                await ExecuteRequestAsync<GetItemEligibilityPreviewResponse>(
                    RateLimitType.FBAInboundEligibility_GetItemEligibilityPreview, cancellationToken);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }
    }
}