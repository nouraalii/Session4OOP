using Session4Assignment.FirstProject;
using Session4Assignment.SecondProject;
using Session4Assignment.ThirdProject;

namespace Session4Assignment
{
    internal class Program
    {
        #region First Project
        ////First Project
        //static Point3D ReadPointFromUser()
        //{
        //    Console.Write("Enter X: ");
        //    int x = int.Parse(Console.ReadLine());

        //    Console.Write("Enter Y: ");
        //    int y = int.Parse(Console.ReadLine());

        //    Console.Write("Enter Z: ");
        //    int z = int.Parse(Console.ReadLine());

        //    return new Point3D(x, y, z);
        //}
        #endregion

        static void Main(string[] args)
        {
            #region First Project
            ////First project
            //Console.WriteLine("Enter Point1");
            //Point3D P01 = ReadPointFromUser();

            //Console.WriteLine("Enter Point2");
            //Point3D P02 = ReadPointFromUser();

            //Console.WriteLine($"P1: {P01}");
            //Console.WriteLine($"P2: {P02}");

            //if (P01 == P02)
            //{
            //    Console.WriteLine("P01 is equal to P02");
            //}
            //else
            //{
            //    Console.WriteLine("Not equal");
            //}

            //Point3D P1Clone = (Point3D)P01.Clone();

            //Point3D[] points = new Point3D[]
            //{
            //new Point3D(3, 2, 1),
            //new Point3D(1, 4, 3),
            //new Point3D(2, 3, 2),
            //new Point3D(1, 2, 1)
            //};

            //Array.Sort(points);

            //foreach (var item in points)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Second Project
            ////Second Project
            //double num1 = 10;
            //double num2 = 5;

            //Console.WriteLine("Add: " + Maths.Add(num1, num2));
            //Console.WriteLine("Subtract: " + Maths.Subtract(num1, num2));
            //Console.WriteLine("Multiply: " + Maths.Multiply(num1, num2));
            //Console.WriteLine("Divide: " + Maths.Divide(num1, num2)); 
            #endregion

            #region Third Project
            ////Third Project
            //Duration D1 = new Duration(1, 10, 15);
            //Console.WriteLine(D1.ToString());  

            //Duration D2 = new Duration(3600);
            //Console.WriteLine(D2.ToString());  

            //Duration D3 = new Duration(7800);
            //Console.WriteLine(D3.ToString()); 

            //Duration D4 = new Duration(666);
            //Console.WriteLine(D4.ToString()); 
            #endregion

        }
    }
}
