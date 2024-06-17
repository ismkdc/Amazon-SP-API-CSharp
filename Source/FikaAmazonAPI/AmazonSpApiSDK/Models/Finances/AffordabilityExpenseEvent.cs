/*
 * Selling Partner API for Finances
 *
 * The Selling Partner API for Finances helps you obtain financial information relevant to a seller's business. You can obtain financial events for a given order, financial event group, or date range without having to wait until a statement period closes. You can also obtain financial event groups for a given date range.
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

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Finances
{
    /// <summary>
    ///     An expense related to an affordability promotion.
    /// </summary>
    [DataContract]
    public class AffordabilityExpenseEvent : IEquatable<AffordabilityExpenseEvent>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="AffordabilityExpenseEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public AffordabilityExpenseEvent()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="AffordabilityExpenseEvent" /> class.
        /// </summary>
        /// <param name="AmazonOrderId">An Amazon-defined identifier for an order..</param>
        /// <param name="PostedDate">The date and time when the financial event was created..</param>
        /// <param name="MarketplaceId">An encrypted, Amazon-defined marketplace identifier..</param>
        /// <param name="TransactionType">
        ///     Indicates the type of transaction.   Possible values:  * Charge - For an affordability
        ///     promotion expense.  * Refund - For an affordability promotion expense reversal..
        /// </param>
        /// <param name="BaseExpense">The amount charged for clicks incurred under the Sponsored Products program..</param>
        /// <param name="TaxTypeCGST">Central Goods and Service Tax, charged and collected by the central government. (required).</param>
        /// <param name="TaxTypeSGST">State Goods and Service Tax, charged and collected by the state government. (required).</param>
        /// <param name="TaxTypeIGST">
        ///     Integrated Goods and Service Tax, charged and collected by the central government.
        ///     (required).
        /// </param>
        /// <param name="TotalExpense">
        ///     The total amount charged to the seller. TotalExpense &#x3D; BaseExpense + TaxTypeIGST +
        ///     TaxTypeCGST + TaxTypeSGST..
        /// </param>
        public AffordabilityExpenseEvent(string AmazonOrderId = default, DateTime? PostedDate = default,
            string MarketplaceId = default, string TransactionType = default, Currency BaseExpense = default,
            Currency TaxTypeCGST = default, Currency TaxTypeSGST = default, Currency TaxTypeIGST = default,
            Currency TotalExpense = default)
        {
            // to ensure "TaxTypeCGST" is required (not null)
            if (TaxTypeCGST == null)
                throw new InvalidDataException(
                    "TaxTypeCGST is a required property for AffordabilityExpenseEvent and cannot be null");
            this.TaxTypeCGST = TaxTypeCGST;
            // to ensure "TaxTypeSGST" is required (not null)
            if (TaxTypeSGST == null)
                throw new InvalidDataException(
                    "TaxTypeSGST is a required property for AffordabilityExpenseEvent and cannot be null");
            this.TaxTypeSGST = TaxTypeSGST;
            // to ensure "TaxTypeIGST" is required (not null)
            if (TaxTypeIGST == null)
                throw new InvalidDataException(
                    "TaxTypeIGST is a required property for AffordabilityExpenseEvent and cannot be null");
            this.TaxTypeIGST = TaxTypeIGST;
            this.AmazonOrderId = AmazonOrderId;
            this.PostedDate = PostedDate;
            this.MarketplaceId = MarketplaceId;
            this.TransactionType = TransactionType;
            this.BaseExpense = BaseExpense;
            this.TotalExpense = TotalExpense;
        }

        /// <summary>
        ///     An Amazon-defined identifier for an order.
        /// </summary>
        /// <value>An Amazon-defined identifier for an order.</value>
        [DataMember(Name = "AmazonOrderId", EmitDefaultValue = false)]
        public string AmazonOrderId { get; set; }

        /// <summary>
        ///     The date and time when the financial event was created.
        /// </summary>
        /// <value>The date and time when the financial event was created.</value>
        [DataMember(Name = "PostedDate", EmitDefaultValue = false)]
        public DateTime? PostedDate { get; set; }

        /// <summary>
        ///     An encrypted, Amazon-defined marketplace identifier.
        /// </summary>
        /// <value>An encrypted, Amazon-defined marketplace identifier.</value>
        [DataMember(Name = "MarketplaceId", EmitDefaultValue = false)]
        public string MarketplaceId { get; set; }

        /// <summary>
        ///     Indicates the type of transaction.   Possible values:  * Charge - For an affordability promotion expense.  * Refund
        ///     - For an affordability promotion expense reversal.
        /// </summary>
        /// <value>
        ///     Indicates the type of transaction.   Possible values:  * Charge - For an affordability promotion expense.  *
        ///     Refund - For an affordability promotion expense reversal.
        /// </value>
        [DataMember(Name = "TransactionType", EmitDefaultValue = false)]
        public string TransactionType { get; set; }

        /// <summary>
        ///     The amount charged for clicks incurred under the Sponsored Products program.
        /// </summary>
        /// <value>The amount charged for clicks incurred under the Sponsored Products program.</value>
        [DataMember(Name = "BaseExpense", EmitDefaultValue = false)]
        public Currency BaseExpense { get; set; }

        /// <summary>
        ///     Central Goods and Service Tax, charged and collected by the central government.
        /// </summary>
        /// <value>Central Goods and Service Tax, charged and collected by the central government.</value>
        [DataMember(Name = "TaxTypeCGST", EmitDefaultValue = false)]
        public Currency TaxTypeCGST { get; set; }

        /// <summary>
        ///     State Goods and Service Tax, charged and collected by the state government.
        /// </summary>
        /// <value>State Goods and Service Tax, charged and collected by the state government.</value>
        [DataMember(Name = "TaxTypeSGST", EmitDefaultValue = false)]
        public Currency TaxTypeSGST { get; set; }

        /// <summary>
        ///     Integrated Goods and Service Tax, charged and collected by the central government.
        /// </summary>
        /// <value>Integrated Goods and Service Tax, charged and collected by the central government.</value>
        [DataMember(Name = "TaxTypeIGST", EmitDefaultValue = false)]
        public Currency TaxTypeIGST { get; set; }

        /// <summary>
        ///     The total amount charged to the seller. TotalExpense &#x3D; BaseExpense + TaxTypeIGST + TaxTypeCGST + TaxTypeSGST.
        /// </summary>
        /// <value>
        ///     The total amount charged to the seller. TotalExpense &#x3D; BaseExpense + TaxTypeIGST + TaxTypeCGST +
        ///     TaxTypeSGST.
        /// </value>
        [DataMember(Name = "TotalExpense", EmitDefaultValue = false)]
        public Currency TotalExpense { get; set; }

        /// <summary>
        ///     Returns true if AffordabilityExpenseEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of AffordabilityExpenseEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AffordabilityExpenseEvent input)
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
                    PostedDate == input.PostedDate ||
                    (PostedDate != null &&
                     PostedDate.Equals(input.PostedDate))
                ) &&
                (
                    MarketplaceId == input.MarketplaceId ||
                    (MarketplaceId != null &&
                     MarketplaceId.Equals(input.MarketplaceId))
                ) &&
                (
                    TransactionType == input.TransactionType ||
                    (TransactionType != null &&
                     TransactionType.Equals(input.TransactionType))
                ) &&
                (
                    BaseExpense == input.BaseExpense ||
                    (BaseExpense != null &&
                     BaseExpense.Equals(input.BaseExpense))
                ) &&
                (
                    TaxTypeCGST == input.TaxTypeCGST ||
                    (TaxTypeCGST != null &&
                     TaxTypeCGST.Equals(input.TaxTypeCGST))
                ) &&
                (
                    TaxTypeSGST == input.TaxTypeSGST ||
                    (TaxTypeSGST != null &&
                     TaxTypeSGST.Equals(input.TaxTypeSGST))
                ) &&
                (
                    TaxTypeIGST == input.TaxTypeIGST ||
                    (TaxTypeIGST != null &&
                     TaxTypeIGST.Equals(input.TaxTypeIGST))
                ) &&
                (
                    TotalExpense == input.TotalExpense ||
                    (TotalExpense != null &&
                     TotalExpense.Equals(input.TotalExpense))
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
            sb.Append("class AffordabilityExpenseEvent {\n");
            sb.Append("  AmazonOrderId: ").Append(AmazonOrderId).Append("\n");
            sb.Append("  PostedDate: ").Append(PostedDate).Append("\n");
            sb.Append("  MarketplaceId: ").Append(MarketplaceId).Append("\n");
            sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
            sb.Append("  BaseExpense: ").Append(BaseExpense).Append("\n");
            sb.Append("  TaxTypeCGST: ").Append(TaxTypeCGST).Append("\n");
            sb.Append("  TaxTypeSGST: ").Append(TaxTypeSGST).Append("\n");
            sb.Append("  TaxTypeIGST: ").Append(TaxTypeIGST).Append("\n");
            sb.Append("  TotalExpense: ").Append(TotalExpense).Append("\n");
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
            return Equals(input as AffordabilityExpenseEvent);
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
                if (PostedDate != null)
                    hashCode = hashCode * 59 + PostedDate.GetHashCode();
                if (MarketplaceId != null)
                    hashCode = hashCode * 59 + MarketplaceId.GetHashCode();
                if (TransactionType != null)
                    hashCode = hashCode * 59 + TransactionType.GetHashCode();
                if (BaseExpense != null)
                    hashCode = hashCode * 59 + BaseExpense.GetHashCode();
                if (TaxTypeCGST != null)
                    hashCode = hashCode * 59 + TaxTypeCGST.GetHashCode();
                if (TaxTypeSGST != null)
                    hashCode = hashCode * 59 + TaxTypeSGST.GetHashCode();
                if (TaxTypeIGST != null)
                    hashCode = hashCode * 59 + TaxTypeIGST.GetHashCode();
                if (TotalExpense != null)
                    hashCode = hashCode * 59 + TotalExpense.GetHashCode();
                return hashCode;
            }
        }
    }
}