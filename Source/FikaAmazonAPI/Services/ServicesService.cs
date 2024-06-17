using System.Net.Http;

namespace FikaAmazonAPI.Services
{
    public class ServicesService : RequestService
    {
        public ServicesService(AmazonCredential amazonCredential, IHttpClientFactory httpClientFactory) : base(
            amazonCredential, httpClientFactory)
        {
        }
    }
}