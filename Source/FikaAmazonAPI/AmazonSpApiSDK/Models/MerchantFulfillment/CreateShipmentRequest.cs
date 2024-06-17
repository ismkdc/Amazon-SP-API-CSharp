/*
 * Selling Partner API for Merchant Fulfillment
 *
 * The Selling Partner API for Merchant Fulfillment helps you build applications that let sellers purchase shipping for non-Prime and Prime orders using Amazon’s Buy Shipping Services.
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

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.MerchantFulfillment
{
    /// <summary>
    ///     Request schema.
    /// </summary>
    [DataContract]
    public class CreateShipmentRequest : IEquatable<CreateShipmentRequest>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="CreateShipmentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public CreateShipmentRequest()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="CreateShipmentRequest" /> class.
        /// </summary>
        /// <param name="shipmentRequestDetails">Shipment information required for creating a shipment. (required).</param>
        /// <param name="shippingServiceId">shippingServiceId (required).</param>
        /// <param name="shippingServiceOfferId">Identifies a shipping service order made by a carrier..</param>
        /// <param name="hazmatType">
        ///     Hazardous materials options for a package. Consult the terms and conditions for each carrier
        ///     for more information about hazardous materials..
        /// </param>
        /// <param name="labelFormatOption">labelFormatOption.</param>
        /// <param name="shipmentLevelSellerInputsList">A list of additional seller inputs required to ship this shipment..</param>
        public CreateShipmentRequest(ShipmentRequestDetails shipmentRequestDetails = default,
            string shippingServiceId = default, string shippingServiceOfferId = default,
            HazmatType? hazmatType = default, LabelFormatOptionRequest labelFormatOption = default,
            AdditionalSellerInputsList shipmentLevelSellerInputsList = default)
        {
            // to ensure "shipmentRequestDetails" is required (not null)
            if (shipmentRequestDetails == null)
                throw new InvalidDataException(
                    "shipmentRequestDetails is a required property for CreateShipmentRequest and cannot be null");
            ShipmentRequestDetails = shipmentRequestDetails;
            // to ensure "shippingServiceId" is required (not null)
            if (shippingServiceId == null)
                throw new InvalidDataException(
                    "shippingServiceId is a required property for CreateShipmentRequest and cannot be null");
            ShippingServiceId = shippingServiceId;
            ShippingServiceOfferId = shippingServiceOfferId;
            HazmatType = hazmatType;
            LabelFormatOption = labelFormatOption;
            ShipmentLevelSellerInputsList = shipmentLevelSellerInputsList;
        }

        /// <summary>
        ///     Hazardous materials options for a package. Consult the terms and conditions for each carrier for more information
        ///     about hazardous materials.
        /// </summary>
        /// <value>
        ///     Hazardous materials options for a package. Consult the terms and conditions for each carrier for more
        ///     information about hazardous materials.
        /// </value>
        [DataMember(Name = "HazmatType", EmitDefaultValue = false)]
        public HazmatType? HazmatType { get; set; }

        /// <summary>
        ///     Shipment information required for creating a shipment.
        /// </summary>
        /// <value>Shipment information required for creating a shipment.</value>
        [DataMember(Name = "ShipmentRequestDetails", EmitDefaultValue = false)]
        public ShipmentRequestDetails ShipmentRequestDetails { get; set; }

        /// <summary>
        ///     Gets or Sets ShippingServiceId
        /// </summary>
        [DataMember(Name = "ShippingServiceId", EmitDefaultValue = false)]
        public string ShippingServiceId { get; set; }

        /// <summary>
        ///     Identifies a shipping service order made by a carrier.
        /// </summary>
        /// <value>Identifies a shipping service order made by a carrier.</value>
        [DataMember(Name = "ShippingServiceOfferId", EmitDefaultValue = false)]
        public string ShippingServiceOfferId { get; set; }


        /// <summary>
        ///     Gets or Sets LabelFormatOption
        /// </summary>
        [DataMember(Name = "LabelFormatOption", EmitDefaultValue = false)]
        public LabelFormatOptionRequest LabelFormatOption { get; set; }

        /// <summary>
        ///     A list of additional seller inputs required to ship this shipment.
        /// </summary>
        /// <value>A list of additional seller inputs required to ship this shipment.</value>
        [DataMember(Name = "ShipmentLevelSellerInputsList", EmitDefaultValue = false)]
        public AdditionalSellerInputsList ShipmentLevelSellerInputsList { get; set; }

        /// <summary>
        ///     Returns true if CreateShipmentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateShipmentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateShipmentRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    ShipmentRequestDetails == input.ShipmentRequestDetails ||
                    (ShipmentRequestDetails != null &&
                     ShipmentRequestDetails.Equals(input.ShipmentRequestDetails))
                ) &&
                (
                    ShippingServiceId == input.ShippingServiceId ||
                    (ShippingServiceId != null &&
                     ShippingServiceId.Equals(input.ShippingServiceId))
                ) &&
                (
                    ShippingServiceOfferId == input.ShippingServiceOfferId ||
                    (ShippingServiceOfferId != null &&
                     ShippingServiceOfferId.Equals(input.ShippingServiceOfferId))
                ) &&
                (
                    HazmatType == input.HazmatType ||
                    (HazmatType != null &&
                     HazmatType.Equals(input.HazmatType))
                ) &&
                (
                    LabelFormatOption == input.LabelFormatOption ||
                    (LabelFormatOption != null &&
                     LabelFormatOption.Equals(input.LabelFormatOption))
                ) &&
                (
                    ShipmentLevelSellerInputsList == input.ShipmentLevelSellerInputsList ||
                    (ShipmentLevelSellerInputsList != null &&
                     ShipmentLevelSellerInputsList.Equals(input.ShipmentLevelSellerInputsList))
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
            sb.Append("class CreateShipmentRequest {\n");
            sb.Append("  ShipmentRequestDetails: ").Append(ShipmentRequestDetails).Append("\n");
            sb.Append("  ShippingServiceId: ").Append(ShippingServiceId).Append("\n");
            sb.Append("  ShippingServiceOfferId: ").Append(ShippingServiceOfferId).Append("\n");
            sb.Append("  HazmatType: ").Append(HazmatType).Append("\n");
            sb.Append("  LabelFormatOption: ").Append(LabelFormatOption).Append("\n");
            sb.Append("  ShipmentLevelSellerInputsList: ").Append(ShipmentLevelSellerInputsList).Append("\n");
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
            return Equals(input as CreateShipmentRequest);
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
                if (ShipmentRequestDetails != null)
                    hashCode = hashCode * 59 + ShipmentRequestDetails.GetHashCode();
                if (ShippingServiceId != null)
                    hashCode = hashCode * 59 + ShippingServiceId.GetHashCode();
                if (ShippingServiceOfferId != null)
                    hashCode = hashCode * 59 + ShippingServiceOfferId.GetHashCode();
                if (HazmatType != null)
                    hashCode = hashCode * 59 + HazmatType.GetHashCode();
                if (LabelFormatOption != null)
                    hashCode = hashCode * 59 + LabelFormatOption.GetHashCode();
                if (ShipmentLevelSellerInputsList != null)
                    hashCode = hashCode * 59 + ShipmentLevelSellerInputsList.GetHashCode();
                return hashCode;
            }
        }
    }
}