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
    ///     Package information for a shipment in a fulfillment order.
    /// </summary>
    [DataContract]
    public class FulfillmentShipmentPackage : IEquatable<FulfillmentShipmentPackage>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="FulfillmentShipmentPackage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public FulfillmentShipmentPackage()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="FulfillmentShipmentPackage" /> class.
        /// </summary>
        /// <param name="PackageNumber">Identifies a package in a shipment. (required).</param>
        /// <param name="CarrierCode">Identifies the carrier who will deliver the shipment to the recipient. (required).</param>
        /// <param name="TrackingNumber">
        ///     The tracking number, if provided, can be used to obtain tracking and delivery
        ///     information..
        /// </param>
        /// <param name="EstimatedArrivalDateTime">
        ///     The estimated arrival date and time of the package, in ISO 8601 date time
        ///     format..
        /// </param>
        public FulfillmentShipmentPackage(int? PackageNumber = default, string CarrierCode = default,
            string TrackingNumber = default, DateTime? EstimatedArrivalDate = null)
        {
            // to ensure "PackageNumber" is required (not null)
            if (PackageNumber == null)
                throw new InvalidDataException(
                    "PackageNumber is a required property for FulfillmentShipmentPackage and cannot be null");
            this.PackageNumber = PackageNumber;
            // to ensure "CarrierCode" is required (not null)
            if (CarrierCode == null)
                throw new InvalidDataException(
                    "CarrierCode is a required property for FulfillmentShipmentPackage and cannot be null");
            this.CarrierCode = CarrierCode;
            this.TrackingNumber = TrackingNumber;
            this.EstimatedArrivalDate = EstimatedArrivalDate;
        }

        /// <summary>
        ///     Identifies a package in a shipment.
        /// </summary>
        /// <value>Identifies a package in a shipment.</value>
        [DataMember(Name = "PackageNumber", EmitDefaultValue = false)]
        public int? PackageNumber { get; set; }

        /// <summary>
        ///     Identifies the carrier who will deliver the shipment to the recipient.
        /// </summary>
        /// <value>Identifies the carrier who will deliver the shipment to the recipient.</value>
        [DataMember(Name = "CarrierCode", EmitDefaultValue = false)]
        public string CarrierCode { get; set; }

        /// <summary>
        ///     The tracking number, if provided, can be used to obtain tracking and delivery information.
        /// </summary>
        /// <value>The tracking number, if provided, can be used to obtain tracking and delivery information.</value>
        [DataMember(Name = "TrackingNumber", EmitDefaultValue = false)]
        public string TrackingNumber { get; set; }

        /// <summary>
        ///     The estimated arrival date and time of the package, in ISO 8601 date time format.
        /// </summary>
        /// <value>The estimated arrival date and time of the package, in ISO 8601 date time format.</value>
        [DataMember(Name = "EstimatedArrivalDate", EmitDefaultValue = false)]
        public DateTime? EstimatedArrivalDate { get; set; }

        /// <summary>
        ///     Returns true if FulfillmentShipmentPackage instances are equal
        /// </summary>
        /// <param name="input">Instance of FulfillmentShipmentPackage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FulfillmentShipmentPackage input)
        {
            if (input == null)
                return false;

            return
                (
                    PackageNumber == input.PackageNumber ||
                    (PackageNumber != null &&
                     PackageNumber.Equals(input.PackageNumber))
                ) &&
                (
                    CarrierCode == input.CarrierCode ||
                    (CarrierCode != null &&
                     CarrierCode.Equals(input.CarrierCode))
                ) &&
                (
                    TrackingNumber == input.TrackingNumber ||
                    (TrackingNumber != null &&
                     TrackingNumber.Equals(input.TrackingNumber))
                ) &&
                (
                    EstimatedArrivalDate == input.EstimatedArrivalDate ||
                    (EstimatedArrivalDate != null &&
                     EstimatedArrivalDate.Equals(input.EstimatedArrivalDate))
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
            sb.Append("class FulfillmentShipmentPackage {\n");
            sb.Append("  PackageNumber: ").Append(PackageNumber).Append("\n");
            sb.Append("  CarrierCode: ").Append(CarrierCode).Append("\n");
            sb.Append("  TrackingNumber: ").Append(TrackingNumber).Append("\n");
            sb.Append("  EstimatedArrivalDate: ").Append(EstimatedArrivalDate).Append("\n");
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
            return Equals(input as FulfillmentShipmentPackage);
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
                if (PackageNumber != null)
                    hashCode = hashCode * 59 + PackageNumber.GetHashCode();
                if (CarrierCode != null)
                    hashCode = hashCode * 59 + CarrierCode.GetHashCode();
                if (TrackingNumber != null)
                    hashCode = hashCode * 59 + TrackingNumber.GetHashCode();
                if (EstimatedArrivalDate != null)
                    hashCode = hashCode * 59 + EstimatedArrivalDate.GetHashCode();
                return hashCode;
            }
        }
    }
}