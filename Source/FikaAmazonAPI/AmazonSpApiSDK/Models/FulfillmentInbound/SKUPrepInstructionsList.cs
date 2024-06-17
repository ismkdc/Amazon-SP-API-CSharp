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
    ///     A list of SKU labeling requirements and item preparation instructions.
    /// </summary>
    [DataContract]
    public class SKUPrepInstructionsList : List<SKUPrepInstructions>, IEquatable<SKUPrepInstructionsList>,
        IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SKUPrepInstructionsList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public SKUPrepInstructionsList()
        {
        }

        /// <summary>
        ///     Returns true if SKUPrepInstructionsList instances are equal
        /// </summary>
        /// <param name="input">Instance of SKUPrepInstructionsList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SKUPrepInstructionsList input)
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
            sb.Append("class SKUPrepInstructionsList {\n");
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
            return Equals(input as SKUPrepInstructionsList);
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