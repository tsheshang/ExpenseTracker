Expense[] expenses = new Expense[20];
int count = 0;

void AddExpense (string description, double amount)
{
    expenses[count] = new Expense(description, amount);
    count++;
}
void ViewExpenses ()
{
     for  (int i=0; i<count; i++) 
{
     Console.WriteLine($"{i+1}. {expenses[i].Description} - ${expenses[i].Amount}");
      }
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

void ViewExpenses()
{
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"{i + 1}. {expenses[i].Description} - ${expenses[i].Amount}");
    }
}
