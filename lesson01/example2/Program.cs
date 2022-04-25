Console.Write("Введите номер дня недели - ");
int a = int.Parse(Console.ReadLine());
if (a <= 7 && a > 0)
{
    if (a == 1)
    {
        Console.Write("Сегодня понедельник ");
    }
    if (a == 2)
    {
        Console.Write("Сегодня вторник");
    }
    if (a == 3)
    {
        Console.Write("Сегодня среда");
    }
    if (a==4)
    {
        Console.Write("Сегодня четверг");
    }
    if (a==5)
    {
        Console.Write("Сегодня пятница");
    }
    if (a==6)
    {
        Console.Write("Сегодня суббота");
    }
    if (a==7)
    {
        Console.Write("Сегодня воскресенье");
    }
}
else
    {
        Console.Write("Такого дня недели не существует!");
    }
