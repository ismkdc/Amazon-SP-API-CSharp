using Newtonsoft.Json.Converters;

namespace FikaAmazonAPI.Utils
{
    internal class Iso8601DateTimeConverter : IsoDateTimeConverter
    {
        public Iso8601DateTimeConverter()
        {
            DateTimeFormat = "yyyy-MM-ddTHH:mm:ssZ";
        }
    }
}