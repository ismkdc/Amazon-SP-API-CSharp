using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.VendorOrders
{
    [DataContract]
    public class OrderedQuantityDetails : IEquatable<OrderedQuantityDetails>, IValidatableObject
    {
        [JsonConstructorAttribute]
        public OrderedQuantityDetails()
        {
        }

        public OrderedQuantityDetails(DateTime? updatedDate = default, ItemQuantity orderedQuantity = default,
            ItemQuantity cancelledQuantity = default)
        {
            UpdatedDate = updatedDate;
            OrderedQuantity = orderedQuantity;
            CancelledQuantity = cancelledQuantity;
        }

        [DataMember(Name = "updatedDate", EmitDefaultValue = false)]
        public DateTime? UpdatedDate { get; set; }

        [DataMember(Name = "orderedQuantity", EmitDefaultValue = false)]
        public ItemQuantity OrderedQuantity { get; set; }

        [DataMember(Name = "cancelledQuantity", EmitDefaultValue = false)]
        public ItemQuantity CancelledQuantity { get; set; }

        /// <summary>
        ///     Returns true if ItemQuantity instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemQuantity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderedQuantityDetails input)
        {
            if (input == null)
                return false;

            return
                (
                    UpdatedDate == input.UpdatedDate ||
                    (UpdatedDate != null &&
                     UpdatedDate.Equals(input.UpdatedDate))
                ) &&
                (
                    OrderedQuantity == input.OrderedQuantity ||
                    (OrderedQuantity != null &&
                     OrderedQuantity.Equals(input.OrderedQuantity))
                ) &&
                (
                    CancelledQuantity == input.CancelledQuantity ||
                    (CancelledQuantity != null &&
                     CancelledQuantity.Equals(input.CancelledQuantity))
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
            sb.Append("class OrderedQuantityDetails {\n");
            sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
            sb.Append("  OrderedQuantity: ").Append(OrderedQuantity).Append("\n");
            sb.Append("  CancelledQuantity: ").Append(CancelledQuantity).Append("\n");
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
            return Equals(input as orderedQuantity);
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
                if (UpdatedDate != null)
                    hashCode = hashCode * 59 + UpdatedDate.GetHashCode();
                if (OrderedQuantity != null)
                    hashCode = hashCode * 59 + OrderedQuantity.GetHashCode();
                if (CancelledQuantity != null)
                    hashCode = hashCode * 59 + CancelledQuantity.GetHashCode();
                return hashCode;
            }
        }
    }
}