using System;
using System.Collections.Generic;
using System.Linq;

namespace Self_Checkout_Simulator
{
    class ScannedProducts
    {
        // Attributes
        private List<Product> products = new List<Product>();


        // Operations
        public List<Product> GetProducts()
        {
            return products;
        }

        public int CalculateWeight()
        {
            int totalWeight = 0;
            for (int i = 0; i < products.Count(); ++i)
            {
                Product temp = products[i];
                int temp2 = temp.GetWeight();
                int units = temp.GetUnits();                //Added units int
                totalWeight += temp2 * units;               //Now += weight per item * number of units
            }
            return totalWeight;
        }

        public int CalculatePrice()
        {
            int totalPrice = 0;
            for (int i = 0; i < products.Count(); ++i)
            {
                Product temp = products[i];
                int temp2 = temp.CalculatePrice();
                totalPrice += temp2;
            }
            return totalPrice;
        }

        public void Reset()
        {
            for (int i = 0; i < products.Count; i++) //Added reset for units
            { products[i].ResetUnits(); }
            products.Clear();
        }

        public void Add(Product p)
        {
            products.Add(p);
        }

        public bool HasItems()
        {
            return products == null;
        }
    }
}