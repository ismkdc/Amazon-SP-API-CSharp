﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Orders
{
    /// <summary>
    /// The request body for the updateVerificationStatus operation.
    /// </summary>
    [DataContract]
    public partial class UpdateVerificationStatusRequest : IEquatable<UpdateVerificationStatusRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVerificationStatusRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateVerificationStatusRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVerificationStatusRequest" /> class.
        /// </summary>
        /// <param name="regulatedOrderVerificationStatus">The updated values of the VerificationStatus field. (required).</param>
        public UpdateVerificationStatusRequest(UpdateVerificationStatusRequestBody regulatedOrderVerificationStatus = default(UpdateVerificationStatusRequestBody))
        {
            // to ensure "regulatedOrderVerificationStatus" is required (not null)
            if (regulatedOrderVerificationStatus == null)
            {
                throw new InvalidDataException("regulatedOrderVerificationStatus is a required property for UpdateVerificationStatusRequest and cannot be null");
            }
            else
            {
                this.RegulatedOrderVerificationStatus = regulatedOrderVerificationStatus;
            }
        }

        /// <summary>
        /// The updated values of the VerificationStatus field.
        /// </summary>
        /// <value>The updated values of the VerificationStatus field.</value>
        [DataMember(Name = "regulatedOrderVerificationStatus", EmitDefaultValue = false)]
        public UpdateVerificationStatusRequestBody RegulatedOrderVerificationStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateVerificationStatusRequest {\n");
            sb.Append("  RegulatedOrderVerificationStatus: ").Append(RegulatedOrderVerificationStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateVerificationStatusRequest);
        }

        /// <summary>
        /// Returns true if UpdateVerificationStatusRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateVerificationStatusRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateVerificationStatusRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    this.RegulatedOrderVerificationStatus == input.RegulatedOrderVerificationStatus ||
                    (this.RegulatedOrderVerificationStatus != null &&
                    this.RegulatedOrderVerificationStatus.Equals(input.RegulatedOrderVerificationStatus))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.RegulatedOrderVerificationStatus != null)
                    hashCode = hashCode * 59 + this.RegulatedOrderVerificationStatus.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}