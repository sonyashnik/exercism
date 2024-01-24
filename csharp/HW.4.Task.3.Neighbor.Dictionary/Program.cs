// See https://aka.ms/new-console-template for more information
using HW._4.Task._2.Neighbor.List;
using HW._4.Task._3.Neighbor.Dictionary;

var floorNeigbors = new Dictionary<int, Neighbor>();

floorNeigbors.AddByKey(new Neighbor("Chandler Bing", 1, "6-66-666"));
floorNeigbors.AddByKey(new Neighbor("Joye Tribbiani", 2, "7-77-777"));
floorNeigbors.AddByKey(new Neighbor("Rachel Green", 3, "2-22-222"));
floorNeigbors.AddByKey(new Neighbor("Ross Geller", 4, "3-33-333"));
floorNeigbors.AddByKey(new Neighbor("Monica Geller", 5, "8-88-888"));
floorNeigbors.AddByKey(new Neighbor("Phoebe Buffay", 6, "1-11-111"));

bool flatNumberIsValid = false;
int flatNumber = 0;

while (!flatNumberIsValid)
{
    Console.WriteLine("Enter a flat number: ");
    if (int.TryParse(Console.ReadLine(), out flatNumber))
    {
        flatNumberIsValid = true;
    }
}

if (floorNeigbors.TryGetValue(flatNumber, out Neighbor neighborSearch))
{
    Console.WriteLine(neighborSearch);
}
else
{
    Console.WriteLine($"There is no flat number {flatNumber} here!");
}
