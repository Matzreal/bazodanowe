using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Model.Product
{
    public class Category   // Value object
    {
        public Category(string Top, string Sub)
        {
            this.Top = Top;
            this.Sub = Sub;
        }

        private Category() { }

        public string Top { get; set; }
        public string Sub { get; set; }
    }
}
