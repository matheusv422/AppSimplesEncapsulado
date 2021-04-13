using System;
using System.Globalization;

namespace CadastroDeContaBancaria
{
    class Account
    {
        public string Name { get; set; }
        public int Number { get; private set; }
        public double Balance { get; private set; }
       

      
        public Account(string name, int number)
        {
            Name = name;
            Number = number;
            
        }

        public Account(string name, int number, double initDeposit) : this(name, number)
        {

            Deposit(initDeposit);
        }
        



        




        public int Numero
        {
            get { return Number; }
        }


        public double Saldo
        {
            get { return Balance; }
           
        }

        public void Deposit (double deposit)
        {
            Balance += deposit;
        }
        

        public void Withdraw(double amount)
        {
            Balance -= amount;
            Balance -= 5.00;

        }

        public override string ToString()
        {
            return   "Account "
                    + Number
                    + ", Holder: "
                    + Name
                    + ", Balance: $ "
                    + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
