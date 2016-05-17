using System;

namespace Store.Domain.Model.Product
{
    public class Product : GuidEntity
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public double Netto { get; set; }
        public double Vat { get; set; }
        public double Brutto { get; set; }
        public string Description { get; set; }
    }
}
