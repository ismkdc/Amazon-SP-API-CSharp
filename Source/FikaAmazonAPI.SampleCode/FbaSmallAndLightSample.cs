using FikaAmazonAPI.AmazonSpApiSDK.Models.FbaSmallandLight;
using FikaAmazonAPI.Utils;

namespace FikaAmazonAPI.SampleCode;

public class FbaSmallAndLightSample
{
    private readonly AmazonConnection amazonConnection;
    private readonly string sellerSKU = "530487_1-hyx";

    public FbaSmallAndLightSample(AmazonConnection amazonConnection)
    {
        this.amazonConnection = amazonConnection;
    }

    public async Task GetSmallAndLightEnrollmentBySellerSKUAsync()
    {
        var smallAndLightEnrollment =
            await amazonConnection.FbaSmallandLight.GetSmallAndLightEnrollmentBySellerSKUAsync(sellerSKU);
    }


    public async Task GetSmallAndLightEligibilityBySellerSKUAsync()
    {
        //string sellerSKU = "530487_1-hyx";

        var smallAndLightEnrollment =
            await amazonConnection.FbaSmallandLight.GetSmallAndLightEligibilityBySellerSKUAsync(sellerSKU);
    }

    public async Task GetSmallAndLightFeePreviewAsync()
    {
        var smallAndLightEnrollment = await amazonConnection.FbaSmallandLight.GetSmallAndLightFeePreviewAsync(
            new SmallAndLightFeePreviewRequest(MarketPlace.UnitedKingdom.ID, new List<Item>
            {
                new("B09TB5PJ9Q",
                    new MoneyType("GBP", 3.69m))
            }));
    }
}