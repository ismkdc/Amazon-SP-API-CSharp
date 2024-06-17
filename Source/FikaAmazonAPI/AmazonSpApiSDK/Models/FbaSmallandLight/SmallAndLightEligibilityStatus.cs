/*
 * Selling Partner API for FBA Small And Light
 *
 * The Selling Partner API for FBA Small and Light lets you help sellers manage their listings in the Small and Light program. The program reduces the cost of fulfilling orders for small and lightweight FBA inventory. You can enroll or remove items from the program and check item eligibility and enrollment status. You can also preview the estimated program fees charged to a seller for items sold while enrolled in the program.
 *
 * OpenAPI spec version: v1
 *
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FbaSmallandLight
{
    /// <summary>
    ///     The Small and Light eligibility status of the item.
    /// </summary>
    /// <value>The Small and Light eligibility status of the item.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SmallAndLightEligibilityStatus
    {
        /// <summary>
        ///     Enum ELIGIBLE for value: ELIGIBLE
        /// </summary>
        [EnumMember(Value = "ELIGIBLE")] ELIGIBLE = 1,

        /// <summary>
        ///     Enum NOTELIGIBLE for value: NOT_ELIGIBLE
        /// </summary>
        [EnumMember(Value = "NOT_ELIGIBLE")] NOTELIGIBLE = 2
    }
}