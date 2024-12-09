using demo_design_patterns.Interfaces;
using demo_design_patterns.structural.Adapter.Interface;
using demo_design_patterns.structural.Adapter.Legacy;
using demo_design_patterns.structural.Adapter;

namespace demo_design_patterns.DePatternsPatternsmos.Structural
{
    public class  AdapterPattern : IPattern
    {
        public void ExecutePattern()
        {
            IClientService service = new ClientService();

            service.GetRequest();

            var serviceLegacy = new ClientServiceLegacy();
            service = new Adapter(serviceLegacy);

            service.GetRequest();
        }
    }
}
