/* 
 * Selling Partner API for Fulfillment Outbound
 *
 * The Selling Partner API for Fulfillment Outbound lets you create applications that help a seller fulfill Multi-Channel Fulfillment orders using their inventory in Amazon's fulfillment network. You can get information on both potential and existing fulfillment orders.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentOutbound
{
    /// <summary>
    /// Item information for updating a fulfillment order.
    /// </summary>
    [DataContract]
    public partial class UpdateFulfillmentOrderItem : IEquatable<UpdateFulfillmentOrderItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFulfillmentOrderItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public UpdateFulfillmentOrderItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFulfillmentOrderItem" /> class.
        /// </summary>
        /// <param name="SellerSKU">The seller SKU of the item..</param>
        /// <param name="SellerFulfillmentOrderItemId">Identifies the fulfillment order item to update. Created with a previous call to the createFulfillmentOrder operation. (required).</param>
        /// <param name="Quantity">Quantity (required).</param>
        /// <param name="GiftMessage">A message to the gift recipient, if applicable..</param>
        /// <param name="DisplayableComment">Item-specific text that displays in recipient-facing materials such as the outbound shipment packing slip..</param>
        /// <param name="FulfillmentNetworkSKU">Amazon&#39;s fulfillment network SKU of the item..</param>
        /// <param name="OrderItemDisposition">Indicates whether the item is sellable or unsellable..</param>
        /// <param name="PerUnitDeclaredValue">The monetary value assigned by the seller to this item..</param>
        /// <param name="PerUnitPrice">The amount to be collected from the recipient for this item in a COD (Cash On Delivery) order..</param>
        /// <param name="PerUnitTax">The tax on the amount to be collected from the recipient for this item in a COD (Cash On Delivery) order..</param>
        public UpdateFulfillmentOrderItem(string SellerSKU = default(string), string SellerFulfillmentOrderItemId = default(string), Quantity Quantity = default(Quantity), string GiftMessage = default(string), string DisplayableComment = default(string), string FulfillmentNetworkSKU = default(string), string OrderItemDisposition = default(string), Currency PerUnitDeclaredValue = default(Currency), Currency PerUnitPrice = default(Currency), Currency PerUnitTax = default(Currency))
        {
            // to ensure "SellerFulfillmentOrderItemId" is required (not null)
            if (SellerFulfillmentOrderItemId == null)
            {
                throw new InvalidDataException("SellerFulfillmentOrderItemId is a required property for UpdateFulfillmentOrderItem and cannot be null");
            }
            else
            {
                this.SellerFulfillmentOrderItemId = SellerFulfillmentOrderItemId;
            }
            // to ensure "Quantity" is required (not null)
            if (Quantity == null)
            {
                throw new InvalidDataException("Quantity is a required property for UpdateFulfillmentOrderItem and cannot be null");
            }
            else
            {
                this.Quantity = Quantity;
            }
            this.SellerSKU = SellerSKU;
            this.GiftMessage = GiftMessage;
            this.DisplayableComment = DisplayableComment;
            this.FulfillmentNetworkSKU = FulfillmentNetworkSKU;
            this.OrderItemDisposition = OrderItemDisposition;
            this.PerUnitDeclaredValue = PerUnitDeclaredValue;
            this.PerUnitPrice = PerUnitPrice;
            this.PerUnitTax = PerUnitTax;
        }

        /// <summary>
        /// The seller SKU of the item.
        /// </summary>
        /// <value>The seller SKU of the item.</value>
        [DataMember(Name = "SellerSKU", EmitDefaultValue = false)]
        public string SellerSKU { get; set; }

        /// <summary>
        /// Identifies the fulfillment order item to update. Created with a previous call to the createFulfillmentOrder operation.
        /// </summary>
        /// <value>Identifies the fulfillment order item to update. Created with a previous call to the createFulfillmentOrder operation.</value>
        [DataMember(Name = "SellerFulfillmentOrderItemId", EmitDefaultValue = false)]
        public string SellerFulfillmentOrderItemId { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "Quantity", EmitDefaultValue = false)]
        public Quantity Quantity { get; set; }

        /// <summary>
        /// A message to the gift recipient, if applicable.
        /// </summary>
        /// <value>A message to the gift recipient, if applicable.</value>
        [DataMember(Name = "GiftMessage", EmitDefaultValue = false)]
        public string GiftMessage { get; set; }

        /// <summary>
        /// Item-specific text that displays in recipient-facing materials such as the outbound shipment packing slip.
        /// </summary>
        /// <value>Item-specific text that displays in recipient-facing materials such as the outbound shipment packing slip.</value>
        [DataMember(Name = "DisplayableComment", EmitDefaultValue = false)]
        public string DisplayableComment { get; set; }

        /// <summary>
        /// Amazon&#39;s fulfillment network SKU of the item.
        /// </summary>
        /// <value>Amazon&#39;s fulfillment network SKU of the item.</value>
        [DataMember(Name = "FulfillmentNetworkSKU", EmitDefaultValue = false)]
        public string FulfillmentNetworkSKU { get; set; }

        /// <summary>
        /// Indicates whether the item is sellable or unsellable.
        /// </summary>
        /// <value>Indicates whether the item is sellable or unsellable.</value>
        [DataMember(Name = "OrderItemDisposition", EmitDefaultValue = false)]
        public string OrderItemDisposition { get; set; }

        /// <summary>
        /// The monetary value assigned by the seller to this item.
        /// </summary>
        /// <value>The monetary value assigned by the seller to this item.</value>
        [DataMember(Name = "PerUnitDeclaredValue", EmitDefaultValue = false)]
        public Currency PerUnitDeclaredValue { get; set; }

        /// <summary>
        /// The amount to be collected from the recipient for this item in a COD (Cash On Delivery) order.
        /// </summary>
        /// <value>The amount to be collected from the recipient for this item in a COD (Cash On Delivery) order.</value>
        [DataMember(Name = "PerUnitPrice", EmitDefaultValue = false)]
        public Currency PerUnitPrice { get; set; }

        /// <summary>
        /// The tax on the amount to be collected from the recipient for this item in a COD (Cash On Delivery) order.
        /// </summary>
        /// <value>The tax on the amount to be collected from the recipient for this item in a COD (Cash On Delivery) order.</value>
        [DataMember(Name = "PerUnitTax", EmitDefaultValue = false)]
        public Currency PerUnitTax { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateFulfillmentOrderItem {\n");
            sb.Append("  SellerSKU: ").Append(SellerSKU).Append("\n");
            sb.Append("  SellerFulfillmentOrderItemId: ").Append(SellerFulfillmentOrderItemId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  GiftMessage: ").Append(GiftMessage).Append("\n");
            sb.Append("  DisplayableComment: ").Append(DisplayableComment).Append("\n");
            sb.Append("  FulfillmentNetworkSKU: ").Append(FulfillmentNetworkSKU).Append("\n");
            sb.Append("  OrderItemDisposition: ").Append(OrderItemDisposition).Append("\n");
            sb.Append("  PerUnitDeclaredValue: ").Append(PerUnitDeclaredValue).Append("\n");
            sb.Append("  PerUnitPrice: ").Append(PerUnitPrice).Append("\n");
            sb.Append("  PerUnitTax: ").Append(PerUnitTax).Append("\n");
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
            return this.Equals(input as UpdateFulfillmentOrderItem);
        }

        /// <summary>
        /// Returns true if UpdateFulfillmentOrderItem instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateFulfillmentOrderItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateFulfillmentOrderItem input)
        {
            if (input == null)
                return false;

            return
                (
                    this.SellerSKU == input.SellerSKU ||
                    (this.SellerSKU != null &&
                    this.SellerSKU.Equals(input.SellerSKU))
                ) &&
                (
                    this.SellerFulfillmentOrderItemId == input.SellerFulfillmentOrderItemId ||
                    (this.SellerFulfillmentOrderItemId != null &&
                    this.SellerFulfillmentOrderItemId.Equals(input.SellerFulfillmentOrderItemId))
                ) &&
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) &&
                (
                    this.GiftMessage == input.GiftMessage ||
                    (this.GiftMessage != null &&
                    this.GiftMessage.Equals(input.GiftMessage))
                ) &&
                (
                    this.DisplayableComment == input.DisplayableComment ||
                    (this.DisplayableComment != null &&
                    this.DisplayableComment.Equals(input.DisplayableComment))
                ) &&
                (
                    this.FulfillmentNetworkSKU == input.FulfillmentNetworkSKU ||
                    (this.FulfillmentNetworkSKU != null &&
                    this.FulfillmentNetworkSKU.Equals(input.FulfillmentNetworkSKU))
                ) &&
                (
                    this.OrderItemDisposition == input.OrderItemDisposition ||
                    (this.OrderItemDisposition != null &&
                    this.OrderItemDisposition.Equals(input.OrderItemDisposition))
                ) &&
                (
                    this.PerUnitDeclaredValue == input.PerUnitDeclaredValue ||
                    (this.PerUnitDeclaredValue != null &&
                    this.PerUnitDeclaredValue.Equals(input.PerUnitDeclaredValue))
                ) &&
                (
                    this.PerUnitPrice == input.PerUnitPrice ||
                    (this.PerUnitPrice != null &&
                    this.PerUnitPrice.Equals(input.PerUnitPrice))
                ) &&
                (
                    this.PerUnitTax == input.PerUnitTax ||
                    (this.PerUnitTax != null &&
                    this.PerUnitTax.Equals(input.PerUnitTax))
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
                if (this.SellerSKU != null)
                    hashCode = hashCode * 59 + this.SellerSKU.GetHashCode();
                if (this.SellerFulfillmentOrderItemId != null)
                    hashCode = hashCode * 59 + this.SellerFulfillmentOrderItemId.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.GiftMessage != null)
                    hashCode = hashCode * 59 + this.GiftMessage.GetHashCode();
                if (this.DisplayableComment != null)
                    hashCode = hashCode * 59 + this.DisplayableComment.GetHashCode();
                if (this.FulfillmentNetworkSKU != null)
                    hashCode = hashCode * 59 + this.FulfillmentNetworkSKU.GetHashCode();
                if (this.OrderItemDisposition != null)
                    hashCode = hashCode * 59 + this.OrderItemDisposition.GetHashCode();
                if (this.PerUnitDeclaredValue != null)
                    hashCode = hashCode * 59 + this.PerUnitDeclaredValue.GetHashCode();
                if (this.PerUnitPrice != null)
                    hashCode = hashCode * 59 + this.PerUnitPrice.GetHashCode();
                if (this.PerUnitTax != null)
                    hashCode = hashCode * 59 + this.PerUnitTax.GetHashCode();
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
            // SellerFulfillmentOrderItemId (string) maxLength
            if (this.SellerFulfillmentOrderItemId != null && this.SellerFulfillmentOrderItemId.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SellerFulfillmentOrderItemId, length must be less than 50.", new[] { "SellerFulfillmentOrderItemId" });
            }

            // GiftMessage (string) maxLength
            if (this.GiftMessage != null && this.GiftMessage.Length > 512)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GiftMessage, length must be less than 512.", new[] { "GiftMessage" });
            }

            // DisplayableComment (string) maxLength
            if (this.DisplayableComment != null && this.DisplayableComment.Length > 250)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DisplayableComment, length must be less than 250.", new[] { "DisplayableComment" });
            }

            yield break;
        }
    }

}
