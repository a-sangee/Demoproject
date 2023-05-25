using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Common
{
    class StudentException: Exception 
    {
        public StudentException()
        {

        }
        public StudentException(string message): base(message)
        {
            Console.WriteLine(message);
        }

        public StudentException(string message, Exception innerException): base(message, innerException)
        {

        }
    }
}
