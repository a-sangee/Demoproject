using ConsoleApp3.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Business
{
    class Student : IStudent
    {
        /*
        string studentName;
        int studentMathMarks;
        int studentEngMarks;
        int studentSciMarks;*/

        public string Name { get; set ; }
        public int MathMarks { get ; set ; }
        public int EnglishMarks { get ; set ; }
        public int ScienceMarks { get ; set ; }

        public  Student(string name, int math, int sci, int eng)
        {
            Name = name;
            MathMarks = math;
            EnglishMarks = eng;
            ScienceMarks = sci;
        }

        public double CalculateAverageMarks()
        {
            try
            {
                return (MathMarks + EnglishMarks + ScienceMarks) / 0;
            }
            catch(Exception e)
            {
                throw new StudentException("Error occurred during CalculateAverageMarks.");
            }
        }

        public double CalculateTotalMarks()
        {
            try
            {
                return (MathMarks + EnglishMarks + ScienceMarks);
            }
            catch(Exception e)
            {
                throw new StudentException("Error occurred during CalculateTotalMarks.");
            }
            
        }
    }
}
