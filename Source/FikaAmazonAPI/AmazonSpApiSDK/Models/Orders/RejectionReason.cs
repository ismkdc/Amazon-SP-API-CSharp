using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Orders
{
    /// <summary>
    ///     The reason for rejecting the order&#39;s regulated information. Not present if the order isn&#39;t rejected.
    /// </summary>
    [DataContract]
    public class RejectionReason : IEquatable<RejectionReason>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="RejectionReason" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public RejectionReason()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="RejectionReason" /> class.
        /// </summary>
        /// <param name="rejectionReasonId">The unique identifier for the rejection reason. (required).</param>
        /// <param name="rejectionReasonDescription">The description of this rejection reason. (required).</param>
        public RejectionReason(string rejectionReasonId = default, string rejectionReasonDescription = default)
        {
            // to ensure "rejectionReasonId" is required (not null)
            if (rejectionReasonId == null)
                throw new InvalidDataException(
                    "rejectionReasonId is a required property for RejectionReason and cannot be null");
            RejectionReasonId = rejectionReasonId;
            // to ensure "rejectionReasonDescription" is required (not null)
            if (rejectionReasonDescription == null)
                throw new InvalidDataException(
                    "rejectionReasonDescription is a required property for RejectionReason and cannot be null");
            RejectionReasonDescription = rejectionReasonDescription;
        }

        /// <summary>
        ///     The unique identifier for the rejection reason.
        /// </summary>
        /// <value>The unique identifier for the rejection reason.</value>
        [DataMember(Name = "RejectionReasonId", EmitDefaultValue = false)]
        public string RejectionReasonId { get; set; }

        /// <summary>
        ///     The description of this rejection reason.
        /// </summary>
        /// <value>The description of this rejection reason.</value>
        [DataMember(Name = "RejectionReasonDescription", EmitDefaultValue = false)]
        public string RejectionReasonDescription { get; set; }

        /// <summary>
        ///     Returns true if RejectionReason instances are equal
        /// </summary>
        /// <param name="input">Instance of RejectionReason to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RejectionReason input)
        {
            if (input == null)
                return false;

            return
                (
                    RejectionReasonId == input.RejectionReasonId ||
                    (RejectionReasonId != null &&
                     RejectionReasonId.Equals(input.RejectionReasonId))
                ) &&
                (
                    RejectionReasonDescription == input.RejectionReasonDescription ||
                    (RejectionReasonDescription != null &&
                     RejectionReasonDescription.Equals(input.RejectionReasonDescription))
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
            sb.Append("class RejectionReason {\n");
            sb.Append("  RejectionReasonId: ").Append(RejectionReasonId).Append("\n");
            sb.Append("  RejectionReasonDescription: ").Append(RejectionReasonDescription).Append("\n");
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
            return Equals(input as RejectionReason);
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
                if (RejectionReasonId != null)
                    hashCode = hashCode * 59 + RejectionReasonId.GetHashCode();
                if (RejectionReasonDescription != null)
                    hashCode = hashCode * 59 + RejectionReasonDescription.GetHashCode();
                return hashCode;
            }
        }
    }
}