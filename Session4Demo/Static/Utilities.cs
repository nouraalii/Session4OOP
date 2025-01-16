using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4Demo.Static
{
    internal static class Utilities
    {
        //public int X { get; set; }
        //public int Y { get; set; }

        private static double Pi = 3.14;

        static Utilities() 
        {
            Pi = 3.14;
        }

        public static double CnToInch(double cm)
        {
            return cm / 2.24;
        }

        public static double PI
        {
            get
            {
                return Pi;
            }
        }

    }
}
