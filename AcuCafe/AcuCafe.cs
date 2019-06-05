using System;
/// <summary>
/// 
/// Reference for Implementation. 
/// https://www.c-sharpcorner.com/UploadFile/damubetha/solid-principles-in-C-Sharp/
/// 
/// </summary>
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
            // Set field to be used later for the Preparation method.
            HasMilk = hasMilk;
            HasSugar = hasSugar;
            /// For compering and returning variable.
            Drink drink = type;


            if (drink is Expresso)
            {
                drink = new Expresso();
                // Adding topping to just Expresso. Other drinks are nullify
                drink.getChocolateTopping();

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
                // Check is has mill and that is not an "Ice Tea"
                if (hasMilk && !(drink is IceTea))
                {
                    drinkCost += MilkCost;
                }

                if (hasSugar)
                {
                    drinkCost += SugarCost;
                }

                // Sets the new price to the Drink. 
                drink.setCost(drinkCost);
                // Here could be a bit confusing as will print the name of the class,
                // whicj will print "IceTea" rather tha "Ice Tea"
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
            // TDOD:  Will this count telling the barista ?
            else if (drink.Equals("IceTea"))
                message += "No milk with Ice Tea please";

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