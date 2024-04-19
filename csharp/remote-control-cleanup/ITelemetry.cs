using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlCleanup
{
	public interface ITelemetry
	{
		void Calibrate();
		bool SelfTest();
		void ShowSponsor(string sponsorName);
		void SetSpeed(decimal amount, string unitsString);
	}
}
