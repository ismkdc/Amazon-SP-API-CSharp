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
    ///     The verification status of the order along with associated approval or rejection metadata.
    /// </summary>
    [DataContract]
    public class RegulatedOrderVerificationStatus : IEquatable<RegulatedOrderVerificationStatus>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="RegulatedOrderVerificationStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public RegulatedOrderVerificationStatus()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="RegulatedOrderVerificationStatus" /> class.
        /// </summary>
        /// <param name="status">The verification status of the order. (required).</param>
        /// <param name="requiresMerchantAction">
        ///     When true, the regulated information provided in the order requires a review by
        ///     the merchant. (required).
        /// </param>
        /// <param name="validRejectionReasons">
        ///     A list of valid rejection reasons that may be used to reject the order&#39;s
        ///     regulated information. (required).
        /// </param>
        /// <param name="rejectionReason">
        ///     The reason for rejecting the order&#39;s regulated information. Not present if the order
        ///     isn&#39;t rejected..
        /// </param>
        /// <param name="reviewDate">The date the order was reviewed. In ISO 8601 date time format..</param>
        /// <param name="externalReviewerId">The identifier for the order&#39;s regulated information reviewer..</param>
        public RegulatedOrderVerificationStatus(VerificationStatus status = default,
            bool? requiresMerchantAction = default, List<RejectionReason> validRejectionReasons = default,
            RejectionReason rejectionReason = default, string reviewDate = default, string externalReviewerId = default)
        {
            // to ensure "status" is required (not null)
            if (status == null)
                throw new InvalidDataException(
                    "status is a required property for RegulatedOrderVerificationStatus and cannot be null");
            Status = status;
            // to ensure "requiresMerchantAction" is required (not null)
            if (requiresMerchantAction == null)
                throw new InvalidDataException(
                    "requiresMerchantAction is a required property for RegulatedOrderVerificationStatus and cannot be null");
            RequiresMerchantAction = requiresMerchantAction;
            // to ensure "validRejectionReasons" is required (not null)
            if (validRejectionReasons == null)
                throw new InvalidDataException(
                    "validRejectionReasons is a required property for RegulatedOrderVerificationStatus and cannot be null");
            ValidRejectionReasons = validRejectionReasons;
            RejectionReason = rejectionReason;
            ReviewDate = reviewDate;
            ExternalReviewerId = externalReviewerId;
        }

        /// <summary>
        ///     The verification status of the order.
        /// </summary>
        /// <value>The verification status of the order.</value>
        [DataMember(Name = "Status", EmitDefaultValue = false)]
        public VerificationStatus Status { get; set; }


        /// <summary>
        ///     When true, the regulated information provided in the order requires a review by the merchant.
        /// </summary>
        /// <value>When true, the regulated information provided in the order requires a review by the merchant.</value>
        [DataMember(Name = "RequiresMerchantAction", EmitDefaultValue = false)]
        public bool? RequiresMerchantAction { get; set; }

        /// <summary>
        ///     A list of valid rejection reasons that may be used to reject the order&#39;s regulated information.
        /// </summary>
        /// <value>A list of valid rejection reasons that may be used to reject the order&#39;s regulated information.</value>
        [DataMember(Name = "ValidRejectionReasons", EmitDefaultValue = false)]
        public List<RejectionReason> ValidRejectionReasons { get; set; }

        /// <summary>
        ///     The reason for rejecting the order&#39;s regulated information. Not present if the order isn&#39;t rejected.
        /// </summary>
        /// <value>The reason for rejecting the order&#39;s regulated information. Not present if the order isn&#39;t rejected.</value>
        [DataMember(Name = "RejectionReason", EmitDefaultValue = false)]
        public RejectionReason RejectionReason { get; set; }

        /// <summary>
        ///     The date the order was reviewed. In ISO 8601 date time format.
        /// </summary>
        /// <value>The date the order was reviewed. In ISO 8601 date time format.</value>
        [DataMember(Name = "ReviewDate", EmitDefaultValue = false)]
        public string ReviewDate { get; set; }

        /// <summary>
        ///     The identifier for the order&#39;s regulated information reviewer.
        /// </summary>
        /// <value>The identifier for the order&#39;s regulated information reviewer.</value>
        [DataMember(Name = "ExternalReviewerId", EmitDefaultValue = false)]
        public string ExternalReviewerId { get; set; }

        /// <summary>
        ///     Returns true if RegulatedOrderVerificationStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of RegulatedOrderVerificationStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegulatedOrderVerificationStatus input)
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
                    RequiresMerchantAction == input.RequiresMerchantAction ||
                    (RequiresMerchantAction != null &&
                     RequiresMerchantAction.Equals(input.RequiresMerchantAction))
                ) &&
                (
                    ValidRejectionReasons == input.ValidRejectionReasons ||
                    ValidRejectionReasons != null
                ) &&
                (
                    RejectionReason == input.RejectionReason ||
                    (RejectionReason != null &&
                     RejectionReason.Equals(input.RejectionReason))
                ) &&
                (
                    ReviewDate == input.ReviewDate ||
                    (ReviewDate != null &&
                     ReviewDate.Equals(input.ReviewDate))
                ) &&
                (
                    ExternalReviewerId == input.ExternalReviewerId ||
                    (ExternalReviewerId != null &&
                     ExternalReviewerId.Equals(input.ExternalReviewerId))
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
            sb.Append("class RegulatedOrderVerificationStatus {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  RequiresMerchantAction: ").Append(RequiresMerchantAction).Append("\n");
            sb.Append("  ValidRejectionReasons: ").Append(ValidRejectionReasons).Append("\n");
            sb.Append("  RejectionReason: ").Append(RejectionReason).Append("\n");
            sb.Append("  ReviewDate: ").Append(ReviewDate).Append("\n");
            sb.Append("  ExternalReviewerId: ").Append(ExternalReviewerId).Append("\n");
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
            return Equals(input as RegulatedOrderVerificationStatus);
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
                if (RequiresMerchantAction != null)
                    hashCode = hashCode * 59 + RequiresMerchantAction.GetHashCode();
                if (ValidRejectionReasons != null)
                    hashCode = hashCode * 59 + ValidRejectionReasons.GetHashCode();
                if (RejectionReason != null)
                    hashCode = hashCode * 59 + RejectionReason.GetHashCode();
                if (ReviewDate != null)
                    hashCode = hashCode * 59 + ReviewDate.GetHashCode();
                if (ExternalReviewerId != null)
                    hashCode = hashCode * 59 + ExternalReviewerId.GetHashCode();
                return hashCode;
            }
        }
    }
}