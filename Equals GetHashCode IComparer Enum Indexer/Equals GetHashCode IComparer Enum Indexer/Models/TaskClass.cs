using Equals_GetHashCode_IComparer_Enum_Indexer.Enums;

namespace Equals_GetHashCode_IComparer_Enum_Indexer.Models
{
    public class TaskClass
    {
        public string Title { get; set; }
        public TaskStatuss Status { get; set; }

        public TaskClass(string title, TaskStatuss status)
        {
            Title = title;
            Status = status;
        }

        public override string ToString()
        {
            return $"Title: {Title},Status:{Status}";
        }
    }
}
