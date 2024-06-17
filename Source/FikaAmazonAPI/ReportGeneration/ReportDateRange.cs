using System;
using System.Collections.Generic;

namespace FikaAmazonAPI.ReportGeneration
{
    public class ReportDateRange
    {
        public ReportDateRange(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        public static IList<ReportDateRange> GetDateRange(DateTime startDate, DateTime endDate, int MaxDays)
        {
            var list = new List<ReportDateRange>();
            var tempEnd = startDate;
            var start = startDate;

            while (true)
            {
                tempEnd = tempEnd.AddDays(MaxDays);
                if (tempEnd > endDate)
                {
                    tempEnd = endDate;
                    list.Add(new ReportDateRange(start, tempEnd));
                    break;
                }

                list.Add(new ReportDateRange(start, tempEnd));
                start = tempEnd.AddSeconds(1);
            }

            return list;
        }
    }
}