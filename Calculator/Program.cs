using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ICaculation CL = new Calculator();
            CL.Calculator();
        }
    }
}