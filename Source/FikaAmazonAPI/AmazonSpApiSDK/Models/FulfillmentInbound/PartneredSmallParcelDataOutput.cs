/*
 * Selling Partner API for Fulfillment Inbound
 *
 * The Selling Partner API for Fulfillment Inbound lets you create applications that create and update inbound shipments of inventory to Amazon's fulfillment network.
 *
 * OpenAPI spec version: v0
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

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInbound
{
    /// <summary>
    ///     Information returned by Amazon about a Small Parcel shipment by an Amazon-partnered carrier.
    /// </summary>
    [DataContract]
    public class PartneredSmallParcelDataOutput : IEquatable<PartneredSmallParcelDataOutput>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="PartneredSmallParcelDataOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PartneredSmallParcelDataOutput()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="PartneredSmallParcelDataOutput" /> class.
        /// </summary>
        /// <param name="packageList">packageList (required).</param>
        /// <param name="partneredEstimate">partneredEstimate.</param>
        public PartneredSmallParcelDataOutput(PartneredSmallParcelPackageOutputList packageList = default,
            PartneredEstimate partneredEstimate = default)
        {
            // to ensure "packageList" is required (not null)
            if (packageList == null)
                throw new InvalidDataException(
                    "packageList is a required property for PartneredSmallParcelDataOutput and cannot be null");
            PackageList = packageList;
            PartneredEstimate = partneredEstimate;
        }

        /// <summary>
        ///     Gets or Sets PackageList
        /// </summary>
        [DataMember(Name = "PackageList", EmitDefaultValue = false)]
        public PartneredSmallParcelPackageOutputList PackageList { get; set; }

        /// <summary>
        ///     Gets or Sets PartneredEstimate
        /// </summary>
        [DataMember(Name = "PartneredEstimate", EmitDefaultValue = false)]
        public PartneredEstimate PartneredEstimate { get; set; }

        /// <summary>
        ///     Returns true if PartneredSmallParcelDataOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of PartneredSmallParcelDataOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PartneredSmallParcelDataOutput input)
        {
            if (input == null)
                return false;

            return
                (
                    PackageList == input.PackageList ||
                    (PackageList != null &&
                     PackageList.Equals(input.PackageList))
                ) &&
                (
                    PartneredEstimate == input.PartneredEstimate ||
                    (PartneredEstimate != null &&
                     PartneredEstimate.Equals(input.PartneredEstimate))
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
            sb.Append("class PartneredSmallParcelDataOutput {\n");
            sb.Append("  PackageList: ").Append(PackageList).Append("\n");
            sb.Append("  PartneredEstimate: ").Append(PartneredEstimate).Append("\n");
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
            return Equals(input as PartneredSmallParcelDataOutput);
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
                if (PackageList != null)
                    hashCode = hashCode * 59 + PackageList.GetHashCode();
                if (PartneredEstimate != null)
                    hashCode = hashCode * 59 + PartneredEstimate.GetHashCode();
                return hashCode;
            }
        }
    }
}