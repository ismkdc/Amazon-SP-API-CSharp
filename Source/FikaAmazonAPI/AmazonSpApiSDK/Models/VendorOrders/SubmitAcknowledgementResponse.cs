﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using FikaAmazonAPI.AmazonSpApiSDK.Models.VendorTransactions;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.VendorOrders
{
    /// <summary>
    ///     The response schema for the submitAcknowledgement operation.
    /// </summary>
    [DataContract]
    public class SubmitAcknowledgementResponse : IEquatable<SubmitAcknowledgementResponse>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SubmitAcknowledgementResponse" /> class.
        /// </summary>
        /// <param name="payload">The payload for the submitAcknowledgement operation..</param>
        /// <param name="errors">errors.</param>
        public SubmitAcknowledgementResponse(TransactionId payload = default, ErrorList errors = default)
        {
            Payload = payload;
            Errors = errors;
        }

        public SubmitAcknowledgementResponse()
        {
            Payload = default;
            Errors = default;
        }

        /// <summary>
        ///     The payload for the submitAcknowledgement operation.
        /// </summary>
        /// <value>The payload for the submitAcknowledgement operation.</value>
        [DataMember(Name = "payload", EmitDefaultValue = false)]
        public TransactionId Payload { get; set; }

        /// <summary>
        ///     Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public ErrorList Errors { get; set; }

        /// <summary>
        ///     Returns true if SubmitAcknowledgementResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SubmitAcknowledgementResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubmitAcknowledgementResponse input)
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
            sb.Append("class SubmitAcknowledgementResponse {\n");
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
            return Equals(input as SubmitAcknowledgementResponse);
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