using demo_design_patterns.structural.Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_design_patterns.structural.Adapter
{
    public class ClientService : IClientService
    {
        public void GetRequest()
        {
            Console.WriteLine("Client Service New");
        }
    }
}
