/*
 * Selling Partner API for Shipping
 *
 * Provides programmatic access to Amazon Shipping APIs.
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
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Shipping
{
    /// <summary>
    ///     The tracking summary.
    /// </summary>
    [DataContract]
    public class TrackingSummary : IEquatable<TrackingSummary>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="TrackingSummary" /> class.
        /// </summary>
        /// <param name="Status">The derived status based on the events in the eventHistory..</param>
        public TrackingSummary(string Status = default)
        {
            this.Status = Status;
        }

        /// <summary>
        ///     The derived status based on the events in the eventHistory.
        /// </summary>
        /// <value>The derived status based on the events in the eventHistory.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        ///     Returns true if TrackingSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackingSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackingSummary input)
        {
            if (input == null)
                return false;

            return
                Status == input.Status ||
                (Status != null &&
                 Status.Equals(input.Status));
        }

        /// <summary>
        ///     To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Status (string) maxLength
            if (Status != null && Status.Length > 60)
                yield return new ValidationResult("Invalid value for Status, length must be less than 60.",
                    new[] { "Status" });

            // Status (string) minLength
            if (Status != null && Status.Length < 1)
                yield return new ValidationResult("Invalid value for Status, length must be greater than 1.",
                    new[] { "Status" });
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrackingSummary {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return Equals(input as TrackingSummary);
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
                if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                return hashCode;
            }
        }
    }
}