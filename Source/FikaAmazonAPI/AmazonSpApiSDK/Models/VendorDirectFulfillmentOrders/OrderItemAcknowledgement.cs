/*
 * Selling Partner API for Direct Fulfillment Orders
 *
 * The Selling Partner API for Direct Fulfillment Orders provides programmatic access to a direct fulfillment vendor's order data.
 *
 * OpenAPI spec version: v1
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

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.VendorDirectFulfillmentOrders
{
    /// <summary>
    ///     OrderItemAcknowledgement
    /// </summary>
    [DataContract]
    public class OrderItemAcknowledgement : IEquatable<OrderItemAcknowledgement>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="OrderItemAcknowledgement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public OrderItemAcknowledgement()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="OrderItemAcknowledgement" /> class.
        /// </summary>
        /// <param name="itemSequenceNumber">Line item sequence number for the item. (required).</param>
        /// <param name="buyerProductIdentifier">Buyer&#39;s standard identification number (ASIN) of an item..</param>
        /// <param name="vendorProductIdentifier">
        ///     The vendor selected product identification of the item. Should be the same as was
        ///     provided in the purchase order..
        /// </param>
        /// <param name="acknowledgedQuantity">Details of quantity acknowledged with the above acknowledgement code. (required).</param>
        public OrderItemAcknowledgement(string itemSequenceNumber = default, string buyerProductIdentifier = default,
            string vendorProductIdentifier = default, ItemQuantity acknowledgedQuantity = default)
        {
            // to ensure "itemSequenceNumber" is required (not null)
            if (itemSequenceNumber == null)
                throw new InvalidDataException(
                    "itemSequenceNumber is a required property for OrderItemAcknowledgement and cannot be null");
            ItemSequenceNumber = itemSequenceNumber;
            // to ensure "acknowledgedQuantity" is required (not null)
            if (acknowledgedQuantity == null)
                throw new InvalidDataException(
                    "acknowledgedQuantity is a required property for OrderItemAcknowledgement and cannot be null");
            AcknowledgedQuantity = acknowledgedQuantity;
            BuyerProductIdentifier = buyerProductIdentifier;
            VendorProductIdentifier = vendorProductIdentifier;
        }

        /// <summary>
        ///     Line item sequence number for the item.
        /// </summary>
        /// <value>Line item sequence number for the item.</value>
        [DataMember(Name = "itemSequenceNumber", EmitDefaultValue = false)]
        public string ItemSequenceNumber { get; set; }

        /// <summary>
        ///     Buyer&#39;s standard identification number (ASIN) of an item.
        /// </summary>
        /// <value>Buyer&#39;s standard identification number (ASIN) of an item.</value>
        [DataMember(Name = "buyerProductIdentifier", EmitDefaultValue = false)]
        public string BuyerProductIdentifier { get; set; }

        /// <summary>
        ///     The vendor selected product identification of the item. Should be the same as was provided in the purchase order.
        /// </summary>
        /// <value>
        ///     The vendor selected product identification of the item. Should be the same as was provided in the purchase
        ///     order.
        /// </value>
        [DataMember(Name = "vendorProductIdentifier", EmitDefaultValue = false)]
        public string VendorProductIdentifier { get; set; }

        /// <summary>
        ///     Details of quantity acknowledged with the above acknowledgement code.
        /// </summary>
        /// <value>Details of quantity acknowledged with the above acknowledgement code.</value>
        [DataMember(Name = "acknowledgedQuantity", EmitDefaultValue = false)]
        public ItemQuantity AcknowledgedQuantity { get; set; }

        /// <summary>
        ///     Returns true if OrderItemAcknowledgement instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderItemAcknowledgement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderItemAcknowledgement input)
        {
            if (input == null)
                return false;

            return
                (
                    ItemSequenceNumber == input.ItemSequenceNumber ||
                    (ItemSequenceNumber != null &&
                     ItemSequenceNumber.Equals(input.ItemSequenceNumber))
                ) &&
                (
                    BuyerProductIdentifier == input.BuyerProductIdentifier ||
                    (BuyerProductIdentifier != null &&
                     BuyerProductIdentifier.Equals(input.BuyerProductIdentifier))
                ) &&
                (
                    VendorProductIdentifier == input.VendorProductIdentifier ||
                    (VendorProductIdentifier != null &&
                     VendorProductIdentifier.Equals(input.VendorProductIdentifier))
                ) &&
                (
                    AcknowledgedQuantity == input.AcknowledgedQuantity ||
                    (AcknowledgedQuantity != null &&
                     AcknowledgedQuantity.Equals(input.AcknowledgedQuantity))
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
            sb.Append("class OrderItemAcknowledgement {\n");
            sb.Append("  ItemSequenceNumber: ").Append(ItemSequenceNumber).Append("\n");
            sb.Append("  BuyerProductIdentifier: ").Append(BuyerProductIdentifier).Append("\n");
            sb.Append("  VendorProductIdentifier: ").Append(VendorProductIdentifier).Append("\n");
            sb.Append("  AcknowledgedQuantity: ").Append(AcknowledgedQuantity).Append("\n");
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
            return Equals(input as OrderItemAcknowledgement);
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
                if (ItemSequenceNumber != null)
                    hashCode = hashCode * 59 + ItemSequenceNumber.GetHashCode();
                if (BuyerProductIdentifier != null)
                    hashCode = hashCode * 59 + BuyerProductIdentifier.GetHashCode();
                if (VendorProductIdentifier != null)
                    hashCode = hashCode * 59 + VendorProductIdentifier.GetHashCode();
                if (AcknowledgedQuantity != null)
                    hashCode = hashCode * 59 + AcknowledgedQuantity.GetHashCode();
                return hashCode;
            }
        }
    }
}