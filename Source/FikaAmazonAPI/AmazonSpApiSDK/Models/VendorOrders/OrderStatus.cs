using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using static FikaAmazonAPI.AmazonSpApiSDK.Models.VendorOrders.Constants;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.VendorOrders
{
    [DataContract]
    public class OrderStatus : IEquatable<OrderStatus>, IValidatableObject
    {
        [JsonConstructorAttribute]
        public OrderStatus()
        {
        }

        public OrderStatus(
            string purchaseOrderNumber = default, PurchaseOrderStatus? purchaseOrderStatus = default,
            DateTime? purchaseOrderDate = default,
            DateTime? lastUpdatedDate = default, PartyIdentification sellingParty = default,
            PartyIdentification shipToParty = default, List<OrderItemStatus> itemStatus = default
        )
        {
            if (purchaseOrderNumber == null)
                throw new InvalidDataException(
                    "purchaseOrderNumber is a required property for OrderStatus and cannot be null");
            PurchaseOrderNumber = purchaseOrderNumber;
            if (purchaseOrderStatus == null)
                throw new InvalidDataException(
                    "purchaseOrderStatus is a required property for OrderStatus and cannot be null");
            PurchaseOrderStatus = purchaseOrderStatus;
            if (purchaseOrderDate == null)
                throw new InvalidDataException(
                    "purchaseOrderDate is a required property for OrderStatus and cannot be null");
            PurchaseOrderDate = purchaseOrderDate;
            LastUpdatedDate = lastUpdatedDate;
            if (sellingParty == null)
                throw new InvalidDataException(
                    "sellingParty is a required property for OrderStatus and cannot be null");
            SellingParty = sellingParty;
            if (shipToParty == null)
                throw new InvalidDataException("shipToParty is a required property for OrderStatus and cannot be null");
            ShipToParty = shipToParty;
            if (itemStatus == null)
                throw new InvalidDataException("itemStatus is a required property for OrderStatus and cannot be null");
            ItemStatus = itemStatus;
        }

        /// <summary>
        ///     The purchase order number for this order. Formatting Notes: alpha-numeric code.
        /// </summary>
        /// <value>The purchase order number for this order. Formatting Notes: alpha-numeric code.</value>
        [DataMember(Name = "purchaseOrderNumber", EmitDefaultValue = false)]
        public string PurchaseOrderNumber { get; set; }

        [DataMember(Name = "purchaseOrderStatus", EmitDefaultValue = false)]
        public PurchaseOrderStatus? PurchaseOrderStatus { get; set; }

        [DataMember(Name = "purchaseOrderDate", EmitDefaultValue = false)]
        public DateTime? PurchaseOrderDate { get; set; }

        [DataMember(Name = "lastUpdatedDate", EmitDefaultValue = false)]
        public DateTime? LastUpdatedDate { get; set; }

        [DataMember(Name = "sellingParty", EmitDefaultValue = false)]
        public PartyIdentification SellingParty { get; set; }

        [DataMember(Name = "shipToParty", EmitDefaultValue = false)]
        public PartyIdentification ShipToParty { get; set; }

        [DataMember(Name = "itemStatus", EmitDefaultValue = false)]
        public List<OrderItemStatus> ItemStatus { get; set; }

        /// <summary>
        ///     Returns true if Order instances are equal
        /// </summary>
        /// <param name="input">Instance of Order to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderStatus input)
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
                    PurchaseOrderStatus == input.PurchaseOrderStatus ||
                    (PurchaseOrderStatus != null &&
                     PurchaseOrderStatus.Equals(input.PurchaseOrderStatus))
                ) &&
                (
                    PurchaseOrderDate == input.PurchaseOrderDate ||
                    (PurchaseOrderDate != null &&
                     PurchaseOrderDate.Equals(input.PurchaseOrderDate))
                ) &&
                (
                    LastUpdatedDate == input.LastUpdatedDate ||
                    (LastUpdatedDate != null &&
                     LastUpdatedDate.Equals(input.LastUpdatedDate))
                ) &&
                (
                    SellingParty == input.SellingParty ||
                    (SellingParty != null &&
                     SellingParty.Equals(input.SellingParty))
                ) &&
                (
                    ShipToParty == input.ShipToParty ||
                    (ShipToParty != null &&
                     ShipToParty.Equals(input.ShipToParty))
                ) &&
                (
                    ItemStatus == input.ItemStatus ||
                    (ItemStatus != null &&
                     ItemStatus.Equals(input.ItemStatus))
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
            sb.Append("class OrderStatus {\n");
            sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
            sb.Append("  PurchaseOrderStatus: ").Append(PurchaseOrderStatus).Append("\n");
            sb.Append("  PurchaseOrderDate: ").Append(PurchaseOrderDate).Append("\n");
            sb.Append("  LastUpdatedDate: ").Append(LastUpdatedDate).Append("\n");
            sb.Append("  SellingParty: ").Append(SellingParty).Append("\n");
            sb.Append("  ShipToParty: ").Append(ShipToParty).Append("\n");
            sb.Append("  ItemStatus: ").Append(ItemStatus).Append("\n");
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
            return Equals(input as Order);
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
                if (PurchaseOrderStatus != null)
                    hashCode = hashCode * 59 + PurchaseOrderStatus.GetHashCode();
                if (PurchaseOrderDate != null)
                    hashCode = hashCode * 59 + PurchaseOrderDate.GetHashCode();
                if (LastUpdatedDate != null)
                    hashCode = hashCode * 59 + LastUpdatedDate.GetHashCode();
                if (SellingParty != null)
                    hashCode = hashCode * 59 + SellingParty.GetHashCode();
                if (ShipToParty != null)
                    hashCode = hashCode * 59 + ShipToParty.GetHashCode();
                if (ItemStatus != null)
                    hashCode = hashCode * 59 + ItemStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}