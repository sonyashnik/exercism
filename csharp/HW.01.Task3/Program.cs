using System.Diagnostics;

static void FillRandom(Int64[] array)
{
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {

        array[i] = random.Next(0, 1000);
    }
}

static void MyReverseMethod(Int64[] array1, Int64[] array2)
{

    int j = 0;
    for (int i = array1.Length - 1; i >= 0; i--)
    {
        array2[j] = array1[i];
        j++;
    }
}
const int dim = 100000000;
Int64[] arr1 = new Int64[dim];
Int64[] arr2 = new Int64[dim];
Int64[] arr3 = new Int64[dim];
arr3.CopyTo(arr1, 0);
var stopWatch = new Stopwatch();
FillRandom(arr1);
stopWatch.Start();
MyReverseMethod(arr1, arr2);
stopWatch.Stop();
TimeSpan ts1 = stopWatch.Elapsed;
string elapsedTime1 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
    ts1.Hours, ts1.Minutes, ts1.Seconds,
    ts1.Milliseconds / 10);
Console.WriteLine("RunTime of MyReverseMethod = " + elapsedTime1);

stopWatch.Start();
Array.Reverse(arr3);
stopWatch.Stop();
TimeSpan ts2 = stopWatch.Elapsed;
string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
    ts2.Hours, ts2.Minutes, ts2.Seconds,
    ts2.Milliseconds / 10);
Console.WriteLine("RunTime of Array.Reverse = " + elapsedTime2);

