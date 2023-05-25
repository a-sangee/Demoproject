using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    /*
    class DelegateSample
    {
        public delegate void HelloFunctionDelegate(string Message);

        public static void Main(String[] args)
        {
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("Hello from Delegate");
            Console.ReadLine();
        }

        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
    }
*/
    /*
        class DelegateSample
        {
            public static void Main(String[] args)
            {
                List<Employee> empList = new List<Employee>();
                empList.Add(new Employee() { ID = 100, Name = "Tom", Salary = 10000, Experience = 6 });
                empList.Add(new Employee() { ID = 101, Name = "Jerry", Salary = 12000, Experience = 7 });
                empList.Add(new Employee() { ID = 102, Name = "Donald", Salary = 11000, Experience = 3 });
                empList.Add(new Employee() { ID = 103, Name = "Daisy", Salary = 10000, Experience = 4 });

                IsEligibleForPromotion ep = new IsEligibleForPromotion(Promote);
                Employee.PromoteEmployee(empList, ep);

                Console.ReadLine();
            }
            public static bool Promote(Employee e)
            {
                if (e.Experience > 5)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        delegate bool IsEligibleForPromotion(Employee empl);

        class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
            public int Experience { get; set; }

            public static void PromoteEmployee(List<Employee> employees, IsEligibleForPromotion elig)
            {
                foreach (Employee e in employees)
                {
                    if(elig(e))
                    {
                        Console.WriteLine(e.Name + " is promoted");
                    }
                }
            }
        }
    */

    /*
    // assignment 10.a
    public delegate void HelloWorldDelegate(string message);

    class Program
    {
        static void Main(string[] args)
        {
            HelloWorldDelegate d = new HelloWorldDelegate(HelloWorld);
            d("Hello World!");
            Console.ReadLine();
        }

        public static void HelloWorld(string msg)
        {
            Console.WriteLine("The message is " + msg);
        }
    }
    */

    //// assignment 10.b - multicast delegate
    //public delegate void MathDelegate(int i);

    //class Program
    //{
    //    public static void Main(String[] args)
    //    {
    //        MathDelegate d = new MathDelegate(Add);
    //        d += Subtract;
    //        d += Multiply;

    //        d(5);

    //        d -= Add;
    //        d(11);
    //        Console.ReadLine();
    //    }

    //    public static void Add(int a)
    //    {
    //        Console.WriteLine("Adding 5 " + (a + 5));
    //    }

    //    public static void Subtract(int a)
    //    {
    //        Console.WriteLine("Subtracting 3 " + (a - 3));
    //    }
    //    public static void Multiply(int a)
    //    {
    //        Console.WriteLine("Multiplying 6 " + (a * 6));
    //    }


    //}


    //// Assignment - 10 d. BinaryOperation delegate
    //public delegate int BinaryOperationDelegate(int a, int b);

    //public class Calculator
    //{
    //    public int Add(int a, int b)
    //    {
    //        return a + b;
    //    }

    //    public int Sub(int a, int b)
    //    {
    //        return a - b;
    //    }
    //    public int Multiply(int a, int b)
    //    {
    //        return a * b;
    //    }
    //    public int Divide (int a, int b)
    //    {
    //        return a / b;
    //    }
    //}

    //public class Program
    //{
    //    public static void Main(String[] args)
    //    {
    //        Console.WriteLine("Enter the two numbers to be operated. ");
    //        int num1 = int.Parse(Console.ReadLine());
    //        int num2 = int.Parse(Console.ReadLine());
    //        Console.WriteLine("Enter operation to ber performed. 1 - Add, 2 - Sub, 3 - Mult, 4 - Div");
    //        int selection = int.Parse(Console.ReadLine());

    //        Calculator c = new Calculator();

    //        BinaryOperationDelegate d;
    //        //d = new BinaryOperationDelegate(Add);

    //        switch(selection)
    //        {
    //            case 1:
    //             {
    //                    d = c.Add;
    //                    break;
    //             }
    //            case 2:
    //             {
    //                    d = c.Sub;
    //                    break;
    //             }
    //            case 3:
    //            {
    //                    d = c.Multiply;
    //                    break;
    //            }
    //            case 4:
    //            {
    //                    d = c.Divide;
    //                    break;
    //            }
    //            default:
    //            {
    //                    Console.WriteLine("invalid choice");
    //                    return;
    //            }
    //        }
    //        int result = d(num1, num2);
    //        Console.WriteLine("The result is " + result);
    //        Console.ReadLine();
    //    }
    //}    

    ////Assignment 10 E - Function Delegates
    //public class Calculator
    //{
    //    public int Add(int a, int b)
    //    {
    //        return a + b;
    //    }
    //    public int Mod(int a, int b)
    //    {
    //        return a % b;
    //    }
    //    public double Div(int a, int b)
    //    {
    //        return a / b;
    //    }
    //}

    //public class Program
    //{
    //    public static void Main(String[] args)
    //    {
    //        Calculator c = new Calculator();
    //        Func<int, int, int> add = c.Add;
    //        Func<int, int, int> mod = c.Mod;
    //        Func<int, int, double> div = c.Div;

    //        int result1 = add(5, 10);
    //        int result2 = mod(10, 3);
    //        double result3 = div(10, 2);

    //        Console.WriteLine("The result of addition is " + result1);
    //        Console.WriteLine("The result of modulus is " + result2);
    //        Console.WriteLine("The result of division is " + result3);
    //        Console.ReadLine();
    //    }
    //}

    ////Assignment 10 F - Action Delegates
    //public class Calculator
    //{
    //    public void Add(int a, int b)
    //    {
    //        Console.WriteLine("The result of addition is " + (a + b));
    //    }
    //    public void Mod(int a, int b)
    //    {
    //        Console.WriteLine("The result of modulus is " + (a % b));
    //    }
    //    public void Div(int a, int b)
    //    {
    //        Console.WriteLine("The result of division is " + (a / b));
    //    }
    //}

    //public class Program
    //{
    //    public static void Main(String[] args)
    //    {
    //        Calculator c = new Calculator();
    //        Action <int, int> add = c.Add;
    //        Action<int, int> mod = c.Mod;
    //        Action<int, int> div = c.Div;

    //        add(5, 10);
    //        mod(10, 3);
    //        div(10, 2);

    //        Console.ReadLine();
    //    }
    //}

    ////Assignment 10 G - Predicate Delegate
    //public class Program
    //{
    //    public static bool IsLower(string msg)
    //    {
    //        return msg.Equals(msg.ToLower());
    //    }

    //    public static void Main(String[] args)
    //    {
    //        Predicate<string> lowerCaseCheckDelegate = IsLower;
    //        bool result = lowerCaseCheckDelegate("first test");

    //        if (result)
    //        {
    //            Console.WriteLine("The string is lowercase.");
    //        }
    //        else
    //        {
    //            Console.WriteLine("The string is uppercase.");
    //        }

    //        result = lowerCaseCheckDelegate("SECOND TEST");

    //        if (result)
    //        {
    //            Console.WriteLine("The string is lowercase.");
    //        }
    //        else
    //        {
    //            Console.WriteLine("The string is uppercase.");
    //        }
    //        Console.ReadLine();
    //    }
    //}

    //Assignment 10 H - Anonymous Delagate

}