﻿namespace Equals_GetHashCode_IComparer_Enum_Indexer.Models
{
    public class PersonAgeComparer : IComparer<Person>
    {
        public int Compare(Person? a, Person? b)
        {
            return a.Age.CompareTo(b.Age);
        }

    }
}
