/* 
 * Selling Partner API for Fulfillment Outbound
 *
 * The Selling Partner API for Fulfillment Outbound lets you create applications that help a seller fulfill Multi-Channel Fulfillment orders using their inventory in Amazon's fulfillment network. You can get information on both potential and existing fulfillment orders.
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

namespace AmazonSpApiSDK.Models.FulfillmentOutbound
{
    /// <summary>
    /// Address information for tracking the package.
    /// </summary>
    [DataContract]
    public partial class TrackingAddress : IEquatable<TrackingAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingAddress" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrackingAddress() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingAddress" /> class.
        /// </summary>
        /// <param name="City">The city. (required).</param>
        /// <param name="State">The state. (required).</param>
        /// <param name="Country">The country. (required).</param>
        public TrackingAddress(string City = default(string), string State = default(string), string Country = default(string))
        {
            // to ensure "City" is required (not null)
            if (City == null)
            {
                throw new InvalidDataException("City is a required property for TrackingAddress and cannot be null");
            }
            else
            {
                this.City = City;
            }
            // to ensure "State" is required (not null)
            if (State == null)
            {
                throw new InvalidDataException("State is a required property for TrackingAddress and cannot be null");
            }
            else
            {
                this.State = State;
            }
            // to ensure "Country" is required (not null)
            if (Country == null)
            {
                throw new InvalidDataException("Country is a required property for TrackingAddress and cannot be null");
            }
            else
            {
                this.Country = Country;
            }
        }

        /// <summary>
        /// The city.
        /// </summary>
        /// <value>The city.</value>
        [DataMember(Name = "City", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// The state.
        /// </summary>
        /// <value>The state.</value>
        [DataMember(Name = "State", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// The country.
        /// </summary>
        /// <value>The country.</value>
        [DataMember(Name = "Country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrackingAddress {\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
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
            return this.Equals(input as TrackingAddress);
        }

        /// <summary>
        /// Returns true if TrackingAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackingAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackingAddress input)
        {
            if (input == null)
                return false;

            return
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) &&
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) &&
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
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
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
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
            // City (string) maxLength
            if (this.City != null && this.City.Length > 150)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for City, length must be less than 150.", new[] { "City" });
            }

            // State (string) maxLength
            if (this.State != null && this.State.Length > 150)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for State, length must be less than 150.", new[] { "State" });
            }

            // Country (string) maxLength
            if (this.Country != null && this.Country.Length > 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Country, length must be less than 6.", new[] { "Country" });
            }

            yield break;
        }
    }

}
