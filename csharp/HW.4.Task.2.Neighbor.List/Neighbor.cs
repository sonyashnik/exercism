using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._4.Task._2.Neighbor.List
{
    public class Neighbor
    {
        private string _fullName;
        private string _phoneNumber;

        public int FlatNumber { get; set; }

        public Neighbor(string fullName, int flatNumber, string phoneNumber)
        {
            _fullName = fullName;
            FlatNumber = flatNumber;
            _phoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return $"{_fullName}, phone: {_phoneNumber}";
        }
    }
}
