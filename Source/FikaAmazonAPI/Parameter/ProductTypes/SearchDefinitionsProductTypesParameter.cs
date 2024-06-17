using System.Collections.Generic;
using FikaAmazonAPI.Search;

namespace FikaAmazonAPI.Parameter.ProductTypes
{
    public class SearchDefinitionsProductTypesParameter : ParameterBased
    {
        public ICollection<string> keywords { get; set; }
        public ICollection<string> marketplaceIds { get; set; } = new List<string>();
    }
}