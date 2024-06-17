/*
 * Selling Partner API for Merchant Fulfillment
 *
 * The Selling Partner API for Merchant Fulfillment helps you build applications that let sellers purchase shipping for non-Prime and Prime orders using Amazon’s Buy Shipping Services.
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

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.MerchantFulfillment
{
    /// <summary>
    ///     Response schema.
    /// </summary>
    [DataContract]
    public class GetEligibleShipmentServicesResponse : IEquatable<GetEligibleShipmentServicesResponse>,
        IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="GetEligibleShipmentServicesResponse" /> class.
        /// </summary>
        /// <param name="payload">payload.</param>
        /// <param name="errors">One or more unexpected errors occurred during this operation..</param>
        public GetEligibleShipmentServicesResponse(GetEligibleShipmentServicesResult payload = default,
            ErrorList errors = default)
        {
            Payload = payload;
            Errors = errors;
        }

        [JsonConstructorAttribute]
        public GetEligibleShipmentServicesResponse()
        {
        }


        /// <summary>
        ///     Gets or Sets Payload
        /// </summary>
        [DataMember(Name = "payload", EmitDefaultValue = false)]
        public GetEligibleShipmentServicesResult Payload { get; set; }

        /// <summary>
        ///     One or more unexpected errors occurred during this operation.
        /// </summary>
        /// <value>One or more unexpected errors occurred during this operation.</value>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public ErrorList Errors { get; set; }

        /// <summary>
        ///     Returns true if GetEligibleShipmentServicesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetEligibleShipmentServicesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetEligibleShipmentServicesResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    Payload == input.Payload ||
                    (Payload != null &&
                     Payload.Equals(input.Payload))
                ) &&
                (
                    Errors == input.Errors ||
                    (Errors != null &&
                     Errors.Equals(input.Errors))
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
            sb.Append("class GetEligibleShipmentServicesResponse {\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
            return Equals(input as GetEligibleShipmentServicesResponse);
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
                if (Payload != null)
                    hashCode = hashCode * 59 + Payload.GetHashCode();
                if (Errors != null)
                    hashCode = hashCode * 59 + Errors.GetHashCode();
                return hashCode;
            }
        }
    }
}