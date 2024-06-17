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
    ///     The payload schema for the getRates operation.
    /// </summary>
    [DataContract]
    public class GetRatesRequest : IEquatable<GetRatesRequest>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="GetRatesRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public GetRatesRequest()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="GetRatesRequest" /> class.
        /// </summary>
        /// <param name="ShipTo">ShipTo (required).</param>
        /// <param name="ShipFrom">ShipFrom (required).</param>
        /// <param name="ServiceTypes">ServiceTypes (required).</param>
        /// <param name="ShipDate">The start date and time. This defaults to the current date and time..</param>
        /// <param name="ContainerSpecifications">ContainerSpecifications (required).</param>
        public GetRatesRequest(Address ShipTo = default, Address ShipFrom = default,
            ServiceTypeList ServiceTypes = default, DateTime? ShipDate = default,
            ContainerSpecificationList ContainerSpecifications = default)
        {
            // to ensure "ShipTo" is required (not null)
            if (ShipTo == null)
                throw new InvalidDataException("ShipTo is a required property for GetRatesRequest and cannot be null");
            this.ShipTo = ShipTo;
            // to ensure "ShipFrom" is required (not null)
            if (ShipFrom == null)
                throw new InvalidDataException(
                    "ShipFrom is a required property for GetRatesRequest and cannot be null");
            this.ShipFrom = ShipFrom;
            // to ensure "ServiceTypes" is required (not null)
            if (ServiceTypes == null)
                throw new InvalidDataException(
                    "ServiceTypes is a required property for GetRatesRequest and cannot be null");
            this.ServiceTypes = ServiceTypes;
            // to ensure "ContainerSpecifications" is required (not null)
            if (ContainerSpecifications == null)
                throw new InvalidDataException(
                    "ContainerSpecifications is a required property for GetRatesRequest and cannot be null");
            this.ContainerSpecifications = ContainerSpecifications;
            this.ShipDate = ShipDate;
        }

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
        ///     Gets or Sets ServiceTypes
        /// </summary>
        [DataMember(Name = "serviceTypes", EmitDefaultValue = false)]
        public ServiceTypeList ServiceTypes { get; set; }

        /// <summary>
        ///     The start date and time. This defaults to the current date and time.
        /// </summary>
        /// <value>The start date and time. This defaults to the current date and time.</value>
        [DataMember(Name = "shipDate", EmitDefaultValue = false)]
        public DateTime? ShipDate { get; set; }

        /// <summary>
        ///     Gets or Sets ContainerSpecifications
        /// </summary>
        [DataMember(Name = "containerSpecifications", EmitDefaultValue = false)]
        public ContainerSpecificationList ContainerSpecifications { get; set; }

        /// <summary>
        ///     Returns true if GetRatesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetRatesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetRatesRequest input)
        {
            if (input == null)
                return false;

            return
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
                    ServiceTypes == input.ServiceTypes ||
                    (ServiceTypes != null &&
                     ServiceTypes.Equals(input.ServiceTypes))
                ) &&
                (
                    ShipDate == input.ShipDate ||
                    (ShipDate != null &&
                     ShipDate.Equals(input.ShipDate))
                ) &&
                (
                    ContainerSpecifications == input.ContainerSpecifications ||
                    (ContainerSpecifications != null &&
                     ContainerSpecifications.Equals(input.ContainerSpecifications))
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
            sb.Append("class GetRatesRequest {\n");
            sb.Append("  ShipTo: ").Append(ShipTo).Append("\n");
            sb.Append("  ShipFrom: ").Append(ShipFrom).Append("\n");
            sb.Append("  ServiceTypes: ").Append(ServiceTypes).Append("\n");
            sb.Append("  ShipDate: ").Append(ShipDate).Append("\n");
            sb.Append("  ContainerSpecifications: ").Append(ContainerSpecifications).Append("\n");
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
            return Equals(input as GetRatesRequest);
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
                if (ShipTo != null)
                    hashCode = hashCode * 59 + ShipTo.GetHashCode();
                if (ShipFrom != null)
                    hashCode = hashCode * 59 + ShipFrom.GetHashCode();
                if (ServiceTypes != null)
                    hashCode = hashCode * 59 + ServiceTypes.GetHashCode();
                if (ShipDate != null)
                    hashCode = hashCode * 59 + ShipDate.GetHashCode();
                if (ContainerSpecifications != null)
                    hashCode = hashCode * 59 + ContainerSpecifications.GetHashCode();
                return hashCode;
            }
        }
    }
}