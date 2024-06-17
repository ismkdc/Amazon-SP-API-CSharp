using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using FikaAmazonAPI.Utils;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Orders
{
    /// <summary>
    ///     Properties of packages
    /// </summary>
    [DataContract]
    public class PackageDetail : IEquatable<PackageDetail>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="PackageDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PackageDetail()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="PackageDetail" /> class.
        /// </summary>
        /// <param name="packageReferenceId">packageReferenceId (required).</param>
        /// <param name="carrierCode">
        ///     Identifies the carrier that will deliver the package. This field is required for all
        ///     marketplaces, see
        ///     [reference](https://developer-docs.amazon.com/sp-api/changelog/carriercode-value-required-in-shipment-confirmations-for-br-mx-ca-sg-au-in-jp-marketplaces).
        ///     (required).
        /// </param>
        /// <param name="carrierName">
        ///     Carrier Name that will deliver the package. Required when carrierCode is \&quot;Others\&quot;
        ///     .
        /// </param>
        /// <param name="shippingMethod">Ship method to be used for shipping the order..</param>
        /// <param name="trackingNumber">The tracking number used to obtain tracking and delivery information. (required).</param>
        /// <param name="shipDate">The shipping date for the package. Must be in ISO-8601 date/time format. (required).</param>
        /// <param name="shipFromSupplySourceId">The unique identifier of the supply source..</param>
        /// <param name="orderItems">The list of order items and quantities to be updated. (required).</param>
        public PackageDetail(string packageReferenceId = default, string carrierCode = default,
            string carrierName = default, string shippingMethod = default, string trackingNumber = default,
            DateTime? shipDate = default, string shipFromSupplySourceId = default,
            ConfirmShipmentOrderItemsList orderItems = default)
        {
            // to ensure "packageReferenceId" is required (not null)
            if (packageReferenceId == null)
                throw new InvalidDataException(
                    "packageReferenceId is a required property for PackageDetail and cannot be null");
            PackageReferenceId = packageReferenceId;
            // to ensure "carrierCode" is required (not null)
            if (carrierCode == null)
                throw new InvalidDataException(
                    "carrierCode is a required property for PackageDetail and cannot be null");
            CarrierCode = carrierCode;
            // to ensure "trackingNumber" is required (not null)
            if (trackingNumber == null)
                throw new InvalidDataException(
                    "trackingNumber is a required property for PackageDetail and cannot be null");
            TrackingNumber = trackingNumber;
            // to ensure "shipDate" is required (not null)
            if (shipDate == null)
                throw new InvalidDataException("shipDate is a required property for PackageDetail and cannot be null");
            ShipDate = shipDate;
            // to ensure "orderItems" is required (not null)
            if (orderItems == null)
                throw new InvalidDataException(
                    "orderItems is a required property for PackageDetail and cannot be null");
            OrderItems = orderItems;
            CarrierName = carrierName;
            ShippingMethod = shippingMethod;
            ShipFromSupplySourceId = shipFromSupplySourceId;
        }

        /// <summary>
        ///     Gets or Sets PackageReferenceId
        /// </summary>
        [DataMember(Name = "packageReferenceId", EmitDefaultValue = false)]
        public string PackageReferenceId { get; set; }

        /// <summary>
        ///     Identifies the carrier that will deliver the package. This field is required for all marketplaces, see
        ///     [reference](https://developer-docs.amazon.com/sp-api/changelog/carriercode-value-required-in-shipment-confirmations-for-br-mx-ca-sg-au-in-jp-marketplaces).
        /// </summary>
        /// <value>
        ///     Identifies the carrier that will deliver the package. This field is required for all marketplaces, see
        ///     [reference](https://developer-docs.amazon.com/sp-api/changelog/carriercode-value-required-in-shipment-confirmations-for-br-mx-ca-sg-au-in-jp-marketplaces).
        /// </value>
        [DataMember(Name = "carrierCode", EmitDefaultValue = false)]
        public string CarrierCode { get; set; }

        /// <summary>
        ///     Carrier Name that will deliver the package. Required when carrierCode is \&quot;Others\&quot;
        /// </summary>
        /// <value>Carrier Name that will deliver the package. Required when carrierCode is \&quot;Others\&quot; </value>
        [DataMember(Name = "carrierName", EmitDefaultValue = false)]
        public string CarrierName { get; set; }

        /// <summary>
        ///     Ship method to be used for shipping the order.
        /// </summary>
        /// <value>Ship method to be used for shipping the order.</value>
        [DataMember(Name = "shippingMethod", EmitDefaultValue = false)]
        public string ShippingMethod { get; set; }

        /// <summary>
        ///     The tracking number used to obtain tracking and delivery information.
        /// </summary>
        /// <value>The tracking number used to obtain tracking and delivery information.</value>
        [DataMember(Name = "trackingNumber", EmitDefaultValue = false)]
        public string TrackingNumber { get; set; }

        /// <summary>
        ///     The shipping date for the package. Must be in ISO-8601 date/time format.
        /// </summary>
        /// <value>The shipping date for the package. Must be in ISO-8601 date/time format.</value>
        [JsonConverter(typeof(Iso8601DateTimeConverter))]
        [DataMember(Name = "shipDate", EmitDefaultValue = false)]
        public DateTime? ShipDate { get; set; }

        /// <summary>
        ///     The unique identifier of the supply source.
        /// </summary>
        /// <value>The unique identifier of the supply source.</value>
        [DataMember(Name = "shipFromSupplySourceId", EmitDefaultValue = false)]
        public string ShipFromSupplySourceId { get; set; }

        /// <summary>
        ///     The list of order items and quantities to be updated.
        /// </summary>
        /// <value>The list of order items and quantities to be updated.</value>
        [DataMember(Name = "orderItems", EmitDefaultValue = false)]
        public ConfirmShipmentOrderItemsList OrderItems { get; set; }

        /// <summary>
        ///     Returns true if PackageDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of PackageDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PackageDetail input)
        {
            if (input == null)
                return false;

            return
                (
                    PackageReferenceId == input.PackageReferenceId ||
                    (PackageReferenceId != null &&
                     PackageReferenceId.Equals(input.PackageReferenceId))
                ) &&
                (
                    CarrierCode == input.CarrierCode ||
                    (CarrierCode != null &&
                     CarrierCode.Equals(input.CarrierCode))
                ) &&
                (
                    CarrierName == input.CarrierName ||
                    (CarrierName != null &&
                     CarrierName.Equals(input.CarrierName))
                ) &&
                (
                    ShippingMethod == input.ShippingMethod ||
                    (ShippingMethod != null &&
                     ShippingMethod.Equals(input.ShippingMethod))
                ) &&
                (
                    TrackingNumber == input.TrackingNumber ||
                    (TrackingNumber != null &&
                     TrackingNumber.Equals(input.TrackingNumber))
                ) &&
                (
                    ShipDate == input.ShipDate ||
                    (ShipDate != null &&
                     ShipDate.Equals(input.ShipDate))
                ) &&
                (
                    ShipFromSupplySourceId == input.ShipFromSupplySourceId ||
                    (ShipFromSupplySourceId != null &&
                     ShipFromSupplySourceId.Equals(input.ShipFromSupplySourceId))
                ) &&
                (
                    OrderItems == input.OrderItems ||
                    (OrderItems != null &&
                     OrderItems.Equals(input.OrderItems))
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
            sb.Append("class PackageDetail {\n");
            sb.Append("  PackageReferenceId: ").Append(PackageReferenceId).Append("\n");
            sb.Append("  CarrierCode: ").Append(CarrierCode).Append("\n");
            sb.Append("  CarrierName: ").Append(CarrierName).Append("\n");
            sb.Append("  ShippingMethod: ").Append(ShippingMethod).Append("\n");
            sb.Append("  TrackingNumber: ").Append(TrackingNumber).Append("\n");
            sb.Append("  ShipDate: ").Append(ShipDate).Append("\n");
            sb.Append("  ShipFromSupplySourceId: ").Append(ShipFromSupplySourceId).Append("\n");
            sb.Append("  OrderItems: ").Append(OrderItems).Append("\n");
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
            return Equals(input as PackageDetail);
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
                if (PackageReferenceId != null)
                    hashCode = hashCode * 59 + PackageReferenceId.GetHashCode();
                if (CarrierCode != null)
                    hashCode = hashCode * 59 + CarrierCode.GetHashCode();
                if (CarrierName != null)
                    hashCode = hashCode * 59 + CarrierName.GetHashCode();
                if (ShippingMethod != null)
                    hashCode = hashCode * 59 + ShippingMethod.GetHashCode();
                if (TrackingNumber != null)
                    hashCode = hashCode * 59 + TrackingNumber.GetHashCode();
                if (ShipDate != null)
                    hashCode = hashCode * 59 + ShipDate.GetHashCode();
                if (ShipFromSupplySourceId != null)
                    hashCode = hashCode * 59 + ShipFromSupplySourceId.GetHashCode();
                if (OrderItems != null)
                    hashCode = hashCode * 59 + OrderItems.GetHashCode();
                return hashCode;
            }
        }
    }
}