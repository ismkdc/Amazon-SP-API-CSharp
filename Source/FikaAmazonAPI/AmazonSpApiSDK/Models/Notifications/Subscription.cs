/* 
 * Selling Partner API for Notifications
 *
 * The Selling Partner API for Notifications lets you subscribe to notifications that are relevant to a selling partner's business. Using this API you can create a destination to receive notifications, subscribe to notifications, delete notification subscriptions, and more.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Notifications
{
    /// <summary>
    /// Represents a subscription to receive notifications.
    /// </summary>
    [DataContract]
    public partial class Subscription : IEquatable<Subscription>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Subscription() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription" /> class.
        /// </summary>
        /// <param name="SubscriptionId">The subscription identifier generated when the subscription is created. (required).</param>
        /// <param name="PayloadVersion">The version of the payload object to be used in the notification. (required).</param>
        /// <param name="DestinationId">The identifier for the destination where notifications will be delivered. (required).</param>
        public Subscription(string SubscriptionId = default(string), string PayloadVersion = default(string), string DestinationId = default(string))
        {
            // to ensure "SubscriptionId" is required (not null)
            if (SubscriptionId == null)
            {
                throw new InvalidDataException("SubscriptionId is a required property for Subscription and cannot be null");
            }
            else
            {
                this.SubscriptionId = SubscriptionId;
            }
            // to ensure "PayloadVersion" is required (not null)
            if (PayloadVersion == null)
            {
                throw new InvalidDataException("PayloadVersion is a required property for Subscription and cannot be null");
            }
            else
            {
                this.PayloadVersion = PayloadVersion;
            }
            // to ensure "DestinationId" is required (not null)
            if (DestinationId == null)
            {
                throw new InvalidDataException("DestinationId is a required property for Subscription and cannot be null");
            }
            else
            {
                this.DestinationId = DestinationId;
            }
        }

        /// <summary>
        /// The subscription identifier generated when the subscription is created.
        /// </summary>
        /// <value>The subscription identifier generated when the subscription is created.</value>
        [DataMember(Name = "subscriptionId", EmitDefaultValue = false)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// The version of the payload object to be used in the notification.
        /// </summary>
        /// <value>The version of the payload object to be used in the notification.</value>
        [DataMember(Name = "payloadVersion", EmitDefaultValue = false)]
        public string PayloadVersion { get; set; }

        /// <summary>
        /// The identifier for the destination where notifications will be delivered.
        /// </summary>
        /// <value>The identifier for the destination where notifications will be delivered.</value>
        [DataMember(Name = "destinationId", EmitDefaultValue = false)]
        public string DestinationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Subscription {\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  PayloadVersion: ").Append(PayloadVersion).Append("\n");
            sb.Append("  DestinationId: ").Append(DestinationId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as Subscription);
        }

        /// <summary>
        /// Returns true if Subscription instances are equal
        /// </summary>
        /// <param name="input">Instance of Subscription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Subscription input)
        {
            if (input == null)
                return false;

            return
                (
                    this.SubscriptionId == input.SubscriptionId ||
                    (this.SubscriptionId != null &&
                    this.SubscriptionId.Equals(input.SubscriptionId))
                ) &&
                (
                    this.PayloadVersion == input.PayloadVersion ||
                    (this.PayloadVersion != null &&
                    this.PayloadVersion.Equals(input.PayloadVersion))
                ) &&
                (
                    this.DestinationId == input.DestinationId ||
                    (this.DestinationId != null &&
                    this.DestinationId.Equals(input.DestinationId))
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
                if (this.SubscriptionId != null)
                    hashCode = hashCode * 59 + this.SubscriptionId.GetHashCode();
                if (this.PayloadVersion != null)
                    hashCode = hashCode * 59 + this.PayloadVersion.GetHashCode();
                if (this.DestinationId != null)
                    hashCode = hashCode * 59 + this.DestinationId.GetHashCode();
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
