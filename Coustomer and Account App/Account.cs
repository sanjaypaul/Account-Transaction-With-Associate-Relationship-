using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coustomer_and_Account_App
{
    public class Account
    {
        public string AccountNumber { set; get; }
        public string OpeningDate { set; get; }
        public double Balance { private set; get; }

       

        public Account()
        {
            Balance = 0;
        }

        public string Diposit(double amount)
        {
            Balance +=amount;
            return "Diposited";
        }

        public string Withdow(double amount)
        {
            if (Balance-amount>=0)
            {
                Balance -= amount;
                return "Withdow";
            }
            else
            {
                return "Not suficent Balance";
            }
        }
    }
}
