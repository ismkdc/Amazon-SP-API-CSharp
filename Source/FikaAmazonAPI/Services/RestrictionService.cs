using System.Threading;
using System.Threading.Tasks;
using FikaAmazonAPI.AmazonSpApiSDK.Models.Restrictions;
using FikaAmazonAPI.Parameter.Restrictions;
using FikaAmazonAPI.Utils;
using RestSharp;

namespace FikaAmazonAPI.Services
{
    public class RestrictionService : RequestService
    {
        public RestrictionService(AmazonCredential amazonCredential) : base(amazonCredential)
        {
        }


        public RestrictionList GetListingsRestrictions(ParameterGetListingsRestrictions parameter)
        {
            return Task.Run(() => GetListingsRestrictionsAsync(parameter)).ConfigureAwait(false).GetAwaiter()
                .GetResult();
        }

        public async Task<RestrictionList> GetListingsRestrictionsAsync(ParameterGetListingsRestrictions parameter,
            CancellationToken cancellationToken = default)
        {
            if (parameter.marketplaceIds == null || parameter.marketplaceIds.Count == 0)
                parameter.marketplaceIds.Add(AmazonCredential.MarketPlace.ID);
            var param = parameter.getParameters();
            await CreateAuthorizedRequestAsync(RestrictionsApiUrls.GetListingsRestrictions, Method.Get, param,
                cancellationToken: cancellationToken);
            return await ExecuteRequestAsync<RestrictionList>(RateLimitType.Restrictions_GetListingsRestrictions,
                cancellationToken);
        }
    }
}