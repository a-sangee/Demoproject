using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
    }

    public class SampleLINQ
    {
        //public int[] Num = { 1,2,3,4,5,6,7,8,9,10};

        //IEnumerable<int> result = from numbers in Num where numbers > 3 select numbers;
        public static void Main(String[] args)
        {
            //int[] Num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //IEnumerable<int> result = from numbers in Num
            //                      where numbers > 3
            //                      select numbers;
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Assignment 13.a.
            ////without lambda expression
            //Func<int, int> a = Square;
            //Console.WriteLine(a(5));

            ////with lambda expression
            //Func<int, int> b = (c) => c * c;
            //Console.WriteLine(b(6));

            //int Square(int i)
            //{
            //    return i*i;
            //}

            ////Assignment 13.b.
            //int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine("Below are even numbers");
            //IEnumerable<int> evenNumbers = numbers.Where( x => x % 2 == 0 );            
            //foreach(var i in evenNumbers)
            //{
            //    Console.WriteLine(i + " is an even number");
            //}

            //Console.WriteLine("Below are odd numbers");
            //IEnumerable<int> oddNumbers = numbers.Where(x => x % 2 != 0);
            //foreach( var j in oddNumbers)
            //{
            //    Console.WriteLine(j + " is an odd number");
            //}

            ////Assignment 13.b.
            //// Lambda expression with no input and no output
            //Action greet = () => Console.WriteLine("Hello World");
            //greet();

            //// Lambda expression with one input and no output
            //Action<string> greetName = name => Console.WriteLine($"Hello, {name} !");
            //greetName("Sangeetha");

            //// Lambda expression with 2 inputs and no output
            //Action<int, int> addValues = (x, y) => Console.WriteLine($"{x} + {y} is  " + (x + y));
            //addValues(9, 8);

            //// Lambda expression with no input and output
            //Action zeroIO = () => Console.WriteLine("The one doesnt expect input and gives no output");
            //zeroIO();

            //// Lambda expression with one input and one output
            //Func<int, int> Squared = (x) => x * x;
            //Console.WriteLine(Squared(6));

            //// Lambda expression with 2 inputs and one output
            //Func<int, int, int> multiply = (x, y) =>
            //{
            //    int result = x * y;
            //    Console.WriteLine($"The result is {result}");
            //    return result;
            //};
            //multiply(7, 8);

            //// Lambda expression with Predicate delegate to filter even numbers
            //List<int> numbers = new List<int>{ 1,2,3,4,5,6,7,8,9,10};
            //Predicate<int> isEven = x => (x % 2 == 0);
            //List<int> evenNumbers = numbers.FindAll(isEven);
            //foreach(var v in evenNumbers)
            //{
            //    Console.WriteLine(v);
            //}

            //// Lambda expression to filter words greater than length 5
            //List<string> fruits = new List<string> { "apple", "banana", "grapes", "strawberry", "pear", "papaya" };
            //Predicate<string> wordLength = x => (x.Length > 5);
            //List<string> shortFruits = fruits.FindAll(wordLength);
            //foreach(var v in shortFruits)
            //{
            //    Console.WriteLine(v);
            //}

            // //Assignment 13.c. - Multithreading with Lambda expressions
            // Thread t1 = new Thread(() =>
            //{
            //    Console.WriteLine("Thread 1 is running ");
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Thread 1 has finished ");
            //});

            // Thread t2 = new Thread((x) =>
            //{
            //    Console.WriteLine($"Thread 2 is running with parameter {x}");
            //    Thread.Sleep(1000);
            //    Console.WriteLine($"Thread 2 with parameter {x} has finished running");
            //});

            // t1.Start();
            // t2.Start("test");

            // t1.Join();
            // t2.Join();

            // Console.WriteLine("All threads have finished.");

            // Console.ReadLine();

            //////Assignment 13.d. - LINQ on arrays and collections
            ////int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ////var arrData = from n in numbers where n > 5 select n;
            ////foreach( var a in arrData)
            ////{
            ////    Console.WriteLine(a);
            ////}

            ////// Filtering data using where operator
            ////List<int> numbersList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ////IEnumerable<int> evenNumbers = from n in numbersList where n % 2 == 0 select n;
            ////foreach(var b in evenNumbers)
            ////{
            ////    Console.WriteLine(b);
            ////}

            ////var descOrder = numbers.OrderByDescending(n => n);
            ////foreach(var a  in descOrder)
            ////{
            ////    Console.WriteLine(a);
            ////}

            ////Console.ReadLine();

            //Assignment 13.e - LINQ in Person object manipulation

            Person[] p = new Person[]
            {
                new Person{Name="ABC",Age=25,Salary=20000.00 },
                new Person { Name = "XYZ", Age = 30, Salary = 30000.00 },
                new Person { Name = "PQR", Age = 35, Salary = 25000.00 }
            };

            // print the name
            var names = p.Select(q => q.Name);
            foreach(var z in names)
            {
                Console.WriteLine(z);
            }

            // print age + 10
            var names1 = p.Select(q => q.Age + 10);
            foreach(var z in names1)
            {
                Console.WriteLine(z);
            }

            // print salary + 10000
            var names2 = p.Select(q => q.Salary + 10000);
            foreach(var z in names2)
            {
                Console.WriteLine(z);
            }

            Console.ReadLine();
        }
            
        }
    }

