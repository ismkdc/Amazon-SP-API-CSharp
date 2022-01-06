/* 
 * Selling Partner API for Merchant Fulfillment
 *
 * The Selling Partner API for Merchant Fulfillment helps you build applications that let sellers purchase shipping for non-Prime and Prime orders using Amazon’s Buy Shipping Services.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.MerchantFulfillment
{
    /// <summary>
    /// The available delivery confirmation options, and the fee charged, if any.
    /// </summary>
    [DataContract]
    public partial class AvailableDeliveryExperienceOption : IEquatable<AvailableDeliveryExperienceOption>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets DeliveryExperienceOption
        /// </summary>
        [DataMember(Name = "DeliveryExperienceOption", EmitDefaultValue = false)]
        public DeliveryExperienceOption DeliveryExperienceOption { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableDeliveryExperienceOption" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public AvailableDeliveryExperienceOption() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableDeliveryExperienceOption" /> class.
        /// </summary>
        /// <param name="DeliveryExperienceOption">DeliveryExperienceOption (required).</param>
        /// <param name="Charge">Charge (required).</param>
        public AvailableDeliveryExperienceOption(DeliveryExperienceOption DeliveryExperienceOption = default(DeliveryExperienceOption), CurrencyAmount Charge = default(CurrencyAmount))
        {
            // to ensure "DeliveryExperienceOption" is required (not null)
            if (DeliveryExperienceOption == null)
            {
                throw new InvalidDataException("DeliveryExperienceOption is a required property for AvailableDeliveryExperienceOption and cannot be null");
            }
            else
            {
                this.DeliveryExperienceOption = DeliveryExperienceOption;
            }
            // to ensure "Charge" is required (not null)
            if (Charge == null)
            {
                throw new InvalidDataException("Charge is a required property for AvailableDeliveryExperienceOption and cannot be null");
            }
            else
            {
                this.Charge = Charge;
            }
        }


        /// <summary>
        /// Gets or Sets Charge
        /// </summary>
        [DataMember(Name = "Charge", EmitDefaultValue = false)]
        public CurrencyAmount Charge { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvailableDeliveryExperienceOption {\n");
            sb.Append("  DeliveryExperienceOption: ").Append(DeliveryExperienceOption).Append("\n");
            sb.Append("  Charge: ").Append(Charge).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AvailableDeliveryExperienceOption);
        }

        /// <summary>
        /// Returns true if AvailableDeliveryExperienceOption instances are equal
        /// </summary>
        /// <param name="input">Instance of AvailableDeliveryExperienceOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvailableDeliveryExperienceOption input)
        {
            if (input == null)
                return false;

            return
                (
                    this.DeliveryExperienceOption == input.DeliveryExperienceOption ||
                    (this.DeliveryExperienceOption != null &&
                    this.DeliveryExperienceOption.Equals(input.DeliveryExperienceOption))
                ) &&
                (
                    this.Charge == input.Charge ||
                    (this.Charge != null &&
                    this.Charge.Equals(input.Charge))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DeliveryExperienceOption != null)
                    hashCode = hashCode * 59 + this.DeliveryExperienceOption.GetHashCode();
                if (this.Charge != null)
                    hashCode = hashCode * 59 + this.Charge.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
