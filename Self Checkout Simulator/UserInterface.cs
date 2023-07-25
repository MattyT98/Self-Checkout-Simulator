using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Self_Checkout_Simulator
{
    public partial class UserInterface : Form
    {
        // Attributes
        SelfCheckout selfCheckout;
        BarcodeScanner barcodeScanner;
        BaggingAreaScale baggingAreaScale;
        LooseItemScale looseItemScale;
        ScannedProducts scannedProducts;
        Clubcard clubcardForm;

        bool clubcard = false;
        bool clubcardviewed = false;

        // Constructor
        public UserInterface()
        {
            InitializeComponent();
            // NOTE: This is where we set up all the objects,
            // and create the various relationships between them.
            baggingAreaScale = new BaggingAreaScale();
            scannedProducts = new ScannedProducts();
            barcodeScanner = new BarcodeScanner();
            looseItemScale = new LooseItemScale();
            selfCheckout = new SelfCheckout(baggingAreaScale, scannedProducts, looseItemScale);
            barcodeScanner.LinkToSelfCheckout(selfCheckout);
            baggingAreaScale.LinkToSelfCheckout(selfCheckout);
            looseItemScale.LinkToSelfCheckout(selfCheckout);
            UpdateDisplay();
        }

        // Operations
        private void UserScansProduct(object sender, EventArgs e)
        {
            barcodeScanner.BarcodeDetected();
            UpdateDisplay();
        }

        private void UserPutsProductInBaggingAreaCorrect(object sender, EventArgs e)
        {
            // NOTE: we use the correct item weight here
            int difference = selfCheckout.GetCurrentProduct().GetWeight();
            baggingAreaScale.WeightChangeDetected(difference);
            UpdateDisplay();
        }

        private void UserPutsProductInBaggingAreaIncorrect(object sender, EventArgs e)
        {
            // NOTE: We are pretending to put down an item with the wrong weight.
            // To simulate this we'll use a random number, here's one for you to use.
            int weight = new Random().Next(20, 100);
            baggingAreaScale.WeightChangeDetected(weight);
            UpdateDisplay();
        }

        private void UserSelectsALooseProduct(object sender, EventArgs e)
        {
            selfCheckout.LooseProductSelected();
            UpdateDisplay();
        }

        private void UserWeighsALooseProduct(object sender, EventArgs e)
        {
            // NOTE: We are pretending to weigh a banana or whatever here.
            // To simulate this we'll use a random number, here's one for you to use.
            int weight = new Random().Next(20, 100);
            looseItemScale.WeightChangeDetected(weight);
            UpdateDisplay();
        }

        private void AdminOverridesWeight(object sender, EventArgs e)
        {
            selfCheckout.AdminOverrideWeight();
            UpdateDisplay();
        }

        private void btnScanAClubcard_Click(object sender, EventArgs e)
        {
            int totalPrice = scannedProducts.CalculatePrice();
            clubcardForm = new Clubcard(totalPrice);
            clubcardForm.Show();
            clubcardviewed = true;
            UpdateDisplay();
        }

        private void btnGoPayment_Click(object sender, EventArgs e)
        {
            clubcard = true;
            selfCheckout.SetGoToPayment();
            UpdateDisplay();
        }

        private void UserChoosesToPay(object sender, EventArgs e)
        {
            selfCheckout.UserPaid();
            selfCheckout.SetGoToPayment();
            UpdateDisplay();
            clubcard = false;
            clubcardviewed = false;
            clubcardForm.Close();
        }        

        void UpdateDisplay()
        {
            lbBasket.Items.Clear();
            lblScreen.Text = selfCheckout.GetPromptForUser();

            lblBaggingAreaCurrentWeight.Text = string.Format("{0:0.00}", baggingAreaScale.GetCurrentWeight());
            lblBaggingAreaExpectedWeight.Text = string.Format("{0:0.00}", baggingAreaScale.GetExpectedWeight());

            lblTotalPrice.Text = string.Format("{0,0:C2}", 0.0);

            if (!scannedProducts.HasItems())
            {
                double discountedPrice = 0.0;                                          
                double totalPrice = scannedProducts.CalculatePrice() / 100.0;          
                lblTotalPrice.Text = string.Format("{0,0:C2}", totalPrice);            

                lblTotalPrice.Text = string.Format("{0,0:C2}", Convert.ToDouble(scannedProducts.CalculatePrice() / 100.0));
                List<Product> products = scannedProducts.GetProducts();

                for (int i = 0; i < products.Count; ++i)
                {
                    string s = "" + String.Format("{0,0:C2}", Convert.ToDouble((products[i].CalculatePrice() / 100.0))) + " " + products[i].GetName() + " x " + products[i].GetUnits(); //Now include the units of a product.
                    lbBasket.Items.Add(s);
                }

                if (totalPrice >= 100.00)
                {
                    discountedPrice = totalPrice - (0.10 * totalPrice);
                }
                else
                    if (totalPrice >= 50)
                {
                    discountedPrice = totalPrice - (0.05 * totalPrice);
                }
                else
                    discountedPrice = totalPrice;

                lblDiscountedPrice.Text = string.Format("{0,0:C2}", discountedPrice);
            }

            //Enable & Disbale Buttons
            if (selfCheckout.GetCurrentProduct() == null)
            {   // Scan Barcoded or Loose Product
                if (looseItemScale.IsEnabled())
                {   //Check if scan loose item has been pressed or scan barcoded product
                    btnUserScansBarcodeProduct.Enabled = false;
                    btnUserPutsProductInBaggingAreaIncorrect.Enabled = false;
                    btnUserPutsProductInBaggingAreaCorrect.Enabled = false;
                    btnAdminOverridesWeight.Enabled = false;
                    btnUserChooseToPay.Enabled = false;
                    btnUserSelectsLooseProduct.Enabled = false;
                    btnUserWeighsLooseProduct.Enabled = true;
                    
                    btnScanAClubcard.Enabled = false;
                    btnGoPayment.Enabled = false;
                }
                else
                {   //Default Setup - enables scan barcode button and loose product button without the pay button
                    btnUserScansBarcodeProduct.Enabled = true;
                    btnUserPutsProductInBaggingAreaIncorrect.Enabled = false;
                    btnUserPutsProductInBaggingAreaCorrect.Enabled = false;
                    btnAdminOverridesWeight.Enabled = false;
                    btnUserChooseToPay.Enabled = false;
                    btnUserSelectsLooseProduct.Enabled = true;
                    btnUserWeighsLooseProduct.Enabled = false;
                    
                    btnScanAClubcard.Enabled = false;
                    btnGoPayment.Enabled = false;
                }
            }
            else
            {
                if (looseItemScale.IsEnabled())
                {   //Enables weigh button
                    btnUserScansBarcodeProduct.Enabled = false;
                    btnUserPutsProductInBaggingAreaIncorrect.Enabled = false;
                    btnUserPutsProductInBaggingAreaCorrect.Enabled = false;
                    btnAdminOverridesWeight.Enabled = false;
                    btnUserChooseToPay.Enabled = false;
                    btnUserSelectsLooseProduct.Enabled = false;
                    btnUserWeighsLooseProduct.Enabled = true;

                    btnScanAClubcard.Enabled = false;
                    btnGoPayment.Enabled = false;
                }
                else
                {   
                    if (baggingAreaScale.GetExpectedWeight() == (baggingAreaScale.GetCurrentWeight() + selfCheckout.GetCurrentProduct().GetWeight()))
                    {   //Enables Put in Bagging Area Buttons
                        btnUserScansBarcodeProduct.Enabled = false;
                        btnUserPutsProductInBaggingAreaIncorrect.Enabled = true;
                        btnUserPutsProductInBaggingAreaCorrect.Enabled = true;
                        btnAdminOverridesWeight.Enabled = false;
                        btnUserChooseToPay.Enabled = false;
                        btnUserSelectsLooseProduct.Enabled = false;
                        btnUserWeighsLooseProduct.Enabled = false;

                        btnScanAClubcard.Enabled = false;
                        btnGoPayment.Enabled = false;
                    }
                    else
                    {
                        if (baggingAreaScale.GetCurrentWeight() != baggingAreaScale.GetExpectedWeight())
                        {   // Enable Admin Button if weights don't match
                            btnUserScansBarcodeProduct.Enabled = false;
                            btnUserPutsProductInBaggingAreaIncorrect.Enabled = false;
                            btnUserPutsProductInBaggingAreaCorrect.Enabled = false;
                            btnAdminOverridesWeight.Enabled = true;
                            btnUserChooseToPay.Enabled = false;
                            btnUserSelectsLooseProduct.Enabled = false;
                            btnUserWeighsLooseProduct.Enabled = false;

                            btnScanAClubcard.Enabled = false;
                            btnGoPayment.Enabled = false;
                        }
                        else
                        {
                            // Restart if statement without a null product
                            if (looseItemScale.IsEnabled())
                            {   //Check if scan loose item has been pressed and enables weigh button
                                btnUserScansBarcodeProduct.Enabled = false;
                                btnUserPutsProductInBaggingAreaIncorrect.Enabled = false;
                                btnUserPutsProductInBaggingAreaCorrect.Enabled = false;
                                btnAdminOverridesWeight.Enabled = false;
                                btnUserChooseToPay.Enabled = false;
                                btnUserSelectsLooseProduct.Enabled = false;
                                btnUserWeighsLooseProduct.Enabled = true;

                                btnScanAClubcard.Enabled = false;
                                btnGoPayment.Enabled = false;
                            }
                            else
                            {   //Default Setup - enable scan barcode button and loose product button with GoToPayment button)                                
                                if ((!looseItemScale.IsEnabled()) && (clubcard == false))
                                {
                                    btnUserScansBarcodeProduct.Enabled = true;
                                    btnUserPutsProductInBaggingAreaIncorrect.Enabled = false;
                                    btnUserPutsProductInBaggingAreaCorrect.Enabled = false;
                                    btnAdminOverridesWeight.Enabled = false;
                                    btnUserChooseToPay.Enabled = false;
                                    btnUserSelectsLooseProduct.Enabled = true;
                                    btnUserWeighsLooseProduct.Enabled = false;

                                    btnScanAClubcard.Enabled = false;
                                    btnGoPayment.Enabled = true;
                                }
                                else
                                {
                                    if (clubcardviewed == false)
                                    {
                                        //Start Clubcard step and disable all other buttons
                                        btnUserScansBarcodeProduct.Enabled = false;
                                        btnUserPutsProductInBaggingAreaIncorrect.Enabled = false;
                                        btnUserPutsProductInBaggingAreaCorrect.Enabled = false;
                                        btnAdminOverridesWeight.Enabled = false;
                                        btnUserChooseToPay.Enabled = true;
                                        btnUserSelectsLooseProduct.Enabled = false;
                                        btnUserWeighsLooseProduct.Enabled = false;

                                        btnScanAClubcard.Enabled = true;
                                        btnGoPayment.Enabled = false;
                                    }
                                    else
                                    {
                                        btnUserScansBarcodeProduct.Enabled = false;
                                        btnUserPutsProductInBaggingAreaIncorrect.Enabled = false;
                                        btnUserPutsProductInBaggingAreaCorrect.Enabled = false;
                                        btnAdminOverridesWeight.Enabled = false;
                                        btnUserChooseToPay.Enabled = true;
                                        btnUserSelectsLooseProduct.Enabled = false;
                                        btnUserWeighsLooseProduct.Enabled = false;

                                        btnScanAClubcard.Enabled = false;
                                        btnGoPayment.Enabled = false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}