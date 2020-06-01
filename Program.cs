using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_delegate
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Student Alex = new Student();
            Parent John = new Parent();
            Alex.MarkChange+=John.OnMarkChange;

            Alex.AddMark(5);
            Alex.AddMark(5);
            Alex.AddMark(2);
            Alex.AddMark(10);
            
        }
    }
}
