/*
 * Selling Partner API for Pricing
 *
 * The Selling Partner API for Pricing helps you programmatically retrieve product pricing and offer information for Amazon Marketplace products.
 *
 * OpenAPI spec version: v0
 *
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.ProductPricing
{
    /// <summary>
    ///     Information that identifies an item.
    /// </summary>
    [DataContract]
    public class ItemIdentifier : IEquatable<ItemIdentifier>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ItemIdentifier" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ItemIdentifier()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ItemIdentifier" /> class.
        /// </summary>
        /// <param name="MarketplaceId">
        ///     A marketplace identifier. Specifies the marketplace from which prices are returned.
        ///     (required).
        /// </param>
        /// <param name="ASIN">The Amazon Standard Identification Number (ASIN) of the item..</param>
        /// <param name="SellerSKU">The seller stock keeping unit (SKU) of the item..</param>
        /// <param name="ItemCondition">The condition of the item. (required).</param>
        public ItemIdentifier(string MarketplaceId = default, string ASIN = default, string SellerSKU = default,
            ConditionType ItemCondition = default)
        {
            // to ensure "MarketplaceId" is required (not null)
            if (MarketplaceId == null)
                throw new InvalidDataException(
                    "MarketplaceId is a required property for ItemIdentifier and cannot be null");
            this.MarketplaceId = MarketplaceId;
            // to ensure "ItemCondition" is required (not null)
            if (ItemCondition == null)
                throw new InvalidDataException(
                    "ItemCondition is a required property for ItemIdentifier and cannot be null");
            this.ItemCondition = ItemCondition;
            this.ASIN = ASIN;
            this.SellerSKU = SellerSKU;
        }

        /// <summary>
        ///     The condition of the item.
        /// </summary>
        /// <value>The condition of the item.</value>
        [DataMember(Name = "ItemCondition", EmitDefaultValue = false)]
        public ConditionType ItemCondition { get; set; }

        /// <summary>
        ///     A marketplace identifier. Specifies the marketplace from which prices are returned.
        /// </summary>
        /// <value>A marketplace identifier. Specifies the marketplace from which prices are returned.</value>
        [DataMember(Name = "MarketplaceId", EmitDefaultValue = false)]
        public string MarketplaceId { get; set; }

        /// <summary>
        ///     The Amazon Standard Identification Number (ASIN) of the item.
        /// </summary>
        /// <value>The Amazon Standard Identification Number (ASIN) of the item.</value>
        [DataMember(Name = "ASIN", EmitDefaultValue = false)]
        public string ASIN { get; set; }

        /// <summary>
        ///     The seller stock keeping unit (SKU) of the item.
        /// </summary>
        /// <value>The seller stock keeping unit (SKU) of the item.</value>
        [DataMember(Name = "SellerSKU", EmitDefaultValue = false)]
        public string SellerSKU { get; set; }

        /// <summary>
        ///     Returns true if ItemIdentifier instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemIdentifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemIdentifier input)
        {
            if (input == null)
                return false;

            return
                (
                    MarketplaceId == input.MarketplaceId ||
                    (MarketplaceId != null &&
                     MarketplaceId.Equals(input.MarketplaceId))
                ) &&
                (
                    ASIN == input.ASIN ||
                    (ASIN != null &&
                     ASIN.Equals(input.ASIN))
                ) &&
                (
                    SellerSKU == input.SellerSKU ||
                    (SellerSKU != null &&
                     SellerSKU.Equals(input.SellerSKU))
                ) &&
                (
                    ItemCondition == input.ItemCondition ||
                    (ItemCondition != null &&
                     ItemCondition.Equals(input.ItemCondition))
                );
        }

        /// <summary>
        ///     To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }


        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemIdentifier {\n");
            sb.Append("  MarketplaceId: ").Append(MarketplaceId).Append("\n");
            sb.Append("  ASIN: ").Append(ASIN).Append("\n");
            sb.Append("  SellerSKU: ").Append(SellerSKU).Append("\n");
            sb.Append("  ItemCondition: ").Append(ItemCondition).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        ///     Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as ItemIdentifier);
        }

        /// <summary>
        ///     Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (MarketplaceId != null)
                    hashCode = hashCode * 59 + MarketplaceId.GetHashCode();
                if (ASIN != null)
                    hashCode = hashCode * 59 + ASIN.GetHashCode();
                if (SellerSKU != null)
                    hashCode = hashCode * 59 + SellerSKU.GetHashCode();
                if (ItemCondition != null)
                    hashCode = hashCode * 59 + ItemCondition.GetHashCode();
                return hashCode;
            }
        }
    }
}