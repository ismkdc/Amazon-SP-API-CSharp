using System.Threading;
using System.Threading.Tasks;
using FikaAmazonAPI.AmazonSpApiSDK.Models.Upload;
using FikaAmazonAPI.Parameter.Upload;
using FikaAmazonAPI.Utils;
using RestSharp;

namespace FikaAmazonAPI.Services
{
    public class UploadService : RequestService
    {
        public UploadService(AmazonCredential amazonCredential) : base(amazonCredential)
        {
        }

        public UploadDestination CreateUploadDestinationForResource(
            ParameterCreateUploadDestinationForResource parameterObj)
        {
            return Task.Run(() => CreateUploadDestinationForResourceAsync(parameterObj)).ConfigureAwait(false)
                .GetAwaiter().GetResult();
        }

        public async Task<UploadDestination> CreateUploadDestinationForResourceAsync(
            ParameterCreateUploadDestinationForResource parameterObj, CancellationToken cancellationToken = default)
        {
            if (parameterObj.marketplaceIds == null || parameterObj.marketplaceIds.Count == 0)
                parameterObj.marketplaceIds.Add(AmazonCredential.MarketPlace.ID);

            var parameter = parameterObj.getParameters();

            await CreateAuthorizedRequestAsync(UploadApiUrls.CreateUploadDestinationForResource(parameterObj.resource),
                Method.Post, parameter, cancellationToken: cancellationToken);
            var response =
                await ExecuteRequestAsync<CreateUploadDestinationResponse>(
                    RateLimitType.Upload_CreateUploadDestinationForResource, cancellationToken);
            return response.Payload;
        }
    }
}