//  Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите цифру от 1 до 7 включительно");
int number = int.Parse(Console.ReadLine());
    if (number == 1)
    {
        Console.WriteLine("Сегодня понедельник");
    }
        if (number == 2)
    {
        Console.WriteLine("Сегодня вторник");
    }
        if (number == 3)
    {
        Console.WriteLine("Сегодня среда");
    }
        if (number == 4)
    {
        Console.WriteLine("Сегодня четверг");
    }
        if (number == 5)
    {
        Console.WriteLine("Сегодня пятница");
    }
        if (number == 6)
    {
        Console.WriteLine("Сегодня суббота");
    }
        if (number == 7)
    {
        Console.WriteLine("Сегодня воскресенье");
    }
else if (number < 1 )
{
    Console.WriteLine("Введена неверная цифра");
}
else if (number > 7 )
{
    Console.WriteLine("Введена неверная цифра");
}