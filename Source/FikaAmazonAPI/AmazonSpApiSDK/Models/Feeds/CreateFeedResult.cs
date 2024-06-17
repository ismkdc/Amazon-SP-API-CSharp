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
    ///     CreateFeedResult
    /// </summary>
    [DataContract]
    public class CreateFeedResult : IEquatable<CreateFeedResult>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="CreateFeedResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public CreateFeedResult()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="CreateFeedResult" /> class.
        /// </summary>
        /// <param name="FeedId">
        ///     The identifier for the feed. This identifier is unique only in combination with a seller ID.
        ///     (required).
        /// </param>
        public CreateFeedResult(string FeedId = default)
        {
            // to ensure "FeedId" is required (not null)
            if (FeedId == null)
                throw new InvalidDataException("FeedId is a required property for CreateFeedResult and cannot be null");
            this.FeedId = FeedId;
        }

        /// <summary>
        ///     The identifier for the feed. This identifier is unique only in combination with a seller ID.
        /// </summary>
        /// <value>The identifier for the feed. This identifier is unique only in combination with a seller ID.</value>
        [DataMember(Name = "feedId", EmitDefaultValue = false)]
        public string FeedId { get; set; }

        /// <summary>
        ///     Returns true if CreateFeedResult instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateFeedResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateFeedResult input)
        {
            if (input == null)
                return false;

            return
                FeedId == input.FeedId ||
                (FeedId != null &&
                 FeedId.Equals(input.FeedId));
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
            sb.Append("class CreateFeedResult {\n");
            sb.Append("  FeedId: ").Append(FeedId).Append("\n");
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
            return Equals(input as CreateFeedResult);
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
                if (FeedId != null)
                    hashCode = hashCode * 59 + FeedId.GetHashCode();
                return hashCode;
            }
        }
    }
}