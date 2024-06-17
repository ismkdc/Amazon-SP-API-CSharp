using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.VendorOrders
{
    [DataContract]
    public class OrderAcknowledgement : IEquatable<OrderAcknowledgement>, IValidatableObject
    {
        [JsonConstructorAttribute]
        public OrderAcknowledgement()
        {
        }

        public OrderAcknowledgement(string purchaseOrderNumber = default, PartyIdentification sellingParty = default,
            DateTime? acknowledgementDate = default, List<OrderAcknowledgementItem> items = default)
        {
            // to ensure "purchaseOrderNumber" is required (not null)
            if (purchaseOrderNumber == null)
                throw new InvalidDataException(
                    "purchaseOrderNumber is a required property for OrderAcknowledgement and cannot be null");
            PurchaseOrderNumber = purchaseOrderNumber;
            // to ensure "sellingParty" is required (not null)
            if (sellingParty == null)
                throw new InvalidDataException(
                    "sellingParty is a required property for OrderAcknowledgement and cannot be null");
            SellingParty = sellingParty;
            // to ensure "acknowledgementDate" is required (not null)
            if (acknowledgementDate == null)
                throw new InvalidDataException(
                    "acknowledgementDate is a required property for OrderAcknowledgement and cannot be null");
            AcknowledgementDate = acknowledgementDate;
            Items = items;
        }

        /// <summary>
        ///     The purchase order number for this order. Formatting Notes: alpha-numeric code.
        /// </summary>
        /// <value>The purchase order number for this order. Formatting Notes: alpha-numeric code.</value>
        [DataMember(Name = "purchaseOrderNumber", EmitDefaultValue = false)]
        public string PurchaseOrderNumber { get; set; }

        [DataMember(Name = "sellingParty", EmitDefaultValue = false)]
        public PartyIdentification SellingParty { get; set; }

        [DataMember(Name = "acknowledgementDate", EmitDefaultValue = false)]
        public DateTime? AcknowledgementDate { get; set; }

        [DataMember(Name = "items", EmitDefaultValue = false)]
        public List<OrderAcknowledgementItem> Items { get; set; }

        public bool Equals(OrderAcknowledgement input)
        {
            if (input == null)
                return false;

            return
                (
                    PurchaseOrderNumber == input.PurchaseOrderNumber ||
                    (PurchaseOrderNumber != null &&
                     PurchaseOrderNumber.Equals(input.PurchaseOrderNumber))
                ) &&
                (
                    SellingParty == input.SellingParty ||
                    (SellingParty != null &&
                     SellingParty.Equals(input.SellingParty))
                ) &&
                (
                    AcknowledgementDate == input.AcknowledgementDate ||
                    (AcknowledgementDate != null &&
                     AcknowledgementDate.Equals(input.AcknowledgementDate))
                ) &&
                (
                    Items == input.Items ||
                    (Items != null &&
                     Items.Equals(input.Items))
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

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderAcknowledgement {\n");
            sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
            sb.Append("  SellingParty: ").Append(SellingParty).Append("\n");
            sb.Append("  AcknowledgementDate: ").Append(AcknowledgementDate).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return Equals(input as OrderAcknowledgement);
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
                if (PurchaseOrderNumber != null)
                    hashCode = hashCode * 59 + PurchaseOrderNumber.GetHashCode();
                if (SellingParty != null)
                    hashCode = hashCode * 59 + SellingParty.GetHashCode();
                if (AcknowledgementDate != null)
                    hashCode = hashCode * 59 + AcknowledgementDate.GetHashCode();
                if (Items != null)
                    hashCode = hashCode * 59 + Items.GetHashCode();
                return hashCode;
            }
        }
    }
}