static void Main(string[] args)
{
    byte day = 8;
    while(day > 7 ) 
    {
        Console.Write("Введите день недели от 1 до 7: ");
        day = Convert.ToByte(Console.ReadLine());
    }
    Console.Write("Введите время в 24 формате: ");
    byte dayTime = Convert.ToByte(Console.ReadLine());

    Console.WriteLine(getInformation((Day)(day -= 1), dayTime));
}
private enum Day
{
    понедельник = 0, 
    вторник, 
    среда, 
    четверг, 
    пятница, 
    суббота,
    воскресенье
}
private enum DayTime
{
    утро = 1, 
    обед, 
    вечер,
    ночь
}
static string getInformation(Day day, byte dayTime) 
{
    if (dayTime >= 7 && dayTime <= 12) { return $"Сейчас {day}, {DayTime.утро}"; }
    if (dayTime >= 13 && dayTime <= 18) { return $"Сейчас {day}, {DayTime.обед}"; }
    if (dayTime >= 19 && dayTime <= 23) { return $"Сейчас {day}, {DayTime.вечер}"; }
    if (dayTime >= 25) { return "Неверный формат времени"; }
    return $"Сейчас {day}, {DayTime.ночь}";
}
