using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao5.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee {  get; set; }

        public ImportedProduct()
        {
            
        }

        public ImportedProduct(string name, double price, double customsFee)
            :base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double totalPrice()
        {
            return CustomsFee + Price;
        }

        public override string priceTag()
        {
            return Name
                + " $ "
                + totalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (Customs fee: $ "
                + CustomsFee.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }

    }
}
