// Задача 13: Программа выводит третью цифру числа.
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("Третьего числа нет. Повторите попытку");
    return;
}

if (number > 1000)
{
  int thirdNumber = number / 10 % 10;
  Console.WriteLine($"Третье число {thirdNumber}");
  return;
}

int thirdNum = number % 10;
Console.WriteLine($"Третье число {thirdNum}");