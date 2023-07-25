namespace Self_Checkout_Simulator
{
    partial class UserInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUserScansBarcodeProduct = new System.Windows.Forms.Button();
            this.lbBasket = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUserSelectsLooseProduct = new System.Windows.Forms.Button();
            this.btnUserPutsProductInBaggingAreaCorrect = new System.Windows.Forms.Button();
            this.btnUserWeighsLooseProduct = new System.Windows.Forms.Button();
            this.btnUserChooseToPay = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblScreen = new System.Windows.Forms.Label();
            this.btnUserPutsProductInBaggingAreaIncorrect = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBaggingAreaExpectedWeight = new System.Windows.Forms.Label();
            this.lblBaggingAreaCurrentWeight = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAdminOverridesWeight = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnScanAClubcard = new System.Windows.Forms.Button();
            this.btnGoPayment = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblDiscountedPrice = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUserScansBarcodeProduct
            // 
            this.btnUserScansBarcodeProduct.Location = new System.Drawing.Point(12, 175);
            this.btnUserScansBarcodeProduct.Margin = new System.Windows.Forms.Padding(6);
            this.btnUserScansBarcodeProduct.Name = "btnUserScansBarcodeProduct";
            this.btnUserScansBarcodeProduct.Size = new System.Drawing.Size(248, 169);
            this.btnUserScansBarcodeProduct.TabIndex = 0;
            this.btnUserScansBarcodeProduct.Text = "Scan a barcoded product";
            this.btnUserScansBarcodeProduct.UseVisualStyleBackColor = true;
            this.btnUserScansBarcodeProduct.Click += new System.EventHandler(this.UserScansProduct);
            // 
            // lbBasket
            // 
            this.lbBasket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBasket.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBasket.FormattingEnabled = true;
            this.lbBasket.ItemHeight = 26;
            this.lbBasket.Location = new System.Drawing.Point(12, 37);
            this.lbBasket.Margin = new System.Windows.Forms.Padding(6);
            this.lbBasket.Name = "lbBasket";
            this.lbBasket.Size = new System.Drawing.Size(436, 498);
            this.lbBasket.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbBasket);
            this.groupBox1.Location = new System.Drawing.Point(1306, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(464, 569);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scanned Products";
            // 
            // btnUserSelectsLooseProduct
            // 
            this.btnUserSelectsLooseProduct.Location = new System.Drawing.Point(272, 175);
            this.btnUserSelectsLooseProduct.Margin = new System.Windows.Forms.Padding(6);
            this.btnUserSelectsLooseProduct.Name = "btnUserSelectsLooseProduct";
            this.btnUserSelectsLooseProduct.Size = new System.Drawing.Size(382, 79);
            this.btnUserSelectsLooseProduct.TabIndex = 0;
            this.btnUserSelectsLooseProduct.Text = "Select a loose product";
            this.btnUserSelectsLooseProduct.UseVisualStyleBackColor = true;
            this.btnUserSelectsLooseProduct.Click += new System.EventHandler(this.UserSelectsALooseProduct);
            // 
            // btnUserPutsProductInBaggingAreaCorrect
            // 
            this.btnUserPutsProductInBaggingAreaCorrect.Location = new System.Drawing.Point(12, 356);
            this.btnUserPutsProductInBaggingAreaCorrect.Margin = new System.Windows.Forms.Padding(6);
            this.btnUserPutsProductInBaggingAreaCorrect.Name = "btnUserPutsProductInBaggingAreaCorrect";
            this.btnUserPutsProductInBaggingAreaCorrect.Size = new System.Drawing.Size(314, 79);
            this.btnUserPutsProductInBaggingAreaCorrect.TabIndex = 0;
            this.btnUserPutsProductInBaggingAreaCorrect.Text = "Put product in bagging area (correct weight)";
            this.btnUserPutsProductInBaggingAreaCorrect.UseVisualStyleBackColor = true;
            this.btnUserPutsProductInBaggingAreaCorrect.Click += new System.EventHandler(this.UserPutsProductInBaggingAreaCorrect);
            // 
            // btnUserWeighsLooseProduct
            // 
            this.btnUserWeighsLooseProduct.Location = new System.Drawing.Point(272, 265);
            this.btnUserWeighsLooseProduct.Margin = new System.Windows.Forms.Padding(6);
            this.btnUserWeighsLooseProduct.Name = "btnUserWeighsLooseProduct";
            this.btnUserWeighsLooseProduct.Size = new System.Drawing.Size(382, 79);
            this.btnUserWeighsLooseProduct.TabIndex = 0;
            this.btnUserWeighsLooseProduct.Text = "Weigh loose product";
            this.btnUserWeighsLooseProduct.UseVisualStyleBackColor = true;
            this.btnUserWeighsLooseProduct.Click += new System.EventHandler(this.UserWeighsALooseProduct);
            // 
            // btnUserChooseToPay
            // 
            this.btnUserChooseToPay.Location = new System.Drawing.Point(9, 308);
            this.btnUserChooseToPay.Margin = new System.Windows.Forms.Padding(6);
            this.btnUserChooseToPay.Name = "btnUserChooseToPay";
            this.btnUserChooseToPay.Size = new System.Drawing.Size(206, 250);
            this.btnUserChooseToPay.TabIndex = 0;
            this.btnUserChooseToPay.Text = "Pay for products";
            this.btnUserChooseToPay.UseVisualStyleBackColor = true;
            this.btnUserChooseToPay.Click += new System.EventHandler(this.UserChoosesToPay);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGoPayment);
            this.groupBox2.Controls.Add(this.lblScreen);
            this.groupBox2.Controls.Add(this.btnUserPutsProductInBaggingAreaIncorrect);
            this.groupBox2.Controls.Add(this.btnUserScansBarcodeProduct);
            this.groupBox2.Controls.Add(this.btnUserPutsProductInBaggingAreaCorrect);
            this.groupBox2.Controls.Add(this.btnUserWeighsLooseProduct);
            this.groupBox2.Controls.Add(this.btnUserSelectsLooseProduct);
            this.groupBox2.Location = new System.Drawing.Point(24, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(666, 569);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Simulate a Customer";
            // 
            // lblScreen
            // 
            this.lblScreen.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblScreen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblScreen.Location = new System.Drawing.Point(12, 37);
            this.lblScreen.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblScreen.Name = "lblScreen";
            this.lblScreen.Size = new System.Drawing.Size(642, 117);
            this.lblScreen.TabIndex = 1;
            this.lblScreen.Text = "[SCREEN SIMULATION]";
            this.lblScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUserPutsProductInBaggingAreaIncorrect
            // 
            this.btnUserPutsProductInBaggingAreaIncorrect.Location = new System.Drawing.Point(338, 356);
            this.btnUserPutsProductInBaggingAreaIncorrect.Margin = new System.Windows.Forms.Padding(6);
            this.btnUserPutsProductInBaggingAreaIncorrect.Name = "btnUserPutsProductInBaggingAreaIncorrect";
            this.btnUserPutsProductInBaggingAreaIncorrect.Size = new System.Drawing.Size(314, 79);
            this.btnUserPutsProductInBaggingAreaIncorrect.TabIndex = 1;
            this.btnUserPutsProductInBaggingAreaIncorrect.Text = "Put product in bagging area (incorrect weight)";
            this.btnUserPutsProductInBaggingAreaIncorrect.UseVisualStyleBackColor = true;
            this.btnUserPutsProductInBaggingAreaIncorrect.Click += new System.EventHandler(this.UserPutsProductInBaggingAreaIncorrect);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox8);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(948, 23);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(340, 375);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Internal Data";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblTotalPrice);
            this.groupBox6.Location = new System.Drawing.Point(12, 217);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox6.Size = new System.Drawing.Size(316, 67);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Total Price";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(12, 31);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(161, 25);
            this.lblTotalPrice.TabIndex = 0;
            this.lblTotalPrice.Text = "[TOTAL PRICE]";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.lblBaggingAreaExpectedWeight);
            this.groupBox4.Controls.Add(this.lblBaggingAreaCurrentWeight);
            this.groupBox4.Location = new System.Drawing.Point(12, 37);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox4.Size = new System.Drawing.Size(316, 169);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bagging Area";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Current Weight";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expected Weight";
            // 
            // lblBaggingAreaExpectedWeight
            // 
            this.lblBaggingAreaExpectedWeight.AutoSize = true;
            this.lblBaggingAreaExpectedWeight.Location = new System.Drawing.Point(12, 56);
            this.lblBaggingAreaExpectedWeight.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBaggingAreaExpectedWeight.Name = "lblBaggingAreaExpectedWeight";
            this.lblBaggingAreaExpectedWeight.Size = new System.Drawing.Size(226, 25);
            this.lblBaggingAreaExpectedWeight.TabIndex = 0;
            this.lblBaggingAreaExpectedWeight.Text = "[EXPECTED WEIGHT]";
            // 
            // lblBaggingAreaCurrentWeight
            // 
            this.lblBaggingAreaCurrentWeight.AutoSize = true;
            this.lblBaggingAreaCurrentWeight.Location = new System.Drawing.Point(12, 117);
            this.lblBaggingAreaCurrentWeight.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBaggingAreaCurrentWeight.Name = "lblBaggingAreaCurrentWeight";
            this.lblBaggingAreaCurrentWeight.Size = new System.Drawing.Size(215, 25);
            this.lblBaggingAreaCurrentWeight.TabIndex = 0;
            this.lblBaggingAreaCurrentWeight.Text = "[CURRENT WEIGHT]";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnAdminOverridesWeight);
            this.groupBox5.Location = new System.Drawing.Point(948, 417);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox5.Size = new System.Drawing.Size(340, 176);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Admin Controls";
            // 
            // btnAdminOverridesWeight
            // 
            this.btnAdminOverridesWeight.Location = new System.Drawing.Point(12, 36);
            this.btnAdminOverridesWeight.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdminOverridesWeight.Name = "btnAdminOverridesWeight";
            this.btnAdminOverridesWeight.Size = new System.Drawing.Size(296, 131);
            this.btnAdminOverridesWeight.TabIndex = 2;
            this.btnAdminOverridesWeight.Text = "Override weight";
            this.btnAdminOverridesWeight.UseVisualStyleBackColor = true;
            this.btnAdminOverridesWeight.Click += new System.EventHandler(this.AdminOverridesWeight);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnScanAClubcard);
            this.groupBox7.Controls.Add(this.btnUserChooseToPay);
            this.groupBox7.Location = new System.Drawing.Point(705, 23);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(224, 570);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Customer Payment";
            // 
            // btnScanAClubcard
            // 
            this.btnScanAClubcard.Location = new System.Drawing.Point(9, 37);
            this.btnScanAClubcard.Margin = new System.Windows.Forms.Padding(6);
            this.btnScanAClubcard.Name = "btnScanAClubcard";
            this.btnScanAClubcard.Size = new System.Drawing.Size(206, 246);
            this.btnScanAClubcard.TabIndex = 1;
            this.btnScanAClubcard.Text = "Scan A Clubcard";
            this.btnScanAClubcard.UseVisualStyleBackColor = true;
            this.btnScanAClubcard.Click += new System.EventHandler(this.btnScanAClubcard_Click);
            // 
            // btnGoPayment
            // 
            this.btnGoPayment.Location = new System.Drawing.Point(12, 448);
            this.btnGoPayment.Margin = new System.Windows.Forms.Padding(6);
            this.btnGoPayment.Name = "btnGoPayment";
            this.btnGoPayment.Size = new System.Drawing.Size(642, 109);
            this.btnGoPayment.TabIndex = 2;
            this.btnGoPayment.Text = "Go To Payment";
            this.btnGoPayment.UseVisualStyleBackColor = true;
            this.btnGoPayment.Click += new System.EventHandler(this.btnGoPayment_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lblDiscountedPrice);
            this.groupBox8.Location = new System.Drawing.Point(12, 296);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox8.Size = new System.Drawing.Size(316, 67);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Discounted Price";
            // 
            // lblDiscountedPrice
            // 
            this.lblDiscountedPrice.AutoSize = true;
            this.lblDiscountedPrice.Location = new System.Drawing.Point(12, 31);
            this.lblDiscountedPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDiscountedPrice.Name = "lblDiscountedPrice";
            this.lblDiscountedPrice.Size = new System.Drawing.Size(146, 25);
            this.lblDiscountedPrice.TabIndex = 0;
            this.lblDiscountedPrice.Text = "[DISC\' PRICE]";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1794, 613);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Self Checkout Simulator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUserScansBarcodeProduct;
        private System.Windows.Forms.ListBox lbBasket;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUserSelectsLooseProduct;
        private System.Windows.Forms.Button btnUserPutsProductInBaggingAreaCorrect;
        private System.Windows.Forms.Button btnUserWeighsLooseProduct;
        private System.Windows.Forms.Button btnUserChooseToPay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblBaggingAreaExpectedWeight;
        private System.Windows.Forms.Label lblBaggingAreaCurrentWeight;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUserPutsProductInBaggingAreaIncorrect;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnAdminOverridesWeight;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblScreen;
        private System.Windows.Forms.Button btnGoPayment;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnScanAClubcard;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lblDiscountedPrice;
    }
}

