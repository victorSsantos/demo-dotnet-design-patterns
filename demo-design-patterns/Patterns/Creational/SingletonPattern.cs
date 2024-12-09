using demo_design_patterns.creational.Singleton;
using demo_design_patterns.Interfaces;

namespace demo_design_patterns.Patterns.Creational
{
    internal class SingletonPattern : IPattern
    {
        public void ExecutePattern()
        {
            var SingletonInstances = Enumerable.Range(1, 4).Select(x =>
            {
                var singletonInstance = SingletonService.GetInstance();
                Console.WriteLine($"Instance {x} created");

                return singletonInstance;
            }).ToArray();

            Console.WriteLine($"Instance 1 == Instance 2 ? {SingletonInstances[0] == SingletonInstances[1]}");
            Console.WriteLine($"Instance 1 == Instance 2 ? {SingletonInstances[2] == SingletonInstances[3]}");
            Console.WriteLine($"Instance 1 == Instance 2 ? {SingletonInstances[0] == SingletonInstances[2]}");
        }
    }
}
