using Section10HerancaAbstract.Entities;

List<Person> list = new List<Person>();

Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Tax payer #{i} data:");
    Console.Write("Individual or company (i/c)?" );
    char type = char.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Anual Income: ");
    double anualIncome = double.Parse(Console.ReadLine());

    if (type == 'i')
    {
        Console.Write("Health expenditures: ");
        double? healthExpense = double.Parse(Console.ReadLine());

        list.Add(new PhysicalPerson(healthExpense, name, anualIncome));
    }
    else
    {
        Console.Write("Number of employees: ");
        int numberOfEmployees = int.Parse(Console.ReadLine());
        list.Add(new LegalPerson(numberOfEmployees, name, anualIncome));
    }
}

Console.WriteLine();
Console.WriteLine("TAXES PAID:");

foreach (Person person in list)
{
    Console.WriteLine(person.Name + ", " + person.CalculateTax().ToString("C"));
}

Console.WriteLine();
Console.WriteLine("TOTAL PAXES");

double sum = 0;
foreach (Person person in list)
{
    sum += person.CalculateTax();
    Console.WriteLine(sum.ToString("C"));
}


