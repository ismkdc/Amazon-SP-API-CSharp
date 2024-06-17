using FikaAmazonAPI.AmazonSpApiSDK.Models.ProductTypes;
using FikaAmazonAPI.Parameter.ProductTypes;
using static FikaAmazonAPI.AmazonSpApiSDK.Models.ListingsItems.ListingsItemPutRequest;

namespace FikaAmazonAPI.SampleCode;

internal class ProductTypeSample
{
    private readonly AmazonConnection amazonConnection;

    public ProductTypeSample(AmazonConnection amazonConnection)
    {
        this.amazonConnection = amazonConnection;
    }


    private void SearchDefinitionsProductTypes()
    {
        var list = amazonConnection.ProductType.SearchDefinitionsProductTypes(
            new SearchDefinitionsProductTypesParameter
            {
                keywords = new List<string> { string.Empty }
            });
    }

    private void GetDefinitionsProductType()
    {
        var def = amazonConnection.ProductType.GetDefinitionsProductType(
            new GetDefinitionsProductTypeParameter
            {
                productType = "PRODUCT",
                requirements = RequirementsEnum.LISTING,
                locale = LocaleEnum.en_US
            });
    }
}