using System.Collections.Generic;
using FikaAmazonAPI.Search;
using Newtonsoft.Json;

namespace FikaAmazonAPI.Parameter.ProductPricing
{
    public class ParameterGetListingOffersBatchRequest : ParameterBased
    {
        [JsonProperty("requests")] public List<ListingOffersRequest> ParameterGetListingOffers { get; set; }
    }
}