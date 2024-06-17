using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Orders
{
    /// <summary>
    ///     Information about whether or not a buyer requested cancellation.
    /// </summary>
    [DataContract]
    public class BuyerRequestedCancel : IEquatable<BuyerRequestedCancel>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="BuyerRequestedCancel" /> class.
        /// </summary>
        /// <param name="isBuyerRequestedCancel">When true, the buyer has requested cancellation..</param>
        /// <param name="buyerCancelReason">The reason that the buyer requested cancellation..</param>
        public BuyerRequestedCancel(bool? isBuyerRequestedCancel = default, string buyerCancelReason = default)
        {
            IsBuyerRequestedCancel = isBuyerRequestedCancel;
            BuyerCancelReason = buyerCancelReason;
        }

        /// <summary>
        ///     When true, the buyer has requested cancellation.
        /// </summary>
        /// <value>When true, the buyer has requested cancellation.</value>
        [DataMember(Name = "IsBuyerRequestedCancel", EmitDefaultValue = false)]
        public bool? IsBuyerRequestedCancel { get; set; }

        /// <summary>
        ///     The reason that the buyer requested cancellation.
        /// </summary>
        /// <value>The reason that the buyer requested cancellation.</value>
        [DataMember(Name = "BuyerCancelReason", EmitDefaultValue = false)]
        public string BuyerCancelReason { get; set; }

        /// <summary>
        ///     Returns true if BuyerRequestedCancel instances are equal
        /// </summary>
        /// <param name="input">Instance of BuyerRequestedCancel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuyerRequestedCancel input)
        {
            if (input == null)
                return false;

            return
                (
                    IsBuyerRequestedCancel == input.IsBuyerRequestedCancel ||
                    (IsBuyerRequestedCancel != null &&
                     IsBuyerRequestedCancel.Equals(input.IsBuyerRequestedCancel))
                ) &&
                (
                    BuyerCancelReason == input.BuyerCancelReason ||
                    (BuyerCancelReason != null &&
                     BuyerCancelReason.Equals(input.BuyerCancelReason))
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
            sb.Append("class BuyerRequestedCancel {\n");
            sb.Append("  IsBuyerRequestedCancel: ").Append(IsBuyerRequestedCancel).Append("\n");
            sb.Append("  BuyerCancelReason: ").Append(BuyerCancelReason).Append("\n");
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
            return Equals(input as BuyerRequestedCancel);
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
                if (IsBuyerRequestedCancel != null)
                    hashCode = hashCode * 59 + IsBuyerRequestedCancel.GetHashCode();
                if (BuyerCancelReason != null)
                    hashCode = hashCode * 59 + BuyerCancelReason.GetHashCode();
                return hashCode;
            }
        }
    }
}