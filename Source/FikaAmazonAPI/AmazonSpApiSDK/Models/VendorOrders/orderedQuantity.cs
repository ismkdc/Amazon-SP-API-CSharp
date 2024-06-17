using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.VendorOrders
{
    [DataContract]
    public class orderedQuantity : IEquatable<orderedQuantity>, IValidatableObject
    {
        [JsonConstructorAttribute]
        public orderedQuantity()
        {
        }

        public orderedQuantity(ItemQuantity orderedQuantity = default,
            List<OrderedQuantityDetails> orderedQuantityDetails = default)
        {
            OrderedQuantity = orderedQuantity;
            OrderedQuantityDetails = orderedQuantityDetails;
        }

        [DataMember(Name = "orderedQuantity", EmitDefaultValue = false)]
        public ItemQuantity OrderedQuantity { get; set; }

        [DataMember(Name = "orderedQuantityDetails", EmitDefaultValue = false)]
        public List<OrderedQuantityDetails> OrderedQuantityDetails { get; set; }

        /// <summary>
        ///     Returns true if ItemQuantity instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemQuantity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(orderedQuantity input)
        {
            if (input == null)
                return false;

            return
                (
                    OrderedQuantity == input.OrderedQuantity ||
                    (OrderedQuantity != null &&
                     OrderedQuantity.Equals(input.OrderedQuantity))
                ) &&
                (
                    OrderedQuantityDetails == input.OrderedQuantityDetails ||
                    (OrderedQuantityDetails != null &&
                     OrderedQuantityDetails.Equals(input.OrderedQuantityDetails))
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
            sb.Append("class orderedQuantity {\n");
            sb.Append("  OrderedQuantity: ").Append(OrderedQuantity).Append("\n");
            sb.Append("  OrderedQuantityDetails: ").Append(OrderedQuantityDetails).Append("\n");
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
                if (OrderedQuantity != null)
                    hashCode = hashCode * 59 + OrderedQuantity.GetHashCode();
                if (OrderedQuantityDetails != null)
                    hashCode = hashCode * 59 + OrderedQuantityDetails.GetHashCode();
                return hashCode;
            }
        }
    }
}