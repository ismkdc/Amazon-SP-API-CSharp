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
    ///     A single order item.
    /// </summary>
    [DataContract]
    public class ConfirmShipmentOrderItem : IEquatable<ConfirmShipmentOrderItem>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ConfirmShipmentOrderItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConfirmShipmentOrderItem()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ConfirmShipmentOrderItem" /> class.
        /// </summary>
        /// <param name="orderItemId">The unique identifier of the order item. (required).</param>
        /// <param name="quantity">The quantity of the item. (required).</param>
        /// <param name="transparencyCodes">The list of transparency codes..</param>
        public ConfirmShipmentOrderItem(string orderItemId = default, int? quantity = default,
            TransparencyCodeList transparencyCodes = default)
        {
            // to ensure "orderItemId" is required (not null)
            if (orderItemId == null)
                throw new InvalidDataException(
                    "orderItemId is a required property for ConfirmShipmentOrderItem and cannot be null");
            OrderItemId = orderItemId;
            // to ensure "quantity" is required (not null)
            if (quantity == null)
                throw new InvalidDataException(
                    "quantity is a required property for ConfirmShipmentOrderItem and cannot be null");
            Quantity = quantity;
            TransparencyCodes = transparencyCodes;
        }

        /// <summary>
        ///     The unique identifier of the order item.
        /// </summary>
        /// <value>The unique identifier of the order item.</value>
        [DataMember(Name = "orderItemId", EmitDefaultValue = false)]
        public string OrderItemId { get; set; }

        /// <summary>
        ///     The quantity of the item.
        /// </summary>
        /// <value>The quantity of the item.</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public int? Quantity { get; set; }

        /// <summary>
        ///     The list of transparency codes.
        /// </summary>
        /// <value>The list of transparency codes.</value>
        [DataMember(Name = "transparencyCodes", EmitDefaultValue = false)]
        public TransparencyCodeList TransparencyCodes { get; set; }

        /// <summary>
        ///     Returns true if ConfirmShipmentOrderItem instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfirmShipmentOrderItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfirmShipmentOrderItem input)
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
                    Quantity == input.Quantity ||
                    (Quantity != null &&
                     Quantity.Equals(input.Quantity))
                ) &&
                (
                    TransparencyCodes == input.TransparencyCodes ||
                    (TransparencyCodes != null &&
                     TransparencyCodes.Equals(input.TransparencyCodes))
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
            sb.Append("class ConfirmShipmentOrderItem {\n");
            sb.Append("  OrderItemId: ").Append(OrderItemId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  TransparencyCodes: ").Append(TransparencyCodes).Append("\n");
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
            return Equals(input as ConfirmShipmentOrderItem);
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
                if (Quantity != null)
                    hashCode = hashCode * 59 + Quantity.GetHashCode();
                if (TransparencyCodes != null)
                    hashCode = hashCode * 59 + TransparencyCodes.GetHashCode();
                return hashCode;
            }
        }
    }
}