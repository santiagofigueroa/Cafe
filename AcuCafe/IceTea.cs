using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuCafe
{
    public class IceTea : Drink
    {
        private double cost { get; set; } = 1.5;

        public override double Cost()
        {
            return cost;
        }
        public override void setCost(double price)
        {
            cost = price;
        }

        public override string getChocolateTopping()
        {

            return null;
        }
    }
}
