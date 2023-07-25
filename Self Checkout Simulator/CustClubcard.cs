using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Checkout_Simulator
{
    class CustClubcard
    {
        string Name;
        int Number;
        int Currentbalance;
        int Newbalance;
        int Newpoints;

        public CustClubcard(String Name, int Number, int Currentbalance, int Newbalance, int totalPrice)
        {
            this.Name = Name;
            this.Number = Number;
            this.Currentbalance = Currentbalance;
            this.Newbalance = Newbalance;
            Newpoints = totalPrice / 100;
            
        }         

        public string GetName()
        {
            return Name;
        }
        public int GetNumber()
        {
            return Number;
        }
        public int GetCurrentBal()
        {
            return Currentbalance;
        }
        public int GetNewBal()
        {
            return Newbalance;
        }
        public int GetNewpoints()
        {
            return Newpoints;
        }
        public void SetCurrentBal(int newCurrentbalance)
        {
            Currentbalance = newCurrentbalance;
        }
        public void CalculateNewBalance()
        {
            Newbalance = Currentbalance + Newpoints; 
        }
        
    }
}
