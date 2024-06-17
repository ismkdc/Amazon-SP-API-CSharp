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
    ///     The updated values of the VerificationStatus field.
    /// </summary>
    [DataContract]
    public class UpdateVerificationStatusRequestBody : IEquatable<UpdateVerificationStatusRequestBody>,
        IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="UpdateVerificationStatusRequestBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public UpdateVerificationStatusRequestBody()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="UpdateVerificationStatusRequestBody" /> class.
        /// </summary>
        /// <param name="status">The new verification status of the order. (required).</param>
        /// <param name="externalReviewerId">The identifier for the order&#39;s regulated information reviewer. (required).</param>
        /// <param name="rejectionReasonId">
        ///     The unique identifier for the rejection reason used for rejecting the order&#39;s
        ///     regulated information. Only required if the new status is rejected..
        /// </param>
        public UpdateVerificationStatusRequestBody(VerificationStatus status = default,
            string externalReviewerId = default, string rejectionReasonId = default)
        {
            // to ensure "status" is required (not null)
            if (status == null)
                throw new InvalidDataException(
                    "status is a required property for UpdateVerificationStatusRequestBody and cannot be null");
            Status = status;
            // to ensure "externalReviewerId" is required (not null)
            if (externalReviewerId == null)
                throw new InvalidDataException(
                    "externalReviewerId is a required property for UpdateVerificationStatusRequestBody and cannot be null");
            ExternalReviewerId = externalReviewerId;
            RejectionReasonId = rejectionReasonId;
        }

        /// <summary>
        ///     The new verification status of the order.
        /// </summary>
        /// <value>The new verification status of the order.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public VerificationStatus Status { get; set; }


        /// <summary>
        ///     The identifier for the order&#39;s regulated information reviewer.
        /// </summary>
        /// <value>The identifier for the order&#39;s regulated information reviewer.</value>
        [DataMember(Name = "externalReviewerId", EmitDefaultValue = false)]
        public string ExternalReviewerId { get; set; }

        /// <summary>
        ///     The unique identifier for the rejection reason used for rejecting the order&#39;s regulated information. Only
        ///     required if the new status is rejected.
        /// </summary>
        /// <value>
        ///     The unique identifier for the rejection reason used for rejecting the order&#39;s regulated information. Only
        ///     required if the new status is rejected.
        /// </value>
        [DataMember(Name = "rejectionReasonId", EmitDefaultValue = false)]
        public string RejectionReasonId { get; set; }

        /// <summary>
        ///     Returns true if UpdateVerificationStatusRequestBody instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateVerificationStatusRequestBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateVerificationStatusRequestBody input)
        {
            if (input == null)
                return false;

            return
                (
                    Status == input.Status ||
                    (Status != null &&
                     Status.Equals(input.Status))
                ) &&
                (
                    ExternalReviewerId == input.ExternalReviewerId ||
                    (ExternalReviewerId != null &&
                     ExternalReviewerId.Equals(input.ExternalReviewerId))
                ) &&
                (
                    RejectionReasonId == input.RejectionReasonId ||
                    (RejectionReasonId != null &&
                     RejectionReasonId.Equals(input.RejectionReasonId))
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
            sb.Append("class UpdateVerificationStatusRequestBody {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ExternalReviewerId: ").Append(ExternalReviewerId).Append("\n");
            sb.Append("  RejectionReasonId: ").Append(RejectionReasonId).Append("\n");
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
            return Equals(input as UpdateVerificationStatusRequestBody);
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
                if (ExternalReviewerId != null)
                    hashCode = hashCode * 59 + ExternalReviewerId.GetHashCode();
                if (RejectionReasonId != null)
                    hashCode = hashCode * 59 + RejectionReasonId.GetHashCode();
                return hashCode;
            }
        }
    }
}