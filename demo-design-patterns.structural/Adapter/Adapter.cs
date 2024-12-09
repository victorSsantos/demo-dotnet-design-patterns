using demo_design_patterns.structural.Adapter.Interface;
using demo_design_patterns.structural.Adapter.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_design_patterns.structural.Adapter
{
    public class Adapter(ClientServiceLegacy legacyService) : IClientService
    {
        private readonly ClientServiceLegacy _legacyService = legacyService;

        public void GetRequest()
        {
            _legacyService.GetRequest();
        }
    }
}
