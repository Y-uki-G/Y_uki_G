using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Calculartor
    {
        public int a, b;
        public int sum(int a, int b)
        {
            return a + b;
        }
        public int difference(int a, int b)
        {
            return a - b;
        }
        public int multi(int a, int b)
        {
            return a * b;
        }
        public double dived(int a, int b)
        {
            return (double)a / b;
        }

    }
}
