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
using static FikaAmazonAPI.Utils.Constants;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.ProductPricing
{
    /// <summary>
    ///     Contains pricing information that includes special pricing when buying in bulk.
    /// </summary>
    [DataContract]
    public class QuantityDiscountPriceType : IEquatable<QuantityDiscountPriceType>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="QuantityDiscountPriceType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public QuantityDiscountPriceType()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="QuantityDiscountPriceType" /> class.
        /// </summary>
        /// <param name="quantityTier">Indicates at what quantity this price becomes active. (required).</param>
        /// <param name="quantityDiscountType">Indicates the type of quantity discount this price applies to. (required).</param>
        /// <param name="listingPrice">The price at this quantity tier. (required).</param>
        public QuantityDiscountPriceType(int? quantityTier = default,
            QuantityDiscountType quantityDiscountType = default, MoneyType price = default)
        {
            // to ensure "quantityTier" is required (not null)
            if (quantityTier == null)
                throw new InvalidDataException(
                    "quantityTier is a required property for QuantityDiscountPriceType and cannot be null");
            QuantityTier = quantityTier;
            // to ensure "quantityDiscountType" is required (not null)
            if (quantityDiscountType == null)
                throw new InvalidDataException(
                    "quantityDiscountType is a required property for QuantityDiscountPriceType and cannot be null");
            QuantityDiscountType = quantityDiscountType;
            // to ensure "listingPrice" is required (not null)
            if (price == null)
                throw new InvalidDataException(
                    "listingPrice is a required property for QuantityDiscountPriceType and cannot be null");
            Price = price;
        }

        /// <summary>
        ///     Indicates the type of quantity discount this price applies to.
        /// </summary>
        /// <value>Indicates the type of quantity discount this price applies to.</value>
        [DataMember(Name = "quantityDiscountType", EmitDefaultValue = false)]
        public QuantityDiscountType QuantityDiscountType { get; set; }

        /// <summary>
        ///     Indicates at what quantity this price becomes active.
        /// </summary>
        /// <value>Indicates at what quantity this price becomes active.</value>
        [DataMember(Name = "quantityTier", EmitDefaultValue = false)]
        public int? QuantityTier { get; set; }


        /// <summary>
        ///     The price at this quantity tier.
        /// </summary>
        /// <value>The price at this quantity tier.</value>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public MoneyType Price { get; set; }

        /// <summary>
        ///     Returns true if QuantityDiscountPriceType instances are equal
        /// </summary>
        /// <param name="input">Instance of QuantityDiscountPriceType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuantityDiscountPriceType input)
        {
            if (input == null)
                return false;

            return
                (
                    QuantityTier == input.QuantityTier ||
                    (QuantityTier != null &&
                     QuantityTier.Equals(input.QuantityTier))
                ) &&
                (
                    QuantityDiscountType == input.QuantityDiscountType ||
                    (QuantityDiscountType != null &&
                     QuantityDiscountType.Equals(input.QuantityDiscountType))
                ) &&
                (
                    Price == input.Price ||
                    (Price != null &&
                     Price.Equals(input.Price))
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
            sb.Append("class QuantityDiscountPriceType {\n");
            sb.Append("  QuantityTier: ").Append(QuantityTier).Append("\n");
            sb.Append("  QuantityDiscountType: ").Append(QuantityDiscountType).Append("\n");
            sb.Append("  ListingPrice: ").Append(Price).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return Equals(input as QuantityDiscountPriceType);
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
                if (QuantityTier != null)
                    hashCode = hashCode * 59 + QuantityTier.GetHashCode();
                if (QuantityDiscountType != null)
                    hashCode = hashCode * 59 + QuantityDiscountType.GetHashCode();
                if (Price != null)
                    hashCode = hashCode * 59 + Price.GetHashCode();
                return hashCode;
            }
        }
    }
}