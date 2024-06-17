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
    ///     Generic item approval context. Check the applicable restrictions at the specific approval type schemas.
    /// </summary>
    [DataContract]
    public class ItemApprovalContext : IEquatable<ItemApprovalContext>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ItemApprovalContext" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ItemApprovalContext()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ItemApprovalContext" /> class.
        /// </summary>
        /// <param name="approvalType">The approval process type required for the order item. (required).</param>
        /// <param name="approvalStatus">Current status of the order item approval. (required).</param>
        /// <param name="approvalSupportData">
        ///     List of additional data elements supporting the approval process. Check the
        ///     applicable restrictions at the specific approval type schemas..
        /// </param>
        public ItemApprovalContext(ItemApprovalType approvalType = default, ItemApprovalStatus approvalStatus = default,
            ApprovalSupportDataElementList approvalSupportData = default)
        {
            // to ensure "approvalType" is required (not null)
            if (approvalType == null)
                throw new InvalidDataException(
                    "approvalType is a required property for ItemApprovalContext and cannot be null");
            ApprovalType = approvalType;
            // to ensure "approvalStatus" is required (not null)
            if (approvalStatus == null)
                throw new InvalidDataException(
                    "approvalStatus is a required property for ItemApprovalContext and cannot be null");
            ApprovalStatus = approvalStatus;
            ApprovalSupportData = approvalSupportData;
        }

        /// <summary>
        ///     The approval process type required for the order item.
        /// </summary>
        /// <value>The approval process type required for the order item.</value>
        [DataMember(Name = "ApprovalType", EmitDefaultValue = false)]
        public ItemApprovalType ApprovalType { get; set; }

        /// <summary>
        ///     Current status of the order item approval.
        /// </summary>
        /// <value>Current status of the order item approval.</value>
        [DataMember(Name = "ApprovalStatus", EmitDefaultValue = false)]
        public ItemApprovalStatus ApprovalStatus { get; set; }


        /// <summary>
        ///     List of additional data elements supporting the approval process. Check the applicable restrictions at the specific
        ///     approval type schemas.
        /// </summary>
        /// <value>
        ///     List of additional data elements supporting the approval process. Check the applicable restrictions at the
        ///     specific approval type schemas.
        /// </value>
        [DataMember(Name = "ApprovalSupportData", EmitDefaultValue = false)]
        public ApprovalSupportDataElementList ApprovalSupportData { get; set; }

        /// <summary>
        ///     Returns true if ItemApprovalContext instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemApprovalContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemApprovalContext input)
        {
            if (input == null)
                return false;

            return
                (
                    ApprovalType == input.ApprovalType ||
                    (ApprovalType != null &&
                     ApprovalType.Equals(input.ApprovalType))
                ) &&
                (
                    ApprovalStatus == input.ApprovalStatus ||
                    (ApprovalStatus != null &&
                     ApprovalStatus.Equals(input.ApprovalStatus))
                ) &&
                (
                    ApprovalSupportData == input.ApprovalSupportData ||
                    (ApprovalSupportData != null &&
                     ApprovalSupportData.Equals(input.ApprovalSupportData))
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
            sb.Append("class ItemApprovalContext {\n");
            sb.Append("  ApprovalType: ").Append(ApprovalType).Append("\n");
            sb.Append("  ApprovalStatus: ").Append(ApprovalStatus).Append("\n");
            sb.Append("  ApprovalSupportData: ").Append(ApprovalSupportData).Append("\n");
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
            return Equals(input as ItemApprovalContext);
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
                if (ApprovalType != null)
                    hashCode = hashCode * 59 + ApprovalType.GetHashCode();
                if (ApprovalStatus != null)
                    hashCode = hashCode * 59 + ApprovalStatus.GetHashCode();
                if (ApprovalSupportData != null)
                    hashCode = hashCode * 59 + ApprovalSupportData.GetHashCode();
                return hashCode;
            }
        }
    }
}