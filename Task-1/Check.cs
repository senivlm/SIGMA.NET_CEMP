﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    public static class Check
    {
        public static void ShowInfo(Buy buy)
        {// Якщо дані в покупці будуть інкапсульовані, цю частину треба переробити
            for (int i = 0; i < buy.CountOfProducts; i++)
            {
                Console.WriteLine("{0} grn, {1} kg, {2} name", buy._allProducts[i].Price,
                    buy._allProducts[i].Weight, buy._allProducts[i].Name);
            }
            Console.WriteLine("Total price: {0}", buy.PriceOfAll);
        }
    }
}
