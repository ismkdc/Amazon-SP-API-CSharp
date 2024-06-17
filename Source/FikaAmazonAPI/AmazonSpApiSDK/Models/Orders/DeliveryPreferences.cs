using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Orders
{
    /// <summary>
    ///     Contains all of the delivery instructions provided by the customer for the shipping address.
    /// </summary>
    [DataContract]
    public class DeliveryPreferences : IEquatable<DeliveryPreferences>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="DeliveryPreferences" /> class.
        /// </summary>
        /// <param name="dropOffLocation">Drop-off location selected by the customer..</param>
        /// <param name="preferredDeliveryTime">Business hours and days when the delivery is preferred..</param>
        /// <param name="otherAttributes">
        ///     Enumerated list of miscellaneous delivery attributes associated with the shipping
        ///     address..
        /// </param>
        /// <param name="addressInstructions">Building instructions, nearby landmark or navigation instructions..</param>
        public DeliveryPreferences(string dropOffLocation = default,
            PreferredDeliveryTime preferredDeliveryTime = default,
            List<OtherDeliveryAttributes> otherAttributes = default, string addressInstructions = default)
        {
            DropOffLocation = dropOffLocation;
            PreferredDeliveryTime = preferredDeliveryTime;
            OtherAttributes = otherAttributes;
            AddressInstructions = addressInstructions;
        }

        public DeliveryPreferences()
        {
        }

        /// <summary>
        ///     Drop-off location selected by the customer.
        /// </summary>
        /// <value>Drop-off location selected by the customer.</value>
        [DataMember(Name = "DropOffLocation", EmitDefaultValue = false)]
        public string DropOffLocation { get; set; }

        /// <summary>
        ///     Business hours and days when the delivery is preferred.
        /// </summary>
        /// <value>Business hours and days when the delivery is preferred.</value>
        [DataMember(Name = "PreferredDeliveryTime", EmitDefaultValue = false)]
        public PreferredDeliveryTime PreferredDeliveryTime { get; set; }

        /// <summary>
        ///     Enumerated list of miscellaneous delivery attributes associated with the shipping address.
        /// </summary>
        /// <value>Enumerated list of miscellaneous delivery attributes associated with the shipping address.</value>
        [DataMember(Name = "OtherAttributes", EmitDefaultValue = false)]
        public List<OtherDeliveryAttributes> OtherAttributes { get; set; }

        /// <summary>
        ///     Building instructions, nearby landmark or navigation instructions.
        /// </summary>
        /// <value>Building instructions, nearby landmark or navigation instructions.</value>
        [DataMember(Name = "AddressInstructions", EmitDefaultValue = false)]
        public string AddressInstructions { get; set; }

        /// <summary>
        ///     Returns true if DeliveryPreferences instances are equal
        /// </summary>
        /// <param name="input">Instance of DeliveryPreferences to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliveryPreferences input)
        {
            if (input == null)
                return false;

            return
                (
                    DropOffLocation == input.DropOffLocation ||
                    (DropOffLocation != null &&
                     DropOffLocation.Equals(input.DropOffLocation))
                ) &&
                (
                    PreferredDeliveryTime == input.PreferredDeliveryTime ||
                    (PreferredDeliveryTime != null &&
                     PreferredDeliveryTime.Equals(input.PreferredDeliveryTime))
                ) &&
                (
                    AddressInstructions == input.AddressInstructions ||
                    (AddressInstructions != null &&
                     AddressInstructions.Equals(input.AddressInstructions))
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
            sb.Append("class DeliveryPreferences {\n");
            sb.Append("  DropOffLocation: ").Append(DropOffLocation).Append("\n");
            sb.Append("  PreferredDeliveryTime: ").Append(PreferredDeliveryTime).Append("\n");
            sb.Append("  OtherAttributes: ").Append(OtherAttributes).Append("\n");
            sb.Append("  AddressInstructions: ").Append(AddressInstructions).Append("\n");
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
            return Equals(input as DeliveryPreferences);
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
                if (DropOffLocation != null)
                    hashCode = hashCode * 59 + DropOffLocation.GetHashCode();
                if (PreferredDeliveryTime != null)
                    hashCode = hashCode * 59 + PreferredDeliveryTime.GetHashCode();
                if (OtherAttributes != null)
                    hashCode = hashCode * 59 + OtherAttributes.GetHashCode();
                if (AddressInstructions != null)
                    hashCode = hashCode * 59 + AddressInstructions.GetHashCode();
                return hashCode;
            }
        }
    }
}