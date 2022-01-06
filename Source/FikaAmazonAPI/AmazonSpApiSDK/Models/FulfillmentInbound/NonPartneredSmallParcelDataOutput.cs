/* 
 * Selling Partner API for Fulfillment Inbound
 *
 * The Selling Partner API for Fulfillment Inbound lets you create applications that create and update inbound shipments of inventory to Amazon's fulfillment network.
 *
 * OpenAPI spec version: v0
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

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInbound
{
    /// <summary>
    /// Information returned by Amazon about a Small Parcel shipment by a carrier that has not partnered with Amazon.
    /// </summary>
    [DataContract]
    public partial class NonPartneredSmallParcelDataOutput : IEquatable<NonPartneredSmallParcelDataOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NonPartneredSmallParcelDataOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public NonPartneredSmallParcelDataOutput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NonPartneredSmallParcelDataOutput" /> class.
        /// </summary>
        /// <param name="PackageList">PackageList (required).</param>
        public NonPartneredSmallParcelDataOutput(NonPartneredSmallParcelPackageOutputList PackageList = default(NonPartneredSmallParcelPackageOutputList))
        {
            // to ensure "PackageList" is required (not null)
            if (PackageList == null)
            {
                throw new InvalidDataException("PackageList is a required property for NonPartneredSmallParcelDataOutput and cannot be null");
            }
            else
            {
                this.PackageList = PackageList;
            }
        }

        /// <summary>
        /// Gets or Sets PackageList
        /// </summary>
        [DataMember(Name = "PackageList", EmitDefaultValue = false)]
        public NonPartneredSmallParcelPackageOutputList PackageList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NonPartneredSmallParcelDataOutput {\n");
            sb.Append("  PackageList: ").Append(PackageList).Append("\n");
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
            return this.Equals(input as NonPartneredSmallParcelDataOutput);
        }

        /// <summary>
        /// Returns true if NonPartneredSmallParcelDataOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of NonPartneredSmallParcelDataOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NonPartneredSmallParcelDataOutput input)
        {
            if (input == null)
                return false;

            return
                (
                    this.PackageList == input.PackageList ||
                    (this.PackageList != null &&
                    this.PackageList.Equals(input.PackageList))
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
                if (this.PackageList != null)
                    hashCode = hashCode * 59 + this.PackageList.GetHashCode();
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
