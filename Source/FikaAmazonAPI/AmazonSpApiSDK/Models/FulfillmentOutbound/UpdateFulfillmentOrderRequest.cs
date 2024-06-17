/*
 * Selling Partner API for Fulfillment Outbound
 *
 * The Selling Partner API for Fulfillment Outbound lets you create applications that help a seller fulfill Multi-Channel Fulfillment orders using their inventory in Amazon's fulfillment network. You can get information on both potential and existing fulfillment orders.
 *
 * OpenAPI spec version: v0
 *
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentOutbound
{
    /// <summary>
    ///     UpdateFulfillmentOrderRequest
    /// </summary>
    [DataContract]
    public class UpdateFulfillmentOrderRequest : IEquatable<UpdateFulfillmentOrderRequest>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="UpdateFulfillmentOrderRequest" /> class.
        /// </summary>
        /// <param name="MarketplaceId">The marketplace the fulfillment order is placed against..</param>
        /// <param name="DisplayableOrderId">
        ///     A fulfillment order identifier that the seller creates. This value displays as the
        ///     order identifier in recipient-facing materials such as the outbound shipment packing slip. The value of
        ///     DisplayableOrderId should match the order identifier that the seller provides to the recipient. The seller can use
        ///     the SellerFulfillmentOrderId for this value or they can specify an alternate value if they want the recipient to
        ///     reference an alternate order identifier..
        /// </param>
        /// <param name="DisplayableOrderDateTime">
        ///     The date of the fulfillment order. Displays as the order date in
        ///     recipient-facing materials such as the outbound shipment packing slip..
        /// </param>
        /// <param name="DisplayableOrderComment">
        ///     Order-specific text that appears in recipient-facing materials such as the
        ///     outbound shipment packing slip..
        /// </param>
        /// <param name="ShippingSpeedCategory">ShippingSpeedCategory.</param>
        /// <param name="DestinationAddress">The destination address for the fulfillment order..</param>
        /// <param name="FulfillmentAction">FulfillmentAction.</param>
        /// <param name="FulfillmentPolicy">FulfillmentPolicy.</param>
        /// <param name="FulfillmentMethod">Indicates the intended recipient channel for the order..</param>
        /// <param name="ShipFromCountryCode">
        ///     The two-character country code for the country from which the fulfillment order
        ///     ships. Must be in ISO 3166-1 alpha-2 format..
        /// </param>
        /// <param name="NotificationEmailList">NotificationEmailList.</param>
        /// <param name="Items">A list of items to include in the fulfillment order preview, including quantity..</param>
        public UpdateFulfillmentOrderRequest(string MarketplaceId = default, string DisplayableOrderId = default,
            DateTime? DisplayableOrderDateTime = default, string DisplayableOrderComment = default,
            ShippingSpeedCategory? ShippingSpeedCategory = default, Address DestinationAddress = default,
            FulfillmentAction? FulfillmentAction = default, FulfillmentPolicy? FulfillmentPolicy = default,
            string ShipFromCountryCode = default, NotificationEmailList NotificationEmailList = default,
            UpdateFulfillmentOrderItemList Items = default)
        {
            this.MarketplaceId = MarketplaceId;
            this.DisplayableOrderId = DisplayableOrderId;
            DisplayableOrderDate = DisplayableOrderDateTime.Value;
            this.DisplayableOrderComment = DisplayableOrderComment;
            this.ShippingSpeedCategory = ShippingSpeedCategory;
            this.DestinationAddress = DestinationAddress;
            this.FulfillmentAction = FulfillmentAction;
            this.FulfillmentPolicy = FulfillmentPolicy;
            this.ShipFromCountryCode = ShipFromCountryCode;
            this.NotificationEmailList = NotificationEmailList;
            this.Items = Items;
        }

        [Obsolete("FulfillmentMethod no longer used and , use the other constructor instead")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public UpdateFulfillmentOrderRequest(string MarketplaceId = default, string DisplayableOrderId = default,
            Timestamp DisplayableOrderDateTime = default, string DisplayableOrderComment = default,
            ShippingSpeedCategory? ShippingSpeedCategory = default, Address DestinationAddress = default,
            FulfillmentAction? FulfillmentAction = default, FulfillmentPolicy? FulfillmentPolicy = default,
            string FulfillmentMethod = default, string ShipFromCountryCode = default,
            NotificationEmailList NotificationEmailList = default, UpdateFulfillmentOrderItemList Items = default)
            : this(MarketplaceId, DisplayableOrderId, null, DisplayableOrderComment, ShippingSpeedCategory,
                DestinationAddress, FulfillmentAction, FulfillmentPolicy, ShipFromCountryCode, NotificationEmailList,
                Items)
        {
        }

        /// <summary>
        ///     Gets or Sets ShippingSpeedCategory
        /// </summary>
        [DataMember(Name = "ShippingSpeedCategory", EmitDefaultValue = false)]
        public ShippingSpeedCategory? ShippingSpeedCategory { get; set; }

        /// <summary>
        ///     Gets or Sets FulfillmentAction
        /// </summary>
        [DataMember(Name = "FulfillmentAction", EmitDefaultValue = false)]
        public FulfillmentAction? FulfillmentAction { get; set; }

        /// <summary>
        ///     Gets or Sets FulfillmentPolicy
        /// </summary>
        [DataMember(Name = "FulfillmentPolicy", EmitDefaultValue = false)]
        public FulfillmentPolicy? FulfillmentPolicy { get; set; }

        /// <summary>
        ///     The marketplace the fulfillment order is placed against.
        /// </summary>
        /// <value>The marketplace the fulfillment order is placed against.</value>
        [DataMember(Name = "MarketplaceId", EmitDefaultValue = false)]
        public string MarketplaceId { get; set; }

        /// <summary>
        ///     A fulfillment order identifier that the seller creates. This value displays as the order identifier in
        ///     recipient-facing materials such as the outbound shipment packing slip. The value of DisplayableOrderId should match
        ///     the order identifier that the seller provides to the recipient. The seller can use the SellerFulfillmentOrderId for
        ///     this value or they can specify an alternate value if they want the recipient to reference an alternate order
        ///     identifier.
        /// </summary>
        /// <value>
        ///     A fulfillment order identifier that the seller creates. This value displays as the order identifier in
        ///     recipient-facing materials such as the outbound shipment packing slip. The value of DisplayableOrderId should match
        ///     the order identifier that the seller provides to the recipient. The seller can use the SellerFulfillmentOrderId for
        ///     this value or they can specify an alternate value if they want the recipient to reference an alternate order
        ///     identifier.
        /// </value>
        [DataMember(Name = "DisplayableOrderId", EmitDefaultValue = false)]
        public string DisplayableOrderId { get; set; }

        /// <summary>
        ///     The date of the fulfillment order. Displays as the order date in recipient-facing materials such as the outbound
        ///     shipment packing slip.
        /// </summary>
        /// <value>
        ///     The date of the fulfillment order. Displays as the order date in recipient-facing materials such as the outbound
        ///     shipment packing slip.
        /// </value>
        [DataMember(Name = "DisplayableOrderDateTime", EmitDefaultValue = false)]
        public DateTime DisplayableOrderDate { get; set; }

        [Obsolete("Timestamp is no longer used, use DisplayableOrderDate instead")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Timestamp DisplayableOrderDateTime { get; set; }

        /// <summary>
        ///     Order-specific text that appears in recipient-facing materials such as the outbound shipment packing slip.
        /// </summary>
        /// <value>Order-specific text that appears in recipient-facing materials such as the outbound shipment packing slip.</value>
        [DataMember(Name = "DisplayableOrderComment", EmitDefaultValue = false)]
        public string DisplayableOrderComment { get; set; }


        /// <summary>
        ///     The destination address for the fulfillment order.
        /// </summary>
        /// <value>The destination address for the fulfillment order.</value>
        [DataMember(Name = "DestinationAddress", EmitDefaultValue = false)]
        public Address DestinationAddress { get; set; }


        /// <summary>
        ///     Indicates the intended recipient channel for the order.
        /// </summary>
        /// <value>Indicates the intended recipient channel for the order.</value>
        [DataMember(Name = "FulfillmentMethod", EmitDefaultValue = false)]
        [Obsolete("Property no longer used")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string FulfillmentMethod { get; set; }

        /// <summary>
        ///     The two-character country code for the country from which the fulfillment order ships. Must be in ISO 3166-1
        ///     alpha-2 format.
        /// </summary>
        /// <value>
        ///     The two-character country code for the country from which the fulfillment order ships. Must be in ISO 3166-1
        ///     alpha-2 format.
        /// </value>
        [DataMember(Name = "ShipFromCountryCode", EmitDefaultValue = false)]
        public string ShipFromCountryCode { get; set; }

        /// <summary>
        ///     Gets or Sets NotificationEmailList
        /// </summary>
        [DataMember(Name = "NotificationEmailList", EmitDefaultValue = false)]
        public NotificationEmailList NotificationEmailList { get; set; }

        /// <summary>
        ///     A list of items to include in the fulfillment order preview, including quantity.
        /// </summary>
        /// <value>A list of items to include in the fulfillment order preview, including quantity.</value>
        [DataMember(Name = "Items", EmitDefaultValue = false)]
        public UpdateFulfillmentOrderItemList Items { get; set; }

        /// <summary>
        ///     Returns true if UpdateFulfillmentOrderRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateFulfillmentOrderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateFulfillmentOrderRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    MarketplaceId == input.MarketplaceId ||
                    (MarketplaceId != null &&
                     MarketplaceId.Equals(input.MarketplaceId))
                ) &&
                (
                    DisplayableOrderId == input.DisplayableOrderId ||
                    (DisplayableOrderId != null &&
                     DisplayableOrderId.Equals(input.DisplayableOrderId))
                ) &&
                (
                    DisplayableOrderDate == input.DisplayableOrderDate ||
                    DisplayableOrderDate.Equals(input.DisplayableOrderDate)
                ) &&
                (
                    DisplayableOrderComment == input.DisplayableOrderComment ||
                    (DisplayableOrderComment != null &&
                     DisplayableOrderComment.Equals(input.DisplayableOrderComment))
                ) &&
                (
                    ShippingSpeedCategory == input.ShippingSpeedCategory ||
                    (ShippingSpeedCategory != null &&
                     ShippingSpeedCategory.Equals(input.ShippingSpeedCategory))
                ) &&
                (
                    DestinationAddress == input.DestinationAddress ||
                    (DestinationAddress != null &&
                     DestinationAddress.Equals(input.DestinationAddress))
                ) &&
                (
                    FulfillmentAction == input.FulfillmentAction ||
                    (FulfillmentAction != null &&
                     FulfillmentAction.Equals(input.FulfillmentAction))
                ) &&
                (
                    FulfillmentPolicy == input.FulfillmentPolicy ||
                    (FulfillmentPolicy != null &&
                     FulfillmentPolicy.Equals(input.FulfillmentPolicy))
                ) &&
                (
                    ShipFromCountryCode == input.ShipFromCountryCode ||
                    (ShipFromCountryCode != null &&
                     ShipFromCountryCode.Equals(input.ShipFromCountryCode))
                ) &&
                (
                    NotificationEmailList == input.NotificationEmailList ||
                    (NotificationEmailList != null &&
                     NotificationEmailList.Equals(input.NotificationEmailList))
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
            // DisplayableOrderId (string) maxLength
            if (DisplayableOrderId != null && DisplayableOrderId.Length > 40)
                yield return new ValidationResult("Invalid value for DisplayableOrderId, length must be less than 40.",
                    new[] { "DisplayableOrderId" });

            // DisplayableOrderComment (string) maxLength
            if (DisplayableOrderComment != null && DisplayableOrderComment.Length > 1000)
                yield return new ValidationResult(
                    "Invalid value for DisplayableOrderComment, length must be less than 1000.",
                    new[] { "DisplayableOrderComment" });
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateFulfillmentOrderRequest {\n");
            sb.Append("  MarketplaceId: ").Append(MarketplaceId).Append("\n");
            sb.Append("  DisplayableOrderId: ").Append(DisplayableOrderId).Append("\n");
            sb.Append("  DisplayableOrderDate: ").Append(DisplayableOrderDate).Append("\n");
            sb.Append("  DisplayableOrderComment: ").Append(DisplayableOrderComment).Append("\n");
            sb.Append("  ShippingSpeedCategory: ").Append(ShippingSpeedCategory).Append("\n");
            sb.Append("  DestinationAddress: ").Append(DestinationAddress).Append("\n");
            sb.Append("  FulfillmentAction: ").Append(FulfillmentAction).Append("\n");
            sb.Append("  FulfillmentPolicy: ").Append(FulfillmentPolicy).Append("\n");
            sb.Append("  ShipFromCountryCode: ").Append(ShipFromCountryCode).Append("\n");
            sb.Append("  NotificationEmailList: ").Append(NotificationEmailList).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return Equals(input as UpdateFulfillmentOrderRequest);
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
                if (MarketplaceId != null)
                    hashCode = hashCode * 59 + MarketplaceId.GetHashCode();
                if (DisplayableOrderId != null)
                    hashCode = hashCode * 59 + DisplayableOrderId.GetHashCode();
                if (DisplayableOrderDate != null)
                    hashCode = hashCode * 59 + DisplayableOrderDate.GetHashCode();
                if (DisplayableOrderComment != null)
                    hashCode = hashCode * 59 + DisplayableOrderComment.GetHashCode();
                if (ShippingSpeedCategory != null)
                    hashCode = hashCode * 59 + ShippingSpeedCategory.GetHashCode();
                if (DestinationAddress != null)
                    hashCode = hashCode * 59 + DestinationAddress.GetHashCode();
                if (FulfillmentAction != null)
                    hashCode = hashCode * 59 + FulfillmentAction.GetHashCode();
                if (FulfillmentPolicy != null)
                    hashCode = hashCode * 59 + FulfillmentPolicy.GetHashCode();
                if (ShipFromCountryCode != null)
                    hashCode = hashCode * 59 + ShipFromCountryCode.GetHashCode();
                if (NotificationEmailList != null)
                    hashCode = hashCode * 59 + NotificationEmailList.GetHashCode();
                if (Items != null)
                    hashCode = hashCode * 59 + Items.GetHashCode();
                return hashCode;
            }
        }
    }
}