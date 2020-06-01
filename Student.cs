using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_delegate
{
    delegate void MyDel(int a);
    class Student
    {
        public event MyDel MarkChange = null;
        List<int> mark = new List<int>();
        public void AddMark(int a)
        {
            mark.Add(a);
            MarkChange?.Invoke(a);
        }
    }
}
