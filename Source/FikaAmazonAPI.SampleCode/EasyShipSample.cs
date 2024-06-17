using FikaAmazonAPI.AmazonSpApiSDK.Models.EasyShip20220323;

namespace FikaAmazonAPI.SampleCode;

internal class EasyShipSample
{
    private readonly AmazonConnection amazonConnection;

    public EasyShipSample(AmazonConnection amazonConnection)
    {
        this.amazonConnection = amazonConnection;
    }


    private void ListHandoverSlots()
    {
        var listSlot = amazonConnection.EasyShip20220323.ListHandoverSlots(new ListHandoverSlotsRequest
        {
            AmazonOrderId = "171-2704093-8575566",
            PackageDimensions = new Dimensions
            {
                Height = 20.0M,
                Width = 10.0M,
                Length = 12.0M,
                Unit = "Cm"
            },
            PackageWeight = new Weight
            {
                Unit = "G",
                Value = 100.0M
            }
        });
    }
}