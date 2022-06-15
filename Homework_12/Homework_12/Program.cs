using System;

namespace Homework_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Starter starter = new Starter();
            StarterLinq starterLinq = new StarterLinq();
            starter.Go();
            starterLinq.Go();
        }
    }
}
