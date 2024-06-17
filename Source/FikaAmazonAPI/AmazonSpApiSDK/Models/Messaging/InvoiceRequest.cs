using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Messaging
{
    [DataContract]
    public class InvoiceRequest : IEquatable<InvoiceRequest>, IValidatableObject
    {
        public InvoiceRequest(List<Attachment> attachments = default, DateTime? coverageStartDate = default,
            DateTime? coverageEndDate = default)
        {
            Attachments = attachments;
        }

        [DataMember(Name = "attachments", EmitDefaultValue = false)]
        public List<Attachment> Attachments { get; set; }

        public bool Equals(InvoiceRequest input)
        {
            if (input == null)
                return false;

            return
                Attachments == input.Attachments ||
                (Attachments != null &&
                 Attachments.SequenceEqual(input.Attachments));
        }

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvoiceRequest {\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        public override bool Equals(object input)
        {
            return Equals(input as InvoiceRequest);
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Attachments != null)
                    hashCode = hashCode * 59 + Attachments.GetHashCode();
                return hashCode;
            }
        }
    }
}