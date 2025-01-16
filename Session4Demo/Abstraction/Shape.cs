using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4Demo.Abstraction
{
    //Abstract Class : partial class [not fully impelemnted class]
    //Concert Class : Fully Impelemented Class

    internal abstract class Shape
    {
        public double Dem01 { get; set; }

        public double Dem02 { get; set; }

        //Abstract Method : Like virtual method without implementation
        public abstract double GetArea();

        //Make this method abstract


        //Abstarct Properity : Like virtual properity without implementation

        public abstract double Perimeter { get; }

        public void Print()
        {
            Console.WriteLine("I am shape");
        }
    }
}
