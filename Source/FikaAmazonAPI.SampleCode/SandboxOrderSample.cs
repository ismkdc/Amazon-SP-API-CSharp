using FikaAmazonAPI.Parameter.Order;
using FikaAmazonAPI.Utils;

namespace FikaAmazonAPI.SampleCode;

public class SandboxOrderSample
{
    private readonly AmazonConnection amazonConnection;

    public SandboxOrderSample(AmazonConnection amazonConnection)
    {
        this.amazonConnection = amazonConnection;
    }

    public void GetOrderTestCase200()
    {
        var orders = amazonConnection.Orders.GetOrders
        (
            new ParameterOrderList
            {
                TestCase = Constants.TestCase200
            }
        );
    }
}