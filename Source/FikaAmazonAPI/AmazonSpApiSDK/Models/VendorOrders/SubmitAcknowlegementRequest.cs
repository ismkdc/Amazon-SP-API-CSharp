﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.VendorOrders
{
    /// <summary>
    ///     The request schema for the submitAcknowledgement operation.
    /// </summary>
    [DataContract]
    public class SubmitAcknowledgementRequest : IEquatable<SubmitAcknowledgementRequest>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SubmitAcknowledgementRequest" /> class.
        /// </summary>
        /// <param name="acknowledgements">A list of one or more purchase orders..</param>
        public SubmitAcknowledgementRequest(List<OrderAcknowledgement> acknowledgements = default)
        {
            Acknowledgements = acknowledgements;
        }

        /// <summary>
        ///     A list of one or more purchase orders.
        /// </summary>
        /// <value>A list of one or more purchase orders.</value>
        [DataMember(Name = "acknowledgements", EmitDefaultValue = false)]
        public List<OrderAcknowledgement> Acknowledgements { get; set; }

        /// <summary>
        ///     Returns true if SubmitAcknowledgementRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SubmitAcknowledgementRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubmitAcknowledgementRequest input)
        {
            if (input == null)
                return false;

            return
                Acknowledgements == input.Acknowledgements ||
                (Acknowledgements != null &&
                 Acknowledgements.SequenceEqual(input.Acknowledgements));
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
            sb.Append("class SubmitAcknowledgementRequest {\n");
            sb.Append("  Acknowledgements: ").Append(Acknowledgements).Append("\n");
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
            return Equals(input as SubmitAcknowledgementRequest);
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
                if (Acknowledgements != null)
                    hashCode = hashCode * 59 + Acknowledgements.GetHashCode();
                return hashCode;
            }
        }
    }
}