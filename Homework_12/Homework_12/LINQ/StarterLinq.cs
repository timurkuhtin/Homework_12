using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12
{
    internal class StarterLinq
    {
        public void Go()
        {
            List<string> strings = new List<string>();
            Initializer initializer = new Initializer();
            initializer.InitializeContact(strings);
            var Selectedsurnames1 = strings.Where(x => x.StartsWith("Ж"));
            var Selectedsurnames2 = strings.FirstOrDefault(x => x.StartsWith("К"));
            var Selectedsurnames3 = strings.Select(x => x == "Журавлёв");
            var Selectedsurnames4 = strings.Any(x => x.Length == 7);
            var Selectedsurnames5 = strings.Count(x => x.Length == 6);
            var Selectedsurnames6 = strings.Take(3);
        }
    }
}
