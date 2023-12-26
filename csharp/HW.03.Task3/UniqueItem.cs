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
                if (value >=0) id = value;
            }
        }
        public UniqueItem()
        {
            id++;
        }
    }
}