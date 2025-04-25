using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormAssignment3._4._1
{
    public abstract class Beverage
    {
        public double Price { get; set; }
        public string BevName { get; set; }
        public double Sizeoz { get; set; }
        public string PackageType { get; set;  }
        public int TemperatureDegF { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
