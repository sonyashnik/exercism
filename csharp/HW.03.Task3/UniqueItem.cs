namespace HW._03.Task3
{
    public class UniqueItem
    {
        static int _id = default;
        public static int Id {get { return _id;}}
        public UniqueItem()
        {
            _id++;
        }

        public UniqueItem(int offset)
        {
            if (offset < 0) throw new ArgumentOutOfRangeException(nameof(offset));
            else _id = offset;
        }
    }
}