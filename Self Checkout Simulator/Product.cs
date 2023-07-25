using System;
using System.Collections.Generic;
using System.Linq;

namespace Self_Checkout_Simulator
{
    class Product
    {
        // Attributes
        protected int barcode, weightInGrams, units = 1; //Added units to vars
        protected string name;

        public Product(int barcode, string name, int weightInGrams)
        {
            this.barcode = barcode;
            this.weightInGrams = weightInGrams;
            this.name = name;
        }
        public Product(int barcode, string name)
        {
            this.barcode = barcode;
            this.name = name;
        }

        // Operations
        //Get
        public string GetName()
        {
            return name;
        }
        public int GetBarcode()
        {
            return barcode;
        }
        public int GetWeight()
        {
            return weightInGrams;
        }
        public int GetUnits()       //Added metod to get units.
        {
            return units;
        }
        //Virtuals
        public virtual bool IsLooseProduct()
        {
            return false;
        }
        public virtual int CalculatePrice()
        {
            return 0;
        }
        //Set
        public void SetWeight(int weightInGrams)
        {
            this.weightInGrams = weightInGrams;
        }
        public void AddUnit()       //Added method to add units
        {
            units++;
        }
        public void ResetUnits()
        {
            units = 0;
        }
    }

    class PackagedProduct : Product
    {
        // Attributes
        private int priceInPence;
        // Constructor
        public PackagedProduct(int barcode, string name, int priceInPence, int weightInGrams) : base(barcode, name, weightInGrams)
        {
            this.priceInPence = priceInPence;
        }

        // Operations
        public override int CalculatePrice()
        {
            return priceInPence * units;
        }
        public override bool IsLooseProduct()
        {
            return false;
        }
    }

    class LooseProduct : Product
    {
        // Attributes
        private int pencePer100g;
        // Constructor
        public LooseProduct(int barcode, string name, int pencePer100g) : base(barcode, name)
        {
            this.pencePer100g = pencePer100g;
        }

        // Operations
        public int GetPencePer100g()
        {
            return pencePer100g;
        }

        public override int CalculatePrice()
        {
            return weightInGrams * pencePer100g / 100 * units;
        }

        public override bool IsLooseProduct()
        {
            return true;
        }

    }
}