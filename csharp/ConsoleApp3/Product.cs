using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	internal class Product
	{
		public Product(string name, int newID)
		{
			ItemName = name;
			ItemID = newID;
		}

		public string ItemName { get; set; }
		public int ItemID { get; set; }
	}
}
