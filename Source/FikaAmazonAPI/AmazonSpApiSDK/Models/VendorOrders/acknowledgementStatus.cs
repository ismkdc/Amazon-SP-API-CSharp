using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using static FikaAmazonAPI.AmazonSpApiSDK.Models.VendorOrders.Constants;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.VendorOrders
{
    [DataContract]
    public class AcknowledgementStatus : IEquatable<AcknowledgementStatus>, IValidatableObject
    {
        [JsonConstructorAttribute]
        public AcknowledgementStatus()
        {
        }

        public AcknowledgementStatus(
            ItemConfirmationStatus? confirmationStatus = default, ItemQuantity acceptedQuantity = default,
            ItemQuantity rejectedQuantity = default,
            List<AcknowledgementStatusDetails> acknowledgementStatusDetails = default
        )
        {
            ConfirmationStatus = confirmationStatus;
            AcceptedQuantity = acceptedQuantity;
            RejectedQuantity = rejectedQuantity;
            AcknowledgementStatusDetails = acknowledgementStatusDetails;
        }

        [DataMember(Name = "confirmationStatus", EmitDefaultValue = false)]
        public ItemConfirmationStatus? ConfirmationStatus { get; set; }

        [DataMember(Name = "acceptedQuantity", EmitDefaultValue = false)]
        public ItemQuantity AcceptedQuantity { get; set; }

        [DataMember(Name = "rejectedQuantity", EmitDefaultValue = false)]
        public ItemQuantity RejectedQuantity { get; set; }

        [DataMember(Name = "acknowledgementStatusDetails", EmitDefaultValue = false)]
        public List<AcknowledgementStatusDetails> AcknowledgementStatusDetails { get; set; }

        /// <summary>
        ///     Returns true if ItemQuantity instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemQuantity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AcknowledgementStatus input)
        {
            if (input == null)
                return false;

            return
                (
                    ConfirmationStatus == input.ConfirmationStatus ||
                    (ConfirmationStatus != null &&
                     ConfirmationStatus.Equals(input.ConfirmationStatus))
                ) &&
                (
                    AcceptedQuantity == input.AcceptedQuantity ||
                    (AcceptedQuantity != null &&
                     AcceptedQuantity.Equals(input.AcceptedQuantity))
                ) &&
                (
                    RejectedQuantity == input.RejectedQuantity ||
                    (RejectedQuantity != null &&
                     RejectedQuantity.Equals(input.RejectedQuantity))
                ) &&
                (
                    AcknowledgementStatusDetails == input.AcknowledgementStatusDetails ||
                    (AcknowledgementStatusDetails != null &&
                     AcknowledgementStatusDetails.Equals(input.AcknowledgementStatusDetails))
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
            sb.Append("class acknowledgementStatus {\n");
            sb.Append("  ConfirmationStatus: ").Append(ConfirmationStatus).Append("\n");
            sb.Append("  AcceptedQuantity: ").Append(AcceptedQuantity).Append("\n");
            sb.Append("  RejectedQuantity: ").Append(RejectedQuantity).Append("\n");
            sb.Append("  AcknowledgementStatusDetails: ").Append(AcknowledgementStatusDetails).Append("\n");
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
            return Equals(input as AcknowledgementStatus);
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
                if (ConfirmationStatus != null)
                    hashCode = hashCode * 59 + ConfirmationStatus.GetHashCode();
                if (AcceptedQuantity != null)
                    hashCode = hashCode * 59 + AcceptedQuantity.GetHashCode();
                if (RejectedQuantity != null)
                    hashCode = hashCode * 59 + RejectedQuantity.GetHashCode();
                if (AcknowledgementStatusDetails != null)
                    hashCode = hashCode * 59 + AcknowledgementStatusDetails.GetHashCode();
                return hashCode;
            }
        }
    }
}