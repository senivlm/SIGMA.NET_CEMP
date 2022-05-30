using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    public class Buy
    {
        public int CountOfProducts { get; private set; }
        public int PriceOfAll { get; private set; }
        public double WeightOffAll { get; private set; }
        // Порушена інкапсуляція даних!!!
        public List<Product> _allProducts;

        public Buy(params Product[] products)
        {
            CountOfProducts = products.Length;
            _allProducts = new List<Product>();

            foreach(var item in products)
            {
                PriceOfAll += item.Price;
                WeightOffAll += item.Weight;
                _allProducts.Add(item);
            }
        }
        public Buy()
        {
            CountOfProducts=0;
            PriceOfAll=0;
            WeightOffAll=0;
            _allProducts = new List<Product>();
        }
        // Варто передбачити купівлю кількох однакових продуктів
        public void AddProduct(Product product)
        {
            if (product != null)
            {
                _allProducts.Add(product);
                PriceOfAll += product.Price;
                WeightOffAll += product.Weight;
                CountOfProducts += 1;
            }
        }
    }
    Метод ToString не перевизначений!
}
