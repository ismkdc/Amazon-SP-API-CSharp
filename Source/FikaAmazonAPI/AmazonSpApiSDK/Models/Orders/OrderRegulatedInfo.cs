using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Orders
{
    /// <summary>
    ///     The order&#39;s regulated information along with its verification status.
    /// </summary>
    [DataContract]
    public class OrderRegulatedInfo : IEquatable<OrderRegulatedInfo>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="OrderRegulatedInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public OrderRegulatedInfo()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="OrderRegulatedInfo" /> class.
        /// </summary>
        /// <param name="amazonOrderId">An Amazon-defined order identifier, in 3-7-7 format. (required).</param>
        /// <param name="regulatedInformation">
        ///     The regulated information collected during purchase and used to verify the order.
        ///     (required).
        /// </param>
        /// <param name="requiresDosageLabel">
        ///     When true, the order requires attaching a dosage information label when shipped.
        ///     (required).
        /// </param>
        /// <param name="regulatedOrderVerificationStatus">The order&#39;s verification status. (required).</param>
        public OrderRegulatedInfo(string amazonOrderId = default, RegulatedInformation regulatedInformation = default,
            bool? requiresDosageLabel = default,
            RegulatedOrderVerificationStatus regulatedOrderVerificationStatus = default)
        {
            // to ensure "amazonOrderId" is required (not null)
            if (amazonOrderId == null)
                throw new InvalidDataException(
                    "amazonOrderId is a required property for OrderRegulatedInfo and cannot be null");
            AmazonOrderId = amazonOrderId;
            // to ensure "regulatedInformation" is required (not null)
            if (regulatedInformation == null)
                throw new InvalidDataException(
                    "regulatedInformation is a required property for OrderRegulatedInfo and cannot be null");
            RegulatedInformation = regulatedInformation;
            // to ensure "requiresDosageLabel" is required (not null)
            if (requiresDosageLabel == null)
                throw new InvalidDataException(
                    "requiresDosageLabel is a required property for OrderRegulatedInfo and cannot be null");
            RequiresDosageLabel = requiresDosageLabel;
            // to ensure "regulatedOrderVerificationStatus" is required (not null)
            if (regulatedOrderVerificationStatus == null)
                throw new InvalidDataException(
                    "regulatedOrderVerificationStatus is a required property for OrderRegulatedInfo and cannot be null");
            RegulatedOrderVerificationStatus = regulatedOrderVerificationStatus;
        }

        /// <summary>
        ///     An Amazon-defined order identifier, in 3-7-7 format.
        /// </summary>
        /// <value>An Amazon-defined order identifier, in 3-7-7 format.</value>
        [DataMember(Name = "AmazonOrderId", EmitDefaultValue = false)]
        public string AmazonOrderId { get; set; }

        /// <summary>
        ///     The regulated information collected during purchase and used to verify the order.
        /// </summary>
        /// <value>The regulated information collected during purchase and used to verify the order.</value>
        [DataMember(Name = "RegulatedInformation", EmitDefaultValue = false)]
        public RegulatedInformation RegulatedInformation { get; set; }

        /// <summary>
        ///     When true, the order requires attaching a dosage information label when shipped.
        /// </summary>
        /// <value>When true, the order requires attaching a dosage information label when shipped.</value>
        [DataMember(Name = "RequiresDosageLabel", EmitDefaultValue = false)]
        public bool? RequiresDosageLabel { get; set; }

        /// <summary>
        ///     The order&#39;s verification status.
        /// </summary>
        /// <value>The order&#39;s verification status.</value>
        [DataMember(Name = "RegulatedOrderVerificationStatus", EmitDefaultValue = false)]
        public RegulatedOrderVerificationStatus RegulatedOrderVerificationStatus { get; set; }

        /// <summary>
        ///     Returns true if OrderRegulatedInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderRegulatedInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderRegulatedInfo input)
        {
            if (input == null)
                return false;

            return
                (
                    AmazonOrderId == input.AmazonOrderId ||
                    (AmazonOrderId != null &&
                     AmazonOrderId.Equals(input.AmazonOrderId))
                ) &&
                (
                    RegulatedInformation == input.RegulatedInformation ||
                    (RegulatedInformation != null &&
                     RegulatedInformation.Equals(input.RegulatedInformation))
                ) &&
                (
                    RequiresDosageLabel == input.RequiresDosageLabel ||
                    (RequiresDosageLabel != null &&
                     RequiresDosageLabel.Equals(input.RequiresDosageLabel))
                ) &&
                (
                    RegulatedOrderVerificationStatus == input.RegulatedOrderVerificationStatus ||
                    (RegulatedOrderVerificationStatus != null &&
                     RegulatedOrderVerificationStatus.Equals(input.RegulatedOrderVerificationStatus))
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
            sb.Append("class OrderRegulatedInfo {\n");
            sb.Append("  AmazonOrderId: ").Append(AmazonOrderId).Append("\n");
            sb.Append("  RegulatedInformation: ").Append(RegulatedInformation).Append("\n");
            sb.Append("  RequiresDosageLabel: ").Append(RequiresDosageLabel).Append("\n");
            sb.Append("  RegulatedOrderVerificationStatus: ").Append(RegulatedOrderVerificationStatus).Append("\n");
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
            return Equals(input as OrderRegulatedInfo);
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
                if (AmazonOrderId != null)
                    hashCode = hashCode * 59 + AmazonOrderId.GetHashCode();
                if (RegulatedInformation != null)
                    hashCode = hashCode * 59 + RegulatedInformation.GetHashCode();
                if (RequiresDosageLabel != null)
                    hashCode = hashCode * 59 + RequiresDosageLabel.GetHashCode();
                if (RegulatedOrderVerificationStatus != null)
                    hashCode = hashCode * 59 + RegulatedOrderVerificationStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}