/*
 * Selling Partner API for Finances
 *
 * The Selling Partner API for Finances helps you obtain financial information relevant to a seller's business. You can obtain financial events for a given order, financial event group, or date range without having to wait until a statement period closes. You can also obtain financial event groups for a given date range.
 *
 * OpenAPI spec version: v0
 *
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Finances
{
    /// <summary>
    ///     A currency type and amount.
    /// </summary>
    [DataContract]
    public class Currency : IEquatable<Currency>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Currency" /> class.
        /// </summary>
        /// <param name="CurrencyCode">The three-digit currency code in ISO 4217 format..</param>
        /// <param name="CurrencyAmount">The monetary value..</param>
        public Currency(string CurrencyCode = default, double CurrencyAmount = default)
        {
            this.CurrencyCode = CurrencyCode;
            this.CurrencyAmount = CurrencyAmount;
        }

        /// <summary>
        ///     The three-digit currency code in ISO 4217 format.
        /// </summary>
        /// <value>The three-digit currency code in ISO 4217 format.</value>
        [DataMember(Name = "CurrencyCode", EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        ///     The monetary value.
        /// </summary>
        /// <value>The monetary value.</value>
        [DataMember(Name = "CurrencyAmount", EmitDefaultValue = false)]
        public double CurrencyAmount { get; set; }

        /// <summary>
        ///     Returns true if Currency instances are equal
        /// </summary>
        /// <param name="input">Instance of Currency to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Currency input)
        {
            if (input == null)
                return false;

            return
                (
                    CurrencyCode == input.CurrencyCode ||
                    (CurrencyCode != null &&
                     CurrencyCode.Equals(input.CurrencyCode))
                ) &&
                (
                    CurrencyAmount == input.CurrencyAmount ||
                    (CurrencyAmount != null &&
                     CurrencyAmount.Equals(input.CurrencyAmount))
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
            sb.Append("class Currency {\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  CurrencyAmount: ").Append(CurrencyAmount).Append("\n");
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
            return Equals(input as Currency);
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
                if (CurrencyCode != null)
                    hashCode = hashCode * 59 + CurrencyCode.GetHashCode();
                if (CurrencyAmount != null)
                    hashCode = hashCode * 59 + CurrencyAmount.GetHashCode();
                return hashCode;
            }
        }
    }
}