﻿using Newtonsoft.Json;
using static FikaAmazonAPI.AmazonSpApiSDK.Services.ApiUrls;

namespace FikaAmazonAPI.Parameter.ProductPricing
{
    public class ItemOffersRequest
    {
        /// <summary>
        ///     The full URI corresponding to the API intended for request, including path parameter substitutions.
        /// </summary>
        [JsonProperty("uri")]
        public string Uri => ProductPricingApiUrls.GetItemOffers(QueryParams.Asin);

        /// <summary>
        ///     The HTTP method associated with the individual APIs being called as part of the batch request.
        /// </summary>
        [JsonProperty("method")]
        public HttpMethodEnum HttpMethod { get; set; }

        //[JsonProperty("headers")]
        //public Dictionary<string, string> Headers { get; set; }

        [JsonProperty("queryParams")] public ParameterGetItemOffers QueryParams { get; set; }

        ///// <summary>
        ///// A marketplace identifier. Specifies the marketplace for which prices are returned.
        ///// </summary>
        //[DataMember(Name = "MarketplaceId")]
        //public string MarketplaceId { get; set; }

        //[DataMember(Name = "ItemCondition")]
        //public ItemCondition ItemCondition { get; set; }

        //[DataMember(Name = "CustomerType")]
        //public CustomerType? CustomerType { get; set; }

        //[JsonIgnore]
        //public string Asin { get; set; }
    }
}