using System.Collections.Generic;
using FikaAmazonAPI.Search;
using static FikaAmazonAPI.Utils.Constants;

namespace FikaAmazonAPI.Parameter.Report
{
    public class ParameterReportSchedules : ParameterBased
    {
        public ParameterReportSchedules()
        {
            reportTypes = new List<ReportTypes>();
        }

        public ICollection<ReportTypes> reportTypes { get; set; }
    }
}