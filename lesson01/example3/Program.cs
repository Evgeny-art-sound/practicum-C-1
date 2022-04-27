// Выяснить: является ли число четным
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
if (a % 2 == 0)
{
    Console.WriteLine("Это четное число!");
}
else
{
    Console.WriteLine("Это не четное число");
}