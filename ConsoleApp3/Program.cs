using ConsoleApp3.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Assignment Number 3 : 14 Apr 2023
//Di
namespace ConsoleApp3
{

    //Assignment Number 3 : 14 Apr 2023
    //Question 1
    /*
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            Dog d = new Dog();
            Cat c = new Cat();

            a.AnimalSound();
            d.AnimalSound();
            c.AnimalSound();
        }
    }

    class Animal
    {
        public void AnimalSound()
        {
            Console.WriteLine("The animal makes sound.");
        }
    }

    class Dog : Animal
    {
        public void AnimalSound()
        {
            Console.WriteLine("The dog says bow bow.");
        }
    }

    class Cat : Animal
    {
        public void AnimalSound()
        {
            Console.WriteLine("The cat says meow meow.");
            Console.ReadLine();
        }
    }
    */

    //Assignment Number 3 : 14 Apr 2023
    //Question 2
    /*
    class Program
    {
        static void Main(string[] args)
        {
            

        }
    }

    class Employee
    {
        public int parttime_employeeId;
        public string parttime_employeeName;
        public float parttime_employeePay;

        public int fulltime_employeeId;
        public string fulltime_employeeName;
        public float fulltime_employeePay;


        public void EmployeeDetail()
        {
            Console.WriteLine("The emmployee id is " + employeeId + " employee name is " + employeeName + " pay is " + employeePay);
        }
       // Console.WriteLine("The employee id is " + employeeId + " name is " + )
    }

    class FullTimeEmployee : Employee
    {
        void EmployeeDetail()
        {
            Console.WriteLine("The employee id is " + employeeId + " employee name is " + employeeName + " pay is " + employeePay);
        }
    }

    class PartTimeEmployee : Employee
    {
        void EmployeeDetail()
        {
            Console.WriteLine("The employee id is " + fullt)
        }
    }
    */

    // Assignment Number 4 : 14 Apr 2023
    /*   
       internal class Program
       {
           static void Main (string[] args)
           {

           }
       }

       public class MyAccessModifier
       {
           // Declare variables with different access modifiers
           public int publicVar;
           private int privateVar;
           protected int protectedVar;
           internal int internalVar;
           protected internal int proIntVar;
           private protected int priProVar;

           // Intialise the variables in constructor
           public MyAccessModifier()
           {
               publicVar = 10;
               privateVar = 20;
               protectedVar = 30;
               internalVar = 40;
               proIntVar = 50;
               priProVar = 60;
           }

           // print the access modifiers
           public virtual void DisplayAccessModifiers()
           {
               Console.WriteLine("The value of publicVar is : " + this.publicVar);
               Console.WriteLine("The value of privateVar is : " + this.privateVar);
               Console.WriteLine("The value of protectedVar is : " + this.protectedVar);
               Console.WriteLine("The value of internalVar is : " + this.internalVar);
               Console.WriteLine("The value of proIntVar is : " + this.proIntVar);
               Console.WriteLine("The value of priProVar is : " + this.priProVar);
           }
       }

       class ChildClass : MyAccessModifier
       {
           public override void DisplayAccessModifiers()
           {
               Console.WriteLine("The value of publicVar is : " + this.publicVar);
               //Console.WriteLine("The value of privateVar is : " + this.privateVar);// inaccessible because, a private var is accessible only with thin the same class, not even available to the derived class.
               Console.WriteLine("The value of protectedVar is : " + this.protectedVar);
               Console.WriteLine("The value of internalVar is : " + this.internalVar);
               Console.WriteLine("The value of proIntVar is : " + this.proIntVar);
               Console.WriteLine("The value of priProVar is : " + this.priProVar);

           }
       }

       class RandomClass
       {
           public void DisplayAccessModifiers()
           {
               MyAccessModifier m = new MyAccessModifier();


               Console.WriteLine("The value of publicVar is : " + m.publicVar);
                   //Console.WriteLine("The value of privateVar is : " + this.privateVar);// inaccessible because, a private var is accessible only with thin the same class, not even available to the derived class.
               //Console.WriteLine("The value of protectedVar is : " + this.protectedVar);// inaccessible because, this is a not a derived class. Only derived class can access protected.
               Console.WriteLine("The value of internalVar is : " + m.internalVar);
               Console.WriteLine("The value of proIntVar is : " + m.proIntVar);
               //Console.WriteLine("The value of priProVar is : " + m.priProVar); // inaccessible as it is private and protected
           }

       }
   */



    // abstract classes

/*
    class Program
    {
        static void Main(string[] args)
        {
            IStudent i = new Student("abc", 90, 90, 98);

            Console.WriteLine(i.CalculateTotalMarks());
            Console.WriteLine(i.CalculateAverageMarks());

            Console.ReadLine();
        }
    }
 */
}