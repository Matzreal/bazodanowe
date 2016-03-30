using Store.Domain.Model.Order;
using Store.Domain.Model.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.ObjectMothers
{
    public class ReportObjectMother
    {
        public static Report CreateReport()
        {
            var report = new Report
            {
                Id = new Guid(),
                OrderList = new List<Order>(),
                StartDateTime = DateTime.Now.AddDays(-1),
                EndDateTime = DateTime.Now
            };

            return report;
        }
    }
}
