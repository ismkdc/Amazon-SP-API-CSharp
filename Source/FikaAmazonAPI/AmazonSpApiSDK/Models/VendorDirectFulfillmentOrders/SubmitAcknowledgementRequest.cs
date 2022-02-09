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
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.VendorDirectFulfillmentOrders
{
    /// <summary>
    /// The request schema for the submitAcknowledgement operation.
    /// </summary>
    [DataContract]
    public partial class SubmitAcknowledgementRequest :  IEquatable<SubmitAcknowledgementRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitAcknowledgementRequest" /> class.
        /// </summary>
        /// <param name="orderAcknowledgements">A list of one or more purchase orders..</param>
        public SubmitAcknowledgementRequest(List<OrderAcknowledgementItem> orderAcknowledgements = default(List<OrderAcknowledgementItem>))
        {
            this.OrderAcknowledgements = orderAcknowledgements;
        }
        
        /// <summary>
        /// A list of one or more purchase orders.
        /// </summary>
        /// <value>A list of one or more purchase orders.</value>
        [DataMember(Name="orderAcknowledgements", EmitDefaultValue=false)]
        public List<OrderAcknowledgementItem> OrderAcknowledgements { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubmitAcknowledgementRequest {\n");
            sb.Append("  OrderAcknowledgements: ").Append(OrderAcknowledgements).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubmitAcknowledgementRequest);
        }

        /// <summary>
        /// Returns true if SubmitAcknowledgementRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SubmitAcknowledgementRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubmitAcknowledgementRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrderAcknowledgements == input.OrderAcknowledgements ||
                    this.OrderAcknowledgements != null &&
                    this.OrderAcknowledgements.SequenceEqual(input.OrderAcknowledgements)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.OrderAcknowledgements != null)
                    hashCode = hashCode * 59 + this.OrderAcknowledgements.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
