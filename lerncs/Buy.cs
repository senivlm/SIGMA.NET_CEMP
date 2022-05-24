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
        public List<Product> _allProducts;

        public Buy(params Product[] products)
        {
            ProductsAmount = products.Length;
            _allProducts = new List<Product>();

            foreach(var item in products)
            {
                TotalPrice += item.Price;
                TotalWeight += item.Weight;
                _allProducts.Add(item);
            }
        }
        public Buy()
        {
            ProductsAmount=0;
            TotalPrice=0;
            TotalWeight=0;
            _allProducts = new List<Product>();
        }
        public void AddProduct(Product product)
        {
            if (product != null)
            {
                _allProducts.Add(product);
                TotalPrice += product.Price;
                TotalWeight += product.Weight;
                ProductsAmount += 1;
            }
        }
    }
}
