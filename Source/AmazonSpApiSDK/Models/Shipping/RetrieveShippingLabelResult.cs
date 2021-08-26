/* 
 * Selling Partner API for Shipping
 *
 * Provides programmatic access to Amazon Shipping APIs.
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

namespace AmazonSpApiSDK.Models.Shipping
{
    /// <summary>
    /// The payload schema for the retrieveShippingLabel operation.
    /// </summary>
    [DataContract]
    public partial class RetrieveShippingLabelResult : IEquatable<RetrieveShippingLabelResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveShippingLabelResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RetrieveShippingLabelResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveShippingLabelResult" /> class.
        /// </summary>
        /// <param name="LabelStream">LabelStream (required).</param>
        /// <param name="LabelSpecification">LabelSpecification (required).</param>
        public RetrieveShippingLabelResult(LabelStream LabelStream = default(LabelStream), LabelSpecification LabelSpecification = default(LabelSpecification))
        {
            // to ensure "LabelStream" is required (not null)
            if (LabelStream == null)
            {
                throw new InvalidDataException("LabelStream is a required property for RetrieveShippingLabelResult and cannot be null");
            }
            else
            {
                this.LabelStream = LabelStream;
            }
            // to ensure "LabelSpecification" is required (not null)
            if (LabelSpecification == null)
            {
                throw new InvalidDataException("LabelSpecification is a required property for RetrieveShippingLabelResult and cannot be null");
            }
            else
            {
                this.LabelSpecification = LabelSpecification;
            }
        }

        /// <summary>
        /// Gets or Sets LabelStream
        /// </summary>
        [DataMember(Name = "labelStream", EmitDefaultValue = false)]
        public LabelStream LabelStream { get; set; }

        /// <summary>
        /// Gets or Sets LabelSpecification
        /// </summary>
        [DataMember(Name = "labelSpecification", EmitDefaultValue = false)]
        public LabelSpecification LabelSpecification { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetrieveShippingLabelResult {\n");
            sb.Append("  LabelStream: ").Append(LabelStream).Append("\n");
            sb.Append("  LabelSpecification: ").Append(LabelSpecification).Append("\n");
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
            return this.Equals(input as RetrieveShippingLabelResult);
        }

        /// <summary>
        /// Returns true if RetrieveShippingLabelResult instances are equal
        /// </summary>
        /// <param name="input">Instance of RetrieveShippingLabelResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RetrieveShippingLabelResult input)
        {
            if (input == null)
                return false;

            return
                (
                    this.LabelStream == input.LabelStream ||
                    (this.LabelStream != null &&
                    this.LabelStream.Equals(input.LabelStream))
                ) &&
                (
                    this.LabelSpecification == input.LabelSpecification ||
                    (this.LabelSpecification != null &&
                    this.LabelSpecification.Equals(input.LabelSpecification))
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
                if (this.LabelStream != null)
                    hashCode = hashCode * 59 + this.LabelStream.GetHashCode();
                if (this.LabelSpecification != null)
                    hashCode = hashCode * 59 + this.LabelSpecification.GetHashCode();
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
