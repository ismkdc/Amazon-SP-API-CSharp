/* 
 * Selling Partner API for Finances
 *
 * The Selling Partner API for Finances helps you obtain financial information relevant to a seller's business. You can obtain financial events for a given order, financial event group, or date range without having to wait until a statement period closes. You can also obtain financial event groups for a given date range.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace AmazonSpApiSDK.Models.Finances
{
    /// <summary>
    /// A credit given to a solution provider.
    /// </summary>
    [DataContract]
    public partial class SolutionProviderCreditEvent : IEquatable<SolutionProviderCreditEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionProviderCreditEvent" /> class.
        /// </summary>
        /// <param name="ProviderTransactionType">The transaction type..</param>
        /// <param name="SellerOrderId">A seller-defined identifier for an order..</param>
        /// <param name="MarketplaceId">The identifier of the marketplace where the order was placed..</param>
        /// <param name="MarketplaceCountryCode">The two-letter country code of the country associated with the marketplace where the order was placed..</param>
        /// <param name="SellerId">The Amazon-defined identifier of the seller..</param>
        /// <param name="SellerStoreName">The store name where the payment event occurred..</param>
        /// <param name="ProviderId">The Amazon-defined identifier of the solution provider..</param>
        /// <param name="ProviderStoreName">The store name where the payment event occurred..</param>
        /// <param name="TransactionAmount">The amount of the credit..</param>
        /// <param name="TransactionCreationDate">The date and time that the credit transaction was created, in ISO 8601 date time format..</param>
        public SolutionProviderCreditEvent(string ProviderTransactionType = default(string), string SellerOrderId = default(string), string MarketplaceId = default(string), string MarketplaceCountryCode = default(string), string SellerId = default(string), string SellerStoreName = default(string), string ProviderId = default(string), string ProviderStoreName = default(string), Currency TransactionAmount = default(Currency), DateTime? TransactionCreationDate = default(DateTime?))
        {
            this.ProviderTransactionType = ProviderTransactionType;
            this.SellerOrderId = SellerOrderId;
            this.MarketplaceId = MarketplaceId;
            this.MarketplaceCountryCode = MarketplaceCountryCode;
            this.SellerId = SellerId;
            this.SellerStoreName = SellerStoreName;
            this.ProviderId = ProviderId;
            this.ProviderStoreName = ProviderStoreName;
            this.TransactionAmount = TransactionAmount;
            this.TransactionCreationDate = TransactionCreationDate;
        }

        /// <summary>
        /// The transaction type.
        /// </summary>
        /// <value>The transaction type.</value>
        [DataMember(Name = "ProviderTransactionType", EmitDefaultValue = false)]
        public string ProviderTransactionType { get; set; }

        /// <summary>
        /// A seller-defined identifier for an order.
        /// </summary>
        /// <value>A seller-defined identifier for an order.</value>
        [DataMember(Name = "SellerOrderId", EmitDefaultValue = false)]
        public string SellerOrderId { get; set; }

        /// <summary>
        /// The identifier of the marketplace where the order was placed.
        /// </summary>
        /// <value>The identifier of the marketplace where the order was placed.</value>
        [DataMember(Name = "MarketplaceId", EmitDefaultValue = false)]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// The two-letter country code of the country associated with the marketplace where the order was placed.
        /// </summary>
        /// <value>The two-letter country code of the country associated with the marketplace where the order was placed.</value>
        [DataMember(Name = "MarketplaceCountryCode", EmitDefaultValue = false)]
        public string MarketplaceCountryCode { get; set; }

        /// <summary>
        /// The Amazon-defined identifier of the seller.
        /// </summary>
        /// <value>The Amazon-defined identifier of the seller.</value>
        [DataMember(Name = "SellerId", EmitDefaultValue = false)]
        public string SellerId { get; set; }

        /// <summary>
        /// The store name where the payment event occurred.
        /// </summary>
        /// <value>The store name where the payment event occurred.</value>
        [DataMember(Name = "SellerStoreName", EmitDefaultValue = false)]
        public string SellerStoreName { get; set; }

        /// <summary>
        /// The Amazon-defined identifier of the solution provider.
        /// </summary>
        /// <value>The Amazon-defined identifier of the solution provider.</value>
        [DataMember(Name = "ProviderId", EmitDefaultValue = false)]
        public string ProviderId { get; set; }

        /// <summary>
        /// The store name where the payment event occurred.
        /// </summary>
        /// <value>The store name where the payment event occurred.</value>
        [DataMember(Name = "ProviderStoreName", EmitDefaultValue = false)]
        public string ProviderStoreName { get; set; }

        /// <summary>
        /// The amount of the credit.
        /// </summary>
        /// <value>The amount of the credit.</value>
        [DataMember(Name = "TransactionAmount", EmitDefaultValue = false)]
        public Currency TransactionAmount { get; set; }

        /// <summary>
        /// The date and time that the credit transaction was created, in ISO 8601 date time format.
        /// </summary>
        /// <value>The date and time that the credit transaction was created, in ISO 8601 date time format.</value>
        [DataMember(Name = "TransactionCreationDate", EmitDefaultValue = false)]
        public DateTime? TransactionCreationDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SolutionProviderCreditEvent {\n");
            sb.Append("  ProviderTransactionType: ").Append(ProviderTransactionType).Append("\n");
            sb.Append("  SellerOrderId: ").Append(SellerOrderId).Append("\n");
            sb.Append("  MarketplaceId: ").Append(MarketplaceId).Append("\n");
            sb.Append("  MarketplaceCountryCode: ").Append(MarketplaceCountryCode).Append("\n");
            sb.Append("  SellerId: ").Append(SellerId).Append("\n");
            sb.Append("  SellerStoreName: ").Append(SellerStoreName).Append("\n");
            sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
            sb.Append("  ProviderStoreName: ").Append(ProviderStoreName).Append("\n");
            sb.Append("  TransactionAmount: ").Append(TransactionAmount).Append("\n");
            sb.Append("  TransactionCreationDate: ").Append(TransactionCreationDate).Append("\n");
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
            return this.Equals(input as SolutionProviderCreditEvent);
        }

        /// <summary>
        /// Returns true if SolutionProviderCreditEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of SolutionProviderCreditEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SolutionProviderCreditEvent input)
        {
            if (input == null)
                return false;

            return
                (
                    this.ProviderTransactionType == input.ProviderTransactionType ||
                    (this.ProviderTransactionType != null &&
                    this.ProviderTransactionType.Equals(input.ProviderTransactionType))
                ) &&
                (
                    this.SellerOrderId == input.SellerOrderId ||
                    (this.SellerOrderId != null &&
                    this.SellerOrderId.Equals(input.SellerOrderId))
                ) &&
                (
                    this.MarketplaceId == input.MarketplaceId ||
                    (this.MarketplaceId != null &&
                    this.MarketplaceId.Equals(input.MarketplaceId))
                ) &&
                (
                    this.MarketplaceCountryCode == input.MarketplaceCountryCode ||
                    (this.MarketplaceCountryCode != null &&
                    this.MarketplaceCountryCode.Equals(input.MarketplaceCountryCode))
                ) &&
                (
                    this.SellerId == input.SellerId ||
                    (this.SellerId != null &&
                    this.SellerId.Equals(input.SellerId))
                ) &&
                (
                    this.SellerStoreName == input.SellerStoreName ||
                    (this.SellerStoreName != null &&
                    this.SellerStoreName.Equals(input.SellerStoreName))
                ) &&
                (
                    this.ProviderId == input.ProviderId ||
                    (this.ProviderId != null &&
                    this.ProviderId.Equals(input.ProviderId))
                ) &&
                (
                    this.ProviderStoreName == input.ProviderStoreName ||
                    (this.ProviderStoreName != null &&
                    this.ProviderStoreName.Equals(input.ProviderStoreName))
                ) &&
                (
                    this.TransactionAmount == input.TransactionAmount ||
                    (this.TransactionAmount != null &&
                    this.TransactionAmount.Equals(input.TransactionAmount))
                ) &&
                (
                    this.TransactionCreationDate == input.TransactionCreationDate ||
                    (this.TransactionCreationDate != null &&
                    this.TransactionCreationDate.Equals(input.TransactionCreationDate))
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
                if (this.ProviderTransactionType != null)
                    hashCode = hashCode * 59 + this.ProviderTransactionType.GetHashCode();
                if (this.SellerOrderId != null)
                    hashCode = hashCode * 59 + this.SellerOrderId.GetHashCode();
                if (this.MarketplaceId != null)
                    hashCode = hashCode * 59 + this.MarketplaceId.GetHashCode();
                if (this.MarketplaceCountryCode != null)
                    hashCode = hashCode * 59 + this.MarketplaceCountryCode.GetHashCode();
                if (this.SellerId != null)
                    hashCode = hashCode * 59 + this.SellerId.GetHashCode();
                if (this.SellerStoreName != null)
                    hashCode = hashCode * 59 + this.SellerStoreName.GetHashCode();
                if (this.ProviderId != null)
                    hashCode = hashCode * 59 + this.ProviderId.GetHashCode();
                if (this.ProviderStoreName != null)
                    hashCode = hashCode * 59 + this.ProviderStoreName.GetHashCode();
                if (this.TransactionAmount != null)
                    hashCode = hashCode * 59 + this.TransactionAmount.GetHashCode();
                if (this.TransactionCreationDate != null)
                    hashCode = hashCode * 59 + this.TransactionCreationDate.GetHashCode();
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
