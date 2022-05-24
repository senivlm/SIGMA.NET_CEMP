using lerncs;
using System;
using System.Collections;
using System.Collections.Generic;




class Program
{
	static void Main(string[] args)
	{


        try 
        { 

            Product myProduct = new Product();
            Product myProductProp = new Product("smth", 20, 3);
            Meat myMeet = new Meat();
            Meat myMeetProp = new Meat(Category.HighSort,Species.mutton,"nameMeet", 110,3);
            Console.WriteLine(myProductProp);
            Console.WriteLine(myMeetProp);

            Storage storage = new Storage();
            storage.Dialogue();
            storage.ShowInfo();
            storage.TryToFindAllMeat();

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