using HF1_OBJProgramming_BankProject;
using System.Data;

bool run = true;
BankAccount balance = new BankAccount(0);

//Main! 
do
{
    Console.Clear();
    UI.StartMenu();
    int.TryParse(Console.ReadLine(), out int choice);

    switch (choice)
    {
        case 1: //Print balance
            balance.Print();
            break;

        case 2: //Withdraw from bank account
            balance.Withdraw();
            break;

        case 3://Deposit to bank account
            balance.Deposit();
            break;

        default:
            break;
    }
} while (run == true);

