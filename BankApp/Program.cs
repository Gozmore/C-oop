using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cashier new_cashier = new Cashier();
            Console.WriteLine("pleas enter your user_name");
           string user_input = Console.ReadLine();
            Console.WriteLine("please enter user password ");
            string user_password = Console.ReadLine();

            new_cashier.login(user_input, user_password);   











        }
    }
}
