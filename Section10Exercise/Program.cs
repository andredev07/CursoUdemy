using Section10Exercise.Entities;
using System.Globalization;

Console.Write("Enther the number of products: ");
int n = int.Parse(Console.ReadLine());


for (int i = 1; i <= n; i++)
{
    Console.WriteLine("Common, used or imported (c/u/i)? ");
    char option = char.Parse(Console.ReadLine());

    if (option == 'c')
    {
        Console.Write("Name: ");
        string nameProduct = Console.ReadLine();

        Console.Write("Price: ");
        double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        var product = new Product(nameProduct, priceProduct);
    }
    else if (option == 'u')
    {
        Console.Write("Name: ");
        string nameUsedProduct = Console.ReadLine();

        Console.Write("Price: ");
        double priceUsedProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Manufacture date (dd/mm/yyyy); ");
        DateTime dateUsedProduct = DateTime.Parse(Console.ReadLine());

        var usedProduct = new UsedProduct(nameUsedProduct, priceUsedProduct, dateUsedProduct);
    }
    else if (option == 'i')
    {
        Console.Write("Name: ");
        string nameImportedProduct = Console.ReadLine();

        Console.Write("Price: ");
        double priceImportedProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Customs Fee: ");
        double customsFeeImportedProduct = double.Parse(Console.ReadLine());

        var importedProduct = new ImportedProduct(nameImportedProduct, priceImportedProduct, customsFeeImportedProduct);
    }
}

Console.WriteLine("");
Console.WriteLine("PRICE TAGS:");
Console.WriteLine();