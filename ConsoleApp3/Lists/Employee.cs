using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Lists
{
    class Employee
    {
        public int Age { get; set; }
        public String Name { get; set; }
        public double Salary{ get; set; }

        public override string ToString()
        {
            return $"Name :{Name}, Age : {Age}, Salary : {Salary}";
        }

        //constructor
        public Employee(int age, String name, double salary)
        {
            Age = age;
            Name = name;
            Salary = salary;
        }
    }
}
