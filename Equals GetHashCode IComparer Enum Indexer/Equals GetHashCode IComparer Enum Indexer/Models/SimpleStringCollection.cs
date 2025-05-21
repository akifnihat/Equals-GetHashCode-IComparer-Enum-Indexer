
namespace Equals_GetHashCode_IComparer_Enum_Indexer.Models
{
    internal class SimpleStringCollection
    {
        private string[] _items;

        public SimpleStringCollection(int size)
        {
            _items = new string[size];
        }

        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= _items.Length)
                    throw new IndexOutOfRangeException("Duzgun index daxil edin");

                return _items[index];
            }
            set
            {
                if (index < 0 || index >= _items.Length)
                    throw new IndexOutOfRangeException("Duzgun index daxil edin");

                _items[index] = value;
            }
        }
    }
}
