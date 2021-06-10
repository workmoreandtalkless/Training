using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise7
{
    class User
    {
        private  int pinNum;
        private  decimal balance;
        private string name;
        public User(int pinNumber, string name, decimal balance = 1000m)
        {
            this.pinNum = pinNumber;
            this.balance = balance;
            this.name = name;
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public int GetpinNum()
        {
            return pinNum;
        }

        public string GetName()
        {
            return name;
        }

        public void Deposit(int money)
        {
            this.balance += money;
        }
        public void Withdraw(int money)
        {
            this.balance -= money;
        }
    }
}
