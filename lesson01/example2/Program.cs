// По заданному номеру дня недели вывести его название
Console.Write("Введите номер дня недели - ");
int a = int.Parse(Console.ReadLine());
if (a <= 7 && a > 0)
{
    if (a == 1)
    {
        Console.WriteLine("Сегодня понедельник ");
    }
    if (a == 2)
    {
        Console.WriteLine("Сегодня вторник");
    }
    if (a == 3)
    {
        Console.WriteLine("Сегодня среда");
    }
    if (a==4)
    {
        Console.WriteLine("Сегодня четверг");
    }
    if (a==5)
    {
        Console.WriteLine("Сегодня пятница");
    }
    if (a==6)
    {
        Console.WriteLine("Сегодня суббота");
    }
    if (a==7)
    {
        Console.WriteLine("Сегодня воскресенье");
    }
}
else
    {
        Console.Write("Такого дня недели не существует!");
    }
