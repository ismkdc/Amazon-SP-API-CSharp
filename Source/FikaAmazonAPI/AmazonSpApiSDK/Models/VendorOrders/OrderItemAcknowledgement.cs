using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.VendorOrders
{
    [DataContract]
    public class OrderItemAcknowledgement : IEquatable<OrderItemAcknowledgement>, IValidatableObject
    {
        public OrderItemAcknowledgement()
        {
        }

        public OrderItemAcknowledgement(AcknowledgementCode? acknowledgementCode = default,
            ItemQuantity acknowledgedQuantity = default, DateTime? scheduledShipDate = default,
            DateTime? scheduledDeliveryDate = default, RejectionReason? rejectionReason = default)
        {
            // to ensure "acknowledgementCode" is required (not null)
            if (acknowledgementCode == null)
                throw new InvalidDataException(
                    "acknowledgementCode is a required property for OrderItemAcknowledgement and cannot be null");
            AcknowledgementCode = acknowledgementCode;
            // to ensure "acknowledgedQuantity" is required (not null)
            if (acknowledgedQuantity == null)
                throw new InvalidDataException(
                    "acknowledgedQuantity is a required property for OrderItemAcknowledgement and cannot be null");
            AcknowledgedQuantity = acknowledgedQuantity;
            ScheduledShipDate = scheduledShipDate;
            ScheduledDeliveryDate = scheduledDeliveryDate;
            RejectionReason = rejectionReason;
        }

        [DataMember(Name = "acknowledgementCode", EmitDefaultValue = false)]
        public AcknowledgementCode? AcknowledgementCode { get; set; }

        [DataMember(Name = "acknowledgedQuantity", EmitDefaultValue = false)]
        public ItemQuantity AcknowledgedQuantity { get; set; }

        [DataMember(Name = "scheduledShipDate", EmitDefaultValue = false)]
        public DateTime? ScheduledShipDate { get; set; }

        [DataMember(Name = "scheduledDeliveryDate", EmitDefaultValue = false)]
        public DateTime? ScheduledDeliveryDate { get; set; }

        [DataMember(Name = "rejectionReason", EmitDefaultValue = false)]
        public RejectionReason? RejectionReason { get; set; }

        public bool Equals(OrderItemAcknowledgement input)
        {
            if (input == null)
                return false;

            return
                (
                    AcknowledgementCode == input.AcknowledgementCode ||
                    (AcknowledgementCode != null &&
                     AcknowledgementCode.Equals(input.AcknowledgementCode))
                ) &&
                (
                    AcknowledgedQuantity == input.AcknowledgedQuantity ||
                    (AcknowledgedQuantity != null &&
                     AcknowledgedQuantity.Equals(input.AcknowledgedQuantity))
                ) &&
                (
                    ScheduledShipDate == input.ScheduledShipDate ||
                    (ScheduledShipDate != null &&
                     ScheduledShipDate.Equals(input.ScheduledShipDate))
                ) &&
                (
                    ScheduledDeliveryDate == input.ScheduledDeliveryDate ||
                    (ScheduledDeliveryDate != null &&
                     ScheduledDeliveryDate.Equals(input.ScheduledDeliveryDate))
                ) &&
                (
                    RejectionReason == input.RejectionReason ||
                    (RejectionReason != null &&
                     RejectionReason.Equals(input.RejectionReason))
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

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderItemAcknowledgement {\n");
            sb.Append("  AcknowledgementCode: ").Append(AcknowledgementCode).Append("\n");
            sb.Append("  AcknowledgedQuantity: ").Append(AcknowledgedQuantity).Append("\n");
            sb.Append("  ScheduledShipDate: ").Append(ScheduledShipDate).Append("\n");
            sb.Append("  ScheduledDeliveryDate: ").Append(ScheduledDeliveryDate).Append("\n");
            sb.Append("  RejectionReason: ").Append(RejectionReason).Append("\n");
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
                if (AcknowledgementCode != null)
                    hashCode = hashCode * 59 + AcknowledgementCode.GetHashCode();
                if (AcknowledgedQuantity != null)
                    hashCode = hashCode * 59 + AcknowledgedQuantity.GetHashCode();
                if (ScheduledShipDate != null)
                    hashCode = hashCode * 59 + ScheduledShipDate.GetHashCode();
                if (ScheduledDeliveryDate != null)
                    hashCode = hashCode * 59 + ScheduledDeliveryDate.GetHashCode();
                if (RejectionReason != null)
                    hashCode = hashCode * 59 + RejectionReason.GetHashCode();
                return hashCode;
            }
        }
    }
}