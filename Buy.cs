using System;
using System.Collections.Generic;
using System.Text;

namespace lerncs
{
    public class Buy
    {
        public int ProductsAmount { get; private set; }
        public int TotalPrice { get; private set; }
        public double TotalWeight { get; private set; }
        public List<Product> AllProducts { get; private set; }
        public Buy(params Product[] products)
        {
            ProductsAmount = products.Length;
            AllProducts = new List<Product>();
            foreach(var item in products)
            {
                TotalPrice += item.Price;
                TotalWeight += item.Weight;
                AllProducts.Add(item);
            }
        }
        public Buy()
        {
           
        }
        public void AddProduct(Product product)
        {
            if (product != null)
            {
                AllProducts.Add(product);
                TotalPrice += product.Price;
                TotalWeight += product.Weight;
                ProductsAmount += 1;
            }
        }
    }
}
