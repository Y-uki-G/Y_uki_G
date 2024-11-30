using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    //class Person
    //{
    //    public string Name { get; set; }
    //    public string Surname { get; set; }
    //    public int Age { get; set; }
    //    public bool IsAdult = false;
    //    public Person(string name, string surname, int age) 
    //    {
    //        Name = name;
    //        Surname = surname;
    //        Age = age;
    //        if (age >= 18) IsAdult = true;
    //    }
    //}
    class Person
    {

        public string Name ;//{ get; set; }
        public string Surname ;//{ get; set; }
        public int Age ;//{ get; set; }
        public bool IsAdult = false;


        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            if (age >=18 ) IsAdult = true;
        }
    }
}
