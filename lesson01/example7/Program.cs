// Удалить вторую цифру трёхзначного числа
Console.Write("Введите трехзначное число: ");
int x = int.Parse(Console.ReadLine());
if (x < 0)
{
    x = x * -1;
}
if (x > 99 && x < 1000)
{
    int a = (x / 100);
    int b = (x % 100 / 10);
    int c = (x % 10);
    Console.WriteLine($"Число без второй цифры: {a}{c}");
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число!");
}