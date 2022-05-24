using System;
using System.Collections.Generic;
using System.Text;

namespace lerncs
{
    public class Storage
    {
        protected List<Product> products { get; private set; } = new List<Product>();
        public Storage(params Product[] products)
        {
            foreach(var item in products)
            {
                this.products.Add(item);
            }
        }
        public Product this[int i]
        {
            get
            {
                return products[i];
            }
        }
        public void Dialogue()
        {
            var pairsToProduct = new Dictionary<string, Product>();
            pairsToProduct["1"] = new Product("apple", 5, 0.5d);
            pairsToProduct["2"] = new Product("cake", 50, 1d);
            pairsToProduct["3"] = new Product("lemon", 10, 0.3d);
            pairsToProduct["4"] = null;
            do
            {
                Console.WriteLine("What do you want to buy? \t Apple - 1, \t Cake - 2, \t Lemon - 3, \t Exit - 4");
                var answer = "1";
                do
                {
                    answer = Console.ReadLine();
                } while (!pairsToProduct.ContainsKey(answer));
                if(answer == "4")
                {
                    break;
                }
                else
                {
                    products.Add(pairsToProduct[answer]);
                }
            }
            while (true);
        }

        public void TryToFindAllMeat()
        {
            foreach(var item in products)
            {
                if(item is Meat)
                {
                    Console.WriteLine("Meat named {0} was found", item.Name);
                }
            }
        }

        public void ChangePriceOfAllProducts(int percentage)
        {
            foreach (var item in products)
            {
                item.ChangePrice(percentage);
            }
        }
        public void ShowInfo()
        {
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine("{0} grn, {1} kg, {2} name", products[i].Price,
                    products[i].Weight, products[i].Name);
            }
        }
    }
}
