using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12
{
    internal class Starter
    {
        public void Go()
        {
            SumSum sumSum = new SumSum();
            Tryer tryer = new Tryer();

            int result = sumSum.SumSums();
            tryer.Try(sumSum.SumSums);
        }
    }
}
