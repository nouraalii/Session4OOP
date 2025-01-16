using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4Demo.Abstraction
{
    //Concert class : fully implemented class
    internal class Rectangle : Shape /*Implemenet and inheirt from shape*/
    {
        public override double Perimeter 
        {
            get 
            {
                return (Dem01 + Dem02) * 2;
            }
        }

        public override double GetArea()
        {
            return Dem01 * Dem02;
        }


    }
}
