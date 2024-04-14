using System;
using ConsoleApp3;

namespace MyApp // Note: actual namespace depends on the project name.
{
	
	internal class Program
	{
		static void Main(string[] args)
		{
			static void ChangeByReference(Product itemRef)
			{
				// Change the address that is stored in the itemRef parameter.
				itemRef = new Product("Stapler", 12345);
			}

				// Declare an instance of Product and display its initial values.
				Product item = new Product("Fasteners", 54321);
				System.Console.WriteLine("Original values in Main.  Name: {0}, ID: {1}\n",
					item.ItemName, item.ItemID);

				// Pass the product instance to ChangeByReference.
				ChangeByReference(item);
				System.Console.WriteLine("Calling method.  Name: {0}, ID: {1}\n",
					item.ItemName, item.ItemID);

			Console.WriteLine("Hello World!");
		}
	}
}