namespace Equals_GetHashCode_IComparer_Enum_Indexer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[]
            {
            new Person("Messi", "Leo", 37),
            new Person("Nihat", "Tagi", 25),
            new Person("Akif", "Tagiyev", 35)
            };

            Array.Sort(people,new PersonAgeComparer());
            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
