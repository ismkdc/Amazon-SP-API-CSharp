using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Upload
{
    /// <summary>
    ///     The response schema for the GetAuthorizationCode operation.
    /// </summary>
    [DataContract]
    public class CreateUploadDestinationResponse : IEquatable<CreateUploadDestinationResponse>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="CreateUploadDestinationResponse" /> class.
        /// </summary>
        /// <param name="Payload">Payload.</param>
        /// <param name="Errors">Errors.</param>
        public CreateUploadDestinationResponse(UploadDestination Payload = default, ErrorList Errors = default)
        {
            this.Payload = Payload;
            this.Errors = Errors;
        }

        public CreateUploadDestinationResponse()
        {
            Payload = default;
            Errors = default;
        }

        /// <summary>
        ///     Gets or Sets Payload
        /// </summary>
        [DataMember(Name = "payload", EmitDefaultValue = false)]
        public UploadDestination Payload { get; set; }

        /// <summary>
        ///     Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public ErrorList Errors { get; set; }

        /// <summary>
        ///     Returns true if CreateUploadDestinationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateUploadDestinationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateUploadDestinationResponse input)
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
            sb.Append("class CreateUploadDestinationResponse {\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
            return Equals(input as CreateUploadDestinationResponse);
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