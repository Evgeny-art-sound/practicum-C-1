Console.Write("Введите число - ");
int a = int.Parse(Console.ReadLine());
int b = 1;
Console.WriteLine("Список всех четных чисел от 1 до введенного числа: ");
while (b <= a)
{
    if (b % 2 == 0)
    {
        Console.Write( b); 
        Console.Write (", ");
    }
    b++;
}