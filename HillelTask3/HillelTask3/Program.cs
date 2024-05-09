using System.Text.RegularExpressions;

namespace HillelTask3;

class Program
{
    static void Main(string[] args)
    {
        User user1 = new User(44);
        user1.gender = Gender.Male;

        user1.FirstName = CheckName("Enter FirstName: ");
        user1.LastName = CheckName("Enter LastName: ");
        switch (CheckGender("Enter Gender (0 - Male, 1 - Female, other - non binary): "))
        {
            case "0": user1.gender = Gender.Male; break;
            case "1": user1.gender = Gender.Female; break;
            default: user1.gender = Gender.Unknown; break;

        }
        Console.WriteLine(user1.ToString());

    }

    public static string CheckName(string message)
    {
        Regex rg = new Regex("^\\p{Lu}\\p{Ll}*(?:-\\p{Lu}\\p{Ll}*)?$");
        MatchCollection match_str;
        string str;
        do
        {
            Console.Write(message);
            str = Console.ReadLine();
            match_str = rg.Matches(str);
        } while (match_str.Count == 0);
        return str;
    }

    public static string CheckGender(string message)
    {
        Regex rg = new Regex("^\\d+$");
        MatchCollection match_str;
        string str;
        do
        {
            Console.Write(message);
            str = Console.ReadLine();
            match_str = rg.Matches(str);
        } while (match_str.Count == 0);
        return str;
    }
}

