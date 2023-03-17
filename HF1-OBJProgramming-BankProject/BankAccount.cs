using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF1_OBJProgramming_BankProject
{
    public class BankAccount
    {
        public BankAccount(double balance)
        {
            this.balance = balance;
        }
        private double balance; //Instanced variable.

        public void Print()
        {
            CurrentBalance(); //Writeline, what is the current Balance. The text is displayed in Green.
            BackToMainMenu(); //Press any button to go back to Main Menu + ReadKey();
        }

        public void Withdraw()
        {
            CurrentBalance();
            Console.WriteLine(" How much would you like to withdraw?");
            Console.Write(" Withdrawing: ");

            int withdraw;
            if (int.TryParse(Console.ReadLine(), out withdraw) && withdraw > 0 && balance != 0)
            {
                balance -= withdraw;
                CurrentBalance();
            }
            else
            {
                IncorrectInputText();
                int reply;
                if (int.TryParse(Console.ReadLine(), out reply) && reply == 1)
                {
                    Withdraw();
                }
            }
        }

        public void Deposit()
        {
            CurrentBalance();
            Console.WriteLine(" How much would you like to deposit?");
            Console.Write(" Depositing: ");

            int deposit;
            if (int.TryParse(Console.ReadLine(), out deposit) && deposit > 0)
            {
                balance += deposit;
                CurrentBalance();
                BackToMainMenu();
            }
            else
            {
                IncorrectInputText();
                int reply;
                if (int.TryParse(Console.ReadLine(), out reply) && reply == 1)
                {
                    Deposit();
                }
            }
        }


        private void CurrentBalance()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n Current balance: " + balance);
            Console.ForegroundColor = ConsoleColor.White;
        }
        private void BackToMainMenu()
        {
            Console.WriteLine(" Press any button to go back to the Main Menu.");
            Console.ReadKey();
        }
        private void IncorrectInputText()
        {
            Console.Clear();
            Console.WriteLine("\n That wasn't correct... Would you like to try again, or go back to the Main Menu?");
            Console.WriteLine(" 1. Try again. \n 2. Main Menu.");
            Console.Write("\n >");
        }
    }
}
