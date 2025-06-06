﻿namespace Equals_GetHashCode_IComparer_Enum_Indexer.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name: {Name},Surname: {Surname},Age: {Age}";
        }


    }
}
