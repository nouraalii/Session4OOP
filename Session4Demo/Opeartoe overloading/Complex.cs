using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4Demo.Opeartoe_overloading
{
    internal class Complex
    {
        public int Real { get; set; }

        public int Imag { get; set; }


        //Operator Overloading
        //+
        //Must be : pubplic - static
        //Binary: + - * / %

        public static Complex operator +(Complex left , Complex right)
        {
            return new Complex()
            {
                Real = left?.Real ?? 0 + right?.Real ?? 0,
                Imag = left?.Imag ?? 0 + right?.Imag ?? 0
            };
        }

        //++ --
        public static Complex operator ++(Complex complex)
        {
            if (complex is not null) 
            {
                complex.Real++;
                return complex;
            }
            return new Complex();
        }

        public static Complex operator --(Complex complex)
        {
            if (complex is not null)
            {
                complex.Real--;
                return complex;
            }
            return new Complex();
        }

        public static Complex operator -(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = left?.Real ?? 0 - right?.Real ?? 0,
                Imag = left?.Imag ?? 0 - right?.Imag ?? 0 
            };
        }

        public override string ToString()
        {
            return $"{Real} + {Imag} i";
        }


        //comparsion operator Binary : < > <= != ==
        //Must Be Boolean 
        public static bool operator >(Complex left , Complex right)
        {
            if (left.Real == right.Real)
            {
                return left.Imag > right.Imag;
            }
            return left.Real > right.Real;
        }

        public static bool operator <(Complex left, Complex right)
        {
            if (left.Real == right.Real)
            {
                return left.Imag < right.Imag;
            }
            return left.Real < right.Real;
        }

        public static bool operator ==(Complex left, Complex right)
        {
            return left.Real == right.Real && left.Imag == right.Imag;
        }

        public static bool operator !=(Complex left, Complex right)
        {
            return left.Real != right.Real || left.Imag != right.Imag;
        }

        //User-Defind Casting operator
        //Complex String
        //Function public - static

        //Implicit-Exolicit
        public static explicit operator string(Complex complex)
        {
            return complex.ToString();
        }

        public static implicit operator int(Complex complex)
        {
            return complex.Real;
        }
    }
}
