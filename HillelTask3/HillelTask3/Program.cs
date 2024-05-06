namespace HillelTask3;

class Program
{
    static void Main(string[] args)
    {
        User user1 = new User();
        user1.gender = Gender.Male;
        
        user1.FirstName=Console.ReadLine();
        user1.LastName = Console.ReadLine();


    }
}

