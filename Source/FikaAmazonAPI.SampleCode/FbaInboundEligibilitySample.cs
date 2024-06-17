using FikaAmazonAPI.AmazonSpApiSDK.Models.FbaInbound;
using FikaAmazonAPI.Parameter.FbaInboundEligibility;
using FikaAmazonAPI.Utils;

namespace FikaAmazonAPI.SampleCode;

public class FbaInboundEligibilitySample
{
    private readonly AmazonConnection amazonConnection;

    public FbaInboundEligibilitySample(AmazonConnection amazonConnection)
    {
        this.amazonConnection = amazonConnection;
    }

    public void GetItemEligibilityPreview()
    {
        var all = amazonConnection.FbaInboundEligibility.GetItemEligibilityPreview(
            new ParameterGetItemEligibilityPreview
            {
                marketplaceIds = new List<string> { MarketPlace.UnitedArabEmirates.ID },
                asin = "B07Q2R45XG",
                program = ItemEligibilityPreview.ProgramEnum.INBOUND
            });
    }
}