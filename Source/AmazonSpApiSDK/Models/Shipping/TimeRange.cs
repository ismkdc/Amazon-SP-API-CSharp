/* 
 * Selling Partner API for Shipping
 *
 * Provides programmatic access to Amazon Shipping APIs.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace AmazonSpApiSDK.Models.Shipping
{
    /// <summary>
    /// The time range.
    /// </summary>
    [DataContract]
    public partial class TimeRange : IEquatable<TimeRange>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeRange" /> class.
        /// </summary>
        /// <param name="Start">The start date and time. This defaults to the current date and time..</param>
        /// <param name="End">The end date and time. This must come after the value of start. This defaults to the next business day from the start..</param>
        public TimeRange(DateTime? Start = default(DateTime?), DateTime? End = default(DateTime?))
        {
            this.Start = Start;
            this.End = End;
        }

        /// <summary>
        /// The start date and time. This defaults to the current date and time.
        /// </summary>
        /// <value>The start date and time. This defaults to the current date and time.</value>
        [DataMember(Name = "start", EmitDefaultValue = false)]
        public DateTime? Start { get; set; }

        /// <summary>
        /// The end date and time. This must come after the value of start. This defaults to the next business day from the start.
        /// </summary>
        /// <value>The end date and time. This must come after the value of start. This defaults to the next business day from the start.</value>
        [DataMember(Name = "end", EmitDefaultValue = false)]
        public DateTime? End { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeRange {\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
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
            return this.Equals(input as TimeRange);
        }

        /// <summary>
        /// Returns true if TimeRange instances are equal
        /// </summary>
        /// <param name="input">Instance of TimeRange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeRange input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
                ) &&
                (
                    this.End == input.End ||
                    (this.End != null &&
                    this.End.Equals(input.End))
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
                if (this.Start != null)
                    hashCode = hashCode * 59 + this.Start.GetHashCode();
                if (this.End != null)
                    hashCode = hashCode * 59 + this.End.GetHashCode();
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
