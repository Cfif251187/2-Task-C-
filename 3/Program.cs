// Задача №15.Задача принимает номер дня недели и выдает выходной это день или нет.
bool weekDay(int num)
{
    if(num == 6 || num == 7) 
    {
        Console.WriteLine("Выходной день");
        return true;
    }
     else 
     { Console.WriteLine(" Не выходной день");
     return false;
     }
}
Console.Write("Введите день недели: ");
int num = Convert.ToInt32(Console.ReadLine());
bool result = weekDay(num);
Console.WriteLine(result);