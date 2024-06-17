using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Orders
{
    /// <summary>
    ///     Buyer information.
    /// </summary>
    [DataContract]
    public class BuyerInfo : IEquatable<BuyerInfo>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="BuyerInfo" /> class.
        /// </summary>
        /// <param name="buyerEmail">The anonymized email address of the buyer..</param>
        /// <param name="buyerName">The buyer name or the recipient name..</param>
        /// <param name="buyerCounty">The county of the buyer..</param>
        /// <param name="buyerTaxInfo">Tax information about the buyer..</param>
        /// <param name="purchaseOrderNumber">
        ///     The purchase order (PO) number entered by the buyer at checkout. Returned only for
        ///     orders where the buyer entered a PO number at checkout..
        /// </param>
        public BuyerInfo(string buyerEmail = default, string buyerName = default, string buyerCounty = default,
            BuyerTaxInfo buyerTaxInfo = default, string purchaseOrderNumber = default)
        {
            BuyerEmail = buyerEmail;
            BuyerName = buyerName;
            BuyerCounty = buyerCounty;
            BuyerTaxInfo = buyerTaxInfo;
            PurchaseOrderNumber = purchaseOrderNumber;
        }

        public BuyerInfo()
        {
            BuyerEmail = default;
            BuyerName = default;
            BuyerCounty = default;
            BuyerTaxInfo = default;
            PurchaseOrderNumber = default;
        }

        /// <summary>
        ///     The anonymized email address of the buyer.
        /// </summary>
        /// <value>The anonymized email address of the buyer.</value>
        [DataMember(Name = "BuyerEmail", EmitDefaultValue = false)]
        public string BuyerEmail { get; set; }

        /// <summary>
        ///     The buyer name or the recipient name.
        /// </summary>
        /// <value>The buyer name or the recipient name.</value>
        [DataMember(Name = "BuyerName", EmitDefaultValue = false)]
        public string BuyerName { get; set; }

        /// <summary>
        ///     The county of the buyer.
        /// </summary>
        /// <value>The county of the buyer.</value>
        [DataMember(Name = "BuyerCounty", EmitDefaultValue = false)]
        public string BuyerCounty { get; set; }

        /// <summary>
        ///     Tax information about the buyer.
        /// </summary>
        /// <value>Tax information about the buyer.</value>
        [DataMember(Name = "BuyerTaxInfo", EmitDefaultValue = false)]
        public BuyerTaxInfo BuyerTaxInfo { get; set; }

        /// <summary>
        ///     The purchase order (PO) number entered by the buyer at checkout. Returned only for orders where the buyer entered a
        ///     PO number at checkout.
        /// </summary>
        /// <value>
        ///     The purchase order (PO) number entered by the buyer at checkout. Returned only for orders where the buyer
        ///     entered a PO number at checkout.
        /// </value>
        [DataMember(Name = "PurchaseOrderNumber", EmitDefaultValue = false)]
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        ///     Returns true if BuyerInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of BuyerInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuyerInfo input)
        {
            if (input == null)
                return false;

            return
                (
                    BuyerEmail == input.BuyerEmail ||
                    (BuyerEmail != null &&
                     BuyerEmail.Equals(input.BuyerEmail))
                ) &&
                (
                    BuyerName == input.BuyerName ||
                    (BuyerName != null &&
                     BuyerName.Equals(input.BuyerName))
                ) &&
                (
                    BuyerCounty == input.BuyerCounty ||
                    (BuyerCounty != null &&
                     BuyerCounty.Equals(input.BuyerCounty))
                ) &&
                (
                    BuyerTaxInfo == input.BuyerTaxInfo ||
                    (BuyerTaxInfo != null &&
                     BuyerTaxInfo.Equals(input.BuyerTaxInfo))
                ) &&
                (
                    PurchaseOrderNumber == input.PurchaseOrderNumber ||
                    (PurchaseOrderNumber != null &&
                     PurchaseOrderNumber.Equals(input.PurchaseOrderNumber))
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
            sb.Append("class BuyerInfo {\n");
            sb.Append("  BuyerEmail: ").Append(BuyerEmail).Append("\n");
            sb.Append("  BuyerName: ").Append(BuyerName).Append("\n");
            sb.Append("  BuyerCounty: ").Append(BuyerCounty).Append("\n");
            sb.Append("  BuyerTaxInfo: ").Append(BuyerTaxInfo).Append("\n");
            sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
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
            return Equals(input as BuyerInfo);
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
                if (BuyerEmail != null)
                    hashCode = hashCode * 59 + BuyerEmail.GetHashCode();
                if (BuyerName != null)
                    hashCode = hashCode * 59 + BuyerName.GetHashCode();
                if (BuyerCounty != null)
                    hashCode = hashCode * 59 + BuyerCounty.GetHashCode();
                if (BuyerTaxInfo != null)
                    hashCode = hashCode * 59 + BuyerTaxInfo.GetHashCode();
                if (PurchaseOrderNumber != null)
                    hashCode = hashCode * 59 + PurchaseOrderNumber.GetHashCode();
                return hashCode;
            }
        }
    }
}