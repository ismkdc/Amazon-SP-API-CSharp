using FikaAmazonAPI.AmazonSpApiSDK.Models.ProductFees;
using FikaAmazonAPI.Parameter.ProductFee;
using FikaAmazonAPI.Utils;

namespace FikaAmazonAPI.SampleCode;

public class ProductFeeSample
{
    private readonly AmazonConnection amazonConnection;

    public ProductFeeSample(AmazonConnection amazonConnection)
    {
        this.amazonConnection = amazonConnection;
    }

    public async Task getMyFeesEstimates()
    {
        var data = await amazonConnection.ProductFee.GetMyFeesEstimateAsync(new FeesEstimateByIdRequest[]
        {
            new()
            {
                IdType = IdTypeEnum.SellerSKU,
                IdValue = "xxx",
                FeesEstimateRequest = new FeesEstimateRequest
                {
                    Identifier = "xxx",
                    IsAmazonFulfilled = true,
                    MarketplaceId = MarketPlace.UnitedKingdom.ID,
                    PriceToEstimateFees = new PriceToEstimateFees
                    {
                        ListingPrice = new MoneyType
                        {
                            Amount = 6.59m,
                            CurrencyCode = "GBP"
                        }
                    }
                }
            }
        });
    }
}