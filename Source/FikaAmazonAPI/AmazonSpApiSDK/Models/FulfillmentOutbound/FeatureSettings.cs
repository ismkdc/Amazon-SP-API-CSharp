﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentOutbound
{
    /// <summary>
    ///     A Multi-Channel Fulfillment feature.
    /// </summary>
    [DataContract]
    public class FeatureSettings : IEquatable<FeatureSettings>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="FeatureSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public FeatureSettings()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="FeatureSettings" /> class.
        /// </summary>
        /// <param name="featureName">The feature name. (required).</param>
        /// <param name="featureDescription">The feature description. (required).</param>
        /// <param name="featureFulfillmentPolicy">The feature FulfillmentPolicy. (required).</param>
        /// <param name="sellerEligible">When true, indicates that the seller is eligible to use the feature..</param>
        public FeatureSettings(string featureName = default,
            FeatureFulfillmentPolicyEnum featureFulfillmentPolicy = default)
        {
            FeatureName = featureName;
            FeatureFulfillmentPolicy = featureFulfillmentPolicy;
        }

        /// <summary>
        ///     The feature name.
        /// </summary>
        /// <value>The feature name.</value>
        [DataMember(Name = "featureName", EmitDefaultValue = false)]
        public string FeatureName { get; set; }

        /// <summary>
        ///     The feature description.
        /// </summary>
        /// <value>The feature description.</value>
        [DataMember(Name = "featureFulfillmentPolicy", EmitDefaultValue = false)]
        [JsonProperty("featureFulfillmentPolicy", Required = Required.Always)]
        public FeatureFulfillmentPolicyEnum FeatureFulfillmentPolicy { get; set; }

        /// <summary>
        ///     Returns true if Feature instances are equal
        /// </summary>
        /// <param name="input">Instance of Feature to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeatureSettings input)
        {
            if (input == null)
                return false;

            return
                FeatureName == input.FeatureName ||
                (FeatureName != null &&
                 FeatureName.Equals(input.FeatureName));
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
            sb.Append("class Feature {\n");
            sb.Append("  FeatureName: ").Append(FeatureName).Append("\n");
            sb.Append("  FeatureFulfillmentPolicy: ").Append(FeatureFulfillmentPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            var jsonSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                Formatting = Formatting.Indented
            };

            var jsonObject = JObject.FromObject(this, JsonSerializer.Create(jsonSettings));
            jsonObject["featureFulfillmentPolicy"] = FeatureFulfillmentPolicy.ToString();

            return jsonObject.ToString();
        }

        /// <summary>
        ///     Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as FeatureSettings);
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
                if (FeatureName != null)
                    hashCode = hashCode * 59 + FeatureName.GetHashCode();
                return hashCode;
            }
        }
    }

    /// <summary>
    ///     Variant of the image, such as &#x60;MAIN&#x60; or &#x60;PT01&#x60;.
    /// </summary>
    /// <value>Variant of the image, such as &#x60;MAIN&#x60; or &#x60;PT01&#x60;.</value>
    [DefaultValue(Required)]
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FeatureFulfillmentPolicyEnum
    {
        /// <summary>
        ///     Enum Required for value: Required
        /// </summary>
        [EnumMember(Value = "Required")] Required,

        /// <summary>
        ///     Enum NotRequired for value: NotRequired
        /// </summary>
        [EnumMember(Value = "NotRequired")] NotRequired
    }
}