using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDependency
{
    public class ServiceA : IService
    {
        public void Print()
        {
            Console.WriteLine("ServiceA");
        }
    }
}
