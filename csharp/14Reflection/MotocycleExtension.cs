using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14Reflection
{
	static class MotocycleExtension
	{
		public static void TakeWheelie(this Motorcycle moto, int acceleration)
		{
			moto.Acceleration = acceleration;
			moto.Move(10);
		}
	}
}
