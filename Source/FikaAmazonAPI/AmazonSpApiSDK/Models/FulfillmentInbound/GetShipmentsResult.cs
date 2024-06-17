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
    ///     GetShipmentsResult
    /// </summary>
    [DataContract]
    public class GetShipmentsResult : IEquatable<GetShipmentsResult>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="GetShipmentsResult" /> class.
        /// </summary>
        /// <param name="shipmentData">Information about your inbound shipments..</param>
        /// <param name="nextToken">
        ///     When present and not empty, pass this string token in the next request to return the next
        ///     response page..
        /// </param>
        public GetShipmentsResult(InboundShipmentList shipmentData = default, string nextToken = default)
        {
            ShipmentData = shipmentData;
            NextToken = nextToken;
        }

        /// <summary>
        ///     Information about your inbound shipments.
        /// </summary>
        /// <value>Information about your inbound shipments.</value>
        [DataMember(Name = "ShipmentData", EmitDefaultValue = false)]
        public InboundShipmentList ShipmentData { get; set; }

        /// <summary>
        ///     When present and not empty, pass this string token in the next request to return the next response page.
        /// </summary>
        /// <value>When present and not empty, pass this string token in the next request to return the next response page.</value>
        [DataMember(Name = "NextToken", EmitDefaultValue = false)]
        public string NextToken { get; set; }

        /// <summary>
        ///     Returns true if GetShipmentsResult instances are equal
        /// </summary>
        /// <param name="input">Instance of GetShipmentsResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetShipmentsResult input)
        {
            if (input == null)
                return false;

            return
                (
                    ShipmentData == input.ShipmentData ||
                    (ShipmentData != null &&
                     ShipmentData.Equals(input.ShipmentData))
                ) &&
                (
                    NextToken == input.NextToken ||
                    (NextToken != null &&
                     NextToken.Equals(input.NextToken))
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
            sb.Append("class GetShipmentsResult {\n");
            sb.Append("  ShipmentData: ").Append(ShipmentData).Append("\n");
            sb.Append("  NextToken: ").Append(NextToken).Append("\n");
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
            return Equals(input as GetShipmentsResult);
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
                if (ShipmentData != null)
                    hashCode = hashCode * 59 + ShipmentData.GetHashCode();
                if (NextToken != null)
                    hashCode = hashCode * 59 + NextToken.GetHashCode();
                return hashCode;
            }
        }
    }
}