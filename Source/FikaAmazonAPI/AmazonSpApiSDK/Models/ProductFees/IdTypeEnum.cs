using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.ProductFees
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IdTypeEnum
    {
        /// <summary>
        ///     An Amazon Standard Identification Number (ASIN) of a listings item.
        /// </summary>
        [EnumMember(Value = "ASIN")] ASIN,

        /// <summary>
        ///     A selling partner provided identifier for an Amazon listing.
        /// </summary>
        [EnumMember(Value = "SellerSKU")] SellerSKU
    }
}