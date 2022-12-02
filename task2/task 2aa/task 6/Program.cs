Console.Write("Введите число a:");
int num = int.Parse(Console.ReadLine()!);

if (num % 2 == 0)
{
    Console.WriteLine("Even number");
} else
{
    Console.WriteLine("Odd number, enter an even number");
}
