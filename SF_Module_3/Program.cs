using System;
using System.Xml.Linq;

enum DaysOfWeek : int
{
    Tuesday,
    Monday,
    Wednesday,
    Friday
}

class MainClass
{
    public static void Main(string[] args)
    {
        DaysOfWeek day = (DaysOfWeek) int.Parse(Console.ReadLine());
        Console.WriteLine(day);
    }
}