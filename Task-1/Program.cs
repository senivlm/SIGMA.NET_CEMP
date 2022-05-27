using System;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Buy buy = new Buy();
              //  Product myProduct = new Product();
                Product myProductProp = new Product("cake", 10, 1);
                Product myProductProp1 = new Product("lemon", 15, 3);
                Product myProductProp2 = new Product("meat", 30, 1);
                Product myProductProp3 = new Product("milk", 20, 2);
                buy.AddProduct(myProductProp);
                buy.AddProduct(myProductProp1);
                buy.AddProduct(myProductProp2);
                buy.AddProduct(myProductProp3);
               // Console.WriteLine(myProduct);
                Console.WriteLine(myProductProp);
                Console.WriteLine(myProductProp1);
                Console.WriteLine(myProductProp2);
                Console.WriteLine(myProductProp3);
                Console.WriteLine("quantity of products: "+buy.CountOfProducts);
                Console.WriteLine("Total price: "+buy.PriceOfAll);
                Console.WriteLine("Total weight: "+buy.WeightOffAll);
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
