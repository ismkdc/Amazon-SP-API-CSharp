/*
 * Selling Partner API for Direct Fulfillment Orders
 *
 * The Selling Partner API for Direct Fulfillment Orders provides programmatic access to a direct fulfillment vendor's order data.
 *
 * OpenAPI spec version: v1
 *
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.VendorDirectFulfillmentOrders
{
    /// <summary>
    ///     Details of an order.
    /// </summary>
    [DataContract]
    public class OrderDetails : IEquatable<OrderDetails>, IValidatableObject
    {
        /// <summary>
        ///     Current status of the order.
        /// </summary>
        /// <value>Current status of the order.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrderStatusEnum
        {
            /// <summary>
            ///     Enum NEW for value: NEW
            /// </summary>
            [EnumMember(Value = "NEW")] NEW = 1,

            /// <summary>
            ///     Enum SHIPPED for value: SHIPPED
            /// </summary>
            [EnumMember(Value = "SHIPPED")] SHIPPED = 2,

            /// <summary>
            ///     Enum ACCEPTED for value: ACCEPTED
            /// </summary>
            [EnumMember(Value = "ACCEPTED")] ACCEPTED = 3,

            /// <summary>
            ///     Enum CANCELLED for value: CANCELLED
            /// </summary>
            [EnumMember(Value = "CANCELLED")] CANCELLED = 4
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="OrderDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public OrderDetails()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="OrderDetails" /> class.
        /// </summary>
        /// <param name="customerOrderNumber">The customer order number. (required).</param>
        /// <param name="orderDate">
        ///     The date the order was placed. This field is expected to be in ISO-8601 date/time format, for
        ///     example:2018-07-16T23:00:00Z/ 2018-07-16T23:00:00-05:00 /2018-07-16T23:00:00-08:00. If no time zone is specified,
        ///     UTC should be assumed. (required).
        /// </param>
        /// <param name="orderStatus">Current status of the order..</param>
        /// <param name="shipmentDetails">shipmentDetails (required).</param>
        /// <param name="taxTotal">taxTotal.</param>
        /// <param name="sellingParty">PartyID of vendor code. (required).</param>
        /// <param name="shipFromParty">PartyID of vendor&#39;s warehouse. (required).</param>
        /// <param name="shipToParty">Name/Address and tax details of the ship to party. (required).</param>
        /// <param name="billToParty">Name/Address and tax details of the bill to party. (required).</param>
        /// <param name="items">A list of items in this purchase order. (required).</param>
        public OrderDetails(string customerOrderNumber = default, DateTime? orderDate = default,
            OrderStatusEnum? orderStatus = default, ShipmentDetails shipmentDetails = default,
            object taxTotal = default, PartyIdentification sellingParty = default,
            PartyIdentification shipFromParty = default, Address shipToParty = default,
            PartyIdentification billToParty = default, List<OrderItem> items = default)
        {
            // to ensure "customerOrderNumber" is required (not null)
            if (customerOrderNumber == null)
                throw new InvalidDataException(
                    "customerOrderNumber is a required property for OrderDetails and cannot be null");
            CustomerOrderNumber = customerOrderNumber;
            // to ensure "orderDate" is required (not null)
            if (orderDate == null)
                throw new InvalidDataException("orderDate is a required property for OrderDetails and cannot be null");
            OrderDate = orderDate;
            // to ensure "shipmentDetails" is required (not null)
            if (shipmentDetails == null)
                throw new InvalidDataException(
                    "shipmentDetails is a required property for OrderDetails and cannot be null");
            ShipmentDetails = shipmentDetails;
            // to ensure "sellingParty" is required (not null)
            if (sellingParty == null)
                throw new InvalidDataException(
                    "sellingParty is a required property for OrderDetails and cannot be null");
            SellingParty = sellingParty;
            // to ensure "shipFromParty" is required (not null)
            if (shipFromParty == null)
                throw new InvalidDataException(
                    "shipFromParty is a required property for OrderDetails and cannot be null");
            ShipFromParty = shipFromParty;
            // to ensure "shipToParty" is required (not null)
            if (shipToParty == null)
                throw new InvalidDataException(
                    "shipToParty is a required property for OrderDetails and cannot be null");
            ShipToParty = shipToParty;
            // to ensure "billToParty" is required (not null)
            if (billToParty == null)
                throw new InvalidDataException(
                    "billToParty is a required property for OrderDetails and cannot be null");
            BillToParty = billToParty;
            // to ensure "items" is required (not null)
            if (items == null)
                throw new InvalidDataException("items is a required property for OrderDetails and cannot be null");
            Items = items;
            OrderStatus = orderStatus;
            TaxTotal = taxTotal;
        }

        /// <summary>
        ///     Current status of the order.
        /// </summary>
        /// <value>Current status of the order.</value>
        [DataMember(Name = "orderStatus", EmitDefaultValue = false)]
        public OrderStatusEnum? OrderStatus { get; set; }

        /// <summary>
        ///     The customer order number.
        /// </summary>
        /// <value>The customer order number.</value>
        [DataMember(Name = "customerOrderNumber", EmitDefaultValue = false)]
        public string CustomerOrderNumber { get; set; }

        /// <summary>
        ///     The date the order was placed. This field is expected to be in ISO-8601 date/time format, for
        ///     example:2018-07-16T23:00:00Z/ 2018-07-16T23:00:00-05:00 /2018-07-16T23:00:00-08:00. If no time zone is specified,
        ///     UTC should be assumed.
        /// </summary>
        /// <value>
        ///     The date the order was placed. This field is expected to be in ISO-8601 date/time format, for
        ///     example:2018-07-16T23:00:00Z/ 2018-07-16T23:00:00-05:00 /2018-07-16T23:00:00-08:00. If no time zone is specified,
        ///     UTC should be assumed.
        /// </value>
        [DataMember(Name = "orderDate", EmitDefaultValue = false)]
        public DateTime? OrderDate { get; set; }


        /// <summary>
        ///     Gets or Sets ShipmentDetails
        /// </summary>
        [DataMember(Name = "shipmentDetails", EmitDefaultValue = false)]
        public ShipmentDetails ShipmentDetails { get; set; }

        /// <summary>
        ///     Gets or Sets TaxTotal
        /// </summary>
        [DataMember(Name = "taxTotal", EmitDefaultValue = false)]
        public object TaxTotal { get; set; }

        /// <summary>
        ///     PartyID of vendor code.
        /// </summary>
        /// <value>PartyID of vendor code.</value>
        [DataMember(Name = "sellingParty", EmitDefaultValue = false)]
        public PartyIdentification SellingParty { get; set; }

        /// <summary>
        ///     PartyID of vendor&#39;s warehouse.
        /// </summary>
        /// <value>PartyID of vendor&#39;s warehouse.</value>
        [DataMember(Name = "shipFromParty", EmitDefaultValue = false)]
        public PartyIdentification ShipFromParty { get; set; }

        /// <summary>
        ///     Name/Address and tax details of the ship to party.
        /// </summary>
        /// <value>Name/Address and tax details of the ship to party.</value>
        [DataMember(Name = "shipToParty", EmitDefaultValue = false)]
        public Address ShipToParty { get; set; }

        /// <summary>
        ///     Name/Address and tax details of the bill to party.
        /// </summary>
        /// <value>Name/Address and tax details of the bill to party.</value>
        [DataMember(Name = "billToParty", EmitDefaultValue = false)]
        public PartyIdentification BillToParty { get; set; }

        /// <summary>
        ///     A list of items in this purchase order.
        /// </summary>
        /// <value>A list of items in this purchase order.</value>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public List<OrderItem> Items { get; set; }

        /// <summary>
        ///     Returns true if OrderDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderDetails input)
        {
            if (input == null)
                return false;

            return
                (
                    CustomerOrderNumber == input.CustomerOrderNumber ||
                    (CustomerOrderNumber != null &&
                     CustomerOrderNumber.Equals(input.CustomerOrderNumber))
                ) &&
                (
                    OrderDate == input.OrderDate ||
                    (OrderDate != null &&
                     OrderDate.Equals(input.OrderDate))
                ) &&
                (
                    OrderStatus == input.OrderStatus ||
                    (OrderStatus != null &&
                     OrderStatus.Equals(input.OrderStatus))
                ) &&
                (
                    ShipmentDetails == input.ShipmentDetails ||
                    (ShipmentDetails != null &&
                     ShipmentDetails.Equals(input.ShipmentDetails))
                ) &&
                (
                    TaxTotal == input.TaxTotal ||
                    (TaxTotal != null &&
                     TaxTotal.Equals(input.TaxTotal))
                ) &&
                (
                    SellingParty == input.SellingParty ||
                    (SellingParty != null &&
                     SellingParty.Equals(input.SellingParty))
                ) &&
                (
                    ShipFromParty == input.ShipFromParty ||
                    (ShipFromParty != null &&
                     ShipFromParty.Equals(input.ShipFromParty))
                ) &&
                (
                    ShipToParty == input.ShipToParty ||
                    (ShipToParty != null &&
                     ShipToParty.Equals(input.ShipToParty))
                ) &&
                (
                    BillToParty == input.BillToParty ||
                    (BillToParty != null &&
                     BillToParty.Equals(input.BillToParty))
                ) &&
                (
                    Items == input.Items ||
                    (Items != null &&
                     Items.SequenceEqual(input.Items))
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
            sb.Append("class OrderDetails {\n");
            sb.Append("  CustomerOrderNumber: ").Append(CustomerOrderNumber).Append("\n");
            sb.Append("  OrderDate: ").Append(OrderDate).Append("\n");
            sb.Append("  OrderStatus: ").Append(OrderStatus).Append("\n");
            sb.Append("  ShipmentDetails: ").Append(ShipmentDetails).Append("\n");
            sb.Append("  TaxTotal: ").Append(TaxTotal).Append("\n");
            sb.Append("  SellingParty: ").Append(SellingParty).Append("\n");
            sb.Append("  ShipFromParty: ").Append(ShipFromParty).Append("\n");
            sb.Append("  ShipToParty: ").Append(ShipToParty).Append("\n");
            sb.Append("  BillToParty: ").Append(BillToParty).Append("\n");
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
            return Equals(input as OrderDetails);
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
                if (CustomerOrderNumber != null)
                    hashCode = hashCode * 59 + CustomerOrderNumber.GetHashCode();
                if (OrderDate != null)
                    hashCode = hashCode * 59 + OrderDate.GetHashCode();
                if (OrderStatus != null)
                    hashCode = hashCode * 59 + OrderStatus.GetHashCode();
                if (ShipmentDetails != null)
                    hashCode = hashCode * 59 + ShipmentDetails.GetHashCode();
                if (TaxTotal != null)
                    hashCode = hashCode * 59 + TaxTotal.GetHashCode();
                if (SellingParty != null)
                    hashCode = hashCode * 59 + SellingParty.GetHashCode();
                if (ShipFromParty != null)
                    hashCode = hashCode * 59 + ShipFromParty.GetHashCode();
                if (ShipToParty != null)
                    hashCode = hashCode * 59 + ShipToParty.GetHashCode();
                if (BillToParty != null)
                    hashCode = hashCode * 59 + BillToParty.GetHashCode();
                if (Items != null)
                    hashCode = hashCode * 59 + Items.GetHashCode();
                return hashCode;
            }
        }
    }
}