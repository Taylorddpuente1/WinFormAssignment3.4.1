using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormAssignment3._4._1
{
    public enum Roast { light, medium, dark }
    public class Coffee : Beverage
    {
        public bool IsDecaf { get; set; }
            public string Variety { get; set; }
        public Roast Roast { get; set; }

    }
}
