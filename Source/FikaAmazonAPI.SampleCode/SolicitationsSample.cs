using FikaAmazonAPI.Search;
using FikaAmazonAPI.Utils;

namespace FikaAmazonAPI.SampleCode;

public class SolicitationsSample
{
    private readonly AmazonConnection amazonConnection;

    public SolicitationsSample(AmazonConnection amazonConnection)
    {
        this.amazonConnection = amazonConnection;
    }


    public void GetSolicitationActionsForOrder()
    {
        var parameterMarketplaceId = new ParameterMarketplaceId(MarketPlace.UnitedArabEmirates.ID);
        var data = amazonConnection.Solicitations.GetSolicitationActionsForOrder("405-3087470-5953115",
            parameterMarketplaceId.getParameters());
    }


    public void CreateProductReviewAndSellerFeedbackSolicitation()
    {
        var parameterMarketplaceId = new ParameterMarketplaceId(MarketPlace.UnitedArabEmirates.ID);
        var data = amazonConnection.Solicitations.CreateProductReviewAndSellerFeedbackSolicitation(
            "405-3087470-5953115", parameterMarketplaceId.getParameters());
    }
}