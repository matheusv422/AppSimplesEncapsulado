using System;
using System.Globalization;

namespace CadastroDeContaBancaria
{
    class Program
    {
        static void Main(string[] args)
            
        {
            Account ac;
          
            Console.Write("Enter account number: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Enter account holder: ");
            string nome = Console.ReadLine();

            Console.Write("Is there na initial deposit (y/n)? ");
            char answer = char.Parse(Console.ReadLine());

            
            
            
            

            if(answer == 'y')
            {
               
                Console.Write("Enter initial deposit value: ");
                double initDeposit = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                ac = new Account(nome, numero, initDeposit);
            }

            else
            {
                ac = new Account(nome, numero);
               
            }

            Console.WriteLine("Account data:");
            Console.WriteLine(ac);

            Console.Write("Enter a deposit value: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            ac.Deposit(deposito);

            Console.WriteLine("Updated account data:");
            Console.WriteLine(ac);

            Console.Write("Enter a withdraw value: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            ac.Withdraw(saque);

            Console.WriteLine("Updated account data:");
            Console.WriteLine(ac);








        }
    }
}
