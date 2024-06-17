/*
 * Selling Partner API for Sellers
 *
 * The Selling Partner API for Sellers lets you retrieve information on behalf of sellers about their seller account, such as the marketplaces they participate in. Along with listing the marketplaces that a seller can sell in, the API also provides additional information about the marketplace such as the default language and the default currency. The API also provides seller-specific information such as whether the seller has suspended listings in that marketplace.
 *
 * OpenAPI spec version: v1
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

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Sellers
{
    /// <summary>
    ///     MarketplaceParticipation
    /// </summary>
    [DataContract]
    public class MarketplaceParticipation : IEquatable<MarketplaceParticipation>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="MarketplaceParticipation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public MarketplaceParticipation()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="MarketplaceParticipation" /> class.
        /// </summary>
        /// <param name="Marketplace">Marketplace (required).</param>
        /// <param name="Participation">Participation (required).</param>
        public MarketplaceParticipation(Marketplace Marketplace = default, Participation Participation = default)
        {
            // to ensure "Marketplace" is required (not null)
            if (Marketplace == null)
                throw new InvalidDataException(
                    "Marketplace is a required property for MarketplaceParticipation and cannot be null");
            this.Marketplace = Marketplace;
            // to ensure "Participation" is required (not null)
            if (Participation == null)
                throw new InvalidDataException(
                    "Participation is a required property for MarketplaceParticipation and cannot be null");
            this.Participation = Participation;
        }

        /// <summary>
        ///     Gets or Sets Marketplace
        /// </summary>
        [DataMember(Name = "marketplace", EmitDefaultValue = false)]
        public Marketplace Marketplace { get; set; }

        /// <summary>
        ///     Gets or Sets Participation
        /// </summary>
        [DataMember(Name = "participation", EmitDefaultValue = false)]
        public Participation Participation { get; set; }

        /// <summary>
        ///     Returns true if MarketplaceParticipation instances are equal
        /// </summary>
        /// <param name="input">Instance of MarketplaceParticipation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MarketplaceParticipation input)
        {
            if (input == null)
                return false;

            return
                (
                    Marketplace == input.Marketplace ||
                    (Marketplace != null &&
                     Marketplace.Equals(input.Marketplace))
                ) &&
                (
                    Participation == input.Participation ||
                    (Participation != null &&
                     Participation.Equals(input.Participation))
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
            sb.Append("class MarketplaceParticipation {\n");
            sb.Append("  Marketplace: ").Append(Marketplace).Append("\n");
            sb.Append("  Participation: ").Append(Participation).Append("\n");
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
            return Equals(input as MarketplaceParticipation);
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
                if (Marketplace != null)
                    hashCode = hashCode * 59 + Marketplace.GetHashCode();
                if (Participation != null)
                    hashCode = hashCode * 59 + Participation.GetHashCode();
                return hashCode;
            }
        }
    }
}