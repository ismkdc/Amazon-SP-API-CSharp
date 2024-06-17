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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Shipping
{
    /// <summary>
    ///     A list of container.
    /// </summary>
    [DataContract]
    public class ContainerList : List<Container>, IEquatable<ContainerList>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ContainerList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ContainerList()
        {
        }

        /// <summary>
        ///     Returns true if ContainerList instances are equal
        /// </summary>
        /// <param name="input">Instance of ContainerList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContainerList input)
        {
            if (input == null)
                return false;

            return base.Equals(input);
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
            sb.Append("class ContainerList {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
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
            return Equals(input as ContainerList);
        }

        /// <summary>
        ///     Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            var hashCode = base.GetHashCode();
            return hashCode;
        }
    }
}