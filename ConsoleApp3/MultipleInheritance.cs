using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    /*
    class MultipleInheritance
    {
         static void Main(String[] args)
        {
            PartTimeEmployee p = new PartTimeEmployee("XYZ", 35, 90);
            FullTimeEmployee f = new FullTimeEmployee("ABC", 30, 90000);

            Console.WriteLine(p.GetHashCode().ToString());
            Console.WriteLine(p.GetType().ToString());
            Console.WriteLine(p.ToString());

            p.DisplayPartTimerInfo();
            f.DisplayFullTimerInfo();
            Console.ReadLine();
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Employee(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name is {Name} and age is {Age}");
        }
    }

    public class PartTimeEmployee : Employee
    {
        public int HourlyRate { get; set; }

        
        public PartTimeEmployee(string name, int age, int hourlyRate) : base(name, age)
        {
            HourlyRate = hourlyRate;
        }
        public void DisplayPartTimerInfo()
        {
            Console.WriteLine($"Name is {Name} and age is {Age} and Hourly Rate is {HourlyRate}");
        }
    }

    public class FullTimeEmployee:Employee
    {
        public int Salary { get; set; }

        public FullTimeEmployee(string name, int age, int salary): base(name, age)
        {
            Salary = salary;
        }

        public void DisplayFullTimerInfo()
        {
            Console.WriteLine($"Name is {Name} and age is {Age} and Salary is {Salary}");
        }
    }
    */
}
