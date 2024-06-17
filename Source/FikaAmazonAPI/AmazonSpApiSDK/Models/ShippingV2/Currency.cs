using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.ShippingV2
{
    /// <summary>
    ///     The total value of all items in the container.
    /// </summary>
    [DataContract]
    public class Currency : IEquatable<Currency>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Currency" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Currency()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Currency" /> class.
        /// </summary>
        /// <param name="Value">The amount of currency. (required).</param>
        /// <param name="Unit">A 3-character currency code. (required).</param>
        public Currency(decimal? Value = default, string Unit = default)
        {
            // to ensure "Value" is required (not null)
            if (Value == null)
                throw new InvalidDataException("Value is a required property for Currency and cannot be null");
            this.Value = Value;
            // to ensure "Unit" is required (not null)
            if (Unit == null)
                throw new InvalidDataException("Unit is a required property for Currency and cannot be null");
            this.Unit = Unit;
        }

        /// <summary>
        ///     The amount of currency.
        /// </summary>
        /// <value>The amount of currency.</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public decimal? Value { get; set; }

        /// <summary>
        ///     A 3-character currency code.
        /// </summary>
        /// <value>A 3-character currency code.</value>
        [DataMember(Name = "unit", EmitDefaultValue = false)]
        public string Unit { get; set; }

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
                    Value == input.Value ||
                    (Value != null &&
                     Value.Equals(input.Value))
                ) &&
                (
                    Unit == input.Unit ||
                    (Unit != null &&
                     Unit.Equals(input.Unit))
                );
        }

        /// <summary>
        ///     To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Unit (string) maxLength
            if (Unit != null && Unit.Length > 3)
                yield return new ValidationResult("Invalid value for Unit, length must be less than 3.",
                    new[] { "Unit" });

            // Unit (string) minLength
            if (Unit != null && Unit.Length < 3)
                yield return new ValidationResult("Invalid value for Unit, length must be greater than 3.",
                    new[] { "Unit" });
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Currency {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
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
                if (Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();
                if (Unit != null)
                    hashCode = hashCode * 59 + Unit.GetHashCode();
                return hashCode;
            }
        }
    }
}