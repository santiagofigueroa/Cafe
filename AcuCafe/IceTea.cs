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

        public new string Description
        {
            get { return "Ice tea"; }
        }

        public new double Cost() {
         

            if (HasMilk)
                cost += MilkCost;

            if (HasSugar)
                cost += SugarCost;

            return cost;
        }
    }
}
