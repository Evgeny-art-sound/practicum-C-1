// Показать вторую цифру трёхзначного числа
Console.Write("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());
if (a < 0)
{
    a = a * -1;
}
if (a > 99 && a < 1000)
{
    a = a / 10;
    Console.Write("Вторая цифра трехзначного числа: ");
    Console.WriteLine(a % 10);
}
else
{
    Console.Write("Это не 3х значное число!");
}