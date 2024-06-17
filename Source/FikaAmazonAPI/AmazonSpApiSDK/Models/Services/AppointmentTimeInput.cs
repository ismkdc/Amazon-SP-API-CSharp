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
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Services
{
    /// <summary>
    ///     The input appointment time details.
    /// </summary>
    [DataContract]
    public class AppointmentTimeInput : IEquatable<AppointmentTimeInput>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="AppointmentTimeInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public AppointmentTimeInput()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="AppointmentTimeInput" /> class.
        /// </summary>
        /// <param name="StartTime">The date, time in UTC for the start time of an appointment in ISO 8601 format. (required).</param>
        /// <param name="DurationInMinutes">The duration of an appointment in minutes..</param>
        public AppointmentTimeInput(DateTime? StartTime = default, int? DurationInMinutes = default)
        {
            // to ensure "StartTime" is required (not null)
            if (StartTime == null)
                throw new InvalidDataException(
                    "StartTime is a required property for AppointmentTimeInput and cannot be null");
            this.StartTime = StartTime;
            this.DurationInMinutes = DurationInMinutes;
        }

        /// <summary>
        ///     The date, time in UTC for the start time of an appointment in ISO 8601 format.
        /// </summary>
        /// <value>The date, time in UTC for the start time of an appointment in ISO 8601 format.</value>
        [DataMember(Name = "startTime", EmitDefaultValue = false)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        ///     The duration of an appointment in minutes.
        /// </summary>
        /// <value>The duration of an appointment in minutes.</value>
        [DataMember(Name = "durationInMinutes", EmitDefaultValue = false)]
        public int? DurationInMinutes { get; set; }

        /// <summary>
        ///     Returns true if AppointmentTimeInput instances are equal
        /// </summary>
        /// <param name="input">Instance of AppointmentTimeInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppointmentTimeInput input)
        {
            if (input == null)
                return false;

            return
                (
                    StartTime == input.StartTime ||
                    (StartTime != null &&
                     StartTime.Equals(input.StartTime))
                ) &&
                (
                    DurationInMinutes == input.DurationInMinutes ||
                    (DurationInMinutes != null &&
                     DurationInMinutes.Equals(input.DurationInMinutes))
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
            sb.Append("class AppointmentTimeInput {\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  DurationInMinutes: ").Append(DurationInMinutes).Append("\n");
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
            return Equals(input as AppointmentTimeInput);
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
                if (StartTime != null)
                    hashCode = hashCode * 59 + StartTime.GetHashCode();
                if (DurationInMinutes != null)
                    hashCode = hashCode * 59 + DurationInMinutes.GetHashCode();
                return hashCode;
            }
        }
    }
}