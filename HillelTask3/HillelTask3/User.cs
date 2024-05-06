using System;
using System.Collections.Generic;

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

        public override string ToString()
        {
            string age_str = (this.Age < 10) ? ". I am a baby." : ". I am " + this.Age + " years old.";
            //return "Created user: " + this.FirstName + " " + this.LastName + ", " + this.Age + " years old. Gender: " + this.gender.ToString();
            return "Hi, my name is " + this.FirstName + " and last name is " + this.LastName + age_str + " I am " + this.gender;
        }
    }
}

