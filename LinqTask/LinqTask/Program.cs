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
            List<string> dupsList = new List<string>() { "cat", "dog", "cat", "bird" };
            List<string> grades1 = new List<string>() {"90,76,89,55,22" ,"98,54,97,72,66" ,"87,25,36,86,47" };
            //List<int> grades2 = new List<int>() { "98, 54, 97, 72, 66" };
            //List<int> grades3 = new List<int>() { "87, 25, 36, 86, 47" };

            LinqFunctions runFunctions = new LinqFunctions();
            List<string> newList = new List<string>();
            newList = runFunctions.GetUnDuplicated(dupsList);

            int classAverage = runFunctions.GetAverageScore(grades1);
            Console.WriteLine(classAverage);







            Console.ReadLine();
        

            
        }

    }
}


