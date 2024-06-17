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
    ///     Item information for a shipment in a fulfillment order.
    /// </summary>
    [DataContract]
    public class FulfillmentShipmentItem : IEquatable<FulfillmentShipmentItem>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="FulfillmentShipmentItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public FulfillmentShipmentItem()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="FulfillmentShipmentItem" /> class.
        /// </summary>
        /// <param name="SellerSKU">The seller SKU of the item. (required).</param>
        /// <param name="SellerFulfillmentOrderItemId">
        ///     The fulfillment order item identifier that the seller created and submitted
        ///     with a call to the createFulfillmentOrder operation. (required).
        /// </param>
        /// <param name="Quantity">Quantity (required).</param>
        /// <param name="PackageNumber">An identifier for the package that contains the item quantity..</param>
        public FulfillmentShipmentItem(string SellerSKU = default, string SellerFulfillmentOrderItemId = default,
            int Quantity = default, int? PackageNumber = default)
        {
            // to ensure "SellerSKU" is required (not null)
            if (SellerSKU == null)
                throw new InvalidDataException(
                    "SellerSKU is a required property for FulfillmentShipmentItem and cannot be null");
            this.SellerSKU = SellerSKU;
            // to ensure "SellerFulfillmentOrderItemId" is required (not null)
            if (SellerFulfillmentOrderItemId == null)
                throw new InvalidDataException(
                    "SellerFulfillmentOrderItemId is a required property for FulfillmentShipmentItem and cannot be null");
            this.SellerFulfillmentOrderItemId = SellerFulfillmentOrderItemId;
            // to ensure "Quantity" is required (not null)
            if (Quantity == null)
                throw new InvalidDataException(
                    "Quantity is a required property for FulfillmentShipmentItem and cannot be null");
            this.Quantity = Quantity;
            this.PackageNumber = PackageNumber;
        }

        /// <summary>
        ///     The seller SKU of the item.
        /// </summary>
        /// <value>The seller SKU of the item.</value>
        [DataMember(Name = "SellerSKU", EmitDefaultValue = false)]
        public string SellerSKU { get; set; }

        /// <summary>
        ///     The fulfillment order item identifier that the seller created and submitted with a call to the
        ///     createFulfillmentOrder operation.
        /// </summary>
        /// <value>
        ///     The fulfillment order item identifier that the seller created and submitted with a call to the
        ///     createFulfillmentOrder operation.
        /// </value>
        [DataMember(Name = "SellerFulfillmentOrderItemId", EmitDefaultValue = false)]
        public string SellerFulfillmentOrderItemId { get; set; }

        /// <summary>
        ///     Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "Quantity", EmitDefaultValue = false)]
        public int Quantity { get; set; }

        /// <summary>
        ///     An identifier for the package that contains the item quantity.
        /// </summary>
        /// <value>An identifier for the package that contains the item quantity.</value>
        [DataMember(Name = "PackageNumber", EmitDefaultValue = false)]
        public int? PackageNumber { get; set; }

        /// <summary>
        ///     The serial number of the shipped item.
        /// </summary>
        /// <value>The serial number of the shipped item.</value>
        [DataMember(Name = "SerialNumber", EmitDefaultValue = false)]
        public string SerialNumber { get; set; }

        /// <summary>
        ///     Returns true if FulfillmentShipmentItem instances are equal
        /// </summary>
        /// <param name="input">Instance of FulfillmentShipmentItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FulfillmentShipmentItem input)
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
                    Quantity == input.Quantity ||
                    Quantity.Equals(input.Quantity)
                ) &&
                (
                    PackageNumber == input.PackageNumber ||
                    (PackageNumber != null &&
                     PackageNumber.Equals(input.PackageNumber))
                ) &&
                (
                    SerialNumber == input.SerialNumber ||
                    (SerialNumber != null &&
                     SerialNumber.Equals(input.SerialNumber))
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
            sb.Append("class FulfillmentShipmentItem {\n");
            sb.Append("  SellerSKU: ").Append(SellerSKU).Append("\n");
            sb.Append("  SellerFulfillmentOrderItemId: ").Append(SellerFulfillmentOrderItemId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  PackageNumber: ").Append(PackageNumber).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
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
            return Equals(input as FulfillmentShipmentItem);
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
                hashCode = hashCode * 59 + Quantity.GetHashCode();
                if (PackageNumber != null)
                    hashCode = hashCode * 59 + PackageNumber.GetHashCode();
                if (SerialNumber != null)
                    hashCode = hashCode * 59 + SerialNumber.GetHashCode();
                return hashCode;
            }
        }
    }
}