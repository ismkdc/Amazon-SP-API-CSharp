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
    ///     The request body for the updateOrderItemsApprovals operation.
    /// </summary>
    [DataContract]
    public class UpdateOrderApprovalsRequest : IEquatable<UpdateOrderApprovalsRequest>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="UpdateOrderApprovalsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateOrderApprovalsRequest()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="UpdateOrderApprovalsRequest" /> class.
        /// </summary>
        /// <param name="approver">Person or system that triggers the approval actions on behalf of the actor..</param>
        /// <param name="orderItemsApprovalRequests">A list of item approval requests. (required).</param>
        public UpdateOrderApprovalsRequest(string approver = default,
            List<OrderItemApprovalRequest> orderItemsApprovalRequests = default)
        {
            // to ensure "orderItemsApprovalRequests" is required (not null)
            if (orderItemsApprovalRequests == null)
                throw new InvalidDataException(
                    "orderItemsApprovalRequests is a required property for UpdateOrderApprovalsRequest and cannot be null");
            OrderItemsApprovalRequests = orderItemsApprovalRequests;
            Approver = approver;
        }

        /// <summary>
        ///     Person or system that triggers the approval actions on behalf of the actor.
        /// </summary>
        /// <value>Person or system that triggers the approval actions on behalf of the actor.</value>
        [DataMember(Name = "Approver", EmitDefaultValue = false)]
        public string Approver { get; set; }

        /// <summary>
        ///     A list of item approval requests.
        /// </summary>
        /// <value>A list of item approval requests.</value>
        [DataMember(Name = "OrderItemsApprovalRequests", EmitDefaultValue = false)]
        public List<OrderItemApprovalRequest> OrderItemsApprovalRequests { get; set; }

        /// <summary>
        ///     Returns true if UpdateOrderApprovalsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateOrderApprovalsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateOrderApprovalsRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    Approver == input.Approver ||
                    (Approver != null &&
                     Approver.Equals(input.Approver))
                ) &&
                (
                    OrderItemsApprovalRequests == input.OrderItemsApprovalRequests ||
                    OrderItemsApprovalRequests != null
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
            sb.Append("class UpdateOrderApprovalsRequest {\n");
            sb.Append("  Approver: ").Append(Approver).Append("\n");
            sb.Append("  OrderItemsApprovalRequests: ").Append(OrderItemsApprovalRequests).Append("\n");
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
            return Equals(input as UpdateOrderApprovalsRequest);
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
                if (Approver != null)
                    hashCode = hashCode * 59 + Approver.GetHashCode();
                if (OrderItemsApprovalRequests != null)
                    hashCode = hashCode * 59 + OrderItemsApprovalRequests.GetHashCode();
                return hashCode;
            }
        }
    }
}