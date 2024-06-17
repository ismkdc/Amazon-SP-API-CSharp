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
    ///     Custom text for shipping labels.
    /// </summary>
    [DataContract]
    public class LabelCustomization : IEquatable<LabelCustomization>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="LabelCustomization" /> class.
        /// </summary>
        /// <param name="customTextForLabel">customTextForLabel.</param>
        /// <param name="standardIdForLabel">standardIdForLabel.</param>
        public LabelCustomization(string customTextForLabel = default, StandardIdForLabel? standardIdForLabel = default)
        {
            CustomTextForLabel = customTextForLabel;
            StandardIdForLabel = standardIdForLabel;
        }

        /// <summary>
        ///     Gets or Sets StandardIdForLabel
        /// </summary>
        [DataMember(Name = "StandardIdForLabel", EmitDefaultValue = false)]
        public StandardIdForLabel? StandardIdForLabel { get; set; }

        /// <summary>
        ///     Gets or Sets CustomTextForLabel
        /// </summary>
        [DataMember(Name = "CustomTextForLabel", EmitDefaultValue = false)]
        public string CustomTextForLabel { get; set; }

        /// <summary>
        ///     Returns true if LabelCustomization instances are equal
        /// </summary>
        /// <param name="input">Instance of LabelCustomization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LabelCustomization input)
        {
            if (input == null)
                return false;

            return
                (
                    CustomTextForLabel == input.CustomTextForLabel ||
                    (CustomTextForLabel != null &&
                     CustomTextForLabel.Equals(input.CustomTextForLabel))
                ) &&
                (
                    StandardIdForLabel == input.StandardIdForLabel ||
                    (StandardIdForLabel != null &&
                     StandardIdForLabel.Equals(input.StandardIdForLabel))
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
            sb.Append("class LabelCustomization {\n");
            sb.Append("  CustomTextForLabel: ").Append(CustomTextForLabel).Append("\n");
            sb.Append("  StandardIdForLabel: ").Append(StandardIdForLabel).Append("\n");
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
            return Equals(input as LabelCustomization);
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
                if (CustomTextForLabel != null)
                    hashCode = hashCode * 59 + CustomTextForLabel.GetHashCode();
                if (StandardIdForLabel != null)
                    hashCode = hashCode * 59 + StandardIdForLabel.GetHashCode();
                return hashCode;
            }
        }
    }
}