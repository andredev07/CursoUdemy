string[] vect = Console.ReadLine().Split(' ');
int line = int.Parse(vect[0]);
int column = int.Parse(vect[1]);

int[,] matz = new int[line, column];    

for (int i = 0; i < line; i++)
{
    string[] values = Console.ReadLine().Split(' ');

    for (int c = 0; c < column; c++)
    {
        matz[i, c] = int.Parse(values[c]);
    }
}

foreach (int i in matz)
{
    Console.WriteLine(i);
}
