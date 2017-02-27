using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace triangleApplication
{
    class Triangle
    {

        double Height;
        double Base;


        public void AcceptDetails()
        {
            Height = 16.5;
            Base = 16.5;
        }

        public double GetArea()
        {
            return Height * Base / 2;
        }

        public void Display()
        {
            WriteLine("Base : {0}", Height);
            WriteLine("Height : {0}", Base);
            WriteLine("Area : {0}", GetArea());
            ReadKey();
        }
    }

    class ExecuteSquare
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle();

            t.AcceptDetails();
            t.Display();
            ReadLine();
        }
    }
}

