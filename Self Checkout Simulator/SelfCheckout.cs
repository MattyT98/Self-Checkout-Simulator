using System;
using System.Collections.Generic;
using System.Linq;

namespace Self_Checkout_Simulator
{
    class SelfCheckout
    {
        // Attributes
        private Product currentProduct;
        private LooseItemScale looseItemScale;
        private BaggingAreaScale baggingAreaScale;
        private ScannedProducts scannedProducts;
        private bool goToPayment;

        // Constructor
        public SelfCheckout(BaggingAreaScale baggingAreaScale, ScannedProducts scannedProducts, LooseItemScale looseItemScale)
        {
            // store objects in attributes above
            this.looseItemScale = looseItemScale;
            this.scannedProducts = scannedProducts;
            this.baggingAreaScale = baggingAreaScale;
            goToPayment = false;
        }

        // Operations
        public void LooseProductSelected()
        {
            looseItemScale.Enable();
        }

        public void LooseItemAreaWeightChanged(int weightOfLooseItem)
        {
            currentProduct = ProductsDAO.GetRandomLooseProduct();
            currentProduct.SetWeight(weightOfLooseItem);

            List<Product> list = scannedProducts.GetProducts();             //Gets the current product list (just to shorten code)
            if (list.Contains(currentProduct))                              //If the list already has the item
            {
                int index = list.IndexOf(currentProduct);                   //Get the current value
                scannedProducts.GetProducts()[index].AddUnit();             //Add 1
            }
            else
                scannedProducts.Add(currentProduct);

            int weight = scannedProducts.CalculateWeight();
            baggingAreaScale.SetExpectedWeight(weight);
            looseItemScale.Disable();
        }

        public void BarcodeWasScanned(int barcode)
        {
            currentProduct = ProductsDAO.SearchUsingBarcode(barcode);

            List<Product> list = scannedProducts.GetProducts();             //Gets the current product list (just to shorten code)
            if (list.Contains(currentProduct))                              //If the list already has the item
            {
                int index = list.IndexOf(currentProduct);                   //Get the current value
                scannedProducts.GetProducts()[index].AddUnit();             //Add 1
            }
            else
                scannedProducts.Add(currentProduct);

            int currentWeight = scannedProducts.CalculateWeight();
            baggingAreaScale.SetExpectedWeight(currentWeight);
        }

        public void BaggingAreaWeightChanged()
        {
            baggingAreaScale.OverrideWeight();
        }

        public void UserPaid()
        {
            scannedProducts.Reset();
            baggingAreaScale.Reset();

            currentProduct = null;
        }

        public string GetPromptForUser()
        {
            if (currentProduct == null)
            {
                if (!looseItemScale.IsEnabled())
                {
                    return "Scan an item";
                }
                else
                {
                    return "Place item on scale";
                }
            }
            else
            {
                if (!looseItemScale.IsEnabled())
                {
                    if (baggingAreaScale.GetCurrentWeight() != baggingAreaScale.GetExpectedWeight())
                    {
                        if ((currentProduct.GetWeight() + baggingAreaScale.GetCurrentWeight()) == baggingAreaScale.GetExpectedWeight())
                        {
                            return "Place the item in the bagging area";
                        }
                        else
                        {
                            return "Please wait, assistant is on the way";
                        }
                    }
                    else
                    {
                        if (goToPayment) // Needs changing to be able to go into scan a clubcard message
                        {
                            return "Scan A Clubcard or pay";
                        }
                        else
                        {
                            return "Scan an item or go to payment";
                        }
                    }
                }
                else
                {
                    if (looseItemScale.IsEnabled())
                    {
                        return "Place item on scale";
                    }
                    else
                    {
                        if (baggingAreaScale.GetCurrentWeight() != baggingAreaScale.GetExpectedWeight())
                        {
                            if ((currentProduct.GetWeight() + baggingAreaScale.GetCurrentWeight()) == baggingAreaScale.GetExpectedWeight())
                            {
                                return "Place the item in the bagging area";
                            }
                            else
                            {
                                return "Please wait, assistant is on the way";
                            }
                        }
                        else
                        {
                            return "Scan an item or go to payment";
                        }
                    }
                }
            }
        }

        public void SetGoToPayment()
        {
            goToPayment ^= true;
        }

        public Product GetCurrentProduct()
        {
            return currentProduct;
        }

        public void AdminOverrideWeight()
        {
            List<Product> temp2 = scannedProducts.GetProducts();
            int temp = temp2.Count() - 1;
            if (currentProduct.GetBarcode() == temp2[temp].GetBarcode())
            {
                scannedProducts.GetProducts()[temp] = currentProduct;
            }
            baggingAreaScale.SetExpectedWeight(baggingAreaScale.GetCurrentWeight());
        }
    }
}