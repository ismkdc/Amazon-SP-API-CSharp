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
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
namespace FikaAmazonAPI.AmazonSpApiSDK.Models.VendorDirectFulfillmentOrders
{
    /// <summary>
    /// Address of the party.
    /// </summary>
    [DataContract]
    public partial class Address :  IEquatable<Address>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Address() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        /// <param name="name">The name of the person, business or institution at that address. (required).</param>
        /// <param name="attention">The attention name of the person at that address..</param>
        /// <param name="addressLine1">First line of the address. (required).</param>
        /// <param name="addressLine2">Additional address information, if required..</param>
        /// <param name="addressLine3">Additional address information, if required..</param>
        /// <param name="city">The city where the person, business or institution is located..</param>
        /// <param name="county">The county where person, business or institution is located..</param>
        /// <param name="district">The district where person, business or institution is located..</param>
        /// <param name="stateOrRegion">The state or region where person, business or institution is located. (required).</param>
        /// <param name="postalCode">The postal code of that address. It conatins a series of letters or digits or both, sometimes including spaces or punctuation..</param>
        /// <param name="countryCode">The two digit country code. In ISO 3166-1 alpha-2 format. (required).</param>
        /// <param name="phone">The phone number of the person, business or institution located at that address..</param>
        public Address(string name = default(string), string attention = default(string), string addressLine1 = default(string), string addressLine2 = default(string), string addressLine3 = default(string), string city = default(string), string county = default(string), string district = default(string), string stateOrRegion = default(string), string postalCode = default(string), string countryCode = default(string), string phone = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Address and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "addressLine1" is required (not null)
            if (addressLine1 == null)
            {
                throw new InvalidDataException("addressLine1 is a required property for Address and cannot be null");
            }
            else
            {
                this.AddressLine1 = addressLine1;
            }
            // to ensure "stateOrRegion" is required (not null)
            if (stateOrRegion == null)
            {
                throw new InvalidDataException("stateOrRegion is a required property for Address and cannot be null");
            }
            else
            {
                this.StateOrRegion = stateOrRegion;
            }
            // to ensure "countryCode" is required (not null)
            if (countryCode == null)
            {
                throw new InvalidDataException("countryCode is a required property for Address and cannot be null");
            }
            else
            {
                this.CountryCode = countryCode;
            }
            this.Attention = attention;
            this.AddressLine2 = addressLine2;
            this.AddressLine3 = addressLine3;
            this.City = city;
            this.County = county;
            this.District = district;
            this.PostalCode = postalCode;
            this.Phone = phone;
        }
        
        /// <summary>
        /// The name of the person, business or institution at that address.
        /// </summary>
        /// <value>The name of the person, business or institution at that address.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The attention name of the person at that address.
        /// </summary>
        /// <value>The attention name of the person at that address.</value>
        [DataMember(Name="attention", EmitDefaultValue=false)]
        public string Attention { get; set; }

        /// <summary>
        /// First line of the address.
        /// </summary>
        /// <value>First line of the address.</value>
        [DataMember(Name="addressLine1", EmitDefaultValue=false)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Additional address information, if required.
        /// </summary>
        /// <value>Additional address information, if required.</value>
        [DataMember(Name="addressLine2", EmitDefaultValue=false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Additional address information, if required.
        /// </summary>
        /// <value>Additional address information, if required.</value>
        [DataMember(Name="addressLine3", EmitDefaultValue=false)]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// The city where the person, business or institution is located.
        /// </summary>
        /// <value>The city where the person, business or institution is located.</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// The county where person, business or institution is located.
        /// </summary>
        /// <value>The county where person, business or institution is located.</value>
        [DataMember(Name="county", EmitDefaultValue=false)]
        public string County { get; set; }

        /// <summary>
        /// The district where person, business or institution is located.
        /// </summary>
        /// <value>The district where person, business or institution is located.</value>
        [DataMember(Name="district", EmitDefaultValue=false)]
        public string District { get; set; }

        /// <summary>
        /// The state or region where person, business or institution is located.
        /// </summary>
        /// <value>The state or region where person, business or institution is located.</value>
        [DataMember(Name="stateOrRegion", EmitDefaultValue=false)]
        public string StateOrRegion { get; set; }

        /// <summary>
        /// The postal code of that address. It conatins a series of letters or digits or both, sometimes including spaces or punctuation.
        /// </summary>
        /// <value>The postal code of that address. It conatins a series of letters or digits or both, sometimes including spaces or punctuation.</value>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The two digit country code. In ISO 3166-1 alpha-2 format.
        /// </summary>
        /// <value>The two digit country code. In ISO 3166-1 alpha-2 format.</value>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The phone number of the person, business or institution located at that address.
        /// </summary>
        /// <value>The phone number of the person, business or institution located at that address.</value>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Address {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Attention: ").Append(Attention).Append("\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  AddressLine3: ").Append(AddressLine3).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  County: ").Append(County).Append("\n");
            sb.Append("  District: ").Append(District).Append("\n");
            sb.Append("  StateOrRegion: ").Append(StateOrRegion).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
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
            return this.Equals(input as Address);
        }

        /// <summary>
        /// Returns true if Address instances are equal
        /// </summary>
        /// <param name="input">Instance of Address to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Address input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Attention == input.Attention ||
                    (this.Attention != null &&
                    this.Attention.Equals(input.Attention))
                ) && 
                (
                    this.AddressLine1 == input.AddressLine1 ||
                    (this.AddressLine1 != null &&
                    this.AddressLine1.Equals(input.AddressLine1))
                ) && 
                (
                    this.AddressLine2 == input.AddressLine2 ||
                    (this.AddressLine2 != null &&
                    this.AddressLine2.Equals(input.AddressLine2))
                ) && 
                (
                    this.AddressLine3 == input.AddressLine3 ||
                    (this.AddressLine3 != null &&
                    this.AddressLine3.Equals(input.AddressLine3))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.County == input.County ||
                    (this.County != null &&
                    this.County.Equals(input.County))
                ) && 
                (
                    this.District == input.District ||
                    (this.District != null &&
                    this.District.Equals(input.District))
                ) && 
                (
                    this.StateOrRegion == input.StateOrRegion ||
                    (this.StateOrRegion != null &&
                    this.StateOrRegion.Equals(input.StateOrRegion))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Attention != null)
                    hashCode = hashCode * 59 + this.Attention.GetHashCode();
                if (this.AddressLine1 != null)
                    hashCode = hashCode * 59 + this.AddressLine1.GetHashCode();
                if (this.AddressLine2 != null)
                    hashCode = hashCode * 59 + this.AddressLine2.GetHashCode();
                if (this.AddressLine3 != null)
                    hashCode = hashCode * 59 + this.AddressLine3.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.County != null)
                    hashCode = hashCode * 59 + this.County.GetHashCode();
                if (this.District != null)
                    hashCode = hashCode * 59 + this.District.GetHashCode();
                if (this.StateOrRegion != null)
                    hashCode = hashCode * 59 + this.StateOrRegion.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
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
