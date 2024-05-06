namespace HillelTask3;

class Program
{
    static void Main(string[] args)
    {
        User user1 = new User();
        user1.gender = Gender.Male;

        Console.Write("Enter FirstName: ");
        user1.FirstName = Console.ReadLine();
        Console.Write("Enter LastName: ");
        user1.LastName = Console.ReadLine();
        Console.WriteLine(user1.ToString());

    }
}

