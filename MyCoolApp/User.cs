using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCoolApp
{
    sealed class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; private set; }
        public Gender Gender { get; set; }

        public User()
        {

        }

        public User(int age)
        {
            Age = age;
        }

        public override string ToString()
        {
            var ageDescription = Age >= 10 ? $"I am {Age} years old" : "I am a baby";
            return $"Hi, my name is {FirstName} and last name {LastName}. {ageDescription}. I am {Gender}.";
        }

    }

    public enum Gender
    {
        Male,
        Female,
        Email
    }
}
