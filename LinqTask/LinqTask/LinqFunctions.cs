using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTask
{
    class LinqFunctions 
    {


        //Function #1
        public List<string> GetUnDuplicated(List<string> list)
        {
            List<string> noDupsList = new List<string>();
            noDupsList = list.Distinct().ToList();
            return noDupsList;
        }
        //Function #2
        public double GetAverageScore(List<string> list)
        {
            List<double> scoresAsDub = new List<double>();
            foreach(string s in list)
            {          
                List<int> scores = (s.Split(',').Select(nums => int.Parse(nums)).ToList());
                scores = scores.Where(x => x != scores.Min()).ToList();
                var scoreAverage = scores.Average();
                scoresAsDub.Add(scoreAverage);
            }
            return Math.Round(scoresAsDub.Average(), 2);          
        }
        //Function #3
        public string GetNumberOfEachLetter(string input)
        {
            var chars =  input.ToUpper().ToCharArray();
            var letters = (from c in chars
                           orderby c
                           select c).ToList();
            var pair = letters.GroupBy(c => c);
            foreach(var num in pair)
            {
                Console.Write("{0}{1}", num.Key, num.Count());
            }
            return null;
        }



    }
}
