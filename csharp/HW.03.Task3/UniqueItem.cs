namespace HW._03.Task3
{
    public class UniqueItem
    {
        static int id = default;
        public static int Id 
        {
            get 
            { 
                return id; 
            }
            set
            {
                id = value;
            }
        }
        public UniqueItem()
        {
            id++;
        }
    }
}