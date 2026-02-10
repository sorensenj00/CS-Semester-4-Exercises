using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem4
{
    internal class MyList
    {
        public List<int> list = new List<int>() { 1, 2, 3, 4, 5 };




        public void AddToList(int nummer)
        {
            this.list.Add(nummer);

        }

        public void printList() { 
        foreach (int i in this.list){ 
                Console.Write(i + " ");
            }
        }
    }
}
