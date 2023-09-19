namespace Banking.Domain;

public class Account
{
    public Account()
    {
    }

    private decimal _balance = 5000M;

    public void Deposit(decimal amountToDeposit)
    {
        _balance += amountToDeposit;
    }

    public decimal GetBalance()
    {
        return _balance;
    }
}