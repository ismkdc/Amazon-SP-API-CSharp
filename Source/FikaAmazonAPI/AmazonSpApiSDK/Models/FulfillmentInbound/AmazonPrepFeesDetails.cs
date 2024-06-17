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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInbound
{
    /// <summary>
    ///     The fees for Amazon to prep goods for shipment.
    /// </summary>
    [DataContract]
    public class AmazonPrepFeesDetails : IEquatable<AmazonPrepFeesDetails>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="AmazonPrepFeesDetails" /> class.
        /// </summary>
        /// <param name="prepInstruction">prepInstruction.</param>
        /// <param name="feePerUnit">The fee for Amazon to prepare 1 unit..</param>
        public AmazonPrepFeesDetails(PrepInstruction? prepInstruction = default, Amount feePerUnit = default)
        {
            PrepInstruction = prepInstruction;
            FeePerUnit = feePerUnit;
        }

        /// <summary>
        ///     Gets or Sets PrepInstruction
        /// </summary>
        [DataMember(Name = "PrepInstruction", EmitDefaultValue = false)]
        public PrepInstruction? PrepInstruction { get; set; }


        /// <summary>
        ///     The fee for Amazon to prepare 1 unit.
        /// </summary>
        /// <value>The fee for Amazon to prepare 1 unit.</value>
        [DataMember(Name = "FeePerUnit", EmitDefaultValue = false)]
        public Amount FeePerUnit { get; set; }

        /// <summary>
        ///     Returns true if AmazonPrepFeesDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of AmazonPrepFeesDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AmazonPrepFeesDetails input)
        {
            if (input == null)
                return false;

            return
                (
                    PrepInstruction == input.PrepInstruction ||
                    (PrepInstruction != null &&
                     PrepInstruction.Equals(input.PrepInstruction))
                ) &&
                (
                    FeePerUnit == input.FeePerUnit ||
                    (FeePerUnit != null &&
                     FeePerUnit.Equals(input.FeePerUnit))
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
            sb.Append("class AmazonPrepFeesDetails {\n");
            sb.Append("  PrepInstruction: ").Append(PrepInstruction).Append("\n");
            sb.Append("  FeePerUnit: ").Append(FeePerUnit).Append("\n");
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
            return Equals(input as AmazonPrepFeesDetails);
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
                if (PrepInstruction != null)
                    hashCode = hashCode * 59 + PrepInstruction.GetHashCode();
                if (FeePerUnit != null)
                    hashCode = hashCode * 59 + FeePerUnit.GetHashCode();
                return hashCode;
            }
        }
    }
}