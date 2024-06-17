using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Messaging
{
    public class GetMessagingActionsForOrderResponseLinks : IEquatable<GetMessagingActionsForOrderResponseLinks>,
        IValidatableObject
    {
        public GetMessagingActionsForOrderResponseLinks(LinkObject self = default, IList<LinkObject> actions = default)
        {
            Self = self;
            Actions = actions;
        }

        public GetMessagingActionsForOrderResponseLinks()
        {
            Self = default;
            Actions = default;
        }

        /// <summary>
        ///     Gets or Sets Links
        /// </summary>
        [DataMember(Name = "self", EmitDefaultValue = false)]
        public LinkObject Self { get; set; }

        /// <summary>
        ///     Gets or Sets Embedded
        /// </summary>
        [DataMember(Name = "actions", EmitDefaultValue = false)]
        public IList<LinkObject> Actions { get; set; }

        public bool Equals(GetMessagingActionsForOrderResponseLinks input)
        {
            return Equals(input);
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
            return Equals(input as GetMessagingActionsForOrderResponse);
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
                if (Self != null)
                    hashCode = hashCode * 59 + Self.GetHashCode();
                if (Actions != null)
                    hashCode = hashCode * 59 + Actions.GetHashCode();
                return hashCode;
            }
        }
    }
}