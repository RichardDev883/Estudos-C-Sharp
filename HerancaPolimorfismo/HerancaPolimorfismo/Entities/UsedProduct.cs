using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPolimorfismo.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactoreData { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufactoreData) 
            : base (name, price)
        {
            ManufactoreData= manufactoreData;
        }

        public override string PriceTag()
        {
             return Name
                + " (used) $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacture date: "
                + ManufactoreData.ToString("dd/MM/yyyy")
                + ")";
        }
    }
}
