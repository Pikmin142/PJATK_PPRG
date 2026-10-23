Console.WriteLine("Podaj wysokość choinki od 2 do 10");
int wysokosc = int.Parse(Console.ReadLine()!);
for (int w = 1; w <= wysokosc; w ++)
{
    for (int s = 1; s <= wysokosc - w; s++)
    {
        Console.Write(" ");
    }

    for (int k = 1; k <= 2*w-1 ; k ++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

for (int s = 1; s <= wysokosc - 1; s++)
{
    Console.Write(" ");
}
for (int w = 1; w < 2; w++)
{
    Console.WriteLine("*");
}
