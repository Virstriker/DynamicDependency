﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDependency
{
    internal class ServiceB : IService
    {
        public void Print()
        {
            Console.WriteLine("ServiceB");
        }
    }
}
