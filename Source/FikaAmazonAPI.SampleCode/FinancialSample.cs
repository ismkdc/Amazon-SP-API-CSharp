using FikaAmazonAPI.Parameter.Finance;

namespace FikaAmazonAPI.SampleCode;

public class FinancialSample
{
    private readonly AmazonConnection amazonConnection;

    public FinancialSample(AmazonConnection amazonConnection)
    {
        this.amazonConnection = amazonConnection;
    }

    public void ListFinancialEventGroups()
    {
        amazonConnection.Financial.ListFinancialEventGroups(new ParameterListFinancialEventGroup
        {
            FinancialEventGroupStartedAfter = DateTime.UtcNow.AddDays(-10),
            FinancialEventGroupStartedBefore = DateTime.UtcNow.AddDays(-1),
            MaxResultsPerPage = 55
        });
    }
}