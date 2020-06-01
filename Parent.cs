using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_delegate
{
    class Parent
    {

        public void OnMarkChange(int a)
        {
            Console.WriteLine("your child received grade {0}", a);
        }
    }
}
