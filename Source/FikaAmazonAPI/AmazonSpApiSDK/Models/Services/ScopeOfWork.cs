/*
 * Selling Partner API for Services
 *
 * With the Services API, you can build applications that help service providers get and modify their service orders.
 *
 * OpenAPI spec version: v1
 *
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Services
{
    /// <summary>
    ///     The scope of work for the order.
    /// </summary>
    [DataContract]
    public class ScopeOfWork : IEquatable<ScopeOfWork>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ScopeOfWork" /> class.
        /// </summary>
        /// <param name="Asin">The Amazon Standard Identification Number (ASIN) of the service job..</param>
        /// <param name="Title">The title of the service job..</param>
        /// <param name="Quantity">The number of service jobs..</param>
        /// <param name="RequiredSkills">A list of skills required to perform the job..</param>
        public ScopeOfWork(string Asin = default, string Title = default, int? Quantity = default,
            List<string> RequiredSkills = default)
        {
            this.Asin = Asin;
            this.Title = Title;
            this.Quantity = Quantity;
            this.RequiredSkills = RequiredSkills;
        }

        /// <summary>
        ///     The Amazon Standard Identification Number (ASIN) of the service job.
        /// </summary>
        /// <value>The Amazon Standard Identification Number (ASIN) of the service job.</value>
        [DataMember(Name = "asin", EmitDefaultValue = false)]
        public string Asin { get; set; }

        /// <summary>
        ///     The title of the service job.
        /// </summary>
        /// <value>The title of the service job.</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        ///     The number of service jobs.
        /// </summary>
        /// <value>The number of service jobs.</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public int? Quantity { get; set; }

        /// <summary>
        ///     A list of skills required to perform the job.
        /// </summary>
        /// <value>A list of skills required to perform the job.</value>
        [DataMember(Name = "requiredSkills", EmitDefaultValue = false)]
        public List<string> RequiredSkills { get; set; }

        /// <summary>
        ///     Returns true if ScopeOfWork instances are equal
        /// </summary>
        /// <param name="input">Instance of ScopeOfWork to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScopeOfWork input)
        {
            if (input == null)
                return false;

            return
                (
                    Asin == input.Asin ||
                    (Asin != null &&
                     Asin.Equals(input.Asin))
                ) &&
                (
                    Title == input.Title ||
                    (Title != null &&
                     Title.Equals(input.Title))
                ) &&
                (
                    Quantity == input.Quantity ||
                    (Quantity != null &&
                     Quantity.Equals(input.Quantity))
                ) &&
                (
                    RequiredSkills == input.RequiredSkills ||
                    (RequiredSkills != null &&
                     RequiredSkills.SequenceEqual(input.RequiredSkills))
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
            sb.Append("class ScopeOfWork {\n");
            sb.Append("  Asin: ").Append(Asin).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  RequiredSkills: ").Append(RequiredSkills).Append("\n");
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
            return Equals(input as ScopeOfWork);
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
                if (Asin != null)
                    hashCode = hashCode * 59 + Asin.GetHashCode();
                if (Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();
                if (Quantity != null)
                    hashCode = hashCode * 59 + Quantity.GetHashCode();
                if (RequiredSkills != null)
                    hashCode = hashCode * 59 + RequiredSkills.GetHashCode();
                return hashCode;
            }
        }
    }
}