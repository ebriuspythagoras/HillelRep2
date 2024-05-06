using System;
namespace HillelTask3
{
    public class User
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public readonly byte Age;

        public Gender gender { get; set; }

        public User()
        {
            Age = 0;
        }

        public User(byte age)
        {
            Age = age;
        }
    }
}

