/*
 * Selling Partner API for Reports
 *
 * The Selling Partner API for Reports lets you retrieve and manage a variety of reports that can help selling partners manage their businesses.
 *
 * OpenAPI spec version: 2020-09-04
 *
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Reports
{
    /// <summary>
    ///     The response for the getReportSchedules operation.
    /// </summary>
    [DataContract]
    public class GetReportSchedulesResponseV00 : IEquatable<GetReportSchedulesResponseV00>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="GetReportSchedulesResponseV00" /> class.
        /// </summary>
        /// <param name="ReportSchedules">The ReportSchedules for the getReportSchedules operation..</param>
        /// <param name="Errors">Errors.</param>
        public GetReportSchedulesResponseV00(ReportScheduleList ReportSchedules = default, ErrorList Errors = default)
        {
            this.ReportSchedules = ReportSchedules;
            this.Errors = Errors;
        }

        public GetReportSchedulesResponseV00()
        {
            ReportSchedules = default;
            Errors = default;
        }

        /// <summary>
        ///     The ReportSchedules for the getReportSchedules operation.
        /// </summary>
        /// <value>The ReportSchedules for the getReportSchedules operation.</value>
        [DataMember(Name = "reportSchedules", EmitDefaultValue = false)]
        public ReportScheduleList ReportSchedules { get; set; }

        /// <summary>
        ///     Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public ErrorList Errors { get; set; }

        /// <summary>
        ///     Returns true if GetReportSchedulesResponseV00 instances are equal
        /// </summary>
        /// <param name="input">Instance of GetReportSchedulesResponseV00 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetReportSchedulesResponseV00 input)
        {
            if (input == null)
                return false;

            return
                (
                    ReportSchedules == input.ReportSchedules ||
                    (ReportSchedules != null &&
                     ReportSchedules.Equals(input.ReportSchedules))
                ) &&
                (
                    Errors == input.Errors ||
                    (Errors != null &&
                     Errors.Equals(input.Errors))
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
            sb.Append("class GetReportSchedulesResponseV00 {\n");
            sb.Append("  ReportSchedules: ").Append(ReportSchedules).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
            return Equals(input as GetReportSchedulesResponseV00);
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
                if (ReportSchedules != null)
                    hashCode = hashCode * 59 + ReportSchedules.GetHashCode();
                if (Errors != null)
                    hashCode = hashCode * 59 + Errors.GetHashCode();
                return hashCode;
            }
        }
    }
}