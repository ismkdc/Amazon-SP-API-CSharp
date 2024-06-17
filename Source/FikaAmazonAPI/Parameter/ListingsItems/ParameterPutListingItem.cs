using System.Collections.Generic;
using System.IO;
using System.Linq;
using FikaAmazonAPI.Search;
using FikaAmazonAPI.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FikaAmazonAPI.Parameter.ListingItem
{
    public class ParameterPutListingItem : ParameterBased
    {
        [PathParameter] public string sellerId { get; set; }

        [PathParameter] public string sku { get; set; }

        public ICollection<string> marketplaceIds { get; set; }

        public string issueLocale { get; set; }

        [BodyParameter] public ListingsItemPutRequest listingsItemPutRequest { get; set; }

        public bool Check()
        {
            if (TestCase == Constants.TestCase400)
                sku = "BadSKU";
            if (string.IsNullOrWhiteSpace(sellerId))
                throw new InvalidDataException(
                    "SellerId is a required property for ParameterPutListingItem and cannot be null");
            if (string.IsNullOrWhiteSpace(sku))
                throw new InvalidDataException(
                    "Sku is a required property for ParameterPutListingItem and cannot be null");
            if (marketplaceIds == null || !marketplaceIds.Any())
                throw new InvalidDataException(
                    "MarketplaceIds is a required property for ParameterPutListingItem and cannot be null");
            if (listingsItemPutRequest == null)
                throw new InvalidDataException(
                    "ListingsItemPutRequest is a required property for ParameterPutListingItem and cannot be null");
            if (string.IsNullOrWhiteSpace(listingsItemPutRequest.productType))
                throw new InvalidDataException(
                    "ProductType is a required property for ListingsItemPutRequest and cannot be null");
            if (listingsItemPutRequest.attributes == null)
                throw new InvalidDataException(
                    "Attributes is a required property for ListingsItemPutRequest and cannot be null");
            return true;
        }
    }

    public class ListingsItemPutRequest
    {
        public string productType { get; set; }

        public Requirements requirements { get; set; }

        public object attributes { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Requirements
    {
        LISTING,
        LISTING_PRODUCT_ONLY,
        LISTING_OFFER_ONLY
    }
}