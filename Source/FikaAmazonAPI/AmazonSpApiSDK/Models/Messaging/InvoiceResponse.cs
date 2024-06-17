using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Messaging
{
    [DataContract]
    public class InvoiceResponse : IEquatable<InvoiceResponse>, IValidatableObject
    {
        public InvoiceResponse(ErrorList errors = default)
        {
            Errors = errors;
        }

        public InvoiceResponse()
        {
            Errors = default;
        }

        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public ErrorList Errors { get; set; }

        public bool Equals(InvoiceResponse input)
        {
            if (input == null)
                return false;

            return
                Errors == input.Errors ||
                (Errors != null &&
                 Errors.Equals(input.Errors));
        }

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvoiceResponse {\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        public override bool Equals(object input)
        {
            return Equals(input as InvoiceResponse);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = 41;
                if (Errors != null)
                    hashCode = hashCode * 59 + Errors.GetHashCode();
                return hashCode;
            }
        }
    }
}