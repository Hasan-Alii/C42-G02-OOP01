using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_OOP01
{
    internal struct  Point
    {
        //default access modifiers inside struct is PRIVATE
        //so we need to change it
        public int x;
        public int y;

        //constructor: is a special method
        //             1. named like struct
        //             2. has no return type
        //CLR by default creates a default parameterless constructor
        //it's used to initialize attributes with the default value
        //x = 0, y = 0
        //CLR constructor example
        //public Point()
        //{
        //    x = default;
        //    y = default;
        //}
    }
}
