Expense[] expenses = new Expense[20];
int count = 0;

while (true)
{
    Console.WriteLine("\nExpense Tracker");
    Console.WriteLine("1. Add Expense");
    Console.WriteLine("2. View Expenses");
    Console.WriteLine("3. show total");
    Console.WriteLine("4. Exit");

    Console.Write("Choose option: ");
    string choice = Console.ReadLine();

    if (choice == "1")
    {
        Console.Write("Enter description: ");
        string description = Console.ReadLine();

        Console.Write("Enter amount: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        AddExpense(description, amount);
    }
    else if (choice == "2")
    {
        ViewExpenses();
    }
    else if (choice == "3")
    {
        ShowTotal();  
    }
    else if (choice == "4")
    {
        break;
    }
}

void AddExpense(string description, double amount)
{
    expenses[count] = new Expense(description, amount);
    count++;
}

void ViewExpenses()
{
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"{i + 1}. {expenses[i].Description} - Rs{expenses[i].Amount}");
    }
}

void ShowTotal()
{
    double total = 0;

    for (int i = 0; i < count; i++)
    {
        total += expenses[i].Amount;
    }

    Console.WriteLine($"Total Expenses: ${total}");
}

class Expense
{
    public string Description { get; set; }
    public double Amount { get; set; }

    public Expense(string description, double amount)
    {
        Description = description;
        Amount = amount;
    }
}