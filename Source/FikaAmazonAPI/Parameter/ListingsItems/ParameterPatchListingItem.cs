using System.Collections.Generic;
using System.IO;
using System.Linq;
using FikaAmazonAPI.Search;
using FikaAmazonAPI.Utils;

namespace FikaAmazonAPI.Parameter.ListingItem
{
    public class ParameterPatchListingItem : ParameterBased
    {
        public string sellerId { get; set; }

        public string sku { get; set; }

        public ICollection<string> marketplaceIds { get; set; }

        public string issueLocale { get; set; }

        public ListingsItemPatchRequest listingsItemPatchRequest { get; set; }

        public bool Check()
        {
            if (TestCase == Constants.TestCase400)
                sku = "BadSKU";
            if (string.IsNullOrWhiteSpace(sellerId))
                throw new InvalidDataException(
                    "SellerId is a required property for ParameterPatchListingItem and cannot be null");
            if (string.IsNullOrWhiteSpace(sku))
                throw new InvalidDataException(
                    "Sku is a required property for ParameterPatchListingItem and cannot be null");
            if (marketplaceIds == null || !marketplaceIds.Any())
                throw new InvalidDataException(
                    "MarketplaceIds is a required property for ParameterPatchListingItem and cannot be null");
            if (listingsItemPatchRequest == null)
                throw new InvalidDataException(
                    "ListingsItemPutRequest is a required property for ParameterPatchListingItem and cannot be null");
            if (string.IsNullOrWhiteSpace(listingsItemPatchRequest.productType))
                throw new InvalidDataException(
                    "ListingsItemPutRequest is a required property for ParameterPatchListingItem and cannot be null");
            if (listingsItemPatchRequest.patches == null || !listingsItemPatchRequest.patches.Any())
                throw new InvalidDataException(
                    "Patches is a required property for ParameterPatchListingItem and cannot be null");
            return true;
        }
    }

    public class ListingsItemPatchRequest
    {
        public string productType { get; set; }

        public ICollection<PatchOperation> patches { get; set; }
    }

    public class PatchOperation
    {
        public Op op { get; set; }
        public string path { get; set; }

        public ICollection<object> value { get; set; }
    }

    public enum Op
    {
        add,
        replace,
        delete
    }
}