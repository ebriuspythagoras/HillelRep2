namespace HillelTask3;

class Program
{
    static void Main(string[] args)
    {
        User user1 = new User(5);
        user1.gender = Gender.Male;

        Console.Write("Enter FirstName: ");
        user1.FirstName = Console.ReadLine();
        Console.Write("Enter LastName: ");
        user1.LastName = Console.ReadLine();
        Console.Write("Enter Gender (0 - Male, 1 - Female, something else - non binary): ");
        byte g = Convert.ToByte(Console.ReadLine());
        switch (g)
        {
            case 0: user1.gender = Gender.Male; break;
            case 1: user1.gender = Gender.Female; break;
            default: user1.gender = Gender.Unknown; break;

        }
        Console.WriteLine(user1.ToString());

    }
}

