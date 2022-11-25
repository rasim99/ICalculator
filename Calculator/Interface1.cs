using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    interface ICaculation
    {
        void Calculator();
       
    }

    class Calculator : ICaculation
    {
        void ICaculation.Calculator()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a+b);
            Console.WriteLine(a-b);
            Console.WriteLine(a*b);
            Console.WriteLine(a/b);
        }
    }
}
