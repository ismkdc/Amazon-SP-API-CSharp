using FikaAmazonAPI.Parameter.ProductPricing;
using FikaAmazonAPI.Parameter.ProductPricing.v2022_05_01;
using FikaAmazonAPI.Utils;
using static FikaAmazonAPI.Utils.Constants;

namespace FikaAmazonAPI.SampleCode;

public class ProductPricingSample
{
    private readonly AmazonConnection amazonConnection;

    public ProductPricingSample(AmazonConnection amazonConnection)
    {
        this.amazonConnection = amazonConnection;
    }

    public void GetPricing()
    {
        var data = amazonConnection.ProductPricing.GetPricing(new ParameterGetPricing
        {
            MarketplaceId = MarketPlace.UnitedArabEmirates.ID,
            Asins = new[] { "B00CZC5F0G" }
        });
    }


    public void GetCompetitivePricing()
    {
        var data = amazonConnection.ProductPricing.GetCompetitivePricing(new ParameterGetCompetitivePricing
        {
            MarketplaceId = MarketPlace.UnitedArabEmirates.ID,
            Asins = new[] { "B00CZC5F0G" }
        });
    }


    public void GetListingOffers()
    {
        var data = amazonConnection.ProductPricing.GetListingOffers(new ParameterGetListingOffers
        {
            ItemCondition = ItemCondition.New,
            MarketplaceId = MarketPlace.UnitedArabEmirates.ID,
            SellerSKU = "8809647390015"
        });
    }


    public void GetItemOffers()
    {
        var data = amazonConnection.ProductPricing.GetItemOffers(new ParameterGetItemOffers
        {
            ItemCondition = ItemCondition.New,
            MarketplaceId = MarketPlace.UnitedKingdom.ID,
            Asin = "B00CZC5F0G"
        });
    }

    public async Task GetItemOffersBatch()
    {
        var data = await amazonConnection.ProductPricing.GetItemOffersBatchAsync(new ParameterGetItemOffersBatchRequest
        {
            ParameterGetItemOffers = new List<ItemOffersRequest>
            {
                new()
                {
                    HttpMethod = HttpMethodEnum.GET,
                    QueryParams = new ParameterGetItemOffers
                    {
                        Asin = "XXXXXX",
                        CustomerType = CustomerType.Consumer,
                        ItemCondition = ItemCondition.New,
                        MarketplaceId = MarketPlace.UnitedKingdom.ID
                    }
                },
                new()
                {
                    HttpMethod = HttpMethodEnum.GET,
                    QueryParams = new ParameterGetItemOffers
                    {
                        Asin = "XXXXXXX",
                        CustomerType = CustomerType.Consumer,
                        ItemCondition = ItemCondition.New,
                        MarketplaceId = MarketPlace.UnitedKingdom.ID
                    }
                }
            }
        });

        ;
    }


    public async Task GetListingOffersBatch()
    {
        var data = await amazonConnection.ProductPricing.GetListingOffersBatchAsync(
            new ParameterGetListingOffersBatchRequest
            {
                ParameterGetListingOffers = new List<ListingOffersRequest>
                {
                    new()
                    {
                        HttpMethod = HttpMethodEnum.GET,
                        QueryParams = new ParameterGetListingOffers
                        {
                            SellerSKU = "SellerSKU_01",
                            CustomerType = CustomerType.Consumer,
                            ItemCondition = ItemCondition.New,
                            MarketplaceId = MarketPlace.UnitedKingdom.ID
                        }
                    },
                    new()
                    {
                        HttpMethod = HttpMethodEnum.GET,
                        QueryParams = new ParameterGetListingOffers
                        {
                            SellerSKU = "SellerSKU_02",
                            CustomerType = CustomerType.Consumer,
                            ItemCondition = ItemCondition.New,
                            MarketplaceId = MarketPlace.UnitedKingdom.ID
                        }
                    }
                }
            });

        ;
    }

    public async Task GetFeaturedOfferExpectedPriceBatch()
    {
        var data = await amazonConnection.ProductPricing.GetFeaturedOfferExpectedPriceBatchAsync(
            new GetFeaturedOfferExpectedPriceBatchRequest
            {
                FeaturedOfferExpectedPriceRequestLists = new List<FeaturedOfferExpectedPriceRequest>
                {
                    new()
                    {
                        SellerSku = "SellerSKU_01",
                        MarketplaceId = MarketPlace.Germany.ID
                    },
                    new()
                    {
                        SellerSku = "SellerSKU_02",
                        MarketplaceId = MarketPlace.Germany.ID
                    }
                }
            });
    }
}