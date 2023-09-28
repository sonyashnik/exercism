// See https://aka.ms/new-console-template for more information
namespace TestApp
{
    class MyProgramm
    {
        static void Main()
        {
            int[] myArray = new int[6];
            Console.WriteLine("Enter elements of myArray");
            for (int i = 0; i < 6; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("See the elements of myArray");
            for (int i = 0; i < myArray.Length; i++) { Console.WriteLine($"myarray[{i}] = {myArray[i]}"); }

            myArray[2] *= 10;
            Console.WriteLine("See new values of elements in myArray");
            for (int i = 0; i < myArray.Length; i++) { Console.WriteLine($"myarray[{i}] = {myArray[i]}"); }

        }
    }
}

