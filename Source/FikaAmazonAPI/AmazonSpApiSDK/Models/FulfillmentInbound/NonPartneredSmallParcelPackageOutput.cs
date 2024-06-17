/*
 * Selling Partner API for Fulfillment Inbound
 *
 * The Selling Partner API for Fulfillment Inbound lets you create applications that create and update inbound shipments of inventory to Amazon's fulfillment network.
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

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInbound
{
    /// <summary>
    ///     Carrier, tracking number, and status information for the package.
    /// </summary>
    [DataContract]
    public class NonPartneredSmallParcelPackageOutput : IEquatable<NonPartneredSmallParcelPackageOutput>,
        IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="NonPartneredSmallParcelPackageOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public NonPartneredSmallParcelPackageOutput()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="NonPartneredSmallParcelPackageOutput" /> class.
        /// </summary>
        /// <param name="carrierName">The carrier that you are using for the inbound shipment. (required).</param>
        /// <param name="trackingId">trackingId (required).</param>
        /// <param name="packageStatus">packageStatus (required).</param>
        public NonPartneredSmallParcelPackageOutput(string carrierName = default, string trackingId = default,
            PackageStatus packageStatus = default)
        {
            // to ensure "carrierName" is required (not null)
            if (carrierName == null)
                throw new InvalidDataException(
                    "carrierName is a required property for NonPartneredSmallParcelPackageOutput and cannot be null");
            CarrierName = carrierName;
            // to ensure "trackingId" is required (not null)
            if (trackingId == null)
                throw new InvalidDataException(
                    "trackingId is a required property for NonPartneredSmallParcelPackageOutput and cannot be null");
            TrackingId = trackingId;
            // to ensure "packageStatus" is required (not null)
            if (packageStatus == null)
                throw new InvalidDataException(
                    "packageStatus is a required property for NonPartneredSmallParcelPackageOutput and cannot be null");
            PackageStatus = packageStatus;
        }

        /// <summary>
        ///     Gets or Sets PackageStatus
        /// </summary>
        [DataMember(Name = "PackageStatus", EmitDefaultValue = false)]
        public PackageStatus PackageStatus { get; set; }

        /// <summary>
        ///     The carrier that you are using for the inbound shipment.
        /// </summary>
        /// <value>The carrier that you are using for the inbound shipment.</value>
        [DataMember(Name = "CarrierName", EmitDefaultValue = false)]
        public string CarrierName { get; set; }

        /// <summary>
        ///     Gets or Sets TrackingId
        /// </summary>
        [DataMember(Name = "TrackingId", EmitDefaultValue = false)]
        public string TrackingId { get; set; }

        /// <summary>
        ///     Returns true if NonPartneredSmallParcelPackageOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of NonPartneredSmallParcelPackageOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NonPartneredSmallParcelPackageOutput input)
        {
            if (input == null)
                return false;

            return
                (
                    CarrierName == input.CarrierName ||
                    (CarrierName != null &&
                     CarrierName.Equals(input.CarrierName))
                ) &&
                (
                    TrackingId == input.TrackingId ||
                    (TrackingId != null &&
                     TrackingId.Equals(input.TrackingId))
                ) &&
                (
                    PackageStatus == input.PackageStatus ||
                    (PackageStatus != null &&
                     PackageStatus.Equals(input.PackageStatus))
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
            sb.Append("class NonPartneredSmallParcelPackageOutput {\n");
            sb.Append("  CarrierName: ").Append(CarrierName).Append("\n");
            sb.Append("  TrackingId: ").Append(TrackingId).Append("\n");
            sb.Append("  PackageStatus: ").Append(PackageStatus).Append("\n");
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
            return Equals(input as NonPartneredSmallParcelPackageOutput);
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
                if (CarrierName != null)
                    hashCode = hashCode * 59 + CarrierName.GetHashCode();
                if (TrackingId != null)
                    hashCode = hashCode * 59 + TrackingId.GetHashCode();
                if (PackageStatus != null)
                    hashCode = hashCode * 59 + PackageStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}