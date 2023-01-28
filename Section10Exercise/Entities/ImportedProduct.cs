using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section10Exercise.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFree)
            : base(name, price)
        {
            CustomsFee = customsFree;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + "(Customs fee: " + CustomsFee.ToString("C") + ")";
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}
