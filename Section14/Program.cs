using Section14.Entities;
using Section14.Services;
using System.Globalization;

Console.WriteLine("Enter contract data");
Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());

Console.Write("Date (dd/MM/yyyy): ");
var date = DateTime.Parse(Console.ReadLine());

Console.Write("Contract value: ");
var totalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Enter number of installments: ");
var months = int.Parse(Console.ReadLine());

var contract = new Contract(number, date, totalValue);
var contractService = new ContractService(new PaypalService());

Console.WriteLine();
Console.WriteLine("INSTALLMENTS:");

contractService.ProcessContract(contract, months);