using System;
using FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInbound;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FikaAmazonAPI.Utils
{
    internal class UnitOfMeasurementConverter : StringEnumConverter
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            var unitOfMeasurementString = reader.Value.ToString();
            if (unitOfMeasurementString.Equals("in", StringComparison.OrdinalIgnoreCase))
                return UnitOfMeasurement.Inches;
            return (UnitOfMeasurement)Enum.Parse(typeof(UnitOfMeasurement), unitOfMeasurementString, true);
        }
    }
}