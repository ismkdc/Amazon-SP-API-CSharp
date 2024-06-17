using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using FikaAmazonAPI.AmazonSpApiSDK.Models.Token;
using Newtonsoft.Json;
using RestSharp;
using Method = RestSharp.Method;

namespace FikaAmazonAPI.AmazonSpApiSDK.Runtime
{
    public class LWAClient
    {
        public const string AccessTokenKey = "access_token";
        public const string JsonMediaType = "application/json";


        public LWAClient(LWAAuthorizationCredentials lwaAuthorizationCredentials, IHttpClientFactory httpClientFactory,
            string proxyAddress = null)
        {
            LWAAuthorizationCredentials = lwaAuthorizationCredentials;
            LWAAccessTokenRequestMetaBuilder = new LWAAccessTokenRequestMetaBuilder();
            // RestClient = new RestClient(LWAAuthorizationCredentials.Endpoint.GetLeftPart(UriPartial.Authority));
            if (string.IsNullOrWhiteSpace(proxyAddress))
            {
                var options =
                    new RestClientOptions(LWAAuthorizationCredentials.Endpoint.GetLeftPart(UriPartial.Authority));
                RestClient = new RestClient(httpClientFactory.CreateClient(nameof(LWAClient)), options);
            }
            else
            {
                var options =
                    new RestClientOptions(LWAAuthorizationCredentials.Endpoint.GetLeftPart(UriPartial.Authority))
                    {
                        Proxy = new WebProxy
                        {
                            Address = new Uri(proxyAddress)
                        }
                    };

                RestClient = new RestClient(httpClientFactory.CreateClient(nameof(LWAClient)), options);
            }
        }

        public RestClient RestClient { get; set; }
        public LWAAccessTokenRequestMetaBuilder LWAAccessTokenRequestMetaBuilder { get; set; }
        public LWAAuthorizationCredentials LWAAuthorizationCredentials { get; }


        /// <summary>
        ///     Retrieves access token from LWA
        /// </summary>
        /// <param name="lwaAccessTokenRequestMeta">LWA AccessTokenRequest metadata</param>
        /// <returns>LWA Access Token</returns>
        public virtual async Task<TokenResponse> GetAccessTokenAsync(CancellationToken cancellationToken = default)
        {
            var lwaAccessTokenRequestMeta = LWAAccessTokenRequestMetaBuilder.Build(LWAAuthorizationCredentials);
            var accessTokenRequest = new RestRequest(LWAAuthorizationCredentials.Endpoint.AbsolutePath, Method.Post);

            var jsonRequestBody = JsonConvert.SerializeObject(lwaAccessTokenRequestMeta);

            //accessTokenRequest.AddParameter(JsonMediaType, jsonRequestBody, ParameterType.RequestBody);
            accessTokenRequest.AddJsonBody(jsonRequestBody);

            try
            {
                var response = await RestClient.ExecuteAsync(accessTokenRequest, cancellationToken)
                    .ConfigureAwait(false);

                if (!IsSuccessful(response))
                    throw new IOException("Unsuccessful LWA token exchange", response.ErrorException);

                var tokenService = new TokenResponse();

                var tokenRespoce = JsonConvert.DeserializeObject<TokenResponse>(response.Content);
                return tokenRespoce;
            }
            catch (Exception e)
            {
                throw new SystemException("Error getting LWA Access Token", e);
            }
        }

        private bool IsSuccessful(RestResponse response)
        {
            var statusCode = (int)response.StatusCode;
            return statusCode >= 200 && statusCode <= 299 && response.ResponseStatus == ResponseStatus.Completed;
        }
    }
}