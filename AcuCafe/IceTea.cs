using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuCafe
{
    public class IceTea : Drink
    {
        public new string Description
        {
            get { return "Ice tea"; }
        }

        public new double Cost()
        {
            double cost = 1.5;

            if (HasMilk)
                cost += MilkCost;

            if (HasSugar)
                cost += SugarCost;

            return cost;
        }
    }
}
