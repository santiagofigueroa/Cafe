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

        public string AddTopping()
        {
           return "Chocolate";
        }

        public new double Cost()
        {
            return cost;
        }
    }
}
