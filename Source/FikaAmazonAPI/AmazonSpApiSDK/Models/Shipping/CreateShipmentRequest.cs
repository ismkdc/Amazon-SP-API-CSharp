/*
 * Selling Partner API for Shipping
 *
 * Provides programmatic access to Amazon Shipping APIs.
 *
 * OpenAPI spec version: v1
 *
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Shipping
{
    /// <summary>
    ///     The request schema for the createShipment operation.
    /// </summary>
    [DataContract]
    public class CreateShipmentRequest : IEquatable<CreateShipmentRequest>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="CreateShipmentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public CreateShipmentRequest()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="CreateShipmentRequest" /> class.
        /// </summary>
        /// <param name="ClientReferenceId">ClientReferenceId (required).</param>
        /// <param name="ShipTo">ShipTo (required).</param>
        /// <param name="ShipFrom">ShipFrom (required).</param>
        /// <param name="Containers">Containers (required).</param>
        public CreateShipmentRequest(string ClientReferenceId = default, Address ShipTo = default,
            Address ShipFrom = default, ContainerList Containers = default)
        {
            // to ensure "ClientReferenceId" is required (not null)
            if (ClientReferenceId == null)
                throw new InvalidDataException(
                    "ClientReferenceId is a required property for CreateShipmentRequest and cannot be null");
            this.ClientReferenceId = ClientReferenceId;
            // to ensure "ShipTo" is required (not null)
            if (ShipTo == null)
                throw new InvalidDataException(
                    "ShipTo is a required property for CreateShipmentRequest and cannot be null");
            this.ShipTo = ShipTo;
            // to ensure "ShipFrom" is required (not null)
            if (ShipFrom == null)
                throw new InvalidDataException(
                    "ShipFrom is a required property for CreateShipmentRequest and cannot be null");
            this.ShipFrom = ShipFrom;
            // to ensure "Containers" is required (not null)
            if (Containers == null)
                throw new InvalidDataException(
                    "Containers is a required property for CreateShipmentRequest and cannot be null");
            this.Containers = Containers;
        }

        /// <summary>
        ///     Gets or Sets ClientReferenceId
        /// </summary>
        [DataMember(Name = "clientReferenceId", EmitDefaultValue = false)]
        public string ClientReferenceId { get; set; }

        /// <summary>
        ///     Gets or Sets ShipTo
        /// </summary>
        [DataMember(Name = "shipTo", EmitDefaultValue = false)]
        public Address ShipTo { get; set; }

        /// <summary>
        ///     Gets or Sets ShipFrom
        /// </summary>
        [DataMember(Name = "shipFrom", EmitDefaultValue = false)]
        public Address ShipFrom { get; set; }

        /// <summary>
        ///     Gets or Sets Containers
        /// </summary>
        [DataMember(Name = "containers", EmitDefaultValue = false)]
        public ContainerList Containers { get; set; }

        /// <summary>
        ///     Returns true if CreateShipmentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateShipmentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateShipmentRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    ClientReferenceId == input.ClientReferenceId ||
                    (ClientReferenceId != null &&
                     ClientReferenceId.Equals(input.ClientReferenceId))
                ) &&
                (
                    ShipTo == input.ShipTo ||
                    (ShipTo != null &&
                     ShipTo.Equals(input.ShipTo))
                ) &&
                (
                    ShipFrom == input.ShipFrom ||
                    (ShipFrom != null &&
                     ShipFrom.Equals(input.ShipFrom))
                ) &&
                (
                    Containers == input.Containers ||
                    (Containers != null &&
                     Containers.Equals(input.Containers))
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
            sb.Append("class CreateShipmentRequest {\n");
            sb.Append("  ClientReferenceId: ").Append(ClientReferenceId).Append("\n");
            sb.Append("  ShipTo: ").Append(ShipTo).Append("\n");
            sb.Append("  ShipFrom: ").Append(ShipFrom).Append("\n");
            sb.Append("  Containers: ").Append(Containers).Append("\n");
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
            return Equals(input as CreateShipmentRequest);
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
                if (ClientReferenceId != null)
                    hashCode = hashCode * 59 + ClientReferenceId.GetHashCode();
                if (ShipTo != null)
                    hashCode = hashCode * 59 + ShipTo.GetHashCode();
                if (ShipFrom != null)
                    hashCode = hashCode * 59 + ShipFrom.GetHashCode();
                if (Containers != null)
                    hashCode = hashCode * 59 + Containers.GetHashCode();
                return hashCode;
            }
        }
    }
}