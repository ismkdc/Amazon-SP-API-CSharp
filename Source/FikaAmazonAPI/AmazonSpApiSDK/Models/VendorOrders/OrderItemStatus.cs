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
    [DataContract]
    public class OrderItemStatus : IEquatable<OrderItemStatus>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="OrderItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public OrderItemStatus()
        {
        }

        public OrderItemStatus(
            string itemSequenceNumber = default, string buyerProductIdentifier = default,
            string vendorProductIdentifier = default, Money netCost = default, Money listPrice = default,
            orderedQuantity orderedQuantity = default, AcknowledgementStatus acknowledgementStatus = default
        )
        {
            if (itemSequenceNumber == null)
                throw new InvalidDataException(
                    "itemSequenceNumber is a required property for OrderItemStatus and cannot be null");
            ItemSequenceNumber = itemSequenceNumber;
            BuyerProductIdentifier = buyerProductIdentifier;
            VendorProductIdentifier = vendorProductIdentifier;
            NetCost = netCost;
            ListPrice = listPrice;
            OrderedQuantity = orderedQuantity;
            AcknowledgementStatus = acknowledgementStatus;
        }

        [DataMember(Name = "itemSequenceNumber", EmitDefaultValue = false)]
        public string ItemSequenceNumber { get; set; }

        [DataMember(Name = "buyerProductIdentifier", EmitDefaultValue = false)]
        public string BuyerProductIdentifier { get; set; }

        [DataMember(Name = "vendorProductIdentifier", EmitDefaultValue = false)]
        public string VendorProductIdentifier { get; set; }

        [DataMember(Name = "netCost", EmitDefaultValue = false)]
        public Money NetCost { get; set; }

        [DataMember(Name = "listPrice", EmitDefaultValue = false)]
        public Money ListPrice { get; set; }

        [DataMember(Name = "orderedQuantity", EmitDefaultValue = false)]
        public orderedQuantity OrderedQuantity { get; set; }

        [DataMember(Name = "acknowledgementStatus", EmitDefaultValue = false)]
        public AcknowledgementStatus AcknowledgementStatus { get; set; }

        [DataMember(Name = "receivingStatus", EmitDefaultValue = false)]
        public receivingStatus ReceivingStatus { get; set; }

        /// <summary>
        ///     Returns true if OrderItem instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderItemStatus input)
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
                    BuyerProductIdentifier == input.BuyerProductIdentifier ||
                    (BuyerProductIdentifier != null &&
                     BuyerProductIdentifier.Equals(input.BuyerProductIdentifier))
                ) &&
                (
                    VendorProductIdentifier == input.VendorProductIdentifier ||
                    (VendorProductIdentifier != null &&
                     VendorProductIdentifier.Equals(input.VendorProductIdentifier))
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
                    OrderedQuantity == input.OrderedQuantity ||
                    (OrderedQuantity != null &&
                     OrderedQuantity.Equals(input.OrderedQuantity))
                ) &&
                (
                    AcknowledgementStatus == input.AcknowledgementStatus ||
                    (AcknowledgementStatus != null &&
                     AcknowledgementStatus.Equals(input.AcknowledgementStatus))
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
            sb.Append("class OrderItem {\n");
            sb.Append("  ItemSequenceNumber: ").Append(ItemSequenceNumber).Append("\n");
            sb.Append("  BuyerProductIdentifier: ").Append(BuyerProductIdentifier).Append("\n");
            sb.Append("  VendorProductIdentifier: ").Append(VendorProductIdentifier).Append("\n");
            sb.Append("  NetCost: ").Append(NetCost).Append("\n");
            sb.Append("  ListPrice: ").Append(ListPrice).Append("\n");
            sb.Append("  OrderedQuantity: ").Append(OrderedQuantity).Append("\n");
            sb.Append("  AcknowledgementStatus: ").Append(AcknowledgementStatus).Append("\n");
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
            return Equals(input as OrderItemStatus);
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
                if (BuyerProductIdentifier != null)
                    hashCode = hashCode * 59 + BuyerProductIdentifier.GetHashCode();
                if (VendorProductIdentifier != null)
                    hashCode = hashCode * 59 + VendorProductIdentifier.GetHashCode();
                if (NetCost != null)
                    hashCode = hashCode * 59 + NetCost.GetHashCode();
                if (ListPrice != null)
                    hashCode = hashCode * 59 + ListPrice.GetHashCode();
                if (OrderedQuantity != null)
                    hashCode = hashCode * 59 + OrderedQuantity.GetHashCode();
                if (AcknowledgementStatus != null)
                    hashCode = hashCode * 59 + AcknowledgementStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}