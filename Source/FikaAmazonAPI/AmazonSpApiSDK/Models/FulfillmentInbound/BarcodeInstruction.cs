/*
 * Selling Partner API for Fulfillment Inbound
 *
 * The Selling Partner API for Fulfillment Inbound lets you create applications that create and update inbound shipments of inventory to Amazon's fulfillment network.
 *
 * OpenAPI spec version: v0
 *
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInbound
{
    /// <summary>
    ///     Labeling requirements for the item. For more information about FBA labeling requirements, see the Seller Central
    ///     Help for your marketplace.
    /// </summary>
    /// <value>
    ///     Labeling requirements for the item. For more information about FBA labeling requirements, see the Seller Central
    ///     Help for your marketplace.
    /// </value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BarcodeInstruction
    {
        /// <summary>
        ///     Enum RequiresFNSKULabel for value: RequiresFNSKULabel
        /// </summary>
        [EnumMember(Value = "RequiresFNSKULabel")]
        RequiresFNSKULabel = 1,

        /// <summary>
        ///     Enum CanUseOriginalBarcode for value: CanUseOriginalBarcode
        /// </summary>
        [EnumMember(Value = "CanUseOriginalBarcode")]
        CanUseOriginalBarcode = 2,

        /// <summary>
        ///     Enum MustProvideSellerSKU for value: MustProvideSellerSKU
        /// </summary>
        [EnumMember(Value = "MustProvideSellerSKU")]
        MustProvideSellerSKU = 3
    }
}