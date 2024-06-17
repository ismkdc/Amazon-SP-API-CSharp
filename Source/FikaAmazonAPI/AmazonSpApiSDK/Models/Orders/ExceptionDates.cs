using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Orders
{
    /// <summary>
    ///     Dates when the business is closed or open with a different time window.
    /// </summary>
    [DataContract]
    public class ExceptionDates : IEquatable<ExceptionDates>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ExceptionDates" /> class.
        /// </summary>
        /// <param name="exceptionDate">Date when the business is closed, in ISO-8601 date format..</param>
        /// <param name="isOpen">Boolean indicating if the business is closed or open on that date..</param>
        /// <param name="openIntervals">Time window during the day when the business is open..</param>
        public ExceptionDates(string exceptionDate = default, bool? isOpen = default,
            List<OpenInterval> openIntervals = default)
        {
            ExceptionDate = exceptionDate;
            IsOpen = isOpen;
            OpenIntervals = openIntervals;
        }

        public ExceptionDates()
        {
        }

        /// <summary>
        ///     Date when the business is closed, in ISO-8601 date format.
        /// </summary>
        /// <value>Date when the business is closed, in ISO-8601 date format.</value>
        [DataMember(Name = "ExceptionDate", EmitDefaultValue = false)]
        public string ExceptionDate { get; set; }

        /// <summary>
        ///     Boolean indicating if the business is closed or open on that date.
        /// </summary>
        /// <value>Boolean indicating if the business is closed or open on that date.</value>
        [DataMember(Name = "IsOpen", EmitDefaultValue = false)]
        public bool? IsOpen { get; set; }

        /// <summary>
        ///     Time window during the day when the business is open.
        /// </summary>
        /// <value>Time window during the day when the business is open.</value>
        [DataMember(Name = "OpenIntervals", EmitDefaultValue = false)]
        public List<OpenInterval> OpenIntervals { get; set; }

        /// <summary>
        ///     Returns true if ExceptionDates instances are equal
        /// </summary>
        /// <param name="input">Instance of ExceptionDates to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExceptionDates input)
        {
            if (input == null)
                return false;

            return
                (
                    ExceptionDate == input.ExceptionDate ||
                    (ExceptionDate != null &&
                     ExceptionDate.Equals(input.ExceptionDate))
                ) &&
                (
                    IsOpen == input.IsOpen ||
                    (IsOpen != null &&
                     IsOpen.Equals(input.IsOpen))
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
            sb.Append("class ExceptionDates {\n");
            sb.Append("  ExceptionDate: ").Append(ExceptionDate).Append("\n");
            sb.Append("  IsOpen: ").Append(IsOpen).Append("\n");
            sb.Append("  OpenIntervals: ").Append(OpenIntervals).Append("\n");
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
            return Equals(input as ExceptionDates);
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
                if (ExceptionDate != null)
                    hashCode = hashCode * 59 + ExceptionDate.GetHashCode();
                if (IsOpen != null)
                    hashCode = hashCode * 59 + IsOpen.GetHashCode();
                if (OpenIntervals != null)
                    hashCode = hashCode * 59 + OpenIntervals.GetHashCode();
                return hashCode;
            }
        }
    }
}