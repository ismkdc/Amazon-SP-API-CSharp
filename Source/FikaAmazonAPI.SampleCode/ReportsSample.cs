using FikaAmazonAPI.AmazonSpApiSDK.Models.Reports;
using FikaAmazonAPI.Parameter.Report;
using FikaAmazonAPI.Utils;
using static FikaAmazonAPI.Utils.Constants;

namespace FikaAmazonAPI.SampleCode;

public class ReportsSample
{
    private readonly AmazonConnection amazonConnection;

    public ReportsSample(AmazonConnection amazonConnection)
    {
        this.amazonConnection = amazonConnection;
    }


    public void GetReports()
    {
        var parameters = new ParameterReportList();
        parameters.pageSize = 100;
        parameters.reportTypes = new List<ReportTypes>();
        parameters.reportTypes.Add(ReportTypes.GET_AFN_INVENTORY_DATA);
        parameters.marketplaceIds = new List<string>();
        parameters.marketplaceIds.Add(MarketPlace.UnitedArabEmirates.ID);
        amazonConnection.Reports.GetReports(parameters);
    }

    public void GetReportGET_FLAT_FILE_RETURNS_DATA_BY_RETURN_DATEs()
    {
        var parameters = new ParameterReportList();
        parameters.pageSize = 100;
        parameters.reportTypes = new List<ReportTypes>();
        parameters.reportTypes.Add(ReportTypes.GET_FLAT_FILE_RETURNS_DATA_BY_RETURN_DATE);
        parameters.marketplaceIds = new List<string>();
        parameters.marketplaceIds.Add(MarketPlace.UnitedArabEmirates.ID);
        var reports = amazonConnection.Reports.GetReports(parameters);
    }

    public void CreateReport()
    {
        var parameters = new ParameterCreateReportSpecification();
        parameters.reportType = ReportTypes.GET_FLAT_FILE_ALL_ORDERS_DATA_BY_LAST_UPDATE_GENERAL;
        parameters.dataStartTime = DateTime.UtcNow.AddDays(-30);
        parameters.dataEndTime = DateTime.UtcNow.AddDays(-10);

        parameters.marketplaceIds = new MarketplaceIds();
        parameters.marketplaceIds.Add(MarketPlace.UnitedArabEmirates.ID);

        parameters.reportOptions = new ReportOptions();

        var reportId = amazonConnection.Reports.CreateReport(parameters);
    }


    public void GetReport()
    {
        amazonConnection.Reports.GetReport("192841018867");
    }


    public void CancelReport()
    {
        amazonConnection.Reports.CancelReport("192841018867");
    }


    public void GetReportSchedules()
    {
        var parameters = new ParameterReportSchedules();
        parameters.reportTypes.Add(ReportTypes.GET_FLAT_FILE_ALL_ORDERS_DATA_BY_LAST_UPDATE_GENERAL);

        var result = amazonConnection.Reports.GetReportSchedules(parameters);
    }


    public void CreateReportScheduleSpecification()
    {
        var parameters = new ParameterCreateReportScheduleSpecification();
        parameters.reportType = ReportTypes.GET_AFN_INVENTORY_DATA;
        parameters.period = AmazonSpApiSDK.Models.Reports.CreateReportScheduleSpecification.PeriodEnum.PT30M;

        parameters.marketplaceIds = new MarketplaceIds();
        parameters.marketplaceIds.Add(MarketPlace.UnitedArabEmirates.ID);

        parameters.reportOptions = new ReportOptions();

        var result = amazonConnection.Reports.CreateReportSchedule(parameters);
    }


    public void GetReportSchedule()
    {
        var data = amazonConnection.Reports.GetReportSchedule("50039018867");
    }

    public void CancelReportSchedule()
    {
        var data = amazonConnection.Reports.CancelReportSchedule("50039018867");
    }

    public void GetReportDocument()
    {
        var data = amazonConnection.Reports.GetReportDocument("50039018867");
    }

    public string CreateReport_GET_MERCHANT_LISTINGS_ALL_DATA()
    {
        var parameters = new ParameterCreateReportSpecification();
        parameters.reportType = ReportTypes.GET_MERCHANT_LISTINGS_ALL_DATA;

        parameters.marketplaceIds = new MarketplaceIds();
        parameters.marketplaceIds.Add(MarketPlace.UnitedArabEmirates.ID);

        parameters.reportOptions = new ReportOptions();


        var reportId = amazonConnection.Reports.CreateReport(parameters);
        var filePath = string.Empty;
        var ReportDocumentId = string.Empty;

        while (string.IsNullOrEmpty(ReportDocumentId))
        {
            var reportData = amazonConnection.Reports.GetReport(reportId);
            if (!string.IsNullOrEmpty(reportData.ReportDocumentId))
            {
                filePath = amazonConnection.Reports.GetReportFile(reportData.ReportDocumentId);
                break;
            }

            Thread.Sleep(1000 * 60);
        }

        return filePath;
    }

    public string CreateReport_GET_FLAT_FILE_RETURNS_DATA_BY_RETURN_DATE()
    {
        var parameters = new ParameterCreateReportSpecification();
        parameters.reportType = ReportTypes.GET_FLAT_FILE_RETURNS_DATA_BY_RETURN_DATE;

        parameters.marketplaceIds = new MarketplaceIds();
        parameters.marketplaceIds.Add(MarketPlace.UnitedArabEmirates.ID);


        parameters.reportOptions = new ReportOptions();

        parameters.dataStartTime = DateTime.UtcNow.AddDays(-50);
        parameters.dataEndTime = DateTime.UtcNow.AddDays(-1);

        var reportId = amazonConnection.Reports.CreateReport(parameters);
        var filePath = string.Empty;
        var ReportDocumentId = string.Empty;

        while (string.IsNullOrEmpty(ReportDocumentId))
        {
            var reportData = amazonConnection.Reports.GetReport(reportId);
            if (!string.IsNullOrEmpty(reportData.ReportDocumentId))
            {
                filePath = amazonConnection.Reports.GetReportFile(reportData.ReportDocumentId);
                break;
            }

            if (reportData.ProcessingStatus == Report.ProcessingStatusEnum.FATAL)
                throw new Exception("Error with Generate report");
            Thread.Sleep(1000 * 60);
        }

        return filePath;
    }


    public string CreateReportAndDawnload(ReportTypes reportTypes, DateTime? dataStartTime = null,
        DateTime? dataEndTime = null, ReportOptions reportOptions = null)
    {
        return amazonConnection.Reports.CreateReportAndDownloadFile(reportTypes, dataStartTime, dataEndTime,
            reportOptions);
    }

    public void DownloadExistingReportAndDownloadFile()
    {
        var createdSince = DateTime.UtcNow.AddDays(-60);
        var createdUntil = DateTime.UtcNow;

        var paths = amazonConnection.Reports.DownloadExistingReportAndDownloadFile(
            ReportTypes.GET_V2_SETTLEMENT_REPORT_DATA_FLAT_FILE_V2,
            createdSince,
            createdUntil);
    }


    public void GetReport_GET_SELLER_FEEDBACK_DATA()
    {
        var startDate = new DateTime(2021, 10, 03);
        var data = amazonConnection.Reports.CreateReportAndDownloadFile(ReportTypes.GET_SELLER_FEEDBACK_DATA,
            startDate);
    }

    public void GetReportGET_FBA_REIMBURSEMENTS_DATA()
    {
        var startDate = new DateTime(2021, 10, 03);
        var data = amazonConnection.Reports.CreateReportAndDownloadFile(ReportTypes.GET_FBA_REIMBURSEMENTS_DATA,
            startDate);
    }

    public void GetReportGET_AMAZON_FULFILLED_SHIPMENTS_DATA_INVOICING()
    {
        var startDate = new DateTime(2021, 10, 03);
        var data = amazonConnection.Reports.CreateReportAndDownloadFile(
            ReportTypes.GET_AMAZON_FULFILLED_SHIPMENTS_DATA_INVOICING, startDate, null, null, true);
    }


    public void GetReportFile()
    {
        var data = amazonConnection.Reports.GetReport("192841018867");


        var filePath = amazonConnection.Reports.GetReportFile(data.ReportDocumentId);
    }
}