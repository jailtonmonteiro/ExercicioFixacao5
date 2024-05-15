using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao5.Entities
{
    internal class ImportedProduct : Product
    {
        public double customsFee {  get; set; }

        public override string priceTag()
        {
            return base.priceTag();
        }

        public double totalPrice()
        {
            return customsFee;
        }
    }
}
