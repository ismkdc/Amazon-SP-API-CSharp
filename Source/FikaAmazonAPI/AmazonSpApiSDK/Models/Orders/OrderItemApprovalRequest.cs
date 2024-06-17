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
    ///     Order item apecific approval request.
    /// </summary>
    [DataContract]
    public class OrderItemApprovalRequest : IEquatable<OrderItemApprovalRequest>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="OrderItemApprovalRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public OrderItemApprovalRequest()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="OrderItemApprovalRequest" /> class.
        /// </summary>
        /// <param name="orderItemId">The unique identifier of the order item. (required).</param>
        /// <param name="approvalAction">Approval action that defines the behavior of the ItemApproval. (required).</param>
        public OrderItemApprovalRequest(string orderItemId = default, ItemApprovalAction approvalAction = default)
        {
            // to ensure "orderItemId" is required (not null)
            if (orderItemId == null)
                throw new InvalidDataException(
                    "orderItemId is a required property for OrderItemApprovalRequest and cannot be null");
            OrderItemId = orderItemId;
            // to ensure "approvalAction" is required (not null)
            if (approvalAction == null)
                throw new InvalidDataException(
                    "approvalAction is a required property for OrderItemApprovalRequest and cannot be null");
            ApprovalAction = approvalAction;
        }

        /// <summary>
        ///     The unique identifier of the order item.
        /// </summary>
        /// <value>The unique identifier of the order item.</value>
        [DataMember(Name = "OrderItemId", EmitDefaultValue = false)]
        public string OrderItemId { get; set; }

        /// <summary>
        ///     Approval action that defines the behavior of the ItemApproval.
        /// </summary>
        /// <value>Approval action that defines the behavior of the ItemApproval.</value>
        [DataMember(Name = "ApprovalAction", EmitDefaultValue = false)]
        public ItemApprovalAction ApprovalAction { get; set; }

        /// <summary>
        ///     Returns true if OrderItemApprovalRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderItemApprovalRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderItemApprovalRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    OrderItemId == input.OrderItemId ||
                    (OrderItemId != null &&
                     OrderItemId.Equals(input.OrderItemId))
                ) &&
                (
                    ApprovalAction == input.ApprovalAction ||
                    (ApprovalAction != null &&
                     ApprovalAction.Equals(input.ApprovalAction))
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
            sb.Append("class OrderItemApprovalRequest {\n");
            sb.Append("  OrderItemId: ").Append(OrderItemId).Append("\n");
            sb.Append("  ApprovalAction: ").Append(ApprovalAction).Append("\n");
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
            return Equals(input as OrderItemApprovalRequest);
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
                if (OrderItemId != null)
                    hashCode = hashCode * 59 + OrderItemId.GetHashCode();
                if (ApprovalAction != null)
                    hashCode = hashCode * 59 + ApprovalAction.GetHashCode();
                return hashCode;
            }
        }
    }
}