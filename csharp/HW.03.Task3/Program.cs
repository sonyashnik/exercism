using HW._03.Task3;

Console.WriteLine($"{UniqueItem.Id} unique item(s) created\n");
var ui1 = new UniqueItem();
var ui2 = new UniqueItem();
Console.WriteLine($"{UniqueItem.Id} unique item(s) created\n");
UniqueItem.Id = 100;
Console.WriteLine($"{UniqueItem.Id} unique item(s) created\n");
var ui3 = new UniqueItem();
Console.WriteLine($"{UniqueItem.Id} unique item(s) created\n");