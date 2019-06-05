using System;

namespace AcuCafe
{
    public class AcuCafe
    {
        private const double MilkCost = 0.5;
        private const double SugarCost = 0.5;

        private static bool HasMilk { get; set; }

        private static bool HasSugar { get; set; }

        public static Drink OrderDrink(Drink type, bool hasMilk, bool hasSugar)
        {
            /// For compering and returning variable.
            Drink drink = type;
 

            if (drink is Expresso)
            {          
                drink = new Expresso();
                
            }
            else if (drink is Tea)
            {                
                drink = new Tea();
            }
            else if (drink is IceTea)
            {            
                drink = new IceTea();
                
            }

            try
            {
               double drinkCost = drink.Cost();
                if(hasMilk)
                {
                    drinkCost += MilkCost;
                } 

                if (hasSugar)
                {
                    drinkCost += SugarCost;
                }

                // Sets the new price to the Drink. 
                drink.setCost(drinkCost);
                Prepare(drink.ToString()); 
            }
            catch (Exception ex)
            {
                Console.WriteLine("We are unable to prepare your drink.");
                System.IO.File.WriteAllText(@"c:\Error.txt", ex.ToString());
            }

            return drink;
        }

        public static void Prepare(string drink)
        {
            string message = "We are preparing the following drink for you: " + drink;
            if (HasMilk)
                message += "with milk";
            else
                message += "without milk";

            if (HasSugar)
                message += "with sugar";
            else
                message += "without sugar";

            Console.WriteLine(message);
        }
    }

   

   
}