namespace Transactions;

public class Balances
{

    public decimal balance {get; set;}

    public event operation creditOperation;

    public event operation debitOperation;

    public void credit (decimal amount) {
        balance += amount;
        creditOperation();
    }

    public void debit (decimal amount) {
        balance -= amount;
        debitOperation();
    }

}
