using System.Runtime.Serialization;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.ProductPricing
{
    public class GetBatchOffersResponse
    {
        [DataMember(Name = "responses", EmitDefaultValue = false)]
        public ItemOffersResponse[] Responses { get; set; }
    }
}