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
using Newtonsoft.Json.Converters;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.CatalogItems.V20220401
{
    /// <summary>
    ///     Image for an item in the Amazon catalog.
    /// </summary>
    [DataContract]
    public class ItemImage : IEquatable<ItemImage>, IValidatableObject
    {
        /// <summary>
        ///     Variant of the image, such as &#x60;MAIN&#x60; or &#x60;PT01&#x60;.
        /// </summary>
        /// <value>Variant of the image, such as &#x60;MAIN&#x60; or &#x60;PT01&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VariantEnum
        {
            /// <summary>
            ///     Enum MAIN for value: MAIN
            /// </summary>
            [EnumMember(Value = "MAIN")] MAIN = 1,

            /// <summary>
            ///     Enum PT01 for value: PT01
            /// </summary>
            [EnumMember(Value = "PT01")] PT01 = 2,

            /// <summary>
            ///     Enum PT02 for value: PT02
            /// </summary>
            [EnumMember(Value = "PT02")] PT02 = 3,

            /// <summary>
            ///     Enum PT03 for value: PT03
            /// </summary>
            [EnumMember(Value = "PT03")] PT03 = 4,

            /// <summary>
            ///     Enum PT04 for value: PT04
            /// </summary>
            [EnumMember(Value = "PT04")] PT04 = 5,

            /// <summary>
            ///     Enum PT05 for value: PT05
            /// </summary>
            [EnumMember(Value = "PT05")] PT05 = 6,

            /// <summary>
            ///     Enum PT06 for value: PT06
            /// </summary>
            [EnumMember(Value = "PT06")] PT06 = 7,

            /// <summary>
            ///     Enum PT07 for value: PT07
            /// </summary>
            [EnumMember(Value = "PT07")] PT07 = 8,

            /// <summary>
            ///     Enum PT08 for value: PT08
            /// </summary>
            [EnumMember(Value = "PT08")] PT08 = 9,

            /// <summary>
            ///     Enum SWCH for value: SWCH
            /// </summary>
            [EnumMember(Value = "SWCH")] SWCH = 10,

            /// <summary>
            ///     Enum PT09 for value: PT09
            /// </summary>
            [EnumMember(Value = "PT09")] PT09 = 11,

            /// <summary>
            ///     Enum PT10 for value: PT10
            /// </summary>
            [EnumMember(Value = "PT10")] PT10 = 12,

            /// <summary>
            ///     Enum PT11 for value: PT11
            /// </summary>
            [EnumMember(Value = "PT11")] PT11 = 13,

            /// <summary>
            ///     Enum PT12 for value: PT12
            /// </summary>
            [EnumMember(Value = "PT12")] PT12 = 14,

            /// <summary>
            ///     Enum PT13 for value: PT13
            /// </summary>
            [EnumMember(Value = "PT13")] PT13 = 15,

            /// <summary>
            ///     Enum PT14 for value: PT14
            /// </summary>
            [EnumMember(Value = "PT14")] PT14 = 16,

            /// <summary>
            ///     Enum PT15 for value: PT15
            /// </summary>
            [EnumMember(Value = "PT15")] PT15 = 17,

            /// <summary>
            ///     Enum EEGL for value: EEGL
            /// </summary>
            [EnumMember(Value = "EEGL")] EEGL = 18,

            /// <summary>
            ///     Enum EGUS for value: EGUS
            /// </summary>
            [EnumMember(Value = "EGUS")] EGUS = 19
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ItemImage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ItemImage()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ItemImage" /> class.
        /// </summary>
        /// <param name="variant">Variant of the image, such as &#x60;MAIN&#x60; or &#x60;PT01&#x60;. (required).</param>
        /// <param name="link">Link, or URL, for the image. (required).</param>
        /// <param name="height">Height of the image in pixels. (required).</param>
        /// <param name="width">Width of the image in pixels. (required).</param>
        public ItemImage(VariantEnum? variant = default(VariantEnum), string link = default, int? height = default,
            int? width = default)
        {
            // to ensure "variant" is required (not null)
            if (variant == null)
                throw new InvalidDataException("variant is a required property for ItemImage and cannot be null");
            Variant = variant;
            // to ensure "link" is required (not null)
            if (link == null)
                throw new InvalidDataException("link is a required property for ItemImage and cannot be null");
            Link = link;
            // to ensure "height" is required (not null)
            if (height == null)
                throw new InvalidDataException("height is a required property for ItemImage and cannot be null");
            Height = height;
            // to ensure "width" is required (not null)
            if (width == null)
                throw new InvalidDataException("width is a required property for ItemImage and cannot be null");
            Width = width;
        }

        /// <summary>
        ///     Variant of the image, such as &#x60;MAIN&#x60; or &#x60;PT01&#x60;.
        /// </summary>
        /// <value>Variant of the image, such as &#x60;MAIN&#x60; or &#x60;PT01&#x60;.</value>
        [DataMember(Name = "variant", EmitDefaultValue = false)]
        public VariantEnum? Variant { get; set; }


        /// <summary>
        ///     Link, or URL, for the image.
        /// </summary>
        /// <value>Link, or URL, for the image.</value>
        [DataMember(Name = "link", EmitDefaultValue = false)]
        public string Link { get; set; }

        /// <summary>
        ///     Height of the image in pixels.
        /// </summary>
        /// <value>Height of the image in pixels.</value>
        [DataMember(Name = "height", EmitDefaultValue = false)]
        public int? Height { get; set; }

        /// <summary>
        ///     Width of the image in pixels.
        /// </summary>
        /// <value>Width of the image in pixels.</value>
        [DataMember(Name = "width", EmitDefaultValue = false)]
        public int? Width { get; set; }

        /// <summary>
        ///     Returns true if ItemImage instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemImage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemImage input)
        {
            if (input == null)
                return false;

            return
                (
                    Variant == input.Variant ||
                    (Variant != null &&
                     Variant.Equals(input.Variant))
                ) &&
                (
                    Link == input.Link ||
                    (Link != null &&
                     Link.Equals(input.Link))
                ) &&
                (
                    Height == input.Height ||
                    (Height != null &&
                     Height.Equals(input.Height))
                ) &&
                (
                    Width == input.Width ||
                    (Width != null &&
                     Width.Equals(input.Width))
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
            sb.Append("class ItemImage {\n");
            sb.Append("  Variant: ").Append(Variant).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
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
            return Equals(input as ItemImage);
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
                if (Variant != null)
                    hashCode = hashCode * 59 + Variant.GetHashCode();
                if (Link != null)
                    hashCode = hashCode * 59 + Link.GetHashCode();
                if (Height != null)
                    hashCode = hashCode * 59 + Height.GetHashCode();
                if (Width != null)
                    hashCode = hashCode * 59 + Width.GetHashCode();
                return hashCode;
            }
        }
    }
}