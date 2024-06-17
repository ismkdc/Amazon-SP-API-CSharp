﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Upload
{
    /// <summary>
    ///     An error response returned when the request is unsuccessful.
    /// </summary>
    [DataContract]
    public class Error : IEquatable<Error>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Error()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        /// <param name="Code">An error code that identifies the type of error that occurred. (required).</param>
        /// <param name="Message">A message that describes the error condition in a human-readable form. (required).</param>
        /// <param name="Details">Additional details that can help the caller understand or fix the issue..</param>
        public Error(string Code = default, string Message = default, string Details = default)
        {
            // to ensure "Code" is required (not null)
            if (Code == null)
                throw new InvalidDataException("Code is a required property for Error and cannot be null");
            this.Code = Code;
            // to ensure "Message" is required (not null)
            if (Message == null)
                throw new InvalidDataException("Message is a required property for Error and cannot be null");
            this.Message = Message;
            this.Details = Details;
        }

        /// <summary>
        ///     An error code that identifies the type of error that occurred.
        /// </summary>
        /// <value>An error code that identifies the type of error that occurred.</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        ///     A message that describes the error condition in a human-readable form.
        /// </summary>
        /// <value>A message that describes the error condition in a human-readable form.</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        ///     Additional details that can help the caller understand or fix the issue.
        /// </summary>
        /// <value>Additional details that can help the caller understand or fix the issue.</value>
        [DataMember(Name = "details", EmitDefaultValue = false)]
        public string Details { get; set; }

        /// <summary>
        ///     Returns true if Error instances are equal
        /// </summary>
        /// <param name="input">Instance of Error to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Error input)
        {
            if (input == null)
                return false;

            return
                (
                    Code == input.Code ||
                    (Code != null &&
                     Code.Equals(input.Code))
                ) &&
                (
                    Message == input.Message ||
                    (Message != null &&
                     Message.Equals(input.Message))
                ) &&
                (
                    Details == input.Details ||
                    (Details != null &&
                     Details.Equals(input.Details))
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
            sb.Append("class Error {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
            return Equals(input as Error);
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
                if (Code != null)
                    hashCode = hashCode * 59 + Code.GetHashCode();
                if (Message != null)
                    hashCode = hashCode * 59 + Message.GetHashCode();
                if (Details != null)
                    hashCode = hashCode * 59 + Details.GetHashCode();
                return hashCode;
            }
        }
    }
}