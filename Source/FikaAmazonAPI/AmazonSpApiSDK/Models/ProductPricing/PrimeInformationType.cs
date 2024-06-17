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
    ///     Amazon Prime information.
    /// </summary>
    [DataContract]
    public class PrimeInformationType : IEquatable<PrimeInformationType>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="PrimeInformationType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PrimeInformationType()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="PrimeInformationType" /> class.
        /// </summary>
        /// <param name="isPrime">Indicates whether the offer is an Amazon Prime offer. (required).</param>
        /// <param name="isNationalPrime">
        ///     Indicates whether the offer is an Amazon Prime offer throughout the entire marketplace
        ///     where it is listed. (required).
        /// </param>
        public PrimeInformationType(bool? isPrime = default, bool? isNationalPrime = default)
        {
            // to ensure "isPrime" is required (not null)
            if (isPrime == null)
                throw new InvalidDataException(
                    "isPrime is a required property for PrimeInformationType and cannot be null");
            IsPrime = isPrime;
            // to ensure "isNationalPrime" is required (not null)
            if (isNationalPrime == null)
                throw new InvalidDataException(
                    "isNationalPrime is a required property for PrimeInformationType and cannot be null");
            IsNationalPrime = isNationalPrime;
        }

        /// <summary>
        ///     Indicates whether the offer is an Amazon Prime offer.
        /// </summary>
        /// <value>Indicates whether the offer is an Amazon Prime offer.</value>
        [DataMember(Name = "IsPrime", EmitDefaultValue = false)]
        public bool? IsPrime { get; set; }

        /// <summary>
        ///     Indicates whether the offer is an Amazon Prime offer throughout the entire marketplace where it is listed.
        /// </summary>
        /// <value>Indicates whether the offer is an Amazon Prime offer throughout the entire marketplace where it is listed.</value>
        [DataMember(Name = "IsNationalPrime", EmitDefaultValue = false)]
        public bool? IsNationalPrime { get; set; }

        /// <summary>
        ///     Returns true if PrimeInformationType instances are equal
        /// </summary>
        /// <param name="input">Instance of PrimeInformationType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrimeInformationType input)
        {
            if (input == null)
                return false;

            return
                (
                    IsPrime == input.IsPrime ||
                    (IsPrime != null &&
                     IsPrime.Equals(input.IsPrime))
                ) &&
                (
                    IsNationalPrime == input.IsNationalPrime ||
                    (IsNationalPrime != null &&
                     IsNationalPrime.Equals(input.IsNationalPrime))
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
            sb.Append("class PrimeInformationType {\n");
            sb.Append("  IsPrime: ").Append(IsPrime).Append("\n");
            sb.Append("  IsNationalPrime: ").Append(IsNationalPrime).Append("\n");
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
            return Equals(input as PrimeInformationType);
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
                if (IsPrime != null)
                    hashCode = hashCode * 59 + IsPrime.GetHashCode();
                if (IsNationalPrime != null)
                    hashCode = hashCode * 59 + IsNationalPrime.GetHashCode();
                return hashCode;
            }
        }
    }
}