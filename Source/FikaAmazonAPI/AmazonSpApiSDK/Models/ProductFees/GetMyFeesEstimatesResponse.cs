using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.ProductFees
{
    [DataContract]
    public class GetMyFeesEstimatesResponse : List<FeesEstimateResult>
    {
    }
}