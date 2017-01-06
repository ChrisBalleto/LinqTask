using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTask
{
    class LinqFunctions
    {



        public List<string> GetUnDuplicated(List<string> list)
        {
            List<string> noDupsList = new List<string>();
            noDupsList = list.Distinct().ToList();
            return noDupsList;
        }

        public int GetAverageScore(List<string> list)
        {
            int average = 0;
            return average;
        }

        public string GetNumberOfEachLetter()
        {
            string nameNumbered;


            return nameNumbered;
        }


        
    }
}
