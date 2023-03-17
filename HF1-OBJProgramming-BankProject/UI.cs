using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF1_OBJProgramming_BankProject
{
    public class UI
    {
        public static void StartMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*** Welcome to Bankimus Maximus! ***");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n*** What would you like to do? ***");
            Console.WriteLine(" 1. See your balance. \n 2. Withdraw. \n 3. Deposit");
            Console.Write("\n >");
        }
    }
}
