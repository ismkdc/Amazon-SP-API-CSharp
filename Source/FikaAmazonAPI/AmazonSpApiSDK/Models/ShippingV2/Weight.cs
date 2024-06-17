using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.ShippingV2
{
    /// <summary>
    ///     The weight.
    /// </summary>
    [DataContract]
    public class Weight : IEquatable<Weight>, IValidatableObject
    {
        /// <summary>
        ///     The unit of measurement.
        /// </summary>
        /// <value>The unit of measurement.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnitEnum
        {
            /// <summary>
            ///     Enum G for value: GRAM
            /// </summary>
            [EnumMember(Value = "GRAM")] G = 1,

            /// <summary>
            ///     Enum Kg for value: KILOGRAM
            /// </summary>
            [EnumMember(Value = "KILOGRAM")] Kg = 2,

            /// <summary>
            ///     Enum Oz for value: OUNCE
            /// </summary>
            [EnumMember(Value = "OUNCE")] Oz = 3,

            /// <summary>
            ///     Enum Lb for value: POUND
            /// </summary>
            [EnumMember(Value = "POUND")] Lb = 4
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Weight" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Weight()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Weight" /> class.
        /// </summary>
        /// <param name="Unit">The unit of measurement. (required).</param>
        /// <param name="Value">The measurement value. (required).</param>
        public Weight(UnitEnum Unit = default, decimal? Value = default)
        {
            // to ensure "Unit" is required (not null)
            if (Unit == null)
                throw new InvalidDataException("Unit is a required property for Weight and cannot be null");
            this.Unit = Unit;
            // to ensure "Value" is required (not null)
            if (Value == null)
                throw new InvalidDataException("Value is a required property for Weight and cannot be null");
            this.Value = Value;
        }

        /// <summary>
        ///     The unit of measurement.
        /// </summary>
        /// <value>The unit of measurement.</value>
        [DataMember(Name = "unit", EmitDefaultValue = false)]
        public UnitEnum Unit { get; set; }


        /// <summary>
        ///     The measurement value.
        /// </summary>
        /// <value>The measurement value.</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public decimal? Value { get; set; }

        /// <summary>
        ///     Returns true if Weight instances are equal
        /// </summary>
        /// <param name="input">Instance of Weight to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Weight input)
        {
            if (input == null)
                return false;

            return
                (
                    Unit == input.Unit ||
                    (Unit != null &&
                     Unit.Equals(input.Unit))
                ) &&
                (
                    Value == input.Value ||
                    (Value != null &&
                     Value.Equals(input.Value))
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
            sb.Append("class Weight {\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return Equals(input as Weight);
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
                if (Unit != null)
                    hashCode = hashCode * 59 + Unit.GetHashCode();
                if (Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();
                return hashCode;
            }
        }
    }
}