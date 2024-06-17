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
    public class receivingStatus : IEquatable<receivingStatus>, IValidatableObject
    {
        [JsonConstructorAttribute]
        public receivingStatus()
        {
        }

        public receivingStatus(ItemReceiveStatus? receiveStatus = default, ItemQuantity receivedQuantity = default,
            DateTime? lastReceiveDate = default)
        {
            ReceiveStatus = receiveStatus;
            ReceivedQuantity = receivedQuantity;
            LastReceiveDate = lastReceiveDate;
        }

        [DataMember(Name = "receiveStatus", EmitDefaultValue = false)]
        public ItemReceiveStatus? ReceiveStatus { get; set; }

        [DataMember(Name = "receivedQuantity", EmitDefaultValue = false)]
        public ItemQuantity ReceivedQuantity { get; set; }

        [DataMember(Name = "lastReceiveDate", EmitDefaultValue = false)]
        public DateTime? LastReceiveDate { get; set; }

        /// <summary>
        ///     Returns true if ItemQuantity instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemQuantity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(receivingStatus input)
        {
            if (input == null)
                return false;

            return
                (
                    ReceiveStatus == input.ReceiveStatus ||
                    (ReceiveStatus != null &&
                     ReceiveStatus.Equals(input.ReceiveStatus))
                ) &&
                (
                    ReceivedQuantity == input.ReceivedQuantity ||
                    (ReceivedQuantity != null &&
                     ReceivedQuantity.Equals(input.ReceivedQuantity))
                ) &&
                (
                    LastReceiveDate == input.LastReceiveDate ||
                    (LastReceiveDate != null &&
                     LastReceiveDate.Equals(input.LastReceiveDate))
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
            sb.Append("class receivingStatus {\n");
            sb.Append("  ReceiveStatus: ").Append(ReceiveStatus).Append("\n");
            sb.Append("  ReceivedQuantity: ").Append(ReceivedQuantity).Append("\n");
            sb.Append("  LastReceiveDate: ").Append(LastReceiveDate).Append("\n");
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
            return Equals(input as receivingStatus);
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
                if (ReceiveStatus != null)
                    hashCode = hashCode * 59 + ReceiveStatus.GetHashCode();
                if (ReceivedQuantity != null)
                    hashCode = hashCode * 59 + ReceivedQuantity.GetHashCode();
                if (LastReceiveDate != null)
                    hashCode = hashCode * 59 + LastReceiveDate.GetHashCode();
                return hashCode;
            }
        }
    }
}