﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Orders
{
    /// <summary>
    ///     A list of order items.
    /// </summary>
    [DataContract]
    public class ConfirmShipmentOrderItemsList : List<ConfirmShipmentOrderItem>,
        IEquatable<ConfirmShipmentOrderItemsList>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ConfirmShipmentOrderItemsList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ConfirmShipmentOrderItemsList()
        {
        }

        /// <summary>
        ///     Returns true if ConfirmShipmentOrderItemsList instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfirmShipmentOrderItemsList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfirmShipmentOrderItemsList input)
        {
            if (input == null)
                return false;

            return base.Equals(input);
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
            sb.Append("class ConfirmShipmentOrderItemsList {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return Equals(input as ConfirmShipmentOrderItemsList);
        }

        /// <summary>
        ///     Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            var hashCode = base.GetHashCode();
            return hashCode;
        }
    }
}