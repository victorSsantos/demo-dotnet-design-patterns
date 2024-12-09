namespace demo_design_patterns.creational.Singleton
{
    public class SingletonService
    {
        private static SingletonService? _instance = null; // object to return as an instance
        private static readonly object _lock = new(); //object to thread safe

        private SingletonService()
        {
            Console.WriteLine("SingletonPattern instance created.");
        }

        public static SingletonService GetInstance()
        {

            if (_instance == null)
                lock (_lock)
                    _instance ??= new SingletonService();

            return _instance;
        }
    }
}
