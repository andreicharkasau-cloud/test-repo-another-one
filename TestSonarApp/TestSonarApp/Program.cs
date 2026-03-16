internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Add the description of your person:");
        Person person = new Person();

        person.Id = Convert.ToInt32(Console.ReadLine());
        person.Name = Console.ReadLine();
        person.Age = Convert.ToInt32(Console.ReadLine());

        GetInfoAboutPerson(person);

        Console.ReadKey();
    }

    public static void GetInfoAboutPerson(Person person)
    {
        Console.WriteLine($"{person.Id}. {person.Name}, {person.Age}");
    }
}