using System;
using System.Collections.Generic;
using System.Text;

namespace prjSecondApplication
{

    interface INormalCalc
    {
        //interface are Public and Abstract by defualt
        int Add(int x, int y);
        int Sub(int x, int y);
    }

    class Calculator : INormalCalc, ISciCal
    {
        int INormalCalc.Add(int x, int y)
        {
            return x + y;
        }

        int INormalCalc.Sub(int x, int y)
        {
            return x - y;
        }

        int ISciCal.Add(int x, int y)
        {
            return x + y;
        }

        int ISciCal.Mul(int x, int y)
        {
            return x * y;
        }
    }
    class InterfaceEg
    {
        static void Main()
        {
            INormalCalc ncal = new Calculator();
            Console.WriteLine("Addition of Normal Calculator:{0}", ncal.Add(5,7));
            Console.WriteLine("Subtraction of Normal Calculator:{0}", ncal.Sub(90,7));
            ISciCal scical = new Calculator();
            Console.WriteLine("Addition of Scientific Calculator:{0}", scical.Add(5, 7));
            Console.WriteLine("Multiplication of Scientific Calculator:{0}", scical.Mul(90, 7));
        }
    }
}
