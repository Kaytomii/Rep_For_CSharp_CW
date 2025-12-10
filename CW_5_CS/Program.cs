namespace CW_5_CS;
using MyExceptions;
using Models;
internal class Program
{
    static void Main(string[] args)
    {
        ATM atm = new ATM(5000);

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("===== ATM MENU =====");
            Console.WriteLine("1 - Deposit");
            Console.WriteLine("2 - Withdraw");
            Console.WriteLine("3 - Check Balance");
            Console.WriteLine("4 - Exit");
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid input. Please enter a number 1-4.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter deposit amount: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal deposit))
                    {
                        try
                        {
                            atm.Deposit(deposit);
                            Console.WriteLine("Deposit successful");
                        }

                        catch (InvalidAmountException ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount format.");
                    }
                    break;

                case 2:
                    Console.Write("Enter withdraw amount: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal withdraw))
                    {
                        try
                        {
                            atm.SetBalance(atm.WidthDraw(withdraw));
                            Console.WriteLine("Withdraw successful!");
                        }

                        catch (InvalidAmountException ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }

                        catch (NotEnoughMoneyInATMException ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                    }

                    else
                    {
                        Console.WriteLine("Invalid amount format.");
                    }
                    break;

                case 3:
                    atm.CheckBalance();
                    break;

                case 4:
                    exit = true;
                    Console.WriteLine("Goodbye");
                    break;

                default:
                    Console.WriteLine("Invalid choice зlease enter 1-4");
                    break;
            }
        }
    }
}
