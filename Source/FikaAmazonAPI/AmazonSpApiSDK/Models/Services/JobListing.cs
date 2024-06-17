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
    ///     The payload for the GetJobs operation.
    /// </summary>
    [DataContract]
    public class JobListing : IEquatable<JobListing>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="JobListing" /> class.
        /// </summary>
        /// <param name="TotalResultSize">Total result size of the query result..</param>
        /// <param name="NextPageToken">
        ///     A generated string used to pass information to your next request.If nextPageToken is
        ///     returned, pass the value of nextPageToken to the pageToken to get next results..
        /// </param>
        /// <param name="PreviousPageToken">
        ///     A generated string used to pass information to your next request.If previousPageToken
        ///     is returned, pass the value of previousPageToken to the pageToken to get previous page results..
        /// </param>
        /// <param name="Jobs">List of job details for the given input..</param>
        public JobListing(int? TotalResultSize = default, string NextPageToken = default,
            string PreviousPageToken = default, List<ServiceJob> Jobs = default)
        {
            this.TotalResultSize = TotalResultSize;
            this.NextPageToken = NextPageToken;
            this.PreviousPageToken = PreviousPageToken;
            this.Jobs = Jobs;
        }

        /// <summary>
        ///     Total result size of the query result.
        /// </summary>
        /// <value>Total result size of the query result.</value>
        [DataMember(Name = "totalResultSize", EmitDefaultValue = false)]
        public int? TotalResultSize { get; set; }

        /// <summary>
        ///     A generated string used to pass information to your next request.If nextPageToken is returned, pass the value of
        ///     nextPageToken to the pageToken to get next results.
        /// </summary>
        /// <value>
        ///     A generated string used to pass information to your next request.If nextPageToken is returned, pass the value of
        ///     nextPageToken to the pageToken to get next results.
        /// </value>
        [DataMember(Name = "nextPageToken", EmitDefaultValue = false)]
        public string NextPageToken { get; set; }

        /// <summary>
        ///     A generated string used to pass information to your next request.If previousPageToken is returned, pass the value
        ///     of previousPageToken to the pageToken to get previous page results.
        /// </summary>
        /// <value>
        ///     A generated string used to pass information to your next request.If previousPageToken is returned, pass the
        ///     value of previousPageToken to the pageToken to get previous page results.
        /// </value>
        [DataMember(Name = "previousPageToken", EmitDefaultValue = false)]
        public string PreviousPageToken { get; set; }

        /// <summary>
        ///     List of job details for the given input.
        /// </summary>
        /// <value>List of job details for the given input.</value>
        [DataMember(Name = "jobs", EmitDefaultValue = false)]
        public List<ServiceJob> Jobs { get; set; }

        /// <summary>
        ///     Returns true if JobListing instances are equal
        /// </summary>
        /// <param name="input">Instance of JobListing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobListing input)
        {
            if (input == null)
                return false;

            return
                (
                    TotalResultSize == input.TotalResultSize ||
                    (TotalResultSize != null &&
                     TotalResultSize.Equals(input.TotalResultSize))
                ) &&
                (
                    NextPageToken == input.NextPageToken ||
                    (NextPageToken != null &&
                     NextPageToken.Equals(input.NextPageToken))
                ) &&
                (
                    PreviousPageToken == input.PreviousPageToken ||
                    (PreviousPageToken != null &&
                     PreviousPageToken.Equals(input.PreviousPageToken))
                ) &&
                (
                    Jobs == input.Jobs ||
                    (Jobs != null &&
                     Jobs.SequenceEqual(input.Jobs))
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
            sb.Append("class JobListing {\n");
            sb.Append("  TotalResultSize: ").Append(TotalResultSize).Append("\n");
            sb.Append("  NextPageToken: ").Append(NextPageToken).Append("\n");
            sb.Append("  PreviousPageToken: ").Append(PreviousPageToken).Append("\n");
            sb.Append("  Jobs: ").Append(Jobs).Append("\n");
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
            return Equals(input as JobListing);
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
                if (TotalResultSize != null)
                    hashCode = hashCode * 59 + TotalResultSize.GetHashCode();
                if (NextPageToken != null)
                    hashCode = hashCode * 59 + NextPageToken.GetHashCode();
                if (PreviousPageToken != null)
                    hashCode = hashCode * 59 + PreviousPageToken.GetHashCode();
                if (Jobs != null)
                    hashCode = hashCode * 59 + Jobs.GetHashCode();
                return hashCode;
            }
        }
    }
}