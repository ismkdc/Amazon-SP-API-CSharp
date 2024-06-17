using System;
using FikaAmazonAPI.Search;

namespace FikaAmazonAPI.Parameter.FulFillmentOutbound
{
    public class ParameterListAllFulfillmentOrders : ParameterBased
    {
        public DateTime? queryStartDate { get; set; }
        public string nextToken { get; set; }
    }
}