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
    /// A validation constraint.
    /// </summary>
    [DataContract]
    public partial class Constraint : IEquatable<Constraint>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Constraint" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Constraint() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Constraint" /> class.
        /// </summary>
        /// <param name="ValidationRegEx">A regular expression..</param>
        /// <param name="ValidationString">A validation string. (required).</param>
        public Constraint(string ValidationRegEx = default(string), string ValidationString = default(string))
        {
            // to ensure "ValidationString" is required (not null)
            if (ValidationString == null)
            {
                throw new InvalidDataException("ValidationString is a required property for Constraint and cannot be null");
            }
            else
            {
                this.ValidationString = ValidationString;
            }
            this.ValidationRegEx = ValidationRegEx;
        }

        /// <summary>
        /// A regular expression.
        /// </summary>
        /// <value>A regular expression.</value>
        [DataMember(Name = "ValidationRegEx", EmitDefaultValue = false)]
        public string ValidationRegEx { get; set; }

        /// <summary>
        /// A validation string.
        /// </summary>
        /// <value>A validation string.</value>
        [DataMember(Name = "ValidationString", EmitDefaultValue = false)]
        public string ValidationString { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Constraint {\n");
            sb.Append("  ValidationRegEx: ").Append(ValidationRegEx).Append("\n");
            sb.Append("  ValidationString: ").Append(ValidationString).Append("\n");
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
            return this.Equals(input as Constraint);
        }

        /// <summary>
        /// Returns true if Constraint instances are equal
        /// </summary>
        /// <param name="input">Instance of Constraint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Constraint input)
        {
            if (input == null)
                return false;

            return
                (
                    this.ValidationRegEx == input.ValidationRegEx ||
                    (this.ValidationRegEx != null &&
                    this.ValidationRegEx.Equals(input.ValidationRegEx))
                ) &&
                (
                    this.ValidationString == input.ValidationString ||
                    (this.ValidationString != null &&
                    this.ValidationString.Equals(input.ValidationString))
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
                if (this.ValidationRegEx != null)
                    hashCode = hashCode * 59 + this.ValidationRegEx.GetHashCode();
                if (this.ValidationString != null)
                    hashCode = hashCode * 59 + this.ValidationString.GetHashCode();
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
