/*
 * Selling Partner API for FBA Inventory
 *
 * The Selling Partner API for FBA Inventory lets you programmatically retrieve information about inventory in Amazon's fulfillment network.
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

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FbaInventory
{
    /// <summary>
    ///     The number of misplaced or warehouse damaged units that are actively being confirmed at our fulfillment centers.
    /// </summary>
    [DataContract]
    public class ResearchingQuantity : IEquatable<ResearchingQuantity>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ResearchingQuantity" /> class.
        /// </summary>
        /// <param name="TotalResearchingQuantity">
        ///     The total number of units currently being researched in Amazon&#39;s fulfillment
        ///     network..
        /// </param>
        /// <param name="ResearchingQuantityBreakdown">A list of quantity details for items currently being researched..</param>
        public ResearchingQuantity(int? TotalResearchingQuantity = default,
            List<ResearchingQuantityEntry> ResearchingQuantityBreakdown = default)
        {
            this.TotalResearchingQuantity = TotalResearchingQuantity;
            this.ResearchingQuantityBreakdown = ResearchingQuantityBreakdown;
        }

        /// <summary>
        ///     The total number of units currently being researched in Amazon&#39;s fulfillment network.
        /// </summary>
        /// <value>The total number of units currently being researched in Amazon&#39;s fulfillment network.</value>
        [DataMember(Name = "totalResearchingQuantity", EmitDefaultValue = false)]
        public int? TotalResearchingQuantity { get; set; }

        /// <summary>
        ///     A list of quantity details for items currently being researched.
        /// </summary>
        /// <value>A list of quantity details for items currently being researched.</value>
        [DataMember(Name = "researchingQuantityBreakdown", EmitDefaultValue = false)]
        public List<ResearchingQuantityEntry> ResearchingQuantityBreakdown { get; set; }

        /// <summary>
        ///     Returns true if ResearchingQuantity instances are equal
        /// </summary>
        /// <param name="input">Instance of ResearchingQuantity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResearchingQuantity input)
        {
            if (input == null)
                return false;

            return
                (
                    TotalResearchingQuantity == input.TotalResearchingQuantity ||
                    (TotalResearchingQuantity != null &&
                     TotalResearchingQuantity.Equals(input.TotalResearchingQuantity))
                ) &&
                (
                    ResearchingQuantityBreakdown == input.ResearchingQuantityBreakdown ||
                    (ResearchingQuantityBreakdown != null &&
                     ResearchingQuantityBreakdown.SequenceEqual(input.ResearchingQuantityBreakdown))
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
            sb.Append("class ResearchingQuantity {\n");
            sb.Append("  TotalResearchingQuantity: ").Append(TotalResearchingQuantity).Append("\n");
            sb.Append("  ResearchingQuantityBreakdown: ").Append(ResearchingQuantityBreakdown).Append("\n");
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
            return Equals(input as ResearchingQuantity);
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
                if (TotalResearchingQuantity != null)
                    hashCode = hashCode * 59 + TotalResearchingQuantity.GetHashCode();
                if (ResearchingQuantityBreakdown != null)
                    hashCode = hashCode * 59 + ResearchingQuantityBreakdown.GetHashCode();
                return hashCode;
            }
        }
    }
}