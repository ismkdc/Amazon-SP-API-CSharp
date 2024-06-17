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
    ///     A set of measurements for a three-dimensional object.
    /// </summary>
    [DataContract]
    public class Dimensions : IEquatable<Dimensions>, IValidatableObject
    {
        /// <summary>
        ///     The unit of these measurements.
        /// </summary>
        /// <value>The unit of these measurements.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnitEnum
        {
            /// <summary>
            ///     Enum IN for value: INCH
            /// </summary>
            [EnumMember(Value = "INCH")] IN = 1,

            /// <summary>
            ///     Enum CM for value: CENTIMETER
            /// </summary>
            [EnumMember(Value = "CENTIMETER")] CM = 2
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Dimensions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Dimensions()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Dimensions" /> class.
        /// </summary>
        /// <param name="Length">The length of the container. (required).</param>
        /// <param name="Width">The width of the container. (required).</param>
        /// <param name="Height">The height of the container. (required).</param>
        /// <param name="Unit">The unit of these measurements. (required).</param>
        public Dimensions(decimal? Length = default, decimal? Width = default, decimal? Height = default,
            UnitEnum Unit = default)
        {
            // to ensure "Length" is required (not null)
            if (Length == null)
                throw new InvalidDataException("Length is a required property for Dimensions and cannot be null");
            this.Length = Length;
            // to ensure "Width" is required (not null)
            if (Width == null)
                throw new InvalidDataException("Width is a required property for Dimensions and cannot be null");
            this.Width = Width;
            // to ensure "Height" is required (not null)
            if (Height == null)
                throw new InvalidDataException("Height is a required property for Dimensions and cannot be null");
            this.Height = Height;
            // to ensure "Unit" is required (not null)
            if (Unit == null)
                throw new InvalidDataException("Unit is a required property for Dimensions and cannot be null");
            this.Unit = Unit;
        }

        /// <summary>
        ///     The unit of these measurements.
        /// </summary>
        /// <value>The unit of these measurements.</value>
        [DataMember(Name = "unit", EmitDefaultValue = false)]
        public UnitEnum Unit { get; set; }

        /// <summary>
        ///     The length of the container.
        /// </summary>
        /// <value>The length of the container.</value>
        [DataMember(Name = "length", EmitDefaultValue = false)]
        public decimal? Length { get; set; }

        /// <summary>
        ///     The width of the container.
        /// </summary>
        /// <value>The width of the container.</value>
        [DataMember(Name = "width", EmitDefaultValue = false)]
        public decimal? Width { get; set; }

        /// <summary>
        ///     The height of the container.
        /// </summary>
        /// <value>The height of the container.</value>
        [DataMember(Name = "height", EmitDefaultValue = false)]
        public decimal? Height { get; set; }

        /// <summary>
        ///     Returns true if Dimensions instances are equal
        /// </summary>
        /// <param name="input">Instance of Dimensions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Dimensions input)
        {
            if (input == null)
                return false;

            return
                (
                    Length == input.Length ||
                    (Length != null &&
                     Length.Equals(input.Length))
                ) &&
                (
                    Width == input.Width ||
                    (Width != null &&
                     Width.Equals(input.Width))
                ) &&
                (
                    Height == input.Height ||
                    (Height != null &&
                     Height.Equals(input.Height))
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
            yield break;
        }


        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Dimensions {\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
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
            return Equals(input as Dimensions);
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
                if (Length != null)
                    hashCode = hashCode * 59 + Length.GetHashCode();
                if (Width != null)
                    hashCode = hashCode * 59 + Width.GetHashCode();
                if (Height != null)
                    hashCode = hashCode * 59 + Height.GetHashCode();
                if (Unit != null)
                    hashCode = hashCode * 59 + Unit.GetHashCode();
                return hashCode;
            }
        }
    }
}