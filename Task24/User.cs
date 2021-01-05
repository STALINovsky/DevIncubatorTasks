using System;
using System.Collections.Generic;
using System.Text;

namespace Task24
{
    /// <summary>
    /// Describes table row user
    /// </summary>
    class User
    {
        public User(int id, string firstName, string surName, int age)
        {
            Id = id;
            FirstName = firstName;
            SurName = surName;
            Age = age;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Id,2} {FirstName ?? "Null",13} {SurName ?? "Null",9} {Age,3}";
        }
    }
}
