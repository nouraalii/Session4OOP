using Session4Demo.Abstraction;
using Session4Demo.Mapping;
using Session4Demo.Opeartoe_overloading;
using Session4Demo.Static;

namespace Session4Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Abstraction
            ////4.Abstraction :
            ////abstract : C# keyword (class-method-propereties)
            ////abstract class
            ////abstract metho
            ////abstract properety

            ////2D shape
            ////Shape shape = new Shape(); //Invalid
            //////Note : Can't create object from abstarct class

            ////shape.GetArea();

            //Rectangle rectangle = new Rectangle() { Dem01 =12 ,Dem02 =4};

            ////rectangle.Perimeter = 10;

            //Console.WriteLine(rectangle.Perimeter);

            //Console.WriteLine(rectangle.GetArea());

            //rectangle.Print(); 
            #endregion


            #region Interface Vs Abstraction
            //Interface Vs Abstraction
            //.Net 3.1 Core 
            #endregion


            #region Operator Overloading
            //Operator Overloading

            //+ - * / % < > >= <= != == || && ! | &  ^ >> 

            //+

            //int X = 3 + 4;
            //string Y = "Hello" + "World";

            //Complex number : Real + imag

            //4 + 3 i
            //4 + 3 ت 

            //Complex C01 = new Complex() { Real = 3 , Imag = 4 };
            //Complex C02 = new Complex() { Real = 4 , Imag = 2 };

            //Console.WriteLine(C01);
            //Console.WriteLine(C02);

            //Complex C03 = C01 - C02;

            //Console.WriteLine(C03);

            //++ , --
            //Unary Opertors

            //int X = 12;

            //X++;

            //Console.WriteLine(X);
            //

            //Console.WriteLine(C01);
            //Complex C03=C01++;

            //Console.WriteLine(C03);


            //if (C01 > C02)
            //{
            //    Console.WriteLine("C01 is greater than C02");
            //}
            //else
            //{
            //    Console.WriteLine("C01 is Not greater than C02");
            //} 
            #endregion


            #region User-Defined & Manual Operator
            ////double X =12;
            ////int Y = (int)X;
            //////(int) : Casting Operator


            //Complex C01 = new Complex() { Real = 3 , Imag = 4 };

            ////string S = (string)C01;

            ////String : Convert complex number to string 

            ////Operator overloading
            ////User-Defind Casting operator

            ////int X = (int) C01;

            ////Console.WriteLine(X);

            ////int X = (int)new Complex() { Real = 3, Imag = 7 };

            ////Mapping : Convert from Datatype to Datatype

            //// Code first 
            ////DB first

            ////User[Id,name,email,password,username,phonenumber,cardnumber,expiredate]


            ////UserViewModel
            ////UserDto
            ////[name,email,phonenumber]


            //User user = new User();//From DB

            //UserDto userDto = new UserDto()
            //{
            //    Name=user.Name,
            //    Email=user.Email,
            //    PhoneNumber=user.PhoneNumber,
            //};            

            ////Casting operator

            ////Automapper : Mapping Automatic  
            #endregion


            #region Static
            //static : C# keyword [class - method - properity - constructor - attribute]
            //static class
            //static method
            //static attribute
            //static properity
            //static constructor

            //Utilities U01 = new Utilities();
            //Utilities U02 = new Utilities();
            //Utilities U03 = new Utilities();

            //Console.WriteLine(U01.CnToInch(3));
            //Console.WriteLine(U02.CnToInch(3));
            //Console.WriteLine(U03.CnToInch(3));

            //Console.WriteLine(Utilities.CnToInch(3));
            //Console.WriteLine(Utilities.CnToInch(3));
            //Console.WriteLine(Utilities.CnToInch(3));


            //Console.WriteLine(U01.PI);
            //Console.WriteLine(U02.PI);
            //Console.WriteLine(U03.PI);

            //Console.WriteLine(Utilities.PI);
            //Console.WriteLine(Utilities.PI);
            //Console.WriteLine(Utilities.PI); 
            #endregion


            #region Sealed
            //Sealed : C# keyword [class-method-properity] 
            #endregion

            #region Partial
            ////Partial
            //Employee employee = new Employee();
            //employee. 
            #endregion
        }
    }
}