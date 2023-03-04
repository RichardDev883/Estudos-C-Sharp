using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace HerancaPolimorfismo.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
            
        }

        public ImportedProduct(string nome, double price, double customsFee)
            : base (nome, price)
        {
            CustomsFee= customsFee;
        }

        public double TotalPrice()
        {
            return Price += CustomsFee;
        }
        public sealed override string PriceTag()
        {
            return Name
                + " $"
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + "(Customs fee: $ "
                + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) 
                +")";
        }

    }
}
