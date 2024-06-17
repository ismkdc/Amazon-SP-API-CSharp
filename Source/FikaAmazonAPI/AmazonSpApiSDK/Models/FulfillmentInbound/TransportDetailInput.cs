/*
 * Selling Partner API for Fulfillment Inbound
 *
 * The Selling Partner API for Fulfillment Inbound lets you create applications that create and update inbound shipments of inventory to Amazon's fulfillment network.
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

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInbound
{
    /// <summary>
    ///     Information required to create an Amazon-partnered carrier shipping estimate, or to alert the Amazon fulfillment
    ///     center to the arrival of an inbound shipment by a non-Amazon-partnered carrier.
    /// </summary>
    [DataContract]
    public class TransportDetailInput : IEquatable<TransportDetailInput>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="TransportDetailInput" /> class.
        /// </summary>
        /// <param name="partneredSmallParcelData">partneredSmallParcelData.</param>
        /// <param name="nonPartneredSmallParcelData">nonPartneredSmallParcelData.</param>
        /// <param name="partneredLtlData">partneredLtlData.</param>
        /// <param name="nonPartneredLtlData">nonPartneredLtlData.</param>
        public TransportDetailInput(PartneredSmallParcelDataInput partneredSmallParcelData = default,
            NonPartneredSmallParcelDataInput nonPartneredSmallParcelData = default,
            PartneredLtlDataInput partneredLtlData = default, NonPartneredLtlDataInput nonPartneredLtlData = default)
        {
            PartneredSmallParcelData = partneredSmallParcelData;
            NonPartneredSmallParcelData = nonPartneredSmallParcelData;
            PartneredLtlData = partneredLtlData;
            NonPartneredLtlData = nonPartneredLtlData;
        }

        /// <summary>
        ///     Gets or Sets PartneredSmallParcelData
        /// </summary>
        [DataMember(Name = "PartneredSmallParcelData", EmitDefaultValue = false)]
        public PartneredSmallParcelDataInput PartneredSmallParcelData { get; set; }

        /// <summary>
        ///     Gets or Sets NonPartneredSmallParcelData
        /// </summary>
        [DataMember(Name = "NonPartneredSmallParcelData", EmitDefaultValue = false)]
        public NonPartneredSmallParcelDataInput NonPartneredSmallParcelData { get; set; }

        /// <summary>
        ///     Gets or Sets PartneredLtlData
        /// </summary>
        [DataMember(Name = "PartneredLtlData", EmitDefaultValue = false)]
        public PartneredLtlDataInput PartneredLtlData { get; set; }

        /// <summary>
        ///     Gets or Sets NonPartneredLtlData
        /// </summary>
        [DataMember(Name = "NonPartneredLtlData", EmitDefaultValue = false)]
        public NonPartneredLtlDataInput NonPartneredLtlData { get; set; }

        /// <summary>
        ///     Returns true if TransportDetailInput instances are equal
        /// </summary>
        /// <param name="input">Instance of TransportDetailInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransportDetailInput input)
        {
            if (input == null)
                return false;

            return
                (
                    PartneredSmallParcelData == input.PartneredSmallParcelData ||
                    (PartneredSmallParcelData != null &&
                     PartneredSmallParcelData.Equals(input.PartneredSmallParcelData))
                ) &&
                (
                    NonPartneredSmallParcelData == input.NonPartneredSmallParcelData ||
                    (NonPartneredSmallParcelData != null &&
                     NonPartneredSmallParcelData.Equals(input.NonPartneredSmallParcelData))
                ) &&
                (
                    PartneredLtlData == input.PartneredLtlData ||
                    (PartneredLtlData != null &&
                     PartneredLtlData.Equals(input.PartneredLtlData))
                ) &&
                (
                    NonPartneredLtlData == input.NonPartneredLtlData ||
                    (NonPartneredLtlData != null &&
                     NonPartneredLtlData.Equals(input.NonPartneredLtlData))
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
            sb.Append("class TransportDetailInput {\n");
            sb.Append("  PartneredSmallParcelData: ").Append(PartneredSmallParcelData).Append("\n");
            sb.Append("  NonPartneredSmallParcelData: ").Append(NonPartneredSmallParcelData).Append("\n");
            sb.Append("  PartneredLtlData: ").Append(PartneredLtlData).Append("\n");
            sb.Append("  NonPartneredLtlData: ").Append(NonPartneredLtlData).Append("\n");
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
            return Equals(input as TransportDetailInput);
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
                if (PartneredSmallParcelData != null)
                    hashCode = hashCode * 59 + PartneredSmallParcelData.GetHashCode();
                if (NonPartneredSmallParcelData != null)
                    hashCode = hashCode * 59 + NonPartneredSmallParcelData.GetHashCode();
                if (PartneredLtlData != null)
                    hashCode = hashCode * 59 + PartneredLtlData.GetHashCode();
                if (NonPartneredLtlData != null)
                    hashCode = hashCode * 59 + NonPartneredLtlData.GetHashCode();
                return hashCode;
            }
        }
    }
}