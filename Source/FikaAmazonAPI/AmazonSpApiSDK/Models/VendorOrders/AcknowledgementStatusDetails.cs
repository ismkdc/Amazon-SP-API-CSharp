using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.VendorOrders
{
    [DataContract]
    public class AcknowledgementStatusDetails : IEquatable<AcknowledgementStatusDetails>, IValidatableObject
    {
        [JsonConstructorAttribute]
        public AcknowledgementStatusDetails()
        {
        }

        public AcknowledgementStatusDetails(DateTime? acknowledgementDate = default,
            ItemQuantity acceptedQuantity = default, ItemQuantity rejectedQuantity = default)
        {
            AcknowledgementDate = acknowledgementDate;
            AcceptedQuantity = acceptedQuantity;
            RejectedQuantity = rejectedQuantity;
        }

        [DataMember(Name = "acknowledgementDate", EmitDefaultValue = false)]
        public DateTime? AcknowledgementDate { get; set; }

        [DataMember(Name = "acceptedQuantity", EmitDefaultValue = false)]
        public ItemQuantity AcceptedQuantity { get; set; }

        [DataMember(Name = "rejectedQuantity", EmitDefaultValue = false)]
        public ItemQuantity RejectedQuantity { get; set; }

        /// <summary>
        ///     Returns true if ItemQuantity instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemQuantity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AcknowledgementStatusDetails input)
        {
            if (input == null)
                return false;

            return
                (
                    AcknowledgementDate == input.AcknowledgementDate ||
                    (AcknowledgementDate != null &&
                     AcknowledgementDate.Equals(input.AcknowledgementDate))
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
            sb.Append("class AcknowledgementStatusDetails {\n");
            sb.Append("  AcknowledgementDate: ").Append(AcknowledgementDate).Append("\n");
            sb.Append("  AcceptedQuantity: ").Append(AcceptedQuantity).Append("\n");
            sb.Append("  RejectedQuantity: ").Append(RejectedQuantity).Append("\n");
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
            return Equals(input as AcknowledgementStatusDetails);
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
                if (AcknowledgementDate != null)
                    hashCode = hashCode * 59 + AcknowledgementDate.GetHashCode();
                if (AcceptedQuantity != null)
                    hashCode = hashCode * 59 + AcceptedQuantity.GetHashCode();
                if (RejectedQuantity != null)
                    hashCode = hashCode * 59 + RejectedQuantity.GetHashCode();
                return hashCode;
            }
        }
    }
}