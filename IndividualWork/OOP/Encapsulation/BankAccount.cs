using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualWork.OOP.Encapsulation
{
    public class BankAccount
    {
        
        private int balance=0;
        private string name;
        public int amount=0;
        public int payment = 0;
        public BankAccount() { }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public BankAccount(int balance)
        {
            this.balance = balance;
        }
        public void SetDeposit(int amount)
        {
            this.amount=amount;
        }
        public void Payment(int payment)
        {
            payment += amount;

            if (payment <= balance)
            {
                balance = balance-payment;
            }
            
            else
            {
                throw new Exception($"Dear {Name},there isn't enough amount in your balance");
            }

            
        }
        public int GetBalance() 
        { 
            return balance;
        }
    }

}
