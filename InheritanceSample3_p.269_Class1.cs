﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample3_p._269
{
    class Class1
    {
        protected string name;  //派生クラスからはアクセス可能

        public Class1(string n)
        {
            name = n;
        }

        public string Name
        {
            get { return name; }
        }
    }
}
