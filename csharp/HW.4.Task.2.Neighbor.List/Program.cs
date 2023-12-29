// See https://aka.ms/new-console-template for more information
using  HW._4.Task._2.Neighbor.List;

IList <Neighbor> floorNeigbors = new List <Neighbor>();
floorNeigbors.Add(new Neighbor("Chandler Bing", 1, "6-66-666"));
floorNeigbors.Add(new Neighbor("Joye Tribbiani", 2, "7-77-777"));
floorNeigbors.Add(new Neighbor("Rachel Green", 3, "2-22-222"));
floorNeigbors.Add(new Neighbor("Ross Geller", 4, "3-33-333"));
floorNeigbors.Add(new Neighbor("Monica Geller", 5, "8-88-888"));
floorNeigbors.Add(new Neighbor("Phoebe Buffay", 6, "1-11-111"));

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

bool neighborIsFound = false;

foreach (Neighbor neighbor in floorNeigbors)
{
    if (neighbor.FlatNumber == flatNumber)
    {
        neighborIsFound = true;
        Console.WriteLine(neighbor);
    }
}

if (!neighborIsFound) Console.WriteLine($"There is no flat number {flatNumber} here!");

