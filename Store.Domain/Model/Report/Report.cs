using System;
using System.Collections.Generic;

namespace Store.Domain.Model.Report
{
    public class Report : GuidEntity
    {
        public List<Order.Order> OrderList { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
    }
}
