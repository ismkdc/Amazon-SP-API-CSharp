/*
 * Selling Partner API for FBA Small And Light
 *
 * The Selling Partner API for FBA Small and Light lets you help sellers manage their listings in the Small and Light program. The program reduces the cost of fulfilling orders for small and lightweight FBA inventory. You can enroll or remove items from the program and check item eligibility and enrollment status. You can also preview the estimated program fees charged to a seller for items sold while enrolled in the program.
 *
 * OpenAPI spec version: v1
 *
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FbaSmallandLight
{
    /// <summary>
    ///     The fee estimate for a specific item.
    /// </summary>
    [DataContract]
    public class FeePreview : IEquatable<FeePreview>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="FeePreview" /> class.
        /// </summary>
        /// <param name="asin">The Amazon Standard Identification Number (ASIN) value used to identify the item..</param>
        /// <param name="price">The price that the seller plans to charge for the item..</param>
        /// <param name="feeBreakdown">A list of the Small and Light fees for the item..</param>
        /// <param name="totalFees">The total fees charged if the item participated in the Small and Light program..</param>
        /// <param name="errors">One or more unexpected errors occurred during the getSmallAndLightFeePreview operation..</param>
        public FeePreview(string asin = default, MoneyType price = default, List<FeeLineItem> feeBreakdown = default,
            MoneyType totalFees = default, List<Error> errors = default)
        {
            Asin = asin;
            Price = price;
            FeeBreakdown = feeBreakdown;
            TotalFees = totalFees;
            Errors = errors;
        }

        /// <summary>
        ///     The Amazon Standard Identification Number (ASIN) value used to identify the item.
        /// </summary>
        /// <value>The Amazon Standard Identification Number (ASIN) value used to identify the item.</value>
        [DataMember(Name = "asin", EmitDefaultValue = false)]
        public string Asin { get; set; }

        /// <summary>
        ///     The price that the seller plans to charge for the item.
        /// </summary>
        /// <value>The price that the seller plans to charge for the item.</value>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public MoneyType Price { get; set; }

        /// <summary>
        ///     A list of the Small and Light fees for the item.
        /// </summary>
        /// <value>A list of the Small and Light fees for the item.</value>
        [DataMember(Name = "feeBreakdown", EmitDefaultValue = false)]
        public List<FeeLineItem> FeeBreakdown { get; set; }

        /// <summary>
        ///     The total fees charged if the item participated in the Small and Light program.
        /// </summary>
        /// <value>The total fees charged if the item participated in the Small and Light program.</value>
        [DataMember(Name = "totalFees", EmitDefaultValue = false)]
        public MoneyType TotalFees { get; set; }

        /// <summary>
        ///     One or more unexpected errors occurred during the getSmallAndLightFeePreview operation.
        /// </summary>
        /// <value>One or more unexpected errors occurred during the getSmallAndLightFeePreview operation.</value>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public List<Error> Errors { get; set; }

        /// <summary>
        ///     Returns true if FeePreview instances are equal
        /// </summary>
        /// <param name="input">Instance of FeePreview to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeePreview input)
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
                    Price == input.Price ||
                    (Price != null &&
                     Price.Equals(input.Price))
                ) &&
                (
                    FeeBreakdown == input.FeeBreakdown ||
                    (FeeBreakdown != null &&
                     FeeBreakdown.SequenceEqual(input.FeeBreakdown))
                ) &&
                (
                    TotalFees == input.TotalFees ||
                    (TotalFees != null &&
                     TotalFees.Equals(input.TotalFees))
                ) &&
                (
                    Errors == input.Errors ||
                    (Errors != null &&
                     Errors.SequenceEqual(input.Errors))
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
            sb.Append("class FeePreview {\n");
            sb.Append("  Asin: ").Append(Asin).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  FeeBreakdown: ").Append(FeeBreakdown).Append("\n");
            sb.Append("  TotalFees: ").Append(TotalFees).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
            return Equals(input as FeePreview);
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
                if (Price != null)
                    hashCode = hashCode * 59 + Price.GetHashCode();
                if (FeeBreakdown != null)
                    hashCode = hashCode * 59 + FeeBreakdown.GetHashCode();
                if (TotalFees != null)
                    hashCode = hashCode * 59 + TotalFees.GetHashCode();
                if (Errors != null)
                    hashCode = hashCode * 59 + Errors.GetHashCode();
                return hashCode;
            }
        }
    }
}