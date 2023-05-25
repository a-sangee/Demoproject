using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class StringExamples
    {
	/*
		static void Main(String[] args)
		{
			/*
			// strings are immutable example
			string s1 = "Hello World";
			string s2 = "Hello World";
			
			// Since both the text are the same, they are pointing to the same memory location. We can check that first as below.
			if(object.ReferenceEquals(s1, s2))
{
				Console.WriteLine("Both are pointing to the same location");
			}
			else
			{
				Console.WriteLine("Both are pointing to different location");
			}
			//Now modify string s2.
			s2 = "Modified";
			
			// The above code would have created a new memory location for s2 and hence they both wont be pointing to the same memory location. Lets check that below.
			if(object.ReferenceEquals(s1, s2))
			{
				Console.WriteLine("Both are pointing to the same location");
			}
			else
			{	
				Console.WriteLine("Both are pointing to different location");
			}

			Console.ReadLine();
		*/
			/*
				//example - Demonstrate Example to String Intern Pool memory usage
				string s1 = "tom";
				string s2 = "t" + "o" + "m";
				string s3 = "to" + "m";
				string s4 = "t" + "om";
				char[] c = { 't','o','m'};
				String s5 = new String(c);

				//all the below statements will return true. this means that "tom" is stored only once in a pool 
				//and all variables having "tom" literal will access it from the same location.
				Console.WriteLine(object.ReferenceEquals(s1, s2));
				Console.WriteLine(object.ReferenceEquals(s1, s3));
				Console.WriteLine(object.ReferenceEquals(s1, s4));
				Console.WriteLine(object.ReferenceEquals(s1, s5));

				Console.ReadLine();
			*/
			/*
			// example - difference between == and Equals operator.
			string a1 = "apple";
			string a2 = "apple";

			Console.WriteLine(a1 == a2);
			Console.WriteLine(a1.Equals(a2));

			StringBuilder b1 = new StringBuilder("apple");
			StringBuilder b2 = new StringBuilder("apple");

			Console.WriteLine(b1 == b2); 
			Console.WriteLine(b1.Equals(b2));

			Console.ReadLine();
			*/

	/*		// demonstrate all methods of String class.
			String s = "Welcome to C# Programming!";
			Console.WriteLine(s);
			Console.WriteLine("The length of the text is " + s.Length);
			
			Console.ReadLine();

		}
	*/
	}
}
