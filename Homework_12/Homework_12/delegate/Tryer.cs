using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12
{
    internal class Tryer
    {
        public delegate int SumSumDeleg();
        public void Try(SumSumDeleg sumSumDeleg)
        {
            try
            {
                int result = sumSumDeleg();
            }
            finally
            {
                Console.WriteLine("try completed");
            }
        }
    }
}
