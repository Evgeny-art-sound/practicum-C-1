// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.Write("Введите делимое: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите делитель: ");
int b = int.Parse(Console.ReadLine());
if (a % b == 0)
{
    Console.WriteLine("Числа кратны ");
}
else
{
    Console.WriteLine("Числа не кратны ");
}