using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Properties
{
    internal class SwapDemp
    {
        // generics , when the type is known at run time

        public void Swap<T> (T x, T y)
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
        }
        //public void Swap(int x, int y)
        //{
        //    int temp;
        //    temp = x;
        //    x = y;
        //    y = temp;
        //}

        //public void Swap(char x, char y)
        //{
        //   char temp;
        //    temp = x;
        //    x = y;
        //    y = temp;
        //}
    }
}
