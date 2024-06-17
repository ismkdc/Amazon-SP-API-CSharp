/*
 * Selling Partner API for Product Fees
 *
 * The Selling Partner API for Product Fees lets you programmatically retrieve estimated fees for a product. You can then account for those fees in your pricing.
 *
 * OpenAPI spec version: v0
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

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.ProductFees
{
    /// <summary>
    ///     The type of fee, fee amount, and other details.
    /// </summary>
    [DataContract]
    public class FeeDetail : IEquatable<FeeDetail>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="FeeDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public FeeDetail()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="FeeDetail" /> class.
        /// </summary>
        /// <param name="FeeType">The type of fee charged to a seller. (required).</param>
        /// <param name="FeeAmount">The amount charged for a given fee. (required).</param>
        /// <param name="FeePromotion">The promotion amount for a given fee..</param>
        /// <param name="TaxAmount">The tax amount for a given fee..</param>
        /// <param name="FinalFee">The final fee amount for a given fee. (required).</param>
        /// <param name="IncludedFeeDetailList">IncludedFeeDetailList.</param>
        public FeeDetail(string FeeType = default, MoneyType FeeAmount = default, MoneyType FeePromotion = default,
            MoneyType TaxAmount = default, MoneyType FinalFee = default,
            IncludedFeeDetailList IncludedFeeDetailList = default)
        {
            // to ensure "FeeType" is required (not null)
            if (FeeType == null)
                throw new InvalidDataException("FeeType is a required property for FeeDetail and cannot be null");
            this.FeeType = FeeType;
            // to ensure "FeeAmount" is required (not null)
            if (FeeAmount == null)
                throw new InvalidDataException("FeeAmount is a required property for FeeDetail and cannot be null");
            this.FeeAmount = FeeAmount;
            // to ensure "FinalFee" is required (not null)
            if (FinalFee == null)
                throw new InvalidDataException("FinalFee is a required property for FeeDetail and cannot be null");
            this.FinalFee = FinalFee;
            this.FeePromotion = FeePromotion;
            this.TaxAmount = TaxAmount;
            this.IncludedFeeDetailList = IncludedFeeDetailList;
        }

        /// <summary>
        ///     The type of fee charged to a seller.
        /// </summary>
        /// <value>The type of fee charged to a seller.</value>
        [DataMember(Name = "FeeType", EmitDefaultValue = false)]
        public string FeeType { get; set; }

        /// <summary>
        ///     The amount charged for a given fee.
        /// </summary>
        /// <value>The amount charged for a given fee.</value>
        [DataMember(Name = "FeeAmount", EmitDefaultValue = false)]
        public MoneyType FeeAmount { get; set; }

        /// <summary>
        ///     The promotion amount for a given fee.
        /// </summary>
        /// <value>The promotion amount for a given fee.</value>
        [DataMember(Name = "FeePromotion", EmitDefaultValue = false)]
        public MoneyType FeePromotion { get; set; }

        /// <summary>
        ///     The tax amount for a given fee.
        /// </summary>
        /// <value>The tax amount for a given fee.</value>
        [DataMember(Name = "TaxAmount", EmitDefaultValue = false)]
        public MoneyType TaxAmount { get; set; }

        /// <summary>
        ///     The final fee amount for a given fee.
        /// </summary>
        /// <value>The final fee amount for a given fee.</value>
        [DataMember(Name = "FinalFee", EmitDefaultValue = false)]
        public MoneyType FinalFee { get; set; }

        /// <summary>
        ///     Gets or Sets IncludedFeeDetailList
        /// </summary>
        [DataMember(Name = "IncludedFeeDetailList", EmitDefaultValue = false)]
        public IncludedFeeDetailList IncludedFeeDetailList { get; set; }

        /// <summary>
        ///     Returns true if FeeDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of FeeDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeeDetail input)
        {
            if (input == null)
                return false;

            return
                (
                    FeeType == input.FeeType ||
                    (FeeType != null &&
                     FeeType.Equals(input.FeeType))
                ) &&
                (
                    FeeAmount == input.FeeAmount ||
                    (FeeAmount != null &&
                     FeeAmount.Equals(input.FeeAmount))
                ) &&
                (
                    FeePromotion == input.FeePromotion ||
                    (FeePromotion != null &&
                     FeePromotion.Equals(input.FeePromotion))
                ) &&
                (
                    TaxAmount == input.TaxAmount ||
                    (TaxAmount != null &&
                     TaxAmount.Equals(input.TaxAmount))
                ) &&
                (
                    FinalFee == input.FinalFee ||
                    (FinalFee != null &&
                     FinalFee.Equals(input.FinalFee))
                ) &&
                (
                    IncludedFeeDetailList == input.IncludedFeeDetailList ||
                    (IncludedFeeDetailList != null &&
                     IncludedFeeDetailList.Equals(input.IncludedFeeDetailList))
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
            sb.Append("class FeeDetail {\n");
            sb.Append("  FeeType: ").Append(FeeType).Append("\n");
            sb.Append("  FeeAmount: ").Append(FeeAmount).Append("\n");
            sb.Append("  FeePromotion: ").Append(FeePromotion).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  FinalFee: ").Append(FinalFee).Append("\n");
            sb.Append("  IncludedFeeDetailList: ").Append(IncludedFeeDetailList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return Equals(input as FeeDetail);
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
                if (FeeType != null)
                    hashCode = hashCode * 59 + FeeType.GetHashCode();
                if (FeeAmount != null)
                    hashCode = hashCode * 59 + FeeAmount.GetHashCode();
                if (FeePromotion != null)
                    hashCode = hashCode * 59 + FeePromotion.GetHashCode();
                if (TaxAmount != null)
                    hashCode = hashCode * 59 + TaxAmount.GetHashCode();
                if (FinalFee != null)
                    hashCode = hashCode * 59 + FinalFee.GetHashCode();
                if (IncludedFeeDetailList != null)
                    hashCode = hashCode * 59 + IncludedFeeDetailList.GetHashCode();
                return hashCode;
            }
        }
    }
}