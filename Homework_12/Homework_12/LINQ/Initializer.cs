using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12
{
    internal class Initializer
    {
        public void InitializeContact(List<string> ContactList)
        {
            ContactList[0] = new ("Иванов");         
            ContactList[1] = new ("Абрамов");          
            ContactList[2] = new ("Журавлёв");            
            ContactList[3] = new ("Платонов");           
            ContactList[4] = new ("Кравец");          
            ContactList[5] = new ("Орлов");        
            ContactList[6] = new ("Корнеев");          
            ContactList[7] = new ("Любимов");           
            ContactList[8] = new ("Стахевич");
            ContactList[9] = new ("Баранов"); 
        }
    }
}
