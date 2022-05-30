﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._1
{
    public class Storage
    {// У класі зовсім не перехоплені винятки.
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
            pairsToProduct["1"] = new Meat(Category.HighSort,Species.mutton,"MuttonHighSort", 110,3);
            pairsToProduct["2"] = new Product("tomatto", 50, 1.5d);
            pairsToProduct["3"] = new Product("solt", 10, 2d);
            pairsToProduct["4"] = null;
            Buy buy = new Buy();
            do
            {
                Console.WriteLine("What do you want to buy? \t Mutton - 1, \t Tomatto - 2, \t Solt - 3, \t Exit - 4");
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
                    buy.AddProduct(pairsToProduct[answer]);
                }
            }
            while (true);
            Console.WriteLine("Price of all products: "+buy.PriceOfAll);
            Console.WriteLine("Weight of all products: " + buy.WeightOffAll);
        }

        public void TryToFindAllMeat()
        {
            foreach(var item in products)
            {
                if(item is Meat)
                {
                    Console.WriteLine("The meat is {0} was found", item.Name);
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
