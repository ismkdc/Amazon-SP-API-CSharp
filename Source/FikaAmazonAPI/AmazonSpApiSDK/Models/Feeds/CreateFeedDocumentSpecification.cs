/*
 * Selling Partner API for Feeds
 *
 * The Selling Partner API for Feeds lets you upload data to Amazon on behalf of a selling partner.
 *
 * OpenAPI spec version: 2020-09-04
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

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Feeds
{
    /// <summary>
    ///     CreateFeedDocumentSpecification
    /// </summary>
    [DataContract]
    public class CreateFeedDocumentSpecification : IEquatable<CreateFeedDocumentSpecification>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="CreateFeedDocumentSpecification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public CreateFeedDocumentSpecification()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="CreateFeedDocumentSpecification" /> class.
        /// </summary>
        /// <param name="ContentType">The content type of the feed. (required).</param>
        public CreateFeedDocumentSpecification(string ContentType = default)
        {
            // to ensure "ContentType" is required (not null)
            if (ContentType == null)
                throw new InvalidDataException(
                    "ContentType is a required property for CreateFeedDocumentSpecification and cannot be null");
            this.ContentType = ContentType;
        }

        /// <summary>
        ///     The content type of the feed.
        /// </summary>
        /// <value>The content type of the feed.</value>
        [DataMember(Name = "contentType", EmitDefaultValue = false)]
        public string ContentType { get; set; }

        /// <summary>
        ///     Returns true if CreateFeedDocumentSpecification instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateFeedDocumentSpecification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateFeedDocumentSpecification input)
        {
            if (input == null)
                return false;

            return
                ContentType == input.ContentType ||
                (ContentType != null &&
                 ContentType.Equals(input.ContentType));
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
            sb.Append("class CreateFeedDocumentSpecification {\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
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
            return Equals(input as CreateFeedDocumentSpecification);
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
                if (ContentType != null)
                    hashCode = hashCode * 59 + ContentType.GetHashCode();
                return hashCode;
            }
        }
    }
}