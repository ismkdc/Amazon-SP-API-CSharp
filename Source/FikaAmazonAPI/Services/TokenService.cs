using System.Net.Http;

namespace FikaAmazonAPI.Services
{
    public class TokenService : RequestService
    {
        public TokenService(AmazonCredential amazonCredential, IHttpClientFactory httpClientFactory) : base(
            amazonCredential, httpClientFactory)
        {
        }
    }
}