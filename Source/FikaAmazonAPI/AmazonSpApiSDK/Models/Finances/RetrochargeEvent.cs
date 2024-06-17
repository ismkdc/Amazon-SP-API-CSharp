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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Finances
{
    /// <summary>
    ///     A retrocharge or retrocharge reversal.
    /// </summary>
    [DataContract]
    public class RetrochargeEvent : IEquatable<RetrochargeEvent>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="RetrochargeEvent" /> class.
        /// </summary>
        /// <param name="RetrochargeEventType">The type of event.  Possible values:  * Retrocharge  * RetrochargeReversal.</param>
        /// <param name="AmazonOrderId">An Amazon-defined identifier for an order..</param>
        /// <param name="PostedDate">The date and time when the financial event was posted..</param>
        /// <param name="BaseTax">The base tax associated with the retrocharge event..</param>
        /// <param name="ShippingTax">The shipping tax associated with the retrocharge event..</param>
        /// <param name="MarketplaceName">The name of the marketplace where the retrocharge event occurred..</param>
        /// <param name="RetrochargeTaxWithheldList">A list of information about taxes withheld..</param>
        public RetrochargeEvent(string RetrochargeEventType = default, string AmazonOrderId = default,
            DateTime? PostedDate = default, Currency BaseTax = default, Currency ShippingTax = default,
            string MarketplaceName = default, TaxWithheldComponentList RetrochargeTaxWithheldList = default)
        {
            this.RetrochargeEventType = RetrochargeEventType;
            this.AmazonOrderId = AmazonOrderId;
            this.PostedDate = PostedDate;
            this.BaseTax = BaseTax;
            this.ShippingTax = ShippingTax;
            this.MarketplaceName = MarketplaceName;
            this.RetrochargeTaxWithheldList = RetrochargeTaxWithheldList;
        }

        /// <summary>
        ///     The type of event.  Possible values:  * Retrocharge  * RetrochargeReversal
        /// </summary>
        /// <value>The type of event.  Possible values:  * Retrocharge  * RetrochargeReversal</value>
        [DataMember(Name = "RetrochargeEventType", EmitDefaultValue = false)]
        public string RetrochargeEventType { get; set; }

        /// <summary>
        ///     An Amazon-defined identifier for an order.
        /// </summary>
        /// <value>An Amazon-defined identifier for an order.</value>
        [DataMember(Name = "AmazonOrderId", EmitDefaultValue = false)]
        public string AmazonOrderId { get; set; }

        /// <summary>
        ///     The date and time when the financial event was posted.
        /// </summary>
        /// <value>The date and time when the financial event was posted.</value>
        [DataMember(Name = "PostedDate", EmitDefaultValue = false)]
        public DateTime? PostedDate { get; set; }

        /// <summary>
        ///     The base tax associated with the retrocharge event.
        /// </summary>
        /// <value>The base tax associated with the retrocharge event.</value>
        [DataMember(Name = "BaseTax", EmitDefaultValue = false)]
        public Currency BaseTax { get; set; }

        /// <summary>
        ///     The shipping tax associated with the retrocharge event.
        /// </summary>
        /// <value>The shipping tax associated with the retrocharge event.</value>
        [DataMember(Name = "ShippingTax", EmitDefaultValue = false)]
        public Currency ShippingTax { get; set; }

        /// <summary>
        ///     The name of the marketplace where the retrocharge event occurred.
        /// </summary>
        /// <value>The name of the marketplace where the retrocharge event occurred.</value>
        [DataMember(Name = "MarketplaceName", EmitDefaultValue = false)]
        public string MarketplaceName { get; set; }

        /// <summary>
        ///     A list of information about taxes withheld.
        /// </summary>
        /// <value>A list of information about taxes withheld.</value>
        [DataMember(Name = "RetrochargeTaxWithheldList", EmitDefaultValue = false)]
        public TaxWithheldComponentList RetrochargeTaxWithheldList { get; set; }

        /// <summary>
        ///     Returns true if RetrochargeEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of RetrochargeEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RetrochargeEvent input)
        {
            if (input == null)
                return false;

            return
                (
                    RetrochargeEventType == input.RetrochargeEventType ||
                    (RetrochargeEventType != null &&
                     RetrochargeEventType.Equals(input.RetrochargeEventType))
                ) &&
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
                    BaseTax == input.BaseTax ||
                    (BaseTax != null &&
                     BaseTax.Equals(input.BaseTax))
                ) &&
                (
                    ShippingTax == input.ShippingTax ||
                    (ShippingTax != null &&
                     ShippingTax.Equals(input.ShippingTax))
                ) &&
                (
                    MarketplaceName == input.MarketplaceName ||
                    (MarketplaceName != null &&
                     MarketplaceName.Equals(input.MarketplaceName))
                ) &&
                (
                    RetrochargeTaxWithheldList == input.RetrochargeTaxWithheldList ||
                    (RetrochargeTaxWithheldList != null &&
                     RetrochargeTaxWithheldList.Equals(input.RetrochargeTaxWithheldList))
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
            sb.Append("class RetrochargeEvent {\n");
            sb.Append("  RetrochargeEventType: ").Append(RetrochargeEventType).Append("\n");
            sb.Append("  AmazonOrderId: ").Append(AmazonOrderId).Append("\n");
            sb.Append("  PostedDate: ").Append(PostedDate).Append("\n");
            sb.Append("  BaseTax: ").Append(BaseTax).Append("\n");
            sb.Append("  ShippingTax: ").Append(ShippingTax).Append("\n");
            sb.Append("  MarketplaceName: ").Append(MarketplaceName).Append("\n");
            sb.Append("  RetrochargeTaxWithheldList: ").Append(RetrochargeTaxWithheldList).Append("\n");
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
            return Equals(input as RetrochargeEvent);
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
                if (RetrochargeEventType != null)
                    hashCode = hashCode * 59 + RetrochargeEventType.GetHashCode();
                if (AmazonOrderId != null)
                    hashCode = hashCode * 59 + AmazonOrderId.GetHashCode();
                if (PostedDate != null)
                    hashCode = hashCode * 59 + PostedDate.GetHashCode();
                if (BaseTax != null)
                    hashCode = hashCode * 59 + BaseTax.GetHashCode();
                if (ShippingTax != null)
                    hashCode = hashCode * 59 + ShippingTax.GetHashCode();
                if (MarketplaceName != null)
                    hashCode = hashCode * 59 + MarketplaceName.GetHashCode();
                if (RetrochargeTaxWithheldList != null)
                    hashCode = hashCode * 59 + RetrochargeTaxWithheldList.GetHashCode();
                return hashCode;
            }
        }
    }
}