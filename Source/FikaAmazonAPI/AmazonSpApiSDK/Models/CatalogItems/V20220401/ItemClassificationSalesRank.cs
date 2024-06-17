/*
 * Selling Partner API for Catalog Items
 *
 * The Selling Partner API for Catalog Items provides programmatic access to information about items in the Amazon catalog.  For more information, refer to the [Catalog Items API Use Case Guide](doc:catalog-items-api-v2022-04-01-use-case-guide).
 *
 * OpenAPI spec version: 2022-04-01
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

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.CatalogItems.V20220401
{
    /// <summary>
    ///     Sales rank of an Amazon catalog item by classification.
    /// </summary>
    [DataContract]
    public class ItemClassificationSalesRank : IEquatable<ItemClassificationSalesRank>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ItemClassificationSalesRank" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ItemClassificationSalesRank()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ItemClassificationSalesRank" /> class.
        /// </summary>
        /// <param name="classificationId">Identifier of the classification associated with the sales rank. (required).</param>
        /// <param name="title">Title, or name, of the sales rank. (required).</param>
        /// <param name="link">Corresponding Amazon retail website link, or URL, for the sales rank..</param>
        /// <param name="rank">Sales rank value. (required).</param>
        public ItemClassificationSalesRank(string classificationId = default, string title = default,
            string link = default, int? rank = default)
        {
            // to ensure "classificationId" is required (not null)
            if (classificationId == null)
                throw new InvalidDataException(
                    "classificationId is a required property for ItemClassificationSalesRank and cannot be null");
            ClassificationId = classificationId;
            // to ensure "title" is required (not null)
            if (title == null)
                throw new InvalidDataException(
                    "title is a required property for ItemClassificationSalesRank and cannot be null");
            Title = title;
            // to ensure "rank" is required (not null)
            if (rank == null)
                throw new InvalidDataException(
                    "rank is a required property for ItemClassificationSalesRank and cannot be null");
            Rank = rank;
            Link = link;
        }

        /// <summary>
        ///     Identifier of the classification associated with the sales rank.
        /// </summary>
        /// <value>Identifier of the classification associated with the sales rank.</value>
        [DataMember(Name = "classificationId", EmitDefaultValue = false)]
        public string ClassificationId { get; set; }

        /// <summary>
        ///     Title, or name, of the sales rank.
        /// </summary>
        /// <value>Title, or name, of the sales rank.</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        ///     Corresponding Amazon retail website link, or URL, for the sales rank.
        /// </summary>
        /// <value>Corresponding Amazon retail website link, or URL, for the sales rank.</value>
        [DataMember(Name = "link", EmitDefaultValue = false)]
        public string Link { get; set; }

        /// <summary>
        ///     Sales rank value.
        /// </summary>
        /// <value>Sales rank value.</value>
        [DataMember(Name = "rank", EmitDefaultValue = false)]
        public int? Rank { get; set; }

        /// <summary>
        ///     Returns true if ItemClassificationSalesRank instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemClassificationSalesRank to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemClassificationSalesRank input)
        {
            if (input == null)
                return false;

            return
                (
                    ClassificationId == input.ClassificationId ||
                    (ClassificationId != null &&
                     ClassificationId.Equals(input.ClassificationId))
                ) &&
                (
                    Title == input.Title ||
                    (Title != null &&
                     Title.Equals(input.Title))
                ) &&
                (
                    Link == input.Link ||
                    (Link != null &&
                     Link.Equals(input.Link))
                ) &&
                (
                    Rank == input.Rank ||
                    (Rank != null &&
                     Rank.Equals(input.Rank))
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
            sb.Append("class ItemClassificationSalesRank {\n");
            sb.Append("  ClassificationId: ").Append(ClassificationId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
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
            return Equals(input as ItemClassificationSalesRank);
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
                if (ClassificationId != null)
                    hashCode = hashCode * 59 + ClassificationId.GetHashCode();
                if (Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();
                if (Link != null)
                    hashCode = hashCode * 59 + Link.GetHashCode();
                if (Rank != null)
                    hashCode = hashCode * 59 + Rank.GetHashCode();
                return hashCode;
            }
        }
    }
}