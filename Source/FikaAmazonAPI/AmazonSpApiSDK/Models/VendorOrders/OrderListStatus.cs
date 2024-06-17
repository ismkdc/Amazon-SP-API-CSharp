using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.VendorOrders
{
    [DataContract]
    public class OrderListStatus : IEquatable<OrderListStatus>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="OrderList" /> class.
        /// </summary>
        /// <param name="pagination">pagination.</param>
        /// <param name="orders">orders.</param>
        public OrderListStatus(Pagination pagination = default, List<OrderStatus> ordersStatus = default)
        {
            Pagination = pagination;
            OrdersStatus = ordersStatus;
        }

        /// <summary>
        ///     Gets or Sets Pagination
        /// </summary>
        [DataMember(Name = "pagination", EmitDefaultValue = false)]
        public Pagination Pagination { get; set; }

        /// <summary>
        ///     Gets or Sets Orders
        /// </summary>
        [DataMember(Name = "ordersStatus", EmitDefaultValue = false)]
        public List<OrderStatus> OrdersStatus { get; set; }

        /// <summary>
        ///     Returns true if OrderList instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderListStatus input)
        {
            if (input == null)
                return false;

            return
                (
                    Pagination == input.Pagination ||
                    (Pagination != null &&
                     Pagination.Equals(input.Pagination))
                ) &&
                (
                    OrdersStatus == input.OrdersStatus ||
                    (OrdersStatus != null &&
                     OrdersStatus.SequenceEqual(input.OrdersStatus))
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
            sb.Append("class OrderListStatus {\n");
            sb.Append("  Pagination: ").Append(Pagination).Append("\n");
            sb.Append("  OrdersStatus: ").Append(OrdersStatus).Append("\n");
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
            return Equals(input as OrderListStatus);
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
                if (Pagination != null)
                    hashCode = hashCode * 59 + Pagination.GetHashCode();
                if (OrdersStatus != null)
                    hashCode = hashCode * 59 + OrdersStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}