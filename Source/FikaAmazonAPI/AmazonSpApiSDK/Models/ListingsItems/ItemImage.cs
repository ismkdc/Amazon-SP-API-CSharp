/*
 * Selling Partner API for Listings Items
 *
 * The Selling Partner API for Listings Items (Listings Items API) provides programmatic access to selling partner listings on Amazon. Use this API in collaboration with the Selling Partner API for Product Type Definitions, which you use to retrieve the information about Amazon product types needed to use the Listings Items API.  For more information, see the [Listings Items API Use Case Guide](doc:listings-items-api-v2021-08-01-use-case-guide).
 *
 * OpenAPI spec version: 2021-08-01
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

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.ListingsItems
{
    /// <summary>
    ///     Image for the listings item.
    /// </summary>
    [DataContract]
    public class ItemImage : IEquatable<ItemImage>, IValidatableObject
    {
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
        /// <param name="link">Link, or URL, for the image. (required).</param>
        /// <param name="height">Height of the image in pixels. (required).</param>
        /// <param name="width">Width of the image in pixels. (required).</param>
        public ItemImage(string link = default, int? height = default, int? width = default)
        {
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