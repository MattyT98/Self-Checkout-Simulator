using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Self_Checkout_Simulator
{
    public partial class Clubcard : Form
    {
        public Clubcard(int totalPrice)
        {
            InitializeComponent();
            CustClubcard custClubcard = new CustClubcard("John", 12345, 250, 0, totalPrice);

            lblName.Text = custClubcard.GetName();
            lblClubNumber.Text = String.Format("{0:0}", custClubcard.GetNumber());
            lblPreviousBalance.Text = String.Format("{0:0}", custClubcard.GetCurrentBal());

            custClubcard.CalculateNewBalance();

            lblNewBalance.Text = String.Format("{0:0}", custClubcard.GetNewBal());
            lblNewpoints.Text = String.Format("{0:0}", custClubcard.GetNewpoints());

            custClubcard.SetCurrentBal(custClubcard.GetNewBal());
        }
    }
}
