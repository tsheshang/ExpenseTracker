
class Expense
{
    public string Description { get; set; }
    public double Amount { get; set; }

    public Expense (string description, double amount)
    {
        Description = description;
        Amount = amount;
    }
}


