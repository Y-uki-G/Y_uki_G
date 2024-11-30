using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Task3
{
    internal class Calculator
    {
        public int Add(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        public int Multiply(int num1, int num2)
        {
            int mult = num1 * num2;
            return mult;
        }



    }
}