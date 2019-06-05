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
        public new string Description
        {
            get { return "Expresso"; }
        }

        public string AddTopping()
        {
           return "Chocolate";
        }

        public new double Cost()
        {
 
            if (HasMilk)
                cost += MilkCost;

            if (HasSugar)
                cost += SugarCost;

            return cost;
        }
    }
}
