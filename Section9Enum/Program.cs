using Section9Enum.Entities;
using Section9Enum.Entities.Enums;
using System.Globalization;

Console.Write("Enter department's name: ");
string dept = Console.ReadLine();

Console.WriteLine("Enter worker data:");
Console.Write("Name: ");
string name = Console.ReadLine();

Console.Write("Level (Junior/MidLevel/Senior): ");
WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

Console.Write("Base salary: ");
double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Department department = new Department(dept);
Worker worker = new Worker(name, level, baseSalary, department);

Console.Write("How many contracts to this worker?");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Enter #{i} contract data:");
    Console.Write("Date (DD/MM/YYYY): ");
    DateTime date = DateTime.Parse(Console.ReadLine());

    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.Write("Duration (hours): ");
    int hour = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    HourContract contract = new HourContract(date, valuePerHour, hour);
    worker.AddContract(contract);
}

Console.WriteLine("");
Console.Write("Enter month and year to calculate income (MM/YYYY): ");
string dateIncome = Console.ReadLine();

int year = int.Parse(dateIncome.Substring(3));
int month = int.Parse(dateIncome.Substring(0, 2)); 

Console.WriteLine("Name: " + worker.Name);
Console.WriteLine("Department: " + worker.Department.Name);
Console.WriteLine("Income for " + dateIncome + ": " + worker.Income(year, month).ToString("C", CultureInfo.InvariantCulture));

