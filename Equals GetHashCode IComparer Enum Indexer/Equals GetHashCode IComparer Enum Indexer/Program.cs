using Equals_GetHashCode_IComparer_Enum_Indexer.Enums;
using Equals_GetHashCode_IComparer_Enum_Indexer.Models;

namespace Equals_GetHashCode_IComparer_Enum_Indexer
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //Person[] people = new Person[]
            //{
            //new Person("Messi", "Leo", 37),
            //new Person("Nihat", "Tagi", 25),
            //new Person("Akif", "Tagiyev", 35)
            //};

            //Array.Sort(people,new PersonAgeComparer());
            //foreach (Person person in people)
            //{
            //    Console.WriteLine(person);
            //}
            #endregion

            #region task2
            //TaskClass task1 = new TaskClass("title1",TaskStatuss.Cancelled);
            //TaskClass task2 = new TaskClass("title1",TaskStatuss.InProgress);
            //TaskClass task3 = new TaskClass("title1",TaskStatuss.NotStarted);
            //TaskClass[] tasks = { task1, task2, task3 };

            //PrintTasks(tasks)
            #endregion

            #region task3
            var strings = new SimpleStringCollection(3);
            strings[0] = "Messi";
            strings[1] = "Neymaz";
            strings[2] = "Suarez";

            Console.WriteLine(strings[0]);

            #endregion


        }
        public static void PrintTasks(TaskClass[] tasks)
        {
            foreach (var task in tasks)
            {
                Console.WriteLine($"Title: {task.Title}, Status: {task.Status}");
            }
        }
    }
}
