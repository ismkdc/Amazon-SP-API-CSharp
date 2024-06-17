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
    ///     ListCatalogCategoriesResponse
    /// </summary>
    [DataContract]
    public class ListCatalogCategoriesResponse : IEquatable<ListCatalogCategoriesResponse>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ListCatalogCategoriesResponse" /> class.
        /// </summary>
        /// <param name="Payload">The payload for the listCatalogCategories operation..</param>
        /// <param name="Errors">One or more unexpected errors occurred during the listCatalogCategories operation..</param>
        public ListCatalogCategoriesResponse(ListOfCategories Payload = default, ErrorList Errors = default)
        {
            this.Payload = Payload;
            this.Errors = Errors;
        }

        public ListCatalogCategoriesResponse()
        {
            Payload = default;
            Errors = default;
        }

        /// <summary>
        ///     The payload for the listCatalogCategories operation.
        /// </summary>
        /// <value>The payload for the listCatalogCategories operation.</value>
        [DataMember(Name = "payload", EmitDefaultValue = false)]
        public ListOfCategories Payload { get; set; }

        /// <summary>
        ///     One or more unexpected errors occurred during the listCatalogCategories operation.
        /// </summary>
        /// <value>One or more unexpected errors occurred during the listCatalogCategories operation.</value>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public ErrorList Errors { get; set; }

        /// <summary>
        ///     Returns true if ListCatalogCategoriesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ListCatalogCategoriesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListCatalogCategoriesResponse input)
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
            sb.Append("class ListCatalogCategoriesResponse {\n");
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
            return Equals(input as ListCatalogCategoriesResponse);
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