using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskuseless
{
    internal class Person
    {
        public string student;
        private static int Age = 0;
        public int age {  get; private set; }
        

        public Person() 
        {
            age= 1+Age;
            Age++;
        }
    }
}
