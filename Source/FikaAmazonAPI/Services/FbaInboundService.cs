using System.Net.Http;

namespace FikaAmazonAPI.Services
{
    public class FbaInboundService : RequestService
    {
        public FbaInboundService(AmazonCredential amazonCredential, IHttpClientFactory httpClientFactory) : base(
            amazonCredential, httpClientFactory)
        {
        }
    }
}