using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.VendorOrders
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RejectionReason
    {
        [EnumMember(Value = "TemporarilyUnavailable")]
        TemporarilyUnavailable,

        [EnumMember(Value = "InvalidProductIdentifier")]
        InvalidProductIdentifier,

        [EnumMember(Value = "ObsoleteProduct")]
        ObsoleteProduct
    }
}