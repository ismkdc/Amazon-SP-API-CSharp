/*
 * Selling Partner API for Fulfillment Outbound
 *
 * The Selling Partner API for Fulfillment Outbound lets you create applications that help a seller fulfill Multi-Channel Fulfillment orders using their inventory in Amazon's fulfillment network. You can get information on both potential and existing fulfillment orders.
 *
 * OpenAPI spec version: v0
 *
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentOutbound
{
    /// <summary>
    ///     Item information for a fulfillment order.
    /// </summary>
    [DataContract]
    public class FulfillmentOrderItem : IEquatable<FulfillmentOrderItem>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="FulfillmentOrderItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public FulfillmentOrderItem()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="FulfillmentOrderItem" /> class.
        /// </summary>
        /// <param name="SellerSKU">The seller SKU of the item. (required).</param>
        /// <param name="SellerFulfillmentOrderItemId">
        ///     A fulfillment order item identifier submitted with a call to the
        ///     createFulfillmentOrder operation. (required).
        /// </param>
        /// <param name="Quantity">Quantity (required).</param>
        /// <param name="GiftMessage">A message to the gift recipient, if applicable..</param>
        /// <param name="DisplayableComment">
        ///     Item-specific text that displays in recipient-facing materials such as the outbound
        ///     shipment packing slip..
        /// </param>
        /// <param name="FulfillmentNetworkSKU">Amazon&#39;s fulfillment network SKU of the item..</param>
        /// <param name="OrderItemDisposition">Indicates whether the item is sellable or unsellable..</param>
        /// <param name="CancelledQuantity">The item quantity that was cancelled by the seller. (required).</param>
        /// <param name="UnfulfillableQuantity">The item quantity that is unfulfillable. (required).</param>
        /// <param name="EstimatedShipDateTime">
        ///     The estimated date and time that the item quantity is scheduled to ship from the
        ///     fulfillment center. Note that this value can change over time. If the shipment that contains the item quantity has
        ///     been cancelled, EstimatedShipDateTime is not returned..
        /// </param>
        /// <param name="EstimatedArrivalDateTime">
        ///     The estimated arrival date and time of the item quantity. Note that this value
        ///     can change over time. If the shipment that contains the item quantity has been cancelled, EstimatedArrivalDateTime
        ///     is not returned..
        /// </param>
        /// <param name="PerUnitPrice">
        ///     The amount to be collected from the recipient for this item in a COD (Cash On Delivery)
        ///     order..
        /// </param>
        /// <param name="PerUnitTax">
        ///     The tax on the amount to be collected from the recipient for this item in a COD (Cash On
        ///     Delivery) order..
        /// </param>
        /// <param name="PerUnitDeclaredValue">The monetary value assigned by the seller to this item..</param>
        public FulfillmentOrderItem(string SellerSKU = default, string SellerFulfillmentOrderItemId = default,
            int Quantity = default, string GiftMessage = default, string DisplayableComment = default,
            string FulfillmentNetworkSKU = default, string OrderItemDisposition = default,
            int CancelledQuantity = default, int UnfulfillableQuantity = default, DateTime? EstimatedShipDate = null,
            DateTime? EstimatedArrivalDate = null, Currency PerUnitPrice = default, Currency PerUnitTax = default,
            Currency PerUnitDeclaredValue = default)
        {
            // to ensure "SellerSKU" is required (not null)
            if (SellerSKU == null)
                throw new InvalidDataException(
                    "SellerSKU is a required property for FulfillmentOrderItem and cannot be null");
            this.SellerSKU = SellerSKU;
            // to ensure "SellerFulfillmentOrderItemId" is required (not null)
            if (SellerFulfillmentOrderItemId == null)
                throw new InvalidDataException(
                    "SellerFulfillmentOrderItemId is a required property for FulfillmentOrderItem and cannot be null");
            this.SellerFulfillmentOrderItemId = SellerFulfillmentOrderItemId;
            // to ensure "Quantity" is required (not null)
            if (Quantity == null)
                throw new InvalidDataException(
                    "Quantity is a required property for FulfillmentOrderItem and cannot be null");
            this.Quantity = Quantity;
            // to ensure "CancelledQuantity" is required (not null)
            if (CancelledQuantity == null)
                throw new InvalidDataException(
                    "CancelledQuantity is a required property for FulfillmentOrderItem and cannot be null");
            this.CancelledQuantity = CancelledQuantity;
            // to ensure "UnfulfillableQuantity" is required (not null)
            if (UnfulfillableQuantity == null)
                throw new InvalidDataException(
                    "UnfulfillableQuantity is a required property for FulfillmentOrderItem and cannot be null");
            this.UnfulfillableQuantity = UnfulfillableQuantity;
            this.GiftMessage = GiftMessage;
            this.DisplayableComment = DisplayableComment;
            this.FulfillmentNetworkSKU = FulfillmentNetworkSKU;
            this.OrderItemDisposition = OrderItemDisposition;
            this.EstimatedShipDate = EstimatedShipDate;
            this.EstimatedArrivalDate = EstimatedArrivalDate;
            this.PerUnitPrice = PerUnitPrice;
            this.PerUnitTax = PerUnitTax;
            this.PerUnitDeclaredValue = PerUnitDeclaredValue;
        }

        /// <summary>
        ///     The seller SKU of the item.
        /// </summary>
        /// <value>The seller SKU of the item.</value>
        [DataMember(Name = "SellerSKU", EmitDefaultValue = false)]
        public string SellerSKU { get; set; }

        /// <summary>
        ///     A fulfillment order item identifier submitted with a call to the createFulfillmentOrder operation.
        /// </summary>
        /// <value>A fulfillment order item identifier submitted with a call to the createFulfillmentOrder operation.</value>
        [DataMember(Name = "SellerFulfillmentOrderItemId", EmitDefaultValue = false)]
        public string SellerFulfillmentOrderItemId { get; set; }

        /// <summary>
        ///     Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "Quantity", EmitDefaultValue = false)]
        public int Quantity { get; set; }

        /// <summary>
        ///     A message to the gift recipient, if applicable.
        /// </summary>
        /// <value>A message to the gift recipient, if applicable.</value>
        [DataMember(Name = "GiftMessage", EmitDefaultValue = false)]
        public string GiftMessage { get; set; }

        /// <summary>
        ///     Item-specific text that displays in recipient-facing materials such as the outbound shipment packing slip.
        /// </summary>
        /// <value>Item-specific text that displays in recipient-facing materials such as the outbound shipment packing slip.</value>
        [DataMember(Name = "DisplayableComment", EmitDefaultValue = false)]
        public string DisplayableComment { get; set; }

        /// <summary>
        ///     Amazon&#39;s fulfillment network SKU of the item.
        /// </summary>
        /// <value>Amazon&#39;s fulfillment network SKU of the item.</value>
        [DataMember(Name = "FulfillmentNetworkSKU", EmitDefaultValue = false)]
        public string FulfillmentNetworkSKU { get; set; }

        /// <summary>
        ///     Indicates whether the item is sellable or unsellable.
        /// </summary>
        /// <value>Indicates whether the item is sellable or unsellable.</value>
        [DataMember(Name = "OrderItemDisposition", EmitDefaultValue = false)]
        public string OrderItemDisposition { get; set; }

        /// <summary>
        ///     The item quantity that was cancelled by the seller.
        /// </summary>
        /// <value>The item quantity that was cancelled by the seller.</value>
        [DataMember(Name = "CancelledQuantity", EmitDefaultValue = false)]
        public int CancelledQuantity { get; set; }

        /// <summary>
        ///     The item quantity that is unfulfillable.
        /// </summary>
        /// <value>The item quantity that is unfulfillable.</value>
        [DataMember(Name = "UnfulfillableQuantity", EmitDefaultValue = false)]
        public int UnfulfillableQuantity { get; set; }

        /// <summary>
        ///     The estimated date and time that the item quantity is scheduled to ship from the fulfillment center. Note that this
        ///     value can change over time. If the shipment that contains the item quantity has been cancelled,
        ///     EstimatedShipDateTime is not returned.
        /// </summary>
        /// <value>
        ///     The estimated date and time that the item quantity is scheduled to ship from the fulfillment center. Note that
        ///     this value can change over time. If the shipment that contains the item quantity has been cancelled,
        ///     EstimatedShipDateTime is not returned.
        /// </value>
        [DataMember(Name = "EstimatedShipDate", EmitDefaultValue = false)]
        public DateTime? EstimatedShipDate { get; set; }

        /// <summary>
        ///     The estimated arrival date and time of the item quantity. Note that this value can change over time. If the
        ///     shipment that contains the item quantity has been cancelled, EstimatedArrivalDateTime is not returned.
        /// </summary>
        /// <value>
        ///     The estimated arrival date and time of the item quantity. Note that this value can change over time. If the
        ///     shipment that contains the item quantity has been cancelled, EstimatedArrivalDateTime is not returned.
        /// </value>
        [DataMember(Name = "EstimatedArrivalDate", EmitDefaultValue = false)]
        public DateTime? EstimatedArrivalDate { get; set; }

        /// <summary>
        ///     The amount to be collected from the recipient for this item in a COD (Cash On Delivery) order.
        /// </summary>
        /// <value>The amount to be collected from the recipient for this item in a COD (Cash On Delivery) order.</value>
        [DataMember(Name = "PerUnitPrice", EmitDefaultValue = false)]
        public Currency PerUnitPrice { get; set; }

        /// <summary>
        ///     The tax on the amount to be collected from the recipient for this item in a COD (Cash On Delivery) order.
        /// </summary>
        /// <value>The tax on the amount to be collected from the recipient for this item in a COD (Cash On Delivery) order.</value>
        [DataMember(Name = "PerUnitTax", EmitDefaultValue = false)]
        public Currency PerUnitTax { get; set; }

        /// <summary>
        ///     The monetary value assigned by the seller to this item.
        /// </summary>
        /// <value>The monetary value assigned by the seller to this item.</value>
        [DataMember(Name = "PerUnitDeclaredValue", EmitDefaultValue = false)]
        public Currency PerUnitDeclaredValue { get; set; }

        /// <summary>
        ///     Returns true if FulfillmentOrderItem instances are equal
        /// </summary>
        /// <param name="input">Instance of FulfillmentOrderItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FulfillmentOrderItem input)
        {
            if (input == null)
                return false;

            return
                (
                    SellerSKU == input.SellerSKU ||
                    (SellerSKU != null &&
                     SellerSKU.Equals(input.SellerSKU))
                ) &&
                (
                    SellerFulfillmentOrderItemId == input.SellerFulfillmentOrderItemId ||
                    (SellerFulfillmentOrderItemId != null &&
                     SellerFulfillmentOrderItemId.Equals(input.SellerFulfillmentOrderItemId))
                ) &&
                (
                    GiftMessage == input.GiftMessage ||
                    (GiftMessage != null &&
                     GiftMessage.Equals(input.GiftMessage))
                ) &&
                (
                    DisplayableComment == input.DisplayableComment ||
                    (DisplayableComment != null &&
                     DisplayableComment.Equals(input.DisplayableComment))
                ) &&
                (
                    FulfillmentNetworkSKU == input.FulfillmentNetworkSKU ||
                    (FulfillmentNetworkSKU != null &&
                     FulfillmentNetworkSKU.Equals(input.FulfillmentNetworkSKU))
                ) &&
                (
                    OrderItemDisposition == input.OrderItemDisposition ||
                    (OrderItemDisposition != null &&
                     OrderItemDisposition.Equals(input.OrderItemDisposition))
                ) &&
                (
                    EstimatedShipDate == input.EstimatedShipDate ||
                    (EstimatedShipDate != null &&
                     EstimatedShipDate.Equals(input.EstimatedShipDate))
                ) &&
                (
                    EstimatedArrivalDate == input.EstimatedArrivalDate ||
                    (EstimatedArrivalDate != null &&
                     EstimatedArrivalDate.Equals(input.EstimatedArrivalDate))
                ) &&
                (
                    PerUnitPrice == input.PerUnitPrice ||
                    (PerUnitPrice != null &&
                     PerUnitPrice.Equals(input.PerUnitPrice))
                ) &&
                (
                    PerUnitTax == input.PerUnitTax ||
                    (PerUnitTax != null &&
                     PerUnitTax.Equals(input.PerUnitTax))
                ) &&
                (
                    PerUnitDeclaredValue == input.PerUnitDeclaredValue ||
                    (PerUnitDeclaredValue != null &&
                     PerUnitDeclaredValue.Equals(input.PerUnitDeclaredValue))
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
            sb.Append("class FulfillmentOrderItem {\n");
            sb.Append("  SellerSKU: ").Append(SellerSKU).Append("\n");
            sb.Append("  SellerFulfillmentOrderItemId: ").Append(SellerFulfillmentOrderItemId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  GiftMessage: ").Append(GiftMessage).Append("\n");
            sb.Append("  DisplayableComment: ").Append(DisplayableComment).Append("\n");
            sb.Append("  FulfillmentNetworkSKU: ").Append(FulfillmentNetworkSKU).Append("\n");
            sb.Append("  OrderItemDisposition: ").Append(OrderItemDisposition).Append("\n");
            sb.Append("  CancelledQuantity: ").Append(CancelledQuantity).Append("\n");
            sb.Append("  UnfulfillableQuantity: ").Append(UnfulfillableQuantity).Append("\n");
            sb.Append("  EstimatedShipDate: ").Append(EstimatedShipDate).Append("\n");
            sb.Append("  EstimatedArrivalDate: ").Append(EstimatedArrivalDate).Append("\n");
            sb.Append("  PerUnitPrice: ").Append(PerUnitPrice).Append("\n");
            sb.Append("  PerUnitTax: ").Append(PerUnitTax).Append("\n");
            sb.Append("  PerUnitDeclaredValue: ").Append(PerUnitDeclaredValue).Append("\n");
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
            return Equals(input as FulfillmentOrderItem);
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
                if (SellerSKU != null)
                    hashCode = hashCode * 59 + SellerSKU.GetHashCode();
                if (SellerFulfillmentOrderItemId != null)
                    hashCode = hashCode * 59 + SellerFulfillmentOrderItemId.GetHashCode();
                if (GiftMessage != null)
                    hashCode = hashCode * 59 + GiftMessage.GetHashCode();
                if (DisplayableComment != null)
                    hashCode = hashCode * 59 + DisplayableComment.GetHashCode();
                if (FulfillmentNetworkSKU != null)
                    hashCode = hashCode * 59 + FulfillmentNetworkSKU.GetHashCode();
                if (OrderItemDisposition != null)
                    hashCode = hashCode * 59 + OrderItemDisposition.GetHashCode();
                if (EstimatedShipDate != null)
                    hashCode = hashCode * 59 + EstimatedShipDate.GetHashCode();
                if (EstimatedArrivalDate != null)
                    hashCode = hashCode * 59 + EstimatedArrivalDate.GetHashCode();
                if (PerUnitPrice != null)
                    hashCode = hashCode * 59 + PerUnitPrice.GetHashCode();
                if (PerUnitTax != null)
                    hashCode = hashCode * 59 + PerUnitTax.GetHashCode();
                if (PerUnitDeclaredValue != null)
                    hashCode = hashCode * 59 + PerUnitDeclaredValue.GetHashCode();
                return hashCode;
            }
        }
    }
}