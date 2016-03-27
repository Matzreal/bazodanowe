using System;
using System.Collections.Generic;

namespace Store.Domain.Model.Report
{
    public class Report // Entity
    {
        public Guid Id { get; set; }
        public List<Order> OrderList { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
    }
}
