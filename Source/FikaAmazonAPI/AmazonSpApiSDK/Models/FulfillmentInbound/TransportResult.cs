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
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInbound
{
    /// <summary>
    ///     The workflow status for a shipment with an Amazon-partnered carrier.
    /// </summary>
    [DataContract]
    public class TransportResult : IEquatable<TransportResult>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="TransportResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public TransportResult()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="TransportResult" /> class.
        /// </summary>
        /// <param name="transportStatus">transportStatus (required).</param>
        /// <param name="errorCode">An error code that identifies the type of error that occured..</param>
        /// <param name="errorDescription">A message that describes the error condition..</param>
        public TransportResult(TransportStatus transportStatus = default, string errorCode = default,
            string errorDescription = default)
        {
            // to ensure "transportStatus" is required (not null)
            if (transportStatus == null)
                throw new InvalidDataException(
                    "transportStatus is a required property for TransportResult and cannot be null");
            TransportStatus = transportStatus;
            ErrorCode = errorCode;
            ErrorDescription = errorDescription;
        }

        /// <summary>
        ///     Gets or Sets TransportStatus
        /// </summary>
        [DataMember(Name = "TransportStatus", EmitDefaultValue = false)]
        public TransportStatus TransportStatus { get; set; }


        /// <summary>
        ///     An error code that identifies the type of error that occured.
        /// </summary>
        /// <value>An error code that identifies the type of error that occured.</value>
        [DataMember(Name = "ErrorCode", EmitDefaultValue = false)]
        public string ErrorCode { get; set; }

        /// <summary>
        ///     A message that describes the error condition.
        /// </summary>
        /// <value>A message that describes the error condition.</value>
        [DataMember(Name = "ErrorDescription", EmitDefaultValue = false)]
        public string ErrorDescription { get; set; }

        /// <summary>
        ///     Returns true if TransportResult instances are equal
        /// </summary>
        /// <param name="input">Instance of TransportResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransportResult input)
        {
            if (input == null)
                return false;

            return
                (
                    TransportStatus == input.TransportStatus ||
                    (TransportStatus != null &&
                     TransportStatus.Equals(input.TransportStatus))
                ) &&
                (
                    ErrorCode == input.ErrorCode ||
                    (ErrorCode != null &&
                     ErrorCode.Equals(input.ErrorCode))
                ) &&
                (
                    ErrorDescription == input.ErrorDescription ||
                    (ErrorDescription != null &&
                     ErrorDescription.Equals(input.ErrorDescription))
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
            sb.Append("class TransportResult {\n");
            sb.Append("  TransportStatus: ").Append(TransportStatus).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorDescription: ").Append(ErrorDescription).Append("\n");
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
            return Equals(input as TransportResult);
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
                if (TransportStatus != null)
                    hashCode = hashCode * 59 + TransportStatus.GetHashCode();
                if (ErrorCode != null)
                    hashCode = hashCode * 59 + ErrorCode.GetHashCode();
                if (ErrorDescription != null)
                    hashCode = hashCode * 59 + ErrorDescription.GetHashCode();
                return hashCode;
            }
        }
    }
}