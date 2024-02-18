
int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

Console.WriteLine(weekDay);

if (weekDay == 0)
{
    Console.WriteLine("Itś Sunday!");

}
else if (weekDay == 1)
{
    Console.WriteLine("Itś Monday!");
}
else if (weekDay == 2)
{
    Console.WriteLine("Itś Tuesday!");
}
else if (weekDay == 3)
{
    Console.WriteLine("Itś Wednesday!");
}
else if (weekDay == 4)
{
    Console.WriteLine("Itś Thursday!");
}
else if (weekDay == 5)
{
    Console.WriteLine("Itś Friday!");
}
else if (weekDay == 6)
{
    Console.WriteLine("Itś Saturday!");
}

Console.WriteLine("Have a nice day!");