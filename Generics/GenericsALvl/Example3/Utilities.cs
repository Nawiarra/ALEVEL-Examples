﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    public class Utilities
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        // this not works now 
        //public T Max<T>(T a, T b)
        //{
        //    return a > b ? a : b;
        //}

        public T Max<T>(T a, T b) where T: IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }

    
}
