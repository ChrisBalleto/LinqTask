using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> dupsList = new List<string>() { "cat", "dog", "cat", "bird", "bird", "falcon", "falcon", "kitten" };
            List<string> grades = new List<string>() {"90,76,89,55,22" ,"98,54,97,72,66" ,"87,25,36,86,47" };

            //Function #1
            LinqFunctions runFunctions = new LinqFunctions();
            List<string> newList = runFunctions.GetUnDuplicated(dupsList);           
            newList.ForEach(Console.WriteLine);

            //Function #2
            double classAverage = runFunctions.GetAverageScore(grades);
            Console.WriteLine(classAverage);

            //Function #3
            Console.WriteLine(runFunctions.GetNumberOfEachLetter("Balleto"));

            Console.ReadLine();        
        }

    }
}


