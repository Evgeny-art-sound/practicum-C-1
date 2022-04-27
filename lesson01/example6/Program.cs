// Дано число из отрезка [10,99] Показать наибольшую цифру числа
Console.Write("Введите число на отрезке от 10 до 99: ");
int a = int.Parse(Console.ReadLine());
if (a >= 10 && a <= 99)
{
    int firstDigit = (a / 10);
    int secondDigit = (a % 10);
    Console.Write("Наибольшая цифра числа: ");
    if (firstDigit > secondDigit)
    {
        Console.WriteLine(firstDigit);
    }
    else
    {
        Console.WriteLine(secondDigit);

    }

}
else
{
    Console.WriteLine("Это число не принадлежит заданному отрезку!");
}
