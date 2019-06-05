using System;

namespace AcuCafe
{
    public class AcuCafe
    {
        public static Drink OrderDrink(Drink type, bool hasMilk, bool hasSugar)
        {
            /// 
            object drink = type;
           
            if (drink is Expresso)
            {
               drink = new Expresso();
            }
            else if (drink is Tea)
                drink = new Tea();
            else if (drink is IceTea)
                drink = new IceTea();

            try
            {
                type.HasMilk = hasMilk;
                type.HasSugar = hasSugar;
                //type.Prepare(type); //TODO: Still thinking whay to do here.
            }
            catch (Exception ex)
            {
                Console.WriteLine("We are unable to prepare your drink.");
                System.IO.File.WriteAllText(@"c:\Error.txt", ex.ToString());
            }

            return type;
        }
    }

   

   
}