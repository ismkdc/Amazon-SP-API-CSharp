using System.Threading;
using System.Threading.Tasks;
using FikaAmazonAPI.AmazonSpApiSDK.Models.ProductTypes;
using FikaAmazonAPI.Parameter.ProductTypes;
using FikaAmazonAPI.Utils;
using RestSharp;

namespace FikaAmazonAPI.Services
{
    public class ProductTypeService : RequestService
    {
        public ProductTypeService(AmazonCredential amazonCredential) : base(amazonCredential)
        {
        }


        public ProductTypeList SearchDefinitionsProductTypes(SearchDefinitionsProductTypesParameter parameter)
        {
            return Task.Run(() => SearchDefinitionsProductTypesAsync(parameter)).ConfigureAwait(false).GetAwaiter()
                .GetResult();
        }

        public async Task<ProductTypeList> SearchDefinitionsProductTypesAsync(
            SearchDefinitionsProductTypesParameter parameter, CancellationToken cancellationToken = default)
        {
            if (parameter.marketplaceIds == null || parameter.marketplaceIds.Count == 0)
                parameter.marketplaceIds.Add(AmazonCredential.MarketPlace.ID);

            var param = parameter.getParameters();

            await CreateAuthorizedRequestAsync(ProductTypeApiUrls.SearchDefinitionsProductTypes, Method.Get, param,
                cancellationToken: cancellationToken);
            return await ExecuteRequestAsync<ProductTypeList>(RateLimitType.ProductTypes_SearchDefinitionsProductTypes,
                cancellationToken);
        }


        public ProductTypeDefinition GetDefinitionsProductType(GetDefinitionsProductTypeParameter parameter)
        {
            return Task.Run(() => SearchDefinitionsProductTypesAsync(parameter)).ConfigureAwait(false).GetAwaiter()
                .GetResult();
        }

        public async Task<ProductTypeDefinition> SearchDefinitionsProductTypesAsync(
            GetDefinitionsProductTypeParameter parameter, CancellationToken cancellationToken = default)
        {
            if (parameter.marketplaceIds == null || parameter.marketplaceIds.Count == 0)
                parameter.marketplaceIds.Add(AmazonCredential.MarketPlace.ID);


            var param = parameter.getParameters();

            await CreateAuthorizedRequestAsync(ProductTypeApiUrls.GetDefinitionsProductType(parameter.productType),
                Method.Get, param, cancellationToken: cancellationToken);
            return await ExecuteRequestAsync<ProductTypeDefinition>(
                RateLimitType.ProductTypes_GetDefinitionsProductType, cancellationToken);
        }
    }
}