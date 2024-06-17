using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Orders
{
    /// <summary>
    ///     This object represents an approval action used by the actors in the order item approval process. Check the
    ///     applicable restrictions at the specific approval type schemas.
    /// </summary>
    [DataContract]
    public class ItemApprovalAction : IEquatable<ItemApprovalAction>, IValidatableObject
    {
        /// <summary>
        ///     Defines the type of action for the approval.
        /// </summary>
        /// <value>Defines the type of action for the approval.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionTypeEnum
        {
            /// <summary>
            ///     Enum APPROVE for value: APPROVE
            /// </summary>
            [EnumMember(Value = "APPROVE")] APPROVE = 1,

            /// <summary>
            ///     Enum DECLINE for value: DECLINE
            /// </summary>
            [EnumMember(Value = "DECLINE")] DECLINE = 2,

            /// <summary>
            ///     Enum APPROVEWITHCHANGES for value: APPROVE_WITH_CHANGES
            /// </summary>
            [EnumMember(Value = "APPROVE_WITH_CHANGES")]
            APPROVEWITHCHANGES = 3
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ItemApprovalAction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ItemApprovalAction()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ItemApprovalAction" /> class.
        /// </summary>
        /// <param name="actionType">Defines the type of action for the approval. (required).</param>
        /// <param name="comment">Comment message to provide optional additional context on the approval action..</param>
        /// <param name="changes">changes.</param>
        public ItemApprovalAction(ActionTypeEnum actionType = default, string comment = default,
            ItemApprovalActionChanges changes = default)
        {
            // to ensure "actionType" is required (not null)
            if (actionType == null)
                throw new InvalidDataException(
                    "actionType is a required property for ItemApprovalAction and cannot be null");
            ActionType = actionType;
            Comment = comment;
            Changes = changes;
        }

        /// <summary>
        ///     Defines the type of action for the approval.
        /// </summary>
        /// <value>Defines the type of action for the approval.</value>
        [DataMember(Name = "ActionType", EmitDefaultValue = false)]
        public ActionTypeEnum ActionType { get; set; }


        /// <summary>
        ///     Comment message to provide optional additional context on the approval action.
        /// </summary>
        /// <value>Comment message to provide optional additional context on the approval action.</value>
        [DataMember(Name = "Comment", EmitDefaultValue = false)]
        public string Comment { get; set; }

        /// <summary>
        ///     Gets or Sets Changes
        /// </summary>
        [DataMember(Name = "Changes", EmitDefaultValue = false)]
        public ItemApprovalActionChanges Changes { get; set; }

        /// <summary>
        ///     Returns true if ItemApprovalAction instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemApprovalAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemApprovalAction input)
        {
            if (input == null)
                return false;

            return
                (
                    ActionType == input.ActionType ||
                    (ActionType != null &&
                     ActionType.Equals(input.ActionType))
                ) &&
                (
                    Comment == input.Comment ||
                    (Comment != null &&
                     Comment.Equals(input.Comment))
                ) &&
                (
                    Changes == input.Changes ||
                    (Changes != null &&
                     Changes.Equals(input.Changes))
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
            sb.Append("class ItemApprovalAction {\n");
            sb.Append("  ActionType: ").Append(ActionType).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Changes: ").Append(Changes).Append("\n");
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
            return Equals(input as ItemApprovalAction);
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
                if (ActionType != null)
                    hashCode = hashCode * 59 + ActionType.GetHashCode();
                if (Comment != null)
                    hashCode = hashCode * 59 + Comment.GetHashCode();
                if (Changes != null)
                    hashCode = hashCode * 59 + Changes.GetHashCode();
                return hashCode;
            }
        }
    }
}