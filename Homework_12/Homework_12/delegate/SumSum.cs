using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12
{
    internal class SumSum
    {
        public delegate int SumDeleg(int x, int y);
        public event SumDeleg Sumevent;
        public int SumSums() 
        {
            A a = new A();
            this.Sumevent += a.Sum;
            this.Sumevent += a.Sum;
            int z = 0;
            for (int i = 0; i < 2; i++)
            {
                z += Sumevent(i, i * 20);
            }
            return z;
        }
    }
}
