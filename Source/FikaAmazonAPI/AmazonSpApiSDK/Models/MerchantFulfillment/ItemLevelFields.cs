/*
 * Selling Partner API for Merchant Fulfillment
 *
 * The Selling Partner API for Merchant Fulfillment helps you build applications that let sellers purchase shipping for non-Prime and Prime orders using Amazon’s Buy Shipping Services.
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

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.MerchantFulfillment
{
    /// <summary>
    ///     ItemLevelFields
    /// </summary>
    [DataContract]
    public class ItemLevelFields : IEquatable<ItemLevelFields>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ItemLevelFields" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ItemLevelFields()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ItemLevelFields" /> class.
        /// </summary>
        /// <param name="asin">The Amazon Standard Identification Number (ASIN) of the item. (required).</param>
        /// <param name="additionalInputs">additionalInputs (required).</param>
        public ItemLevelFields(string asin = default, AdditionalInputsList additionalInputs = default)
        {
            // to ensure "asin" is required (not null)
            if (asin == null)
                throw new InvalidDataException("asin is a required property for ItemLevelFields and cannot be null");
            Asin = asin;
            // to ensure "additionalInputs" is required (not null)
            if (additionalInputs == null)
                throw new InvalidDataException(
                    "additionalInputs is a required property for ItemLevelFields and cannot be null");
            AdditionalInputs = additionalInputs;
        }

        /// <summary>
        ///     The Amazon Standard Identification Number (ASIN) of the item.
        /// </summary>
        /// <value>The Amazon Standard Identification Number (ASIN) of the item.</value>
        [DataMember(Name = "Asin", EmitDefaultValue = false)]
        public string Asin { get; set; }

        /// <summary>
        ///     Gets or Sets AdditionalInputs
        /// </summary>
        [DataMember(Name = "AdditionalInputs", EmitDefaultValue = false)]
        public AdditionalInputsList AdditionalInputs { get; set; }

        /// <summary>
        ///     Returns true if ItemLevelFields instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemLevelFields to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemLevelFields input)
        {
            if (input == null)
                return false;

            return
                (
                    Asin == input.Asin ||
                    (Asin != null &&
                     Asin.Equals(input.Asin))
                ) &&
                (
                    AdditionalInputs == input.AdditionalInputs ||
                    (AdditionalInputs != null &&
                     AdditionalInputs.Equals(input.AdditionalInputs))
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
            sb.Append("class ItemLevelFields {\n");
            sb.Append("  Asin: ").Append(Asin).Append("\n");
            sb.Append("  AdditionalInputs: ").Append(AdditionalInputs).Append("\n");
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
            return Equals(input as ItemLevelFields);
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
                if (Asin != null)
                    hashCode = hashCode * 59 + Asin.GetHashCode();
                if (AdditionalInputs != null)
                    hashCode = hashCode * 59 + AdditionalInputs.GetHashCode();
                return hashCode;
            }
        }
    }
}