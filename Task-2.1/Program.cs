using System;

namespace Task_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Product myProduct = new Product();
                Product myProductProp = new Product("smth", 20, 3);
                Meat myMeet = new Meat();
                Meat myMeetProp = new Meat(Category.HighSort, Species.mutton, "nameMeet", 110, 3);
                Console.WriteLine(myProductProp);
                Console.WriteLine(myMeetProp);

                Storage storage = new Storage();
                storage.Dialogue();
                storage.ShowInfo();
                storage.TryToFindAllMeat();
                var date = new DateTime(2021, 12, 1);
                var date1 = new DateTime(2024, 12, 1);
                DairyProducts dairyProducts = new DairyProducts(date, "smth", 30, 15);
                DairyProducts dairyProducts1 = new DairyProducts(date1, "smth", 30, 15);
                dairyProducts.ChangePrice(dairyProducts.Price);
                dairyProducts1.ChangePrice(dairyProducts1.Price);
                Console.WriteLine(dairyProducts);
                Console.WriteLine(dairyProducts1);
                //myProduct = myMeetProp;
                //if (myProduct is Meat)
                //{
                //    (myProduct as Meat).trash();
                //    ((Meat)myProduct).trash();
                //}
                //Console.WriteLine("input meet category");
                //string categoryUser = Console.ReadLine();
                //Console.WriteLine("input meet species");
                //string species = Console.ReadLine();
                //Console.WriteLine("input meet name");
                //string name = Console.ReadLine();
                //Console.WriteLine("input meet price");
                //int price = int.Parse(Console.ReadLine());
                //Console.WriteLine("input meet weight");
                //double weight = double.Parse(Console.ReadLine());

                //Object obj;
                //if (Enum.TryParse(typeof(Category), categoryUser, out obj)) ;
                //{
                //    Category category = (Category)obj;
                //    Category category1 = (Category)Enum.Parse(typeof(Category), categoryUser);
                //    Meat meatFromClient = new Meat(category, Species.pork, name, price, weight);
                //    Meat meatFromClient1 = new Meat(category1, Species.pork, name, price, weight);
                //    Console.WriteLine(meatFromClient);
                //    Console.WriteLine(meatFromClient1);
                //}
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Argument problem");
            }
            catch (Exception)
            {
                Console.WriteLine("Any problem");
            }



        }
    }
    
}
