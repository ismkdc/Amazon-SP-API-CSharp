/*
 * Selling Partner API for Catalog Items
 *
 * The Selling Partner API for Catalog Items helps you programmatically retrieve item details for items in the catalog.
 *
 * OpenAPI spec version: v0
 *
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.CatalogItems
{
    /// <summary>
    ///     ListMatchingItemsResponse
    /// </summary>
    [DataContract]
    public class ListMatchingItemsResponse : IEquatable<ListMatchingItemsResponse>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ListMatchingItemsResponse" /> class.
        /// </summary>
        /// <param name="Items">Items.</param>
        public ListMatchingItemsResponse(ItemList Items = default)
        {
            this.Items = Items;
        }

        public ListMatchingItemsResponse()
        {
            Items = default;
        }

        /// <summary>
        ///     Gets or Sets Items
        /// </summary>
        [DataMember(Name = "Items", EmitDefaultValue = false)]
        public ItemList Items { get; set; }

        /// <summary>
        ///     Returns true if ListMatchingItemsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ListMatchingItemsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListMatchingItemsResponse input)
        {
            if (input == null)
                return false;

            return
                Items == input.Items ||
                (Items != null &&
                 Items.Equals(input.Items));
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
            sb.Append("class ListMatchingItemsResponse {\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return Equals(input as ListMatchingItemsResponse);
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
                if (Items != null)
                    hashCode = hashCode * 59 + Items.GetHashCode();
                return hashCode;
            }
        }
    }
}