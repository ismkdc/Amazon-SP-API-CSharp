using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using FikaAmazonAPI.AmazonSpApiSDK.Models.Sales;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.VendorOrders
{
    /// <summary>
    ///     OrderItem
    /// </summary>
    [DataContract]
    public class OrderItem : IEquatable<OrderItem>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="OrderItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public OrderItem()
        {
        }

        public OrderItem(string itemSequenceNumber = default, string amazonProductIdentifier = default,
            string vendorProductIdentifier = default, ItemQuantity orderedQuantity = default,
            bool isBackOrderAllowed = default, Money netCost = default, Money listPrice = default)
        {
            // to ensure "itemSequenceNumber" is required (not null)
            if (itemSequenceNumber == null)
                throw new InvalidDataException(
                    "itemSequenceNumber is a required property for OrderItem and cannot be null");
            ItemSequenceNumber = itemSequenceNumber;
            AmazonProductIdentifier = amazonProductIdentifier;
            VendorProductIdentifier = vendorProductIdentifier;
            // to ensure "orderedQuantity" is required (not null)
            if (orderedQuantity == null)
                throw new InvalidDataException(
                    "orderedQuantity is a required property for OrderItem and cannot be null");
            OrderedQuantity = orderedQuantity;
            IsBackOrderAllowed = isBackOrderAllowed;
            NetCost = netCost;
            ListPrice = listPrice;
        }

        /// <summary>
        ///     Numbering of the item on the purchase order. The first item will be 1, the second 2, and so on.
        /// </summary>
        /// <value>Numbering of the item on the purchase order. The first item will be 1, the second 2, and so on.</value>
        [DataMember(Name = "itemSequenceNumber", EmitDefaultValue = false)]
        public string ItemSequenceNumber { get; set; }

        /// <summary>
        ///     Buyer&#39;s standard identification number (ASIN) of an item.
        /// </summary>
        /// <value>Buyer&#39;s standard identification number (ASIN) of an item.</value>
        [DataMember(Name = "amazonProductIdentifier", EmitDefaultValue = false)]
        public string AmazonProductIdentifier { get; set; }

        /// <summary>
        ///     The vendor selected product identification of the item.
        /// </summary>
        /// <value>The vendor selected product identification of the item.</value>
        [DataMember(Name = "vendorProductIdentifier", EmitDefaultValue = false)]
        public string VendorProductIdentifier { get; set; }

        /// <summary>
        ///     Item quantity ordered.
        /// </summary>
        /// <value>Item quantity ordered.</value>
        [DataMember(Name = "orderedQuantity", EmitDefaultValue = false)]
        public ItemQuantity OrderedQuantity { get; set; }

        /// <summary>
        ///     Is back order allowed?
        /// </summary>
        /// <value>Is back order allowed?.</value>
        [DataMember(Name = "isBackOrderAllowed", EmitDefaultValue = false)]
        public bool IsBackOrderAllowed { get; set; }

        /// <summary>
        ///     The price to Amazon each (cost).
        /// </summary>
        /// <value>The price to Amazon each (cost).</value>
        [DataMember(Name = "netCost", EmitDefaultValue = false)]
        public Money NetCost { get; set; }

        /// <summary>
        ///     The list price each.
        /// </summary>
        /// <value>The list price each.</value>
        [DataMember(Name = "listPrice", EmitDefaultValue = false)]
        public Money ListPrice { get; set; }

        /// <summary>
        ///     Returns true if OrderItem instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderItem input)
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
                    IsBackOrderAllowed == input.IsBackOrderAllowed ||
                    IsBackOrderAllowed.Equals(input.IsBackOrderAllowed)
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
            sb.Append("class OrderItem {\n");
            sb.Append("  ItemSequenceNumber: ").Append(ItemSequenceNumber).Append("\n");
            sb.Append("  AmazonProductIdentifier: ").Append(AmazonProductIdentifier).Append("\n");
            sb.Append("  VendorProductIdentifier: ").Append(VendorProductIdentifier).Append("\n");
            sb.Append("  OrderedQuantity: ").Append(OrderedQuantity).Append("\n");
            sb.Append("  IsBackOrderAllowed: ").Append(IsBackOrderAllowed).Append("\n");
            sb.Append("  NetCost: ").Append(NetCost).Append("\n");
            sb.Append("  ListPrice: ").Append(ListPrice).Append("\n");
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
            return Equals(input as OrderItem);
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
                hashCode = hashCode * 59 + IsBackOrderAllowed.GetHashCode();
                if (NetCost != null)
                    hashCode = hashCode * 59 + NetCost.GetHashCode();
                if (ListPrice != null)
                    hashCode = hashCode * 59 + ListPrice.GetHashCode();
                return hashCode;
            }
        }
    }
}