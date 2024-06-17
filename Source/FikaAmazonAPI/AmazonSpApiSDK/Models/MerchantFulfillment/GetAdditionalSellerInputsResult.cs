/*
 * Selling Partner API for Merchant Fulfillment
 *
 * The Selling Partner API for Merchant Fulfillment helps you build applications that let sellers purchase shipping for non-Prime and Prime orders using Amazon’s Buy Shipping Services.
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

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.MerchantFulfillment
{
    /// <summary>
    ///     The payload for the getAdditionalSellerInputs operation.
    /// </summary>
    [DataContract]
    public class GetAdditionalSellerInputsResult : IEquatable<GetAdditionalSellerInputsResult>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="GetAdditionalSellerInputsResult" /> class.
        /// </summary>
        /// <param name="shipmentLevelFields">shipmentLevelFields.</param>
        /// <param name="itemLevelFieldsList">itemLevelFieldsList.</param>
        public GetAdditionalSellerInputsResult(AdditionalInputsList shipmentLevelFields = default,
            ItemLevelFieldsList itemLevelFieldsList = default)
        {
            ShipmentLevelFields = shipmentLevelFields;
            ItemLevelFieldsList = itemLevelFieldsList;
        }

        /// <summary>
        ///     Gets or Sets ShipmentLevelFields
        /// </summary>
        [DataMember(Name = "ShipmentLevelFields", EmitDefaultValue = false)]
        public AdditionalInputsList ShipmentLevelFields { get; set; }

        /// <summary>
        ///     Gets or Sets ItemLevelFieldsList
        /// </summary>
        [DataMember(Name = "ItemLevelFieldsList", EmitDefaultValue = false)]
        public ItemLevelFieldsList ItemLevelFieldsList { get; set; }

        /// <summary>
        ///     Returns true if GetAdditionalSellerInputsResult instances are equal
        /// </summary>
        /// <param name="input">Instance of GetAdditionalSellerInputsResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAdditionalSellerInputsResult input)
        {
            if (input == null)
                return false;

            return
                (
                    ShipmentLevelFields == input.ShipmentLevelFields ||
                    (ShipmentLevelFields != null &&
                     ShipmentLevelFields.Equals(input.ShipmentLevelFields))
                ) &&
                (
                    ItemLevelFieldsList == input.ItemLevelFieldsList ||
                    (ItemLevelFieldsList != null &&
                     ItemLevelFieldsList.Equals(input.ItemLevelFieldsList))
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
            sb.Append("class GetAdditionalSellerInputsResult {\n");
            sb.Append("  ShipmentLevelFields: ").Append(ShipmentLevelFields).Append("\n");
            sb.Append("  ItemLevelFieldsList: ").Append(ItemLevelFieldsList).Append("\n");
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
            return Equals(input as GetAdditionalSellerInputsResult);
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
                if (ShipmentLevelFields != null)
                    hashCode = hashCode * 59 + ShipmentLevelFields.GetHashCode();
                if (ItemLevelFieldsList != null)
                    hashCode = hashCode * 59 + ItemLevelFieldsList.GetHashCode();
                return hashCode;
            }
        }
    }
}