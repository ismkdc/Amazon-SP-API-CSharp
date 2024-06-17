/*
 * Selling Partner API for Catalog Items
 *
 * The Selling Partner API for Catalog Items helps you programmatically retrieve item details for items in the catalog.
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

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.CatalogItems
{
    /// <summary>
    ///     SellerSKUIdentifier
    /// </summary>
    [DataContract]
    public class SellerSKUIdentifier : IEquatable<SellerSKUIdentifier>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SellerSKUIdentifier" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public SellerSKUIdentifier()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="SellerSKUIdentifier" /> class.
        /// </summary>
        /// <param name="MarketplaceId">A marketplace identifier. (required).</param>
        /// <param name="SellerId">The seller identifier submitted for the operation. (required).</param>
        /// <param name="SellerSKU">The seller stock keeping unit (SKU) of the item. (required).</param>
        public SellerSKUIdentifier(string MarketplaceId = default, string SellerId = default,
            string SellerSKU = default)
        {
            // to ensure "MarketplaceId" is required (not null)
            if (MarketplaceId == null)
                throw new InvalidDataException(
                    "MarketplaceId is a required property for SellerSKUIdentifier and cannot be null");
            this.MarketplaceId = MarketplaceId;
            // to ensure "SellerId" is required (not null)
            if (SellerId == null)
                throw new InvalidDataException(
                    "SellerId is a required property for SellerSKUIdentifier and cannot be null");
            this.SellerId = SellerId;
            // to ensure "SellerSKU" is required (not null)
            if (SellerSKU == null)
                throw new InvalidDataException(
                    "SellerSKU is a required property for SellerSKUIdentifier and cannot be null");
            this.SellerSKU = SellerSKU;
        }

        /// <summary>
        ///     A marketplace identifier.
        /// </summary>
        /// <value>A marketplace identifier.</value>
        [DataMember(Name = "MarketplaceId", EmitDefaultValue = false)]
        public string MarketplaceId { get; set; }

        /// <summary>
        ///     The seller identifier submitted for the operation.
        /// </summary>
        /// <value>The seller identifier submitted for the operation.</value>
        [DataMember(Name = "SellerId", EmitDefaultValue = false)]
        public string SellerId { get; set; }

        /// <summary>
        ///     The seller stock keeping unit (SKU) of the item.
        /// </summary>
        /// <value>The seller stock keeping unit (SKU) of the item.</value>
        [DataMember(Name = "SellerSKU", EmitDefaultValue = false)]
        public string SellerSKU { get; set; }

        /// <summary>
        ///     Returns true if SellerSKUIdentifier instances are equal
        /// </summary>
        /// <param name="input">Instance of SellerSKUIdentifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SellerSKUIdentifier input)
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
                    SellerId == input.SellerId ||
                    (SellerId != null &&
                     SellerId.Equals(input.SellerId))
                ) &&
                (
                    SellerSKU == input.SellerSKU ||
                    (SellerSKU != null &&
                     SellerSKU.Equals(input.SellerSKU))
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
            sb.Append("class SellerSKUIdentifier {\n");
            sb.Append("  MarketplaceId: ").Append(MarketplaceId).Append("\n");
            sb.Append("  SellerId: ").Append(SellerId).Append("\n");
            sb.Append("  SellerSKU: ").Append(SellerSKU).Append("\n");
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
            return Equals(input as SellerSKUIdentifier);
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
                if (SellerId != null)
                    hashCode = hashCode * 59 + SellerId.GetHashCode();
                if (SellerSKU != null)
                    hashCode = hashCode * 59 + SellerSKU.GetHashCode();
                return hashCode;
            }
        }
    }
}