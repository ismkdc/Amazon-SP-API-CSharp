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
    /// The COD (Cash On Delivery) charges that you associate with a COD fulfillment order.
    /// </summary>
    [DataContract]
    public partial class CODSettings : IEquatable<CODSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CODSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CODSettings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CODSettings" /> class.
        /// </summary>
        /// <param name="IsCODRequired">Indicates whether this fulfillment order requires COD (Cash On Delivery) payment. (required).</param>
        /// <param name="CODCharge">The amount of the COD charge to be collected from the recipient for a COD order..</param>
        /// <param name="CODChargeTax">The amount of the tax on the COD charge to be collected from the recipient for a COD order..</param>
        /// <param name="ShippingCharge">The amount of the tax on the COD charge to be collected from the recipient for a COD order..</param>
        /// <param name="ShippingChargeTax">The amount of the tax on the shipping charge to be collected from the recipient for a COD order..</param>
        public CODSettings(bool? IsCODRequired = default(bool?), Currency CODCharge = default(Currency), Currency CODChargeTax = default(Currency), Currency ShippingCharge = default(Currency), Currency ShippingChargeTax = default(Currency))
        {
            // to ensure "IsCODRequired" is required (not null)
            if (IsCODRequired == null)
            {
                throw new InvalidDataException("IsCODRequired is a required property for CODSettings and cannot be null");
            }
            else
            {
                this.IsCODRequired = IsCODRequired;
            }
            this.CODCharge = CODCharge;
            this.CODChargeTax = CODChargeTax;
            this.ShippingCharge = ShippingCharge;
            this.ShippingChargeTax = ShippingChargeTax;
        }

        /// <summary>
        /// Indicates whether this fulfillment order requires COD (Cash On Delivery) payment.
        /// </summary>
        /// <value>Indicates whether this fulfillment order requires COD (Cash On Delivery) payment.</value>
        [DataMember(Name = "IsCODRequired", EmitDefaultValue = false)]
        public bool? IsCODRequired { get; set; }

        /// <summary>
        /// The amount of the COD charge to be collected from the recipient for a COD order.
        /// </summary>
        /// <value>The amount of the COD charge to be collected from the recipient for a COD order.</value>
        [DataMember(Name = "CODCharge", EmitDefaultValue = false)]
        public Currency CODCharge { get; set; }

        /// <summary>
        /// The amount of the tax on the COD charge to be collected from the recipient for a COD order.
        /// </summary>
        /// <value>The amount of the tax on the COD charge to be collected from the recipient for a COD order.</value>
        [DataMember(Name = "CODChargeTax", EmitDefaultValue = false)]
        public Currency CODChargeTax { get; set; }

        /// <summary>
        /// The amount of the tax on the COD charge to be collected from the recipient for a COD order.
        /// </summary>
        /// <value>The amount of the tax on the COD charge to be collected from the recipient for a COD order.</value>
        [DataMember(Name = "ShippingCharge", EmitDefaultValue = false)]
        public Currency ShippingCharge { get; set; }

        /// <summary>
        /// The amount of the tax on the shipping charge to be collected from the recipient for a COD order.
        /// </summary>
        /// <value>The amount of the tax on the shipping charge to be collected from the recipient for a COD order.</value>
        [DataMember(Name = "ShippingChargeTax", EmitDefaultValue = false)]
        public Currency ShippingChargeTax { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CODSettings {\n");
            sb.Append("  IsCODRequired: ").Append(IsCODRequired).Append("\n");
            sb.Append("  CODCharge: ").Append(CODCharge).Append("\n");
            sb.Append("  CODChargeTax: ").Append(CODChargeTax).Append("\n");
            sb.Append("  ShippingCharge: ").Append(ShippingCharge).Append("\n");
            sb.Append("  ShippingChargeTax: ").Append(ShippingChargeTax).Append("\n");
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
            return this.Equals(input as CODSettings);
        }

        /// <summary>
        /// Returns true if CODSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of CODSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CODSettings input)
        {
            if (input == null)
                return false;

            return
                (
                    this.IsCODRequired == input.IsCODRequired ||
                    (this.IsCODRequired != null &&
                    this.IsCODRequired.Equals(input.IsCODRequired))
                ) &&
                (
                    this.CODCharge == input.CODCharge ||
                    (this.CODCharge != null &&
                    this.CODCharge.Equals(input.CODCharge))
                ) &&
                (
                    this.CODChargeTax == input.CODChargeTax ||
                    (this.CODChargeTax != null &&
                    this.CODChargeTax.Equals(input.CODChargeTax))
                ) &&
                (
                    this.ShippingCharge == input.ShippingCharge ||
                    (this.ShippingCharge != null &&
                    this.ShippingCharge.Equals(input.ShippingCharge))
                ) &&
                (
                    this.ShippingChargeTax == input.ShippingChargeTax ||
                    (this.ShippingChargeTax != null &&
                    this.ShippingChargeTax.Equals(input.ShippingChargeTax))
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
                if (this.IsCODRequired != null)
                    hashCode = hashCode * 59 + this.IsCODRequired.GetHashCode();
                if (this.CODCharge != null)
                    hashCode = hashCode * 59 + this.CODCharge.GetHashCode();
                if (this.CODChargeTax != null)
                    hashCode = hashCode * 59 + this.CODChargeTax.GetHashCode();
                if (this.ShippingCharge != null)
                    hashCode = hashCode * 59 + this.ShippingCharge.GetHashCode();
                if (this.ShippingChargeTax != null)
                    hashCode = hashCode * 59 + this.ShippingChargeTax.GetHashCode();
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
