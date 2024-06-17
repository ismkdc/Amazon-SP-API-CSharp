using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FikaAmazonAPI.AmazonSpApiSDK.Models.Sales;
using FikaAmazonAPI.Parameter.Sales;
using FikaAmazonAPI.Utils;
using RestSharp;

namespace FikaAmazonAPI.Services
{
    public class SalesService : RequestService
    {
        public SalesService(AmazonCredential amazonCredential) : base(amazonCredential)
        {
        }


        public List<OrderMetricsInterval> GetOrderMetrics(ParameterGetOrderMetrics parameterGetOrderMetrics)
        {
            return Task.Run(() => GetOrderMetricsAsync(parameterGetOrderMetrics)).ConfigureAwait(false).GetAwaiter()
                .GetResult();
        }

        public async Task<List<OrderMetricsInterval>> GetOrderMetricsAsync(
            ParameterGetOrderMetrics parameterGetOrderMetrics, CancellationToken cancellationToken = default)
        {
            var param = parameterGetOrderMetrics.getParameters();
            await CreateAuthorizedRequestAsync(SalesApiUrls.GetOrderMetrics, Method.Get, param,
                cancellationToken: cancellationToken);
            var response =
                await ExecuteRequestAsync<GetOrderMetricsResponse>(RateLimitType.Sales_GetOrderMetrics,
                    cancellationToken);
            if (response != null && response.Payload != null)
                return response.Payload;
            return null;
        }
    }
}