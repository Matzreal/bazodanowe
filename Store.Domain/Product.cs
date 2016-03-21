using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain
{
    public class Product    // Entity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Netto { get; set; }
        public double Brutto { get; set; }
        public string Description { get; set; }
    }
}
