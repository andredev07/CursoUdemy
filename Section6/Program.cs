using Section6;

List<Employeer> list = new List<Employeer>();

Console.Write("How many employees will be registred? ");
int n = int.Parse(Console.ReadLine());


for (int i = 0; i < n; i++)
{
    Console.WriteLine("Employee #" + (i + 1) + ";");
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Salary: ");
    double salary = double.Parse(Console.ReadLine());

    list.Add(new Employeer(id, name, salary));
}

Console.Write("Enter the employee id that will have salary increase: ");
double idAttempt = double.Parse(Console.ReadLine());
var attempt = list.FirstOrDefault(employeer => employeer.Id == idAttempt);


if (attempt != null)
{
    Console.Write("Enter the percentage: ");
    double percentage = double.Parse(Console.ReadLine());
    attempt.IncreaseSalary(percentage);
}
else
    Console.WriteLine("This Id does not exist!");

Console.WriteLine("Update list of employees:");
foreach(Employeer obj in list)
{
    Console.Write(obj.Id + ", ");
    Console.Write(obj.Name+ ", ");
    Console.Write(obj.Salary);
}

