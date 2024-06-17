﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.VendorOrders
{
    [DataContract]
    public class ItemQuantity : IEquatable<ItemQuantity>, IValidatableObject
    {
        /// <summary>
        ///     Unit of measure for the acknowledged quantity.
        /// </summary>
        /// <value>Unit of measure for the acknowledged quantity.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnitOfMeasureEnum
        {
            [EnumMember(Value = "Cases")] Cases,

            [EnumMember(Value = "Eaches")] Eaches
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ItemQuantity" /> class.
        /// </summary>
        /// <param name="amount">Acknowledged quantity. This value should not be zero..</param>
        /// <param name="unitOfMeasure">Unit of measure for the acknowledged quantity..</param>
        [JsonConstructorAttribute]
        public ItemQuantity()
        {
        }

        public ItemQuantity(int? amount = default, UnitOfMeasureEnum? unitOfMeasure = default, int? unitSize = default)
        {
            Amount = amount;
            UnitOfMeasure = unitOfMeasure;
            UnitSize = unitSize;
        }

        /// <summary>
        ///     Unit of measure for the acknowledged quantity.
        /// </summary>
        /// <value>Unit of measure for the acknowledged quantity.</value>
        [DataMember(Name = "unitOfMeasure", EmitDefaultValue = false)]
        public UnitOfMeasureEnum? UnitOfMeasure { get; set; }

        /// <summary>
        ///     Acknowledged quantity. This value should not be zero.
        /// </summary>
        /// <value>Acknowledged quantity. This value should not be zero.</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public int? Amount { get; set; }

        /// <summary>
        ///     The case size, in the event that Amazon ordered using cases.
        /// </summary>
        /// <value>The case size, in the event that Amazon ordered using cases.</value>
        [DataMember(Name = "unitSize", EmitDefaultValue = false)]
        public int? UnitSize { get; set; }

        /// <summary>
        ///     Returns true if ItemQuantity instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemQuantity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemQuantity input)
        {
            if (input == null)
                return false;

            return
                (
                    Amount == input.Amount ||
                    (Amount != null &&
                     Amount.Equals(input.Amount))
                ) &&
                (
                    UnitOfMeasure == input.UnitOfMeasure ||
                    (UnitOfMeasure != null &&
                     UnitOfMeasure.Equals(input.UnitOfMeasure))
                ) &&
                (
                    UnitSize == input.UnitSize ||
                    (UnitSize != null &&
                     UnitSize.Equals(input.UnitSize))
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
            sb.Append("class ItemQuantity {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
            sb.Append("  UnitSize: ").Append(UnitSize).Append("\n");
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
            return Equals(input as ItemQuantity);
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
                if (Amount != null)
                    hashCode = hashCode * 59 + Amount.GetHashCode();
                if (UnitOfMeasure != null)
                    hashCode = hashCode * 59 + UnitOfMeasure.GetHashCode();
                if (UnitSize != null)
                    hashCode = hashCode * 59 + UnitSize.GetHashCode();
                return hashCode;
            }
        }
    }
}