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
    ///     The request schema for the createInboundShipmentPlan operation.
    /// </summary>
    [DataContract]
    public class CreateInboundShipmentPlanRequest : IEquatable<CreateInboundShipmentPlanRequest>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="CreateInboundShipmentPlanRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public CreateInboundShipmentPlanRequest()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="CreateInboundShipmentPlanRequest" /> class.
        /// </summary>
        /// <param name="shipFromAddress">The address from which the inbound shipment will be sent. (required).</param>
        /// <param name="labelPrepPreference">
        ///     The seller&#39;s preference for label preparation for an inbound shipment.
        ///     (required).
        /// </param>
        /// <param name="shipToCountryCode">
        ///     The two-character country code for the country where the inbound shipment is to be
        ///     sent.  Note: Not required. Specifying both ShipToCountryCode and ShipToCountrySubdivisionCode returns an error.
        ///     Values:   ShipToCountryCode values for North America:  * CA – Canada  * MX - Mexico  * US - United States
        ///     ShipToCountryCode values for MCI sellers in Europe:  * DE – Germany  * ES – Spain  * FR – France  * GB – United
        ///     Kingdom  * IT – Italy  Default: The country code for the seller&#39;s home marketplace..
        /// </param>
        /// <param name="shipToCountrySubdivisionCode">
        ///     The two-character country code, followed by a dash and then up to three
        ///     characters that represent the subdivision of the country where the inbound shipment is to be sent. For example, \
        ///     &quot;IN-MH\&quot;. In full ISO 3166-2 format.  Note: Not required. Specifying both ShipToCountryCode and
        ///     ShipToCountrySubdivisionCode returns an error..
        /// </param>
        /// <param name="inboundShipmentPlanRequestItems">inboundShipmentPlanRequestItems (required).</param>
        public CreateInboundShipmentPlanRequest(Address shipFromAddress = default,
            LabelPrepPreference labelPrepPreference = default, string shipToCountryCode = default,
            string shipToCountrySubdivisionCode = default,
            InboundShipmentPlanRequestItemList inboundShipmentPlanRequestItems = default)
        {
            // to ensure "shipFromAddress" is required (not null)
            if (shipFromAddress == null)
                throw new InvalidDataException(
                    "shipFromAddress is a required property for CreateInboundShipmentPlanRequest and cannot be null");
            ShipFromAddress = shipFromAddress;
            // to ensure "labelPrepPreference" is required (not null)
            if (labelPrepPreference == null)
                throw new InvalidDataException(
                    "labelPrepPreference is a required property for CreateInboundShipmentPlanRequest and cannot be null");
            LabelPrepPreference = labelPrepPreference;
            // to ensure "inboundShipmentPlanRequestItems" is required (not null)
            if (inboundShipmentPlanRequestItems == null)
                throw new InvalidDataException(
                    "inboundShipmentPlanRequestItems is a required property for CreateInboundShipmentPlanRequest and cannot be null");
            InboundShipmentPlanRequestItems = inboundShipmentPlanRequestItems;
            ShipToCountryCode = shipToCountryCode;
            ShipToCountrySubdivisionCode = shipToCountrySubdivisionCode;
        }

        /// <summary>
        ///     The seller&#39;s preference for label preparation for an inbound shipment.
        /// </summary>
        /// <value>The seller&#39;s preference for label preparation for an inbound shipment.</value>
        [DataMember(Name = "LabelPrepPreference", EmitDefaultValue = false)]
        public LabelPrepPreference LabelPrepPreference { get; set; }

        /// <summary>
        ///     The address from which the inbound shipment will be sent.
        /// </summary>
        /// <value>The address from which the inbound shipment will be sent.</value>
        [DataMember(Name = "ShipFromAddress", EmitDefaultValue = false)]
        public Address ShipFromAddress { get; set; }


        /// <summary>
        ///     The two-character country code for the country where the inbound shipment is to be sent.  Note: Not required.
        ///     Specifying both ShipToCountryCode and ShipToCountrySubdivisionCode returns an error.   Values:   ShipToCountryCode
        ///     values for North America:  * CA – Canada  * MX - Mexico  * US - United States  ShipToCountryCode values for MCI
        ///     sellers in Europe:  * DE – Germany  * ES – Spain  * FR – France  * GB – United Kingdom  * IT – Italy  Default: The
        ///     country code for the seller&#39;s home marketplace.
        /// </summary>
        /// <value>
        ///     The two-character country code for the country where the inbound shipment is to be sent.  Note: Not required.
        ///     Specifying both ShipToCountryCode and ShipToCountrySubdivisionCode returns an error.   Values:   ShipToCountryCode
        ///     values for North America:  * CA – Canada  * MX - Mexico  * US - United States  ShipToCountryCode values for MCI
        ///     sellers in Europe:  * DE – Germany  * ES – Spain  * FR – France  * GB – United Kingdom  * IT – Italy  Default: The
        ///     country code for the seller&#39;s home marketplace.
        /// </value>
        [DataMember(Name = "ShipToCountryCode", EmitDefaultValue = false)]
        public string ShipToCountryCode { get; set; }

        /// <summary>
        ///     The two-character country code, followed by a dash and then up to three characters that represent the subdivision
        ///     of the country where the inbound shipment is to be sent. For example, \&quot;IN-MH\&quot;. In full ISO 3166-2
        ///     format.  Note: Not required. Specifying both ShipToCountryCode and ShipToCountrySubdivisionCode returns an error.
        /// </summary>
        /// <value>
        ///     The two-character country code, followed by a dash and then up to three characters that represent the
        ///     subdivision of the country where the inbound shipment is to be sent. For example, \&quot;IN-MH\&quot;. In full ISO
        ///     3166-2 format.  Note: Not required. Specifying both ShipToCountryCode and ShipToCountrySubdivisionCode returns an
        ///     error.
        /// </value>
        [DataMember(Name = "ShipToCountrySubdivisionCode", EmitDefaultValue = false)]
        public string ShipToCountrySubdivisionCode { get; set; }

        /// <summary>
        ///     Gets or Sets InboundShipmentPlanRequestItems
        /// </summary>
        [DataMember(Name = "InboundShipmentPlanRequestItems", EmitDefaultValue = false)]
        public InboundShipmentPlanRequestItemList InboundShipmentPlanRequestItems { get; set; }

        /// <summary>
        ///     Returns true if CreateInboundShipmentPlanRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateInboundShipmentPlanRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateInboundShipmentPlanRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    ShipFromAddress == input.ShipFromAddress ||
                    (ShipFromAddress != null &&
                     ShipFromAddress.Equals(input.ShipFromAddress))
                ) &&
                (
                    LabelPrepPreference == input.LabelPrepPreference ||
                    (LabelPrepPreference != null &&
                     LabelPrepPreference.Equals(input.LabelPrepPreference))
                ) &&
                (
                    ShipToCountryCode == input.ShipToCountryCode ||
                    (ShipToCountryCode != null &&
                     ShipToCountryCode.Equals(input.ShipToCountryCode))
                ) &&
                (
                    ShipToCountrySubdivisionCode == input.ShipToCountrySubdivisionCode ||
                    (ShipToCountrySubdivisionCode != null &&
                     ShipToCountrySubdivisionCode.Equals(input.ShipToCountrySubdivisionCode))
                ) &&
                (
                    InboundShipmentPlanRequestItems == input.InboundShipmentPlanRequestItems ||
                    (InboundShipmentPlanRequestItems != null &&
                     InboundShipmentPlanRequestItems.Equals(input.InboundShipmentPlanRequestItems))
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
            sb.Append("class CreateInboundShipmentPlanRequest {\n");
            sb.Append("  ShipFromAddress: ").Append(ShipFromAddress).Append("\n");
            sb.Append("  LabelPrepPreference: ").Append(LabelPrepPreference).Append("\n");
            sb.Append("  ShipToCountryCode: ").Append(ShipToCountryCode).Append("\n");
            sb.Append("  ShipToCountrySubdivisionCode: ").Append(ShipToCountrySubdivisionCode).Append("\n");
            sb.Append("  InboundShipmentPlanRequestItems: ").Append(InboundShipmentPlanRequestItems).Append("\n");
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
            return Equals(input as CreateInboundShipmentPlanRequest);
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
                if (ShipFromAddress != null)
                    hashCode = hashCode * 59 + ShipFromAddress.GetHashCode();
                if (LabelPrepPreference != null)
                    hashCode = hashCode * 59 + LabelPrepPreference.GetHashCode();
                if (ShipToCountryCode != null)
                    hashCode = hashCode * 59 + ShipToCountryCode.GetHashCode();
                if (ShipToCountrySubdivisionCode != null)
                    hashCode = hashCode * 59 + ShipToCountrySubdivisionCode.GetHashCode();
                if (InboundShipmentPlanRequestItems != null)
                    hashCode = hashCode * 59 + InboundShipmentPlanRequestItems.GetHashCode();
                return hashCode;
            }
        }
    }
}