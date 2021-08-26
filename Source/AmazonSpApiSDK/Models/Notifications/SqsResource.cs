/* 
 * Selling Partner API for Notifications
 *
 * The Selling Partner API for Notifications lets you subscribe to notifications that are relevant to a selling partner's business. Using this API you can create a destination to receive notifications, subscribe to notifications, delete notification subscriptions, and more.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;

namespace AmazonSpApiSDK.Models.Notifications
{
    /// <summary>
    /// The information required to create an Amazon Simple Queue Service (Amazon SQS) queue destination.
    /// </summary>
    [DataContract]
    public partial class SqsResource : IEquatable<SqsResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SqsResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SqsResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SqsResource" /> class.
        /// </summary>
        /// <param name="Arn">The Amazon Resource Name (ARN) associated with the SQS queue. (required).</param>
        public SqsResource(string Arn = default(string))
        {
            // to ensure "Arn" is required (not null)
            if (Arn == null)
            {
                throw new InvalidDataException("Arn is a required property for SqsResource and cannot be null");
            }
            else
            {
                this.Arn = Arn;
            }
        }

        /// <summary>
        /// The Amazon Resource Name (ARN) associated with the SQS queue.
        /// </summary>
        /// <value>The Amazon Resource Name (ARN) associated with the SQS queue.</value>
        [DataMember(Name = "arn", EmitDefaultValue = false)]
        public string Arn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SqsResource {\n");
            sb.Append("  Arn: ").Append(Arn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as SqsResource);
        }

        /// <summary>
        /// Returns true if SqsResource instances are equal
        /// </summary>
        /// <param name="input">Instance of SqsResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SqsResource input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Arn == input.Arn ||
                    (this.Arn != null &&
                    this.Arn.Equals(input.Arn))
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
                if (this.Arn != null)
                    hashCode = hashCode * 59 + this.Arn.GetHashCode();
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
            // Arn (string) maxLength
            if (this.Arn != null && this.Arn.Length > 1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Arn, length must be less than 1000.", new[] { "Arn" });
            }

            // Arn (string) pattern
            Regex regexArn = new Regex(@"^arn:aws:sqs:\\S+:\\S+:\\S+", RegexOptions.CultureInvariant);
            if (false == regexArn.Match(this.Arn).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Arn, must match a pattern of " + regexArn, new[] { "Arn" });
            }

            yield break;
        }
    }

}
