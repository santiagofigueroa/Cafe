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

        public new double Cost()
        {
            return cost;
        }
        public void setCost(double price )
        {

        } 
    }
}
