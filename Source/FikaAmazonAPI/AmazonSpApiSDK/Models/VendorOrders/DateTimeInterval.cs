using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.VendorOrders
{
    [DataContract]
    public class DateTimeInterval : IEquatable<DateTimeInterval>, IValidatableObject
    {
        private readonly string dateTimeIntervalStr;

        public DateTimeInterval(string dateTimeInterval = default)
        {
            dateTimeIntervalStr = dateTimeInterval;
            var intervalWithSpaceDelimiter = dateTimeInterval.Replace("--", " ");
            var dateStrings = intervalWithSpaceDelimiter.Split(' ');
            StartDate = DateTime.Parse(dateStrings[0]).ToUniversalTime();
            EndDate = DateTime.Parse(dateStrings[1]).ToUniversalTime();
        }

        [DataMember(Name = "startDate", EmitDefaultValue = false)]
        public DateTime StartDate { get; set; }

        [DataMember(Name = "endDate", EmitDefaultValue = false)]
        public DateTime EndDate { get; set; }

        public bool Equals(DateTimeInterval input)
        {
            if (input == null)
                return false;
            return
                dateTimeIntervalStr == input.dateTimeIntervalStr ||
                (dateTimeIntervalStr != null &&
                 dateTimeIntervalStr.Equals(input.dateTimeIntervalStr));
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

        public static explicit operator DateTimeInterval(string interval)
        {
            return new DateTimeInterval(interval);
        }

        public override string ToString()
        {
            return dateTimeIntervalStr;
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
            return Equals(input as DateTimeInterval);
        }

        /// <summary>
        ///     Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            return dateTimeIntervalStr.GetHashCode();
        }
    }
}