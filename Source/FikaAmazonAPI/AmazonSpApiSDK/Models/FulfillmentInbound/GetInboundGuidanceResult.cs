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
    ///     GetInboundGuidanceResult
    /// </summary>
    [DataContract]
    public class GetInboundGuidanceResult : IEquatable<GetInboundGuidanceResult>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="GetInboundGuidanceResult" /> class.
        /// </summary>
        /// <param name="sKUInboundGuidanceList">sKUInboundGuidanceList.</param>
        /// <param name="invalidSKUList">invalidSKUList.</param>
        /// <param name="aSINInboundGuidanceList">aSINInboundGuidanceList.</param>
        /// <param name="invalidASINList">invalidASINList.</param>
        public GetInboundGuidanceResult(SKUInboundGuidanceList sKUInboundGuidanceList = default,
            InvalidSKUList invalidSKUList = default, ASINInboundGuidanceList aSINInboundGuidanceList = default,
            InvalidASINList invalidASINList = default)
        {
            SKUInboundGuidanceList = sKUInboundGuidanceList;
            InvalidSKUList = invalidSKUList;
            ASINInboundGuidanceList = aSINInboundGuidanceList;
            InvalidASINList = invalidASINList;
        }

        /// <summary>
        ///     Gets or Sets SKUInboundGuidanceList
        /// </summary>
        [DataMember(Name = "SKUInboundGuidanceList", EmitDefaultValue = false)]
        public SKUInboundGuidanceList SKUInboundGuidanceList { get; set; }

        /// <summary>
        ///     Gets or Sets InvalidSKUList
        /// </summary>
        [DataMember(Name = "InvalidSKUList", EmitDefaultValue = false)]
        public InvalidSKUList InvalidSKUList { get; set; }

        /// <summary>
        ///     Gets or Sets ASINInboundGuidanceList
        /// </summary>
        [DataMember(Name = "ASINInboundGuidanceList", EmitDefaultValue = false)]
        public ASINInboundGuidanceList ASINInboundGuidanceList { get; set; }

        /// <summary>
        ///     Gets or Sets InvalidASINList
        /// </summary>
        [DataMember(Name = "InvalidASINList", EmitDefaultValue = false)]
        public InvalidASINList InvalidASINList { get; set; }

        /// <summary>
        ///     Returns true if GetInboundGuidanceResult instances are equal
        /// </summary>
        /// <param name="input">Instance of GetInboundGuidanceResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetInboundGuidanceResult input)
        {
            if (input == null)
                return false;

            return
                (
                    SKUInboundGuidanceList == input.SKUInboundGuidanceList ||
                    (SKUInboundGuidanceList != null &&
                     SKUInboundGuidanceList.Equals(input.SKUInboundGuidanceList))
                ) &&
                (
                    InvalidSKUList == input.InvalidSKUList ||
                    (InvalidSKUList != null &&
                     InvalidSKUList.Equals(input.InvalidSKUList))
                ) &&
                (
                    ASINInboundGuidanceList == input.ASINInboundGuidanceList ||
                    (ASINInboundGuidanceList != null &&
                     ASINInboundGuidanceList.Equals(input.ASINInboundGuidanceList))
                ) &&
                (
                    InvalidASINList == input.InvalidASINList ||
                    (InvalidASINList != null &&
                     InvalidASINList.Equals(input.InvalidASINList))
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
            sb.Append("class GetInboundGuidanceResult {\n");
            sb.Append("  SKUInboundGuidanceList: ").Append(SKUInboundGuidanceList).Append("\n");
            sb.Append("  InvalidSKUList: ").Append(InvalidSKUList).Append("\n");
            sb.Append("  ASINInboundGuidanceList: ").Append(ASINInboundGuidanceList).Append("\n");
            sb.Append("  InvalidASINList: ").Append(InvalidASINList).Append("\n");
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
            return Equals(input as GetInboundGuidanceResult);
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
                if (SKUInboundGuidanceList != null)
                    hashCode = hashCode * 59 + SKUInboundGuidanceList.GetHashCode();
                if (InvalidSKUList != null)
                    hashCode = hashCode * 59 + InvalidSKUList.GetHashCode();
                if (ASINInboundGuidanceList != null)
                    hashCode = hashCode * 59 + ASINInboundGuidanceList.GetHashCode();
                if (InvalidASINList != null)
                    hashCode = hashCode * 59 + InvalidASINList.GetHashCode();
                return hashCode;
            }
        }
    }
}