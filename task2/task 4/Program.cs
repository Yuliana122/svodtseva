Console.Write("Введите число a:");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число b:");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите число c:");
int c = int.Parse(Console.ReadLine()!);
if (a > b)
{
    if (a > c)
    {
        Console.WriteLine("Max Number: " + a);
    } else
    {
       Console.WriteLine("Max Number: " + c); 
    }
} else if (b > c)
{
Console.WriteLine("Max Number: " + b); 
} else
{
    Console.WriteLine("Max Number: " + c); 
}
