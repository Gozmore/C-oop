using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    internal class Cashier
    {
        public string Cashier_password;
        public string Cashier_username; 

        public long accountBalance;

        public Cashier()
        {
            
            
            accountBalance = 0;
            Cashier_username = "jb";
            Cashier_password = "12345";





        }


        public void  login(string user_input_username , string user_input_password) {

            if (user_input_username == Cashier_username && user_input_password == Cashier_password)
            {
                Console.WriteLine("login succesful");
                bool keepRunning = true;




                while (keepRunning)
                {



                    Console.WriteLine("do you want to withdraw or deposit... input (d) for deposit and (w) for withdrawal");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "d")
                    {
                        Console.WriteLine("How much do you want to deposit ");
                        long userammount_deposit = Convert.ToInt64(Console.ReadLine());
                        deposit(userammount_deposit);


                    }
                    else if (input.ToLower() == "w")
                    {
                        Console.WriteLine("how much do you want to withdraw");

                    }
                    else
                    {
                        Console.WriteLine("invalid input");

                    }


                }



            }
            else {
                Console.WriteLine("user does not exist");
            }

                            }


        public void deposit(long deposit_amount)
        {

            accountBalance = accountBalance + deposit_amount;
            Console.WriteLine($" you deposited {deposit_amount} , new balance is {accountBalance}");


        }

        public void withdrawl(long withdraw_amount)
        {

            accountBalance = accountBalance - withdraw_amount;
            Console.WriteLine($" you withdrew {withdraw_amount} , new balance is {accountBalance}");

        }
        public void Change_username()
        {
            this.Cashier_username = "cash123";
        }





    }

}
        

