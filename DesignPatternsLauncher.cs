namespace DesignPatterns
{
    class DesignPatternsLauncher
    {
        private static ITester _tester;
        static void Main(string[] args)
        {
            //_tester = new SingletonTester();
            //_tester = new FactoryMethodTester();
            //_tester = new AbstractFactoryTester();
            //_tester = new CommandTester();
            //_tester = new StateTester();
            //_tester = new StrategyTester();
            _tester = new ObserverTester();
            
            _tester.Run();
        }
    }
}