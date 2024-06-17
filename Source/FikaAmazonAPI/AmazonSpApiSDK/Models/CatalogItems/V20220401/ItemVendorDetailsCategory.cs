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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.CatalogItems.V20220401
{
    /// <summary>
    ///     Product category or subcategory associated with an Amazon catalog item.
    /// </summary>
    [DataContract]
    public class ItemVendorDetailsCategory : IEquatable<ItemVendorDetailsCategory>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ItemVendorDetailsCategory" /> class.
        /// </summary>
        /// <param name="displayName">Display name of the product category or subcategory.</param>
        /// <param name="value">Value (code) of the product category or subcategory..</param>
        public ItemVendorDetailsCategory(string displayName = default, string value = default)
        {
            DisplayName = displayName;
            Value = value;
        }

        /// <summary>
        ///     Display name of the product category or subcategory
        /// </summary>
        /// <value>Display name of the product category or subcategory</value>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        ///     Value (code) of the product category or subcategory.
        /// </summary>
        /// <value>Value (code) of the product category or subcategory.</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        ///     Returns true if ItemVendorDetailsCategory instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemVendorDetailsCategory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemVendorDetailsCategory input)
        {
            if (input == null)
                return false;

            return
                (
                    DisplayName == input.DisplayName ||
                    (DisplayName != null &&
                     DisplayName.Equals(input.DisplayName))
                ) &&
                (
                    Value == input.Value ||
                    (Value != null &&
                     Value.Equals(input.Value))
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
            sb.Append("class ItemVendorDetailsCategory {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return Equals(input as ItemVendorDetailsCategory);
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
                if (DisplayName != null)
                    hashCode = hashCode * 59 + DisplayName.GetHashCode();
                if (Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();
                return hashCode;
            }
        }
    }
}