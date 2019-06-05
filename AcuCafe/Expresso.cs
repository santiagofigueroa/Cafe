using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuCafe
{
    public class Expresso : Drink
    {
        public new string Description
        {
            get { return "Expresso"; }
        }

        //public string AddTopping()
        //{
        //    return "Chocolate";
        //}

        public new double Cost()
        {
            double cost = 1.8;

            if (HasMilk)
                cost += MilkCost;

            if (HasSugar)
                cost += SugarCost;

            return cost;
        }
    }
}
