using System.Collections.Generic;
using FikaAmazonAPI.Search;
using Newtonsoft.Json;

namespace FikaAmazonAPI.Parameter.ProductPricing
{
    public class ParameterGetItemOffersBatchRequest : ParameterBased
    {
        [JsonProperty("requests")] public List<ItemOffersRequest> ParameterGetItemOffers { get; set; }
    }
}