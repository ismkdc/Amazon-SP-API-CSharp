/*
 * Selling Partner API for Services
 *
 * With the Services API, you can build applications that help service providers get and modify their service orders.
 *
 * OpenAPI spec version: v1
 *
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Services
{
    /// <summary>
    ///     Information about the seller of the service job.
    /// </summary>
    [DataContract]
    public class Seller : IEquatable<Seller>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Seller" /> class.
        /// </summary>
        /// <param name="SellerId">The identifier of the seller of the service job..</param>
        public Seller(string SellerId = default)
        {
            this.SellerId = SellerId;
        }

        /// <summary>
        ///     The identifier of the seller of the service job.
        /// </summary>
        /// <value>The identifier of the seller of the service job.</value>
        [DataMember(Name = "sellerId", EmitDefaultValue = false)]
        public string SellerId { get; set; }

        /// <summary>
        ///     Returns true if Seller instances are equal
        /// </summary>
        /// <param name="input">Instance of Seller to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Seller input)
        {
            if (input == null)
                return false;

            return
                SellerId == input.SellerId ||
                (SellerId != null &&
                 SellerId.Equals(input.SellerId));
        }

        /// <summary>
        ///     To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // SellerId (string) pattern
            var regexSellerId = new Regex(@"^[A-Z0-9]*$", RegexOptions.CultureInvariant);
            if (false == regexSellerId.Match(SellerId).Success)
                yield return new ValidationResult(
                    "Invalid value for SellerId, must match a pattern of " + regexSellerId, new[] { "SellerId" });
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Seller {\n");
            sb.Append("  SellerId: ").Append(SellerId).Append("\n");
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
            return Equals(input as Seller);
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
                if (SellerId != null)
                    hashCode = hashCode * 59 + SellerId.GetHashCode();
                return hashCode;
            }
        }
    }
}