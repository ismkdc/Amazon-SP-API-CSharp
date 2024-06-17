using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Orders
{
    /// <summary>
    ///     The time when the business opens or closes.
    /// </summary>
    [DataContract]
    public class OpenTimeInterval : IEquatable<OpenTimeInterval>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="OpenTimeInterval" /> class.
        /// </summary>
        /// <param name="hour">The hour when the business opens or closes..</param>
        /// <param name="minute">The minute when the business opens or closes..</param>
        public OpenTimeInterval(int? hour = default, int? minute = default)
        {
            Hour = hour;
            Minute = minute;
        }

        public OpenTimeInterval()
        {
        }

        /// <summary>
        ///     The hour when the business opens or closes.
        /// </summary>
        /// <value>The hour when the business opens or closes.</value>
        [DataMember(Name = "Hour", EmitDefaultValue = false)]
        public int? Hour { get; set; }

        /// <summary>
        ///     The minute when the business opens or closes.
        /// </summary>
        /// <value>The minute when the business opens or closes.</value>
        [DataMember(Name = "Minute", EmitDefaultValue = false)]
        public int? Minute { get; set; }

        /// <summary>
        ///     Returns true if OpenTimeInterval instances are equal
        /// </summary>
        /// <param name="input">Instance of OpenTimeInterval to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpenTimeInterval input)
        {
            if (input == null)
                return false;

            return
                (
                    Hour == input.Hour ||
                    (Hour != null &&
                     Hour.Equals(input.Hour))
                ) &&
                (
                    Minute == input.Minute ||
                    (Minute != null &&
                     Minute.Equals(input.Minute))
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
            sb.Append("class OpenTimeInterval {\n");
            sb.Append("  Hour: ").Append(Hour).Append("\n");
            sb.Append("  Minute: ").Append(Minute).Append("\n");
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
            return Equals(input as OpenTimeInterval);
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
                if (Hour != null)
                    hashCode = hashCode * 59 + Hour.GetHashCode();
                if (Minute != null)
                    hashCode = hashCode * 59 + Minute.GetHashCode();
                return hashCode;
            }
        }
    }
}