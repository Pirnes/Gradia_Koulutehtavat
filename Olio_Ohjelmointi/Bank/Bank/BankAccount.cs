using System;

namespace BankAccountNS
{
    public class BankAccount
    {
        private string m_customerName;
        private double m_balance;

        private BankAccount()
        {
        }

        public BankAccount (string customernamne, double balance)
        {
            m_customerName = customernamne;
            m_balance = balance;
        }

        public string CustomerName
        {
            get { return m_customerName; }
        } 

        public double Balance
        {
            get { return m_balance; }
        }

        public void Debit(double amount)
        {
            if (amount > m_balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            m_balance -= amount; //intentionally incorrect code
        }

        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            m_balance += amount;
        }

        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount("Mr. Bryan Walton", 11.99);

            ba.Credit(5.77);
            ba.Debit(11.22);
            Console.WriteLine("Current Balance is ${}", ba.Balance);

        }
    }
}
