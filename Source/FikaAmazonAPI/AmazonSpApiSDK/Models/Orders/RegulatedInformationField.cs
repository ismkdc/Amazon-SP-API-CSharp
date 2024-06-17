using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Orders
{
    /// <summary>
    ///     A field collected from the regulatory form.
    /// </summary>
    [DataContract]
    public class RegulatedInformationField : IEquatable<RegulatedInformationField>, IValidatableObject
    {
        /// <summary>
        ///     The type of field.
        /// </summary>
        /// <value>The type of field.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FieldTypeEnum
        {
            /// <summary>
            ///     Enum Text for value: Text
            /// </summary>
            [EnumMember(Value = "Text")] Text = 1,

            /// <summary>
            ///     Enum FileAttachment for value: FileAttachment
            /// </summary>
            [EnumMember(Value = "FileAttachment")] FileAttachment = 2
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="RegulatedInformationField" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public RegulatedInformationField()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="RegulatedInformationField" /> class.
        /// </summary>
        /// <param name="fieldId">The unique identifier for the field. (required).</param>
        /// <param name="fieldLabel">The name for the field. (required).</param>
        /// <param name="fieldType">The type of field. (required).</param>
        /// <param name="fieldValue">
        ///     The content of the field as collected in regulatory form. Note that FileAttachment type fields
        ///     will contain a URL to download the attachment here. (required).
        /// </param>
        public RegulatedInformationField(string fieldId = default, string fieldLabel = default,
            FieldTypeEnum fieldType = default, string fieldValue = default)
        {
            // to ensure "fieldId" is required (not null)
            if (fieldId == null)
                throw new InvalidDataException(
                    "fieldId is a required property for RegulatedInformationField and cannot be null");
            FieldId = fieldId;
            // to ensure "fieldLabel" is required (not null)
            if (fieldLabel == null)
                throw new InvalidDataException(
                    "fieldLabel is a required property for RegulatedInformationField and cannot be null");
            FieldLabel = fieldLabel;
            // to ensure "fieldType" is required (not null)
            if (fieldType == null)
                throw new InvalidDataException(
                    "fieldType is a required property for RegulatedInformationField and cannot be null");
            FieldType = fieldType;
            // to ensure "fieldValue" is required (not null)
            if (fieldValue == null)
                throw new InvalidDataException(
                    "fieldValue is a required property for RegulatedInformationField and cannot be null");
            FieldValue = fieldValue;
        }

        /// <summary>
        ///     The type of field.
        /// </summary>
        /// <value>The type of field.</value>
        [DataMember(Name = "FieldType", EmitDefaultValue = false)]
        public FieldTypeEnum FieldType { get; set; }

        /// <summary>
        ///     The unique identifier for the field.
        /// </summary>
        /// <value>The unique identifier for the field.</value>
        [DataMember(Name = "FieldId", EmitDefaultValue = false)]
        public string FieldId { get; set; }

        /// <summary>
        ///     The name for the field.
        /// </summary>
        /// <value>The name for the field.</value>
        [DataMember(Name = "FieldLabel", EmitDefaultValue = false)]
        public string FieldLabel { get; set; }


        /// <summary>
        ///     The content of the field as collected in regulatory form. Note that FileAttachment type fields will contain a URL
        ///     to download the attachment here.
        /// </summary>
        /// <value>
        ///     The content of the field as collected in regulatory form. Note that FileAttachment type fields will contain a
        ///     URL to download the attachment here.
        /// </value>
        [DataMember(Name = "FieldValue", EmitDefaultValue = false)]
        public string FieldValue { get; set; }

        /// <summary>
        ///     Returns true if RegulatedInformationField instances are equal
        /// </summary>
        /// <param name="input">Instance of RegulatedInformationField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegulatedInformationField input)
        {
            if (input == null)
                return false;

            return
                (
                    FieldId == input.FieldId ||
                    (FieldId != null &&
                     FieldId.Equals(input.FieldId))
                ) &&
                (
                    FieldLabel == input.FieldLabel ||
                    (FieldLabel != null &&
                     FieldLabel.Equals(input.FieldLabel))
                ) &&
                (
                    FieldType == input.FieldType ||
                    (FieldType != null &&
                     FieldType.Equals(input.FieldType))
                ) &&
                (
                    FieldValue == input.FieldValue ||
                    (FieldValue != null &&
                     FieldValue.Equals(input.FieldValue))
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
            sb.Append("class RegulatedInformationField {\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
            sb.Append("  FieldLabel: ").Append(FieldLabel).Append("\n");
            sb.Append("  FieldType: ").Append(FieldType).Append("\n");
            sb.Append("  FieldValue: ").Append(FieldValue).Append("\n");
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
            return Equals(input as RegulatedInformationField);
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
                if (FieldId != null)
                    hashCode = hashCode * 59 + FieldId.GetHashCode();
                if (FieldLabel != null)
                    hashCode = hashCode * 59 + FieldLabel.GetHashCode();
                if (FieldType != null)
                    hashCode = hashCode * 59 + FieldType.GetHashCode();
                if (FieldValue != null)
                    hashCode = hashCode * 59 + FieldValue.GetHashCode();
                return hashCode;
            }
        }
    }
}