using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDependency
{
    public class Execution
    {
        private readonly IService _service;
        public Execution(IService service) { 
            _service = service;
        }
        public void CallPrint()
        {
            _service.Print();
        }
    }
}
