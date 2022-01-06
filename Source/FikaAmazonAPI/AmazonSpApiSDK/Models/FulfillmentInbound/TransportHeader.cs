/* 
 * Selling Partner API for Fulfillment Inbound
 *
 * The Selling Partner API for Fulfillment Inbound lets you create applications that create and update inbound shipments of inventory to Amazon's fulfillment network.
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

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInbound
{
    /// <summary>
    /// The shipping identifier, information about whether the shipment is by an Amazon-partnered carrier, and information about whether the shipment is Small Parcel or Less Than Truckload/Full Truckload (LTL/FTL).
    /// </summary>
    [DataContract]
    public partial class TransportHeader : IEquatable<TransportHeader>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ShipmentType
        /// </summary>
        [DataMember(Name = "ShipmentType", EmitDefaultValue = false)]
        public ShipmentType ShipmentType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransportHeader" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public TransportHeader() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransportHeader" /> class.
        /// </summary>
        /// <param name="SellerId">The Amazon seller identifier. (required).</param>
        /// <param name="ShipmentId">A shipment identifier originally returned by the createInboundShipmentPlan operation. (required).</param>
        /// <param name="IsPartnered">Indicates whether a putTransportDetails request is for a partnered carrier.  Possible values:  * true – Request is for an Amazon-partnered carrier.  * false – Request is for a non-Amazon-partnered carrier. (required).</param>
        /// <param name="ShipmentType">ShipmentType (required).</param>
        public TransportHeader(string SellerId = default(string), string ShipmentId = default(string), bool? IsPartnered = default(bool?), ShipmentType ShipmentType = default(ShipmentType))
        {
            // to ensure "SellerId" is required (not null)
            if (SellerId == null)
            {
                throw new InvalidDataException("SellerId is a required property for TransportHeader and cannot be null");
            }
            else
            {
                this.SellerId = SellerId;
            }
            // to ensure "ShipmentId" is required (not null)
            if (ShipmentId == null)
            {
                throw new InvalidDataException("ShipmentId is a required property for TransportHeader and cannot be null");
            }
            else
            {
                this.ShipmentId = ShipmentId;
            }
            // to ensure "IsPartnered" is required (not null)
            if (IsPartnered == null)
            {
                throw new InvalidDataException("IsPartnered is a required property for TransportHeader and cannot be null");
            }
            else
            {
                this.IsPartnered = IsPartnered;
            }
            // to ensure "ShipmentType" is required (not null)
            if (ShipmentType == null)
            {
                throw new InvalidDataException("ShipmentType is a required property for TransportHeader and cannot be null");
            }
            else
            {
                this.ShipmentType = ShipmentType;
            }
        }

        /// <summary>
        /// The Amazon seller identifier.
        /// </summary>
        /// <value>The Amazon seller identifier.</value>
        [DataMember(Name = "SellerId", EmitDefaultValue = false)]
        public string SellerId { get; set; }

        /// <summary>
        /// A shipment identifier originally returned by the createInboundShipmentPlan operation.
        /// </summary>
        /// <value>A shipment identifier originally returned by the createInboundShipmentPlan operation.</value>
        [DataMember(Name = "ShipmentId", EmitDefaultValue = false)]
        public string ShipmentId { get; set; }

        /// <summary>
        /// Indicates whether a putTransportDetails request is for a partnered carrier.  Possible values:  * true – Request is for an Amazon-partnered carrier.  * false – Request is for a non-Amazon-partnered carrier.
        /// </summary>
        /// <value>Indicates whether a putTransportDetails request is for a partnered carrier.  Possible values:  * true – Request is for an Amazon-partnered carrier.  * false – Request is for a non-Amazon-partnered carrier.</value>
        [DataMember(Name = "IsPartnered", EmitDefaultValue = false)]
        public bool? IsPartnered { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransportHeader {\n");
            sb.Append("  SellerId: ").Append(SellerId).Append("\n");
            sb.Append("  ShipmentId: ").Append(ShipmentId).Append("\n");
            sb.Append("  IsPartnered: ").Append(IsPartnered).Append("\n");
            sb.Append("  ShipmentType: ").Append(ShipmentType).Append("\n");
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
            return this.Equals(input as TransportHeader);
        }

        /// <summary>
        /// Returns true if TransportHeader instances are equal
        /// </summary>
        /// <param name="input">Instance of TransportHeader to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransportHeader input)
        {
            if (input == null)
                return false;

            return
                (
                    this.SellerId == input.SellerId ||
                    (this.SellerId != null &&
                    this.SellerId.Equals(input.SellerId))
                ) &&
                (
                    this.ShipmentId == input.ShipmentId ||
                    (this.ShipmentId != null &&
                    this.ShipmentId.Equals(input.ShipmentId))
                ) &&
                (
                    this.IsPartnered == input.IsPartnered ||
                    (this.IsPartnered != null &&
                    this.IsPartnered.Equals(input.IsPartnered))
                ) &&
                (
                    this.ShipmentType == input.ShipmentType ||
                    (this.ShipmentType != null &&
                    this.ShipmentType.Equals(input.ShipmentType))
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
                if (this.SellerId != null)
                    hashCode = hashCode * 59 + this.SellerId.GetHashCode();
                if (this.ShipmentId != null)
                    hashCode = hashCode * 59 + this.ShipmentId.GetHashCode();
                if (this.IsPartnered != null)
                    hashCode = hashCode * 59 + this.IsPartnered.GetHashCode();
                if (this.ShipmentType != null)
                    hashCode = hashCode * 59 + this.ShipmentType.GetHashCode();
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
            yield break;
        }
    }

}
