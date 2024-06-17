using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Orders
{
    /// <summary>
    ///     Business days and hours when the destination is open for deliveries.
    /// </summary>
    [DataContract]
    public class BusinessHours : IEquatable<BusinessHours>, IValidatableObject
    {
        /// <summary>
        ///     Day of the week.
        /// </summary>
        /// <value>Day of the week.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DayOfWeekEnum
        {
            /// <summary>
            ///     Enum SUN for value: SUN
            /// </summary>
            [EnumMember(Value = "SUN")] SUN = 1,

            /// <summary>
            ///     Enum MON for value: MON
            /// </summary>
            [EnumMember(Value = "MON")] MON = 2,

            /// <summary>
            ///     Enum TUE for value: TUE
            /// </summary>
            [EnumMember(Value = "TUE")] TUE = 3,

            /// <summary>
            ///     Enum WED for value: WED
            /// </summary>
            [EnumMember(Value = "WED")] WED = 4,

            /// <summary>
            ///     Enum THU for value: THU
            /// </summary>
            [EnumMember(Value = "THU")] THU = 5,

            /// <summary>
            ///     Enum FRI for value: FRI
            /// </summary>
            [EnumMember(Value = "FRI")] FRI = 6,

            /// <summary>
            ///     Enum SAT for value: SAT
            /// </summary>
            [EnumMember(Value = "SAT")] SAT = 7
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="BusinessHours" /> class.
        /// </summary>
        /// <param name="dayOfWeek">Day of the week..</param>
        /// <param name="openIntervals">Time window during the day when the business is open..</param>
        public BusinessHours(DayOfWeekEnum? dayOfWeek = default, List<OpenInterval> openIntervals = default)
        {
            DayOfWeek = dayOfWeek;
            OpenIntervals = openIntervals;
        }

        public BusinessHours()
        {
        }

        /// <summary>
        ///     Day of the week.
        /// </summary>
        /// <value>Day of the week.</value>
        [DataMember(Name = "DayOfWeek", EmitDefaultValue = false)]
        public DayOfWeekEnum? DayOfWeek { get; set; }

        /// <summary>
        ///     Time window during the day when the business is open.
        /// </summary>
        /// <value>Time window during the day when the business is open.</value>
        [DataMember(Name = "OpenIntervals", EmitDefaultValue = false)]
        public List<OpenInterval> OpenIntervals { get; set; }

        /// <summary>
        ///     Returns true if BusinessHours instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessHours to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessHours input)
        {
            if (input == null)
                return false;

            return
                DayOfWeek == input.DayOfWeek ||
                (DayOfWeek != null &&
                 DayOfWeek.Equals(input.DayOfWeek));
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
            sb.Append("class BusinessHours {\n");
            sb.Append("  DayOfWeek: ").Append(DayOfWeek).Append("\n");
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
            return Equals(input as BusinessHours);
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
                if (DayOfWeek != null)
                    hashCode = hashCode * 59 + DayOfWeek.GetHashCode();
                if (OpenIntervals != null)
                    hashCode = hashCode * 59 + OpenIntervals.GetHashCode();
                return hashCode;
            }
        }
    }
}