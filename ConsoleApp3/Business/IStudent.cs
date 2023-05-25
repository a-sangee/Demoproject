using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Business
{
    interface IStudent
    {
        string Name { get; set; }
        int MathMarks { get; set; }
        int EnglishMarks { get; set; }
        int ScienceMarks { get; set; }

        double CalculateTotalMarks();
        double CalculateAverageMarks();
    }
}
