using System;
using System.Collections.Generic;
using FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInbound;
using FikaAmazonAPI.Search;
using static FikaAmazonAPI.Utils.Constants;

namespace FikaAmazonAPI.Parameter.FulFillmentInbound
{
    public class ParameterGetShipments : ParameterBased
    {
        public ICollection<ShipmentStatus> ShipmentStatusList { get; set; }
        public ICollection<string> ShipmentIdList { get; set; }
        public DateTime? LastUpdatedAfter { get; set; }
        public DateTime? LastUpdatedBefore { get; set; }
        public QueryType QueryType { get; set; }
        public string NextToken { get; set; }
        public string MarketplaceId { get; set; }
    }
}