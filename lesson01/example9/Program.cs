// Найти третью цифру числа или сообщить, что её нет
Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine());
if (x < 0)
{
    x = x * -1;
}
if (x < 100)

{
    Console.WriteLine("Третьей цифры в числе нет!");

}
else
{
    while (x > 999)
    {
        x = x / 10;
    }
    Console.WriteLine($"Третья цифра введенного числа: {x % 10}");
}