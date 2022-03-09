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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;


namespace FikaAmazonAPI.AmazonSpApiSDK.Models.MerchantFulfillment
{
    /// <summary>
    /// Specifies characteristics that apply to a seller input.
    /// </summary>
    [DataContract]
    public partial class SellerInputDefinition :  IEquatable<SellerInputDefinition>, IValidatableObject
    {
        /// <summary>
        /// Whether the seller input applies to the item or the shipment.
        /// </summary>
        /// <value>Whether the seller input applies to the item or the shipment.</value>
        [DataMember(Name="InputTarget", EmitDefaultValue=false)]
        public InputTargetType? InputTarget { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SellerInputDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public SellerInputDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SellerInputDefinition" /> class.
        /// </summary>
        /// <param name="isRequired">When true, the additional input field is required. (required).</param>
        /// <param name="dataType">The data type of the additional input field. (required).</param>
        /// <param name="constraints">constraints (required).</param>
        /// <param name="inputDisplayText">The display text for the additional input field. (required).</param>
        /// <param name="inputTarget">Whether the seller input applies to the item or the shipment..</param>
        /// <param name="storedValue">storedValue (required).</param>
        /// <param name="restrictedSetValues">restrictedSetValues.</param>
        public SellerInputDefinition(bool? isRequired = default(bool?), string dataType = default(string), Constraints constraints = default(Constraints), string inputDisplayText = default(string), InputTargetType? inputTarget = default(InputTargetType?), AdditionalSellerInput storedValue = default(AdditionalSellerInput), RestrictedSetValues restrictedSetValues = default(RestrictedSetValues))
        {
            // to ensure "isRequired" is required (not null)
            if (isRequired == null)
            {
                throw new InvalidDataException("isRequired is a required property for SellerInputDefinition and cannot be null");
            }
            else
            {
                this.IsRequired = isRequired;
            }
            // to ensure "dataType" is required (not null)
            if (dataType == null)
            {
                throw new InvalidDataException("dataType is a required property for SellerInputDefinition and cannot be null");
            }
            else
            {
                this.DataType = dataType;
            }
            // to ensure "constraints" is required (not null)
            if (constraints == null)
            {
                throw new InvalidDataException("constraints is a required property for SellerInputDefinition and cannot be null");
            }
            else
            {
                this.Constraints = constraints;
            }
            // to ensure "inputDisplayText" is required (not null)
            if (inputDisplayText == null)
            {
                throw new InvalidDataException("inputDisplayText is a required property for SellerInputDefinition and cannot be null");
            }
            else
            {
                this.InputDisplayText = inputDisplayText;
            }
            // to ensure "storedValue" is required (not null)
            if (storedValue == null)
            {
                throw new InvalidDataException("storedValue is a required property for SellerInputDefinition and cannot be null");
            }
            else
            {
                this.StoredValue = storedValue;
            }
            this.InputTarget = inputTarget;
            this.RestrictedSetValues = restrictedSetValues;
        }
        
        /// <summary>
        /// When true, the additional input field is required.
        /// </summary>
        /// <value>When true, the additional input field is required.</value>
        [DataMember(Name="IsRequired", EmitDefaultValue=false)]
        public bool? IsRequired { get; set; }

        /// <summary>
        /// The data type of the additional input field.
        /// </summary>
        /// <value>The data type of the additional input field.</value>
        [DataMember(Name="DataType", EmitDefaultValue=false)]
        public string DataType { get; set; }

        /// <summary>
        /// Gets or Sets Constraints
        /// </summary>
        [DataMember(Name="Constraints", EmitDefaultValue=false)]
        public Constraints Constraints { get; set; }

        /// <summary>
        /// The display text for the additional input field.
        /// </summary>
        /// <value>The display text for the additional input field.</value>
        [DataMember(Name="InputDisplayText", EmitDefaultValue=false)]
        public string InputDisplayText { get; set; }


        /// <summary>
        /// Gets or Sets StoredValue
        /// </summary>
        [DataMember(Name="StoredValue", EmitDefaultValue=false)]
        public AdditionalSellerInput StoredValue { get; set; }

        /// <summary>
        /// Gets or Sets RestrictedSetValues
        /// </summary>
        [DataMember(Name="RestrictedSetValues", EmitDefaultValue=false)]
        public RestrictedSetValues RestrictedSetValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SellerInputDefinition {\n");
            sb.Append("  IsRequired: ").Append(IsRequired).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  Constraints: ").Append(Constraints).Append("\n");
            sb.Append("  InputDisplayText: ").Append(InputDisplayText).Append("\n");
            sb.Append("  InputTarget: ").Append(InputTarget).Append("\n");
            sb.Append("  StoredValue: ").Append(StoredValue).Append("\n");
            sb.Append("  RestrictedSetValues: ").Append(RestrictedSetValues).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as SellerInputDefinition);
        }

        /// <summary>
        /// Returns true if SellerInputDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of SellerInputDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SellerInputDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsRequired == input.IsRequired ||
                    (this.IsRequired != null &&
                    this.IsRequired.Equals(input.IsRequired))
                ) && 
                (
                    this.DataType == input.DataType ||
                    (this.DataType != null &&
                    this.DataType.Equals(input.DataType))
                ) && 
                (
                    this.Constraints == input.Constraints ||
                    (this.Constraints != null &&
                    this.Constraints.Equals(input.Constraints))
                ) && 
                (
                    this.InputDisplayText == input.InputDisplayText ||
                    (this.InputDisplayText != null &&
                    this.InputDisplayText.Equals(input.InputDisplayText))
                ) && 
                (
                    this.InputTarget == input.InputTarget ||
                    (this.InputTarget != null &&
                    this.InputTarget.Equals(input.InputTarget))
                ) && 
                (
                    this.StoredValue == input.StoredValue ||
                    (this.StoredValue != null &&
                    this.StoredValue.Equals(input.StoredValue))
                ) && 
                (
                    this.RestrictedSetValues == input.RestrictedSetValues ||
                    (this.RestrictedSetValues != null &&
                    this.RestrictedSetValues.Equals(input.RestrictedSetValues))
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
                if (this.IsRequired != null)
                    hashCode = hashCode * 59 + this.IsRequired.GetHashCode();
                if (this.DataType != null)
                    hashCode = hashCode * 59 + this.DataType.GetHashCode();
                if (this.Constraints != null)
                    hashCode = hashCode * 59 + this.Constraints.GetHashCode();
                if (this.InputDisplayText != null)
                    hashCode = hashCode * 59 + this.InputDisplayText.GetHashCode();
                if (this.InputTarget != null)
                    hashCode = hashCode * 59 + this.InputTarget.GetHashCode();
                if (this.StoredValue != null)
                    hashCode = hashCode * 59 + this.StoredValue.GetHashCode();
                if (this.RestrictedSetValues != null)
                    hashCode = hashCode * 59 + this.RestrictedSetValues.GetHashCode();
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
