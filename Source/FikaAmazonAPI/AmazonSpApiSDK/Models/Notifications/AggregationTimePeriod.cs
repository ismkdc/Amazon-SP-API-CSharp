using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Notifications
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AggregationTimePeriod
    {
        /// <summary>
        ///     Enum AggregationTimePeriod for value: FiveMinutes
        /// </summary>
        [EnumMember(Value = "FiveMinutes")] FiveMinutes = 1,

        /// <summary>
        ///     Enum AggregationTimePeriod for value: TenMinutes
        /// </summary>
        [EnumMember(Value = "TenMinutes")] TenMinutes = 1
    }
}