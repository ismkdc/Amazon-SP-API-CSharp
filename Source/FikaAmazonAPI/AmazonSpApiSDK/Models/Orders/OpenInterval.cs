using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Orders
{
    /// <summary>
    ///     The time interval for which the business is open.
    /// </summary>
    [DataContract]
    public class OpenInterval : IEquatable<OpenInterval>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="OpenInterval" /> class.
        /// </summary>
        /// <param name="startTime">The time when the business opens..</param>
        /// <param name="endTime">The time when the business closes..</param>
        public OpenInterval(OpenTimeInterval startTime = default, OpenTimeInterval endTime = default)
        {
            StartTime = startTime;
            EndTime = endTime;
        }

        public OpenInterval()
        {
        }

        /// <summary>
        ///     The time when the business opens.
        /// </summary>
        /// <value>The time when the business opens.</value>
        [DataMember(Name = "StartTime", EmitDefaultValue = false)]
        public OpenTimeInterval StartTime { get; set; }

        /// <summary>
        ///     The time when the business closes.
        /// </summary>
        /// <value>The time when the business closes.</value>
        [DataMember(Name = "EndTime", EmitDefaultValue = false)]
        public OpenTimeInterval EndTime { get; set; }

        /// <summary>
        ///     Returns true if OpenInterval instances are equal
        /// </summary>
        /// <param name="input">Instance of OpenInterval to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpenInterval input)
        {
            if (input == null)
                return false;

            return
                (
                    StartTime == input.StartTime ||
                    (StartTime != null &&
                     StartTime.Equals(input.StartTime))
                ) &&
                (
                    EndTime == input.EndTime ||
                    (EndTime != null &&
                     EndTime.Equals(input.EndTime))
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
            sb.Append("class OpenInterval {\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
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
            return Equals(input as OpenInterval);
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
                if (StartTime != null)
                    hashCode = hashCode * 59 + StartTime.GetHashCode();
                if (EndTime != null)
                    hashCode = hashCode * 59 + EndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}