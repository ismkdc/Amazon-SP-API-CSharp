using System.Net.Http;

namespace FikaAmazonAPI.Services
{
    public class AplusContentService : RequestService
    {
        public AplusContentService(AmazonCredential amazonCredential, IHttpClientFactory httpClientFactory) : base(
            amazonCredential, httpClientFactory)
        {
        }
    }
}