/* 
 * Selling Partner API for Fulfillment Outbound
 *
 * The Selling Partner API for Fulfillment Outbound lets you create applications that help a seller fulfill Multi-Channel Fulfillment orders using their inventory in Amazon's fulfillment network. You can get information on both potential and existing fulfillment orders.
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

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentOutbound
{
    /// <summary>
    /// The reason that the item is invalid for return.
    /// </summary>
    [DataContract]
    public partial class InvalidItemReason : IEquatable<InvalidItemReason>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets InvalidItemReasonCode
        /// </summary>
        [DataMember(Name = "InvalidItemReasonCode", EmitDefaultValue = false)]
        public InvalidItemReasonCode InvalidItemReasonCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidItemReason" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public InvalidItemReason() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidItemReason" /> class.
        /// </summary>
        /// <param name="InvalidItemReasonCode">InvalidItemReasonCode (required).</param>
        /// <param name="Description">A human readable description of the invalid item reason code. (required).</param>
        public InvalidItemReason(InvalidItemReasonCode InvalidItemReasonCode = default(InvalidItemReasonCode), string Description = default(string))
        {
            // to ensure "InvalidItemReasonCode" is required (not null)
            if (InvalidItemReasonCode == null)
            {
                throw new InvalidDataException("InvalidItemReasonCode is a required property for InvalidItemReason and cannot be null");
            }
            else
            {
                this.InvalidItemReasonCode = InvalidItemReasonCode;
            }
            // to ensure "Description" is required (not null)
            if (Description == null)
            {
                throw new InvalidDataException("Description is a required property for InvalidItemReason and cannot be null");
            }
            else
            {
                this.Description = Description;
            }
        }


        /// <summary>
        /// A human readable description of the invalid item reason code.
        /// </summary>
        /// <value>A human readable description of the invalid item reason code.</value>
        [DataMember(Name = "Description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvalidItemReason {\n");
            sb.Append("  InvalidItemReasonCode: ").Append(InvalidItemReasonCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as InvalidItemReason);
        }

        /// <summary>
        /// Returns true if InvalidItemReason instances are equal
        /// </summary>
        /// <param name="input">Instance of InvalidItemReason to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvalidItemReason input)
        {
            if (input == null)
                return false;

            return
                (
                    this.InvalidItemReasonCode == input.InvalidItemReasonCode ||
                    (this.InvalidItemReasonCode != null &&
                    this.InvalidItemReasonCode.Equals(input.InvalidItemReasonCode))
                ) &&
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.InvalidItemReasonCode != null)
                    hashCode = hashCode * 59 + this.InvalidItemReasonCode.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
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
