using FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInbound;
using FikaAmazonAPI.Parameter.FulFillmentInbound;
using FikaAmazonAPI.Utils;
using static FikaAmazonAPI.Utils.Constants;

namespace FikaAmazonAPI.SampleCode;

public class FulFillmentInboundSample
{
    private readonly AmazonConnection amazonConnection;

    public FulFillmentInboundSample(AmazonConnection amazonConnection)
    {
        this.amazonConnection = amazonConnection;
    }

    public void GetInboundGuidance()
    {
        var parm = new ParameterGetInboundGuidance
        {
            MarketplaceId = MarketPlace.UnitedArabEmirates.ID,
            ASINList = new List<string> { "B071XVSXRL" }
        };
        amazonConnection.FulFillmentInbound.GetInboundGuidance(parm);
    }

    public void GetPrepInstructions()
    {
        var parm = new ParameterGetPrepInstructions
        {
            ShipToCountryCode = "AE",
            MarketplaceId = MarketPlace.UnitedArabEmirates.ID,
            ASINList = new List<string> { "B071XVSXRL" }
        };
        amazonConnection.FulFillmentInbound.GetPrepInstructions(parm);
    }

    public void CreateShipmentPlan()
    {
        var oCreateInboundShipmentPlanRequest = new CreateInboundShipmentPlanRequest();

        oCreateInboundShipmentPlanRequest.ShipToCountryCode = "AE";
        oCreateInboundShipmentPlanRequest.LabelPrepPreference = LabelPrepPreference.SELLERLABEL;


        oCreateInboundShipmentPlanRequest.ShipFromAddress = new Address();
        oCreateInboundShipmentPlanRequest.ShipFromAddress.AddressLine1 = "Add";
        oCreateInboundShipmentPlanRequest.ShipFromAddress.AddressLine2 = "ADD2";
        oCreateInboundShipmentPlanRequest.ShipFromAddress.City = "City";
        oCreateInboundShipmentPlanRequest.ShipFromAddress.CountryCode = "AE";
        oCreateInboundShipmentPlanRequest.ShipFromAddress.PostalCode = "0000";
        oCreateInboundShipmentPlanRequest.ShipFromAddress.Name = "Name";


        oCreateInboundShipmentPlanRequest.InboundShipmentPlanRequestItems = new InboundShipmentPlanRequestItemList();
        var oInboundShipmentPlanRequestItem = new InboundShipmentPlanRequestItem();
        oInboundShipmentPlanRequestItem.SellerSKU = "16118";
        oInboundShipmentPlanRequestItem.ASIN = "B08BXH6234";
        oInboundShipmentPlanRequestItem.Quantity = 1;
        oInboundShipmentPlanRequestItem.Condition = Condition.NewItem;

        oCreateInboundShipmentPlanRequest.InboundShipmentPlanRequestItems.Add(oInboundShipmentPlanRequestItem);
        var oResult = amazonConnection.FulFillmentInbound.CreateInboundShipmentPlan(oCreateInboundShipmentPlanRequest);
    }

    public void GetFulFillmentInboundLabelsFromWebCreationSample(string shipmentId, int boxCount)
    {
        var labelParams = new ParameterGetLabels
        {
            PageType = PageType.PackageLabel_Letter_6,
            shipmentId = shipmentId,
            LabelType = LabelType.SELLER_LABEL,
            PageSize = boxCount
        };

        var labels = amazonConnection.FulFillmentInbound.GetLabels(labelParams);
    }
}