/*
 * Selling Partner API for Pricing
 *
 * The Selling Partner API for Pricing helps you programmatically retrieve product pricing and offer information for Amazon Marketplace products.
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

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.ProductPricing
{
    /// <summary>
    ///     Information about the seller&#39;s feedback, including the percentage of positive feedback, and the total number of
    ///     ratings received.
    /// </summary>
    [DataContract]
    public class SellerFeedbackType : IEquatable<SellerFeedbackType>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SellerFeedbackType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public SellerFeedbackType()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="SellerFeedbackType" /> class.
        /// </summary>
        /// <param name="SellerPositiveFeedbackRating">The percentage of positive feedback for the seller in the past 365 days..</param>
        /// <param name="FeedbackCount">The number of ratings received about the seller. (required).</param>
        public SellerFeedbackType(double? SellerPositiveFeedbackRating = default, long? FeedbackCount = default)
        {
            // to ensure "FeedbackCount" is required (not null)
            if (FeedbackCount == null)
                throw new InvalidDataException(
                    "FeedbackCount is a required property for SellerFeedbackType and cannot be null");
            this.FeedbackCount = FeedbackCount;
            this.SellerPositiveFeedbackRating = SellerPositiveFeedbackRating;
        }

        /// <summary>
        ///     The percentage of positive feedback for the seller in the past 365 days.
        /// </summary>
        /// <value>The percentage of positive feedback for the seller in the past 365 days.</value>
        [DataMember(Name = "SellerPositiveFeedbackRating", EmitDefaultValue = false)]
        public double? SellerPositiveFeedbackRating { get; set; }

        /// <summary>
        ///     The number of ratings received about the seller.
        /// </summary>
        /// <value>The number of ratings received about the seller.</value>
        [DataMember(Name = "FeedbackCount", EmitDefaultValue = false)]
        public long? FeedbackCount { get; set; }

        /// <summary>
        ///     Returns true if SellerFeedbackType instances are equal
        /// </summary>
        /// <param name="input">Instance of SellerFeedbackType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SellerFeedbackType input)
        {
            if (input == null)
                return false;

            return
                (
                    SellerPositiveFeedbackRating == input.SellerPositiveFeedbackRating ||
                    (SellerPositiveFeedbackRating != null &&
                     SellerPositiveFeedbackRating.Equals(input.SellerPositiveFeedbackRating))
                ) &&
                (
                    FeedbackCount == input.FeedbackCount ||
                    (FeedbackCount != null &&
                     FeedbackCount.Equals(input.FeedbackCount))
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
            sb.Append("class SellerFeedbackType {\n");
            sb.Append("  SellerPositiveFeedbackRating: ").Append(SellerPositiveFeedbackRating).Append("\n");
            sb.Append("  FeedbackCount: ").Append(FeedbackCount).Append("\n");
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
            return Equals(input as SellerFeedbackType);
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
                if (SellerPositiveFeedbackRating != null)
                    hashCode = hashCode * 59 + SellerPositiveFeedbackRating.GetHashCode();
                if (FeedbackCount != null)
                    hashCode = hashCode * 59 + FeedbackCount.GetHashCode();
                return hashCode;
            }
        }
    }
}