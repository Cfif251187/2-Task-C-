// Задача 10: Программа принимает на вход трехзначное число и на выходе показывает вторую цифру.

Console.Write("Ведите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number > 1000)

{
    Console.WriteLine("Вы ввели неверное число. Повторите попытку");
    return;
}

int hundreds = number / 100;
int decade = number / 10;
int secondNum = decade - hundreds * 10;
Console.WriteLine($"Второе число {secondNum}");