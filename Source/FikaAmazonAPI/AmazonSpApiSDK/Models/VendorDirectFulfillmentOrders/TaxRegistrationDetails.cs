/*
 * Selling Partner API for Direct Fulfillment Orders
 *
 * The Selling Partner API for Direct Fulfillment Orders provides programmatic access to a direct fulfillment vendor's order data.
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
using Newtonsoft.Json.Converters;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.VendorDirectFulfillmentOrders
{
    /// <summary>
    ///     Tax registration details of the entity.
    /// </summary>
    [DataContract]
    public class TaxRegistrationDetails : IEquatable<TaxRegistrationDetails>, IValidatableObject
    {
        /// <summary>
        ///     Tax registration type for the entity.
        /// </summary>
        /// <value>Tax registration type for the entity.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TaxRegistrationTypeEnum
        {
            /// <summary>
            ///     Enum VAT for value: VAT
            /// </summary>
            [EnumMember(Value = "VAT")] VAT = 1,

            /// <summary>
            ///     Enum GST for value: GST
            /// </summary>
            [EnumMember(Value = "GST")] GST = 2
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="TaxRegistrationDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public TaxRegistrationDetails()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="TaxRegistrationDetails" /> class.
        /// </summary>
        /// <param name="taxRegistrationType">Tax registration type for the entity..</param>
        /// <param name="taxRegistrationNumber">Tax registration number for the party. For example, VAT ID. (required).</param>
        /// <param name="taxRegistrationAddress">Address associated with the tax registration number..</param>
        /// <param name="taxRegistrationMessages">Tax registration message that can be used for additional tax related details..</param>
        public TaxRegistrationDetails(TaxRegistrationTypeEnum? taxRegistrationType = default,
            string taxRegistrationNumber = default, Address taxRegistrationAddress = default,
            string taxRegistrationMessages = default)
        {
            // to ensure "taxRegistrationNumber" is required (not null)
            if (taxRegistrationNumber == null)
                throw new InvalidDataException(
                    "taxRegistrationNumber is a required property for TaxRegistrationDetails and cannot be null");
            TaxRegistrationNumber = taxRegistrationNumber;
            TaxRegistrationType = taxRegistrationType;
            TaxRegistrationAddress = taxRegistrationAddress;
            TaxRegistrationMessages = taxRegistrationMessages;
        }

        /// <summary>
        ///     Tax registration type for the entity.
        /// </summary>
        /// <value>Tax registration type for the entity.</value>
        [DataMember(Name = "taxRegistrationType", EmitDefaultValue = false)]
        public TaxRegistrationTypeEnum? TaxRegistrationType { get; set; }


        /// <summary>
        ///     Tax registration number for the party. For example, VAT ID.
        /// </summary>
        /// <value>Tax registration number for the party. For example, VAT ID.</value>
        [DataMember(Name = "taxRegistrationNumber", EmitDefaultValue = false)]
        public string TaxRegistrationNumber { get; set; }

        /// <summary>
        ///     Address associated with the tax registration number.
        /// </summary>
        /// <value>Address associated with the tax registration number.</value>
        [DataMember(Name = "taxRegistrationAddress", EmitDefaultValue = false)]
        public Address TaxRegistrationAddress { get; set; }

        /// <summary>
        ///     Tax registration message that can be used for additional tax related details.
        /// </summary>
        /// <value>Tax registration message that can be used for additional tax related details.</value>
        [DataMember(Name = "taxRegistrationMessages", EmitDefaultValue = false)]
        public string TaxRegistrationMessages { get; set; }

        /// <summary>
        ///     Returns true if TaxRegistrationDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxRegistrationDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxRegistrationDetails input)
        {
            if (input == null)
                return false;

            return
                (
                    TaxRegistrationType == input.TaxRegistrationType ||
                    (TaxRegistrationType != null &&
                     TaxRegistrationType.Equals(input.TaxRegistrationType))
                ) &&
                (
                    TaxRegistrationNumber == input.TaxRegistrationNumber ||
                    (TaxRegistrationNumber != null &&
                     TaxRegistrationNumber.Equals(input.TaxRegistrationNumber))
                ) &&
                (
                    TaxRegistrationAddress == input.TaxRegistrationAddress ||
                    (TaxRegistrationAddress != null &&
                     TaxRegistrationAddress.Equals(input.TaxRegistrationAddress))
                ) &&
                (
                    TaxRegistrationMessages == input.TaxRegistrationMessages ||
                    (TaxRegistrationMessages != null &&
                     TaxRegistrationMessages.Equals(input.TaxRegistrationMessages))
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
            sb.Append("class TaxRegistrationDetails {\n");
            sb.Append("  TaxRegistrationType: ").Append(TaxRegistrationType).Append("\n");
            sb.Append("  TaxRegistrationNumber: ").Append(TaxRegistrationNumber).Append("\n");
            sb.Append("  TaxRegistrationAddress: ").Append(TaxRegistrationAddress).Append("\n");
            sb.Append("  TaxRegistrationMessages: ").Append(TaxRegistrationMessages).Append("\n");
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
            return Equals(input as TaxRegistrationDetails);
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
                if (TaxRegistrationType != null)
                    hashCode = hashCode * 59 + TaxRegistrationType.GetHashCode();
                if (TaxRegistrationNumber != null)
                    hashCode = hashCode * 59 + TaxRegistrationNumber.GetHashCode();
                if (TaxRegistrationAddress != null)
                    hashCode = hashCode * 59 + TaxRegistrationAddress.GetHashCode();
                if (TaxRegistrationMessages != null)
                    hashCode = hashCode * 59 + TaxRegistrationMessages.GetHashCode();
                return hashCode;
            }
        }
    }
}