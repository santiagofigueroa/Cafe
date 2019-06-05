using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuCafe
{
    public class Tea : Drink
    {
        private double cost { get; set; } = 1.0;

        public override double Cost()
        {

            return cost;
        }
    }
}
