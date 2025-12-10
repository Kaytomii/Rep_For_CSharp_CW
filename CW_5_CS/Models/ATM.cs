namespace CW_5_CS.Models;
using MyExceptions;

public class ATM
{
    private decimal _Balance;

    public ATM(decimal balance)
    {
        _Balance = balance;
    }

    public decimal GetBalance()
    { return _Balance; }

    public void SetBalance(decimal balance)
    { _Balance = balance; }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new InvalidAmountException("Sum must be positive");
        }

        _Balance += amount;
    }

    public decimal WidthDraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new InvalidAmountException("Sum must be postive");
        }

        if (amount > _Balance)
        {
            throw new NotEnoughMoneyInATMException("There is not enough money in the ATM");
        }

        else
        {
            decimal sum = _Balance - amount;
            return sum;
        }
    }

    public void CheckBalance()
    {
        Console.WriteLine($"Your balance is: {GetBalance()}");
    }
}
