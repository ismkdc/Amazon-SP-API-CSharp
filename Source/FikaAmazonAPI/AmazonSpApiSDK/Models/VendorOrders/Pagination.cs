﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.VendorOrders
{
    /// <summary>
    ///     Pagination
    /// </summary>
    [DataContract]
    public class Pagination : IEquatable<Pagination>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Pagination" /> class.
        /// </summary>
        /// <param name="nextToken">
        ///     A generated string used to pass information to your next request. If NextToken is returned,
        ///     pass the value of NextToken to the next request. If NextToken is not returned, there are no more order items to
        ///     return..
        /// </param>
        public Pagination(string nextToken = default)
        {
            NextToken = nextToken;
        }

        /// <summary>
        ///     A generated string used to pass information to your next request. If NextToken is returned, pass the value of
        ///     NextToken to the next request. If NextToken is not returned, there are no more order items to return.
        /// </summary>
        /// <value>
        ///     A generated string used to pass information to your next request. If NextToken is returned, pass the value of
        ///     NextToken to the next request. If NextToken is not returned, there are no more order items to return.
        /// </value>
        [DataMember(Name = "nextToken", EmitDefaultValue = false)]
        public string NextToken { get; set; }

        /// <summary>
        ///     Returns true if Pagination instances are equal
        /// </summary>
        /// <param name="input">Instance of Pagination to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Pagination input)
        {
            if (input == null)
                return false;

            return
                NextToken == input.NextToken ||
                (NextToken != null &&
                 NextToken.Equals(input.NextToken));
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
            sb.Append("class Pagination {\n");
            sb.Append("  NextToken: ").Append(NextToken).Append("\n");
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
            return Equals(input as Pagination);
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
                if (NextToken != null)
                    hashCode = hashCode * 59 + NextToken.GetHashCode();
                return hashCode;
            }
        }
    }
}