Console.WriteLine("Введите число");
var n = int.Parse(Console.ReadLine());


for (int i = 1; i < n; i++)
{
    if (i * i > n)
    {
        Console.WriteLine(n);
        break;
    }
    Console.WriteLine(i * i);
}