/* 
 * Selling Partner API for Fulfillment Outbound
 *
 * The Selling Partner API for Fulfillment Outbound lets you create applications that help a seller fulfill Multi-Channel Fulfillment orders using their inventory in Amazon's fulfillment network. You can get information on both potential and existing fulfillment orders.
 *
 * OpenAPI spec version: v0
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

namespace AmazonSpApiSDK.Models.FulfillmentOutbound
{
    /// <summary>
    /// An item that is invalid for return.
    /// </summary>
    [DataContract]
    public partial class InvalidReturnItem : IEquatable<InvalidReturnItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidReturnItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InvalidReturnItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidReturnItem" /> class.
        /// </summary>
        /// <param name="SellerReturnItemId">An identifier assigned by the seller to the return item. (required).</param>
        /// <param name="SellerFulfillmentOrderItemId">The identifier assigned to the item by the seller when the fulfillment order was created. (required).</param>
        /// <param name="InvalidItemReason">InvalidItemReason (required).</param>
        public InvalidReturnItem(string SellerReturnItemId = default(string), string SellerFulfillmentOrderItemId = default(string), InvalidItemReason InvalidItemReason = default(InvalidItemReason))
        {
            // to ensure "SellerReturnItemId" is required (not null)
            if (SellerReturnItemId == null)
            {
                throw new InvalidDataException("SellerReturnItemId is a required property for InvalidReturnItem and cannot be null");
            }
            else
            {
                this.SellerReturnItemId = SellerReturnItemId;
            }
            // to ensure "SellerFulfillmentOrderItemId" is required (not null)
            if (SellerFulfillmentOrderItemId == null)
            {
                throw new InvalidDataException("SellerFulfillmentOrderItemId is a required property for InvalidReturnItem and cannot be null");
            }
            else
            {
                this.SellerFulfillmentOrderItemId = SellerFulfillmentOrderItemId;
            }
            // to ensure "InvalidItemReason" is required (not null)
            if (InvalidItemReason == null)
            {
                throw new InvalidDataException("InvalidItemReason is a required property for InvalidReturnItem and cannot be null");
            }
            else
            {
                this.InvalidItemReason = InvalidItemReason;
            }
        }

        /// <summary>
        /// An identifier assigned by the seller to the return item.
        /// </summary>
        /// <value>An identifier assigned by the seller to the return item.</value>
        [DataMember(Name = "SellerReturnItemId", EmitDefaultValue = false)]
        public string SellerReturnItemId { get; set; }

        /// <summary>
        /// The identifier assigned to the item by the seller when the fulfillment order was created.
        /// </summary>
        /// <value>The identifier assigned to the item by the seller when the fulfillment order was created.</value>
        [DataMember(Name = "SellerFulfillmentOrderItemId", EmitDefaultValue = false)]
        public string SellerFulfillmentOrderItemId { get; set; }

        /// <summary>
        /// Gets or Sets InvalidItemReason
        /// </summary>
        [DataMember(Name = "InvalidItemReason", EmitDefaultValue = false)]
        public InvalidItemReason InvalidItemReason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvalidReturnItem {\n");
            sb.Append("  SellerReturnItemId: ").Append(SellerReturnItemId).Append("\n");
            sb.Append("  SellerFulfillmentOrderItemId: ").Append(SellerFulfillmentOrderItemId).Append("\n");
            sb.Append("  InvalidItemReason: ").Append(InvalidItemReason).Append("\n");
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
            return this.Equals(input as InvalidReturnItem);
        }

        /// <summary>
        /// Returns true if InvalidReturnItem instances are equal
        /// </summary>
        /// <param name="input">Instance of InvalidReturnItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvalidReturnItem input)
        {
            if (input == null)
                return false;

            return
                (
                    this.SellerReturnItemId == input.SellerReturnItemId ||
                    (this.SellerReturnItemId != null &&
                    this.SellerReturnItemId.Equals(input.SellerReturnItemId))
                ) &&
                (
                    this.SellerFulfillmentOrderItemId == input.SellerFulfillmentOrderItemId ||
                    (this.SellerFulfillmentOrderItemId != null &&
                    this.SellerFulfillmentOrderItemId.Equals(input.SellerFulfillmentOrderItemId))
                ) &&
                (
                    this.InvalidItemReason == input.InvalidItemReason ||
                    (this.InvalidItemReason != null &&
                    this.InvalidItemReason.Equals(input.InvalidItemReason))
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
                if (this.SellerReturnItemId != null)
                    hashCode = hashCode * 59 + this.SellerReturnItemId.GetHashCode();
                if (this.SellerFulfillmentOrderItemId != null)
                    hashCode = hashCode * 59 + this.SellerFulfillmentOrderItemId.GetHashCode();
                if (this.InvalidItemReason != null)
                    hashCode = hashCode * 59 + this.InvalidItemReason.GetHashCode();
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
