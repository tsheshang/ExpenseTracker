Expense[] expenses = new Expense[20];
int count = 0;

void AddExpense (string description, double amount)
{
    expenses[count] = new Expense(description, amount);
    count++;
}

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


