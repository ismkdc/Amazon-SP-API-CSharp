using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using FikaAmazonAPI.AmazonSpApiSDK.Models.ListingsItems;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.VendorOrders
{
    [DataContract]
    public class OrderAcknowledgementItem : IEquatable<OrderAcknowledgementItem>, IValidatableObject
    {
        [JsonConstructorAttribute]
        public OrderAcknowledgementItem()
        {
        }

        public OrderAcknowledgementItem(string itemSequenceNumber = default, string amazonProductIdentifier = default,
            string vendorProductIdentifier = default, ItemQuantity orderedQuantity = default, Money netCost = default,
            Money listPrice = default, string discountMultiplier = default,
            List<OrderItemAcknowledgement> itemAcknowledgements = default)
        {
            // to ensure "purchaseOrderNumber" is required (not null)
            if (orderedQuantity == null)
                throw new InvalidDataException(
                    "orderedQuantity is a required property for OrderAcknowledgementItem and cannot be null");
            OrderedQuantity = orderedQuantity;
            ItemSequenceNumber = itemSequenceNumber;
            AmazonProductIdentifier = amazonProductIdentifier;
            NetCost = netCost;
            ListPrice = listPrice;
            DiscountMultiplier = discountMultiplier;
            if (itemAcknowledgements == null)
                throw new InvalidDataException(
                    "itemAcknowledgements is a required property for OrderAcknowledgementItem and cannot be null");
            ItemAcknowledgements = itemAcknowledgements;
        }

        [DataMember(Name = "itemSequenceNumber", EmitDefaultValue = false)]
        public string ItemSequenceNumber { get; set; }

        [DataMember(Name = "amazonProductIdentifier", EmitDefaultValue = false)]
        public string AmazonProductIdentifier { get; set; }

        [DataMember(Name = "vendorProductIdentifier", EmitDefaultValue = false)]
        public string VendorProductIdentifier { get; set; }

        [DataMember(Name = "orderedQuantity", EmitDefaultValue = false)]
        public ItemQuantity OrderedQuantity { get; set; }

        [DataMember(Name = "netCost", EmitDefaultValue = false)]
        public Money NetCost { get; set; }

        [DataMember(Name = "listPrice", EmitDefaultValue = false)]
        public Money ListPrice { get; set; }

        [DataMember(Name = "discountMultiplier", EmitDefaultValue = false)]
        public string DiscountMultiplier { get; set; }

        [DataMember(Name = "itemAcknowledgements", EmitDefaultValue = false)]
        public List<OrderItemAcknowledgement> ItemAcknowledgements { get; set; }

        public bool Equals(OrderAcknowledgementItem input)
        {
            if (input == null)
                return false;

            return
                (
                    ItemSequenceNumber == input.ItemSequenceNumber ||
                    (ItemSequenceNumber != null &&
                     ItemSequenceNumber.Equals(input.ItemSequenceNumber))
                ) &&
                (
                    AmazonProductIdentifier == input.AmazonProductIdentifier ||
                    (AmazonProductIdentifier != null &&
                     AmazonProductIdentifier.Equals(input.AmazonProductIdentifier))
                ) &&
                (
                    VendorProductIdentifier == input.VendorProductIdentifier ||
                    (VendorProductIdentifier != null &&
                     VendorProductIdentifier.Equals(input.VendorProductIdentifier))
                ) &&
                (
                    OrderedQuantity == input.OrderedQuantity ||
                    (OrderedQuantity != null &&
                     OrderedQuantity.Equals(input.OrderedQuantity))
                ) &&
                (
                    NetCost == input.NetCost ||
                    (NetCost != null &&
                     NetCost.Equals(input.NetCost))
                ) &&
                (
                    ListPrice == input.ListPrice ||
                    (ListPrice != null &&
                     ListPrice.Equals(input.ListPrice))
                ) &&
                (
                    DiscountMultiplier == input.DiscountMultiplier ||
                    (DiscountMultiplier != null &&
                     DiscountMultiplier.Equals(input.DiscountMultiplier))
                ) &&
                (
                    ItemAcknowledgements == input.ItemAcknowledgements ||
                    (ItemAcknowledgements != null &&
                     ItemAcknowledgements.SequenceEqual(input.ItemAcknowledgements))
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
            sb.Append("class OrderAcknowledgementItem {\n");
            sb.Append("  ItemSequenceNumber: ").Append(ItemSequenceNumber).Append("\n");
            sb.Append("  AmazonProductIdentifier: ").Append(AmazonProductIdentifier).Append("\n");
            sb.Append("  VendorProductIdentifier: ").Append(VendorProductIdentifier).Append("\n");
            sb.Append("  OrderedQuantity: ").Append(OrderedQuantity).Append("\n");
            sb.Append("  NetCost: ").Append(NetCost).Append("\n");
            sb.Append("  ListPrice: ").Append(ListPrice).Append("\n");
            sb.Append("  DiscountMultiplier: ").Append(DiscountMultiplier).Append("\n");
            sb.Append("  ItemAcknowledgements: ").Append(ItemAcknowledgements).Append("\n");
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
            return Equals(input as OrderAcknowledgementItem);
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
                if (ItemSequenceNumber != null)
                    hashCode = hashCode * 59 + ItemSequenceNumber.GetHashCode();
                if (AmazonProductIdentifier != null)
                    hashCode = hashCode * 59 + AmazonProductIdentifier.GetHashCode();
                if (VendorProductIdentifier != null)
                    hashCode = hashCode * 59 + VendorProductIdentifier.GetHashCode();
                if (OrderedQuantity != null)
                    hashCode = hashCode * 59 + OrderedQuantity.GetHashCode();
                if (NetCost != null)
                    hashCode = hashCode * 59 + NetCost.GetHashCode();
                if (ListPrice != null)
                    hashCode = hashCode * 59 + ListPrice.GetHashCode();
                if (DiscountMultiplier != null)
                    hashCode = hashCode * 59 + DiscountMultiplier.GetHashCode();
                if (ItemAcknowledgements != null)
                    hashCode = hashCode * 59 + ItemAcknowledgements.GetHashCode();
                return hashCode;
            }
        }
    }
}