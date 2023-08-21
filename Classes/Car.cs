using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Car
    {
        public string make { get; set; }
        public string model { get; set; }
        public int year { get; set; }

        public Car(string mk, string md, int yr) {
            make = mk;
            model = md;
            year = yr;
        }
    }
}
