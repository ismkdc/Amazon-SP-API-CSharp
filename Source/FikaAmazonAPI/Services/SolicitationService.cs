﻿using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using FikaAmazonAPI.AmazonSpApiSDK.Models.Solicitations;
using FikaAmazonAPI.Utils;
using RestSharp;

namespace FikaAmazonAPI.Services
{
    public class SolicitationService : RequestService
    {
        public SolicitationService(AmazonCredential amazonCredential, IHttpClientFactory httpClientFactory) : base(
            amazonCredential, httpClientFactory)
        {
        }


        public GetSolicitationActionsForOrderResponseEmbedded GetSolicitationActionsForOrder(string orderId,
            List<KeyValuePair<string, string>> queryParameters = null)
        {
            return Task.Run(() => GetSolicitationActionsForOrderAsync(orderId, queryParameters)).ConfigureAwait(false)
                .GetAwaiter().GetResult();
        }

        public async Task<GetSolicitationActionsForOrderResponseEmbedded> GetSolicitationActionsForOrderAsync(
            string orderId, List<KeyValuePair<string, string>> queryParameters = null,
            CancellationToken cancellationToken = default)
        {
            await CreateAuthorizedRequestAsync(SolicitationsApiUrls.GetSolicitationActionsForOrder(orderId), Method.Get,
                queryParameters, cancellationToken: cancellationToken);
            var response =
                await ExecuteRequestAsync<GetSolicitationActionsForOrderResponse>(
                    RateLimitType.Solicitations_GetSolicitationActionsForOrder, cancellationToken);
            return response.Embedded;
        }

        public GetSolicitationActionsForOrderResponseEmbedded CreateProductReviewAndSellerFeedbackSolicitation(
            string orderId, List<KeyValuePair<string, string>> queryParameters = null)
        {
            return Task.Run(() => CreateProductReviewAndSellerFeedbackSolicitationAsync(orderId, queryParameters))
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<GetSolicitationActionsForOrderResponseEmbedded>
            CreateProductReviewAndSellerFeedbackSolicitationAsync(string orderId,
                List<KeyValuePair<string, string>> queryParameters = null,
                CancellationToken cancellationToken = default)
        {
            await CreateAuthorizedRequestAsync(
                SolicitationsApiUrls.CreateProductReviewAndSellerFeedbackSolicitation(orderId), Method.Post,
                queryParameters, cancellationToken: cancellationToken);
            var response = await ExecuteRequestAsync<GetSolicitationActionsForOrderResponse>(
                RateLimitType.Solicitations_CreateProductReviewAndSellerFeedbackSolicitation, cancellationToken);
            return response.Embedded;
        }
    }
}