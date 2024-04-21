class Program 
{
    static void Main(string[] args)
    { 
        Console.Write("Ваше имя: ");
        var name = Console.ReadLine();

        Console.Write("Ваш возраст: ");
        var age = int.Parse(Console.ReadLine());

        Console.Write("Ваша дата рождения: ");
        var birthdate = Console.ReadLine();

        Console.WriteLine("=======================================================================");

        Console.WriteLine($"Вас зовут {name}, ваш возраст - {age}\n" +
                          $"Дата вашего рождения: {birthdate}");
    }
}