using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuCafe
{
    public class Expresso : Drink
    {
        private double cost { get; set; } = 1.8;
        private string topping { get; } = "Chocolate";

        public string getChocolateTopping()
        {

            return topping;
        }

        public override double Cost()
        {
            return cost;
        }

        public override void setCost(double price)
        {
            cost = price;
        }
    }
}
