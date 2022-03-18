using System;

namespace DesignPatterns
{
    public class AbstractFactoryTester: ITester
    {
        public void Run()
        {
            //Both factories are run with the same method. It doesn't matter if we are using a normal or an upgraded
            //factory, both work the same
            Console.WriteLine("Testing Normal factory...");
            MakeMinerWorkAloneButScientistCollaborateWithLumberjack(new NormalWorkersFactory());
            Console.WriteLine("Testing Upgraded factory...");
            MakeMinerWorkAloneButScientistCollaborateWithLumberjack(new UpgradedWorkersFactory());
        }
        
        //Every product from the factory (workers in this example) have their own interface, so it doesnt matter in 
        //which factory we are, an upgraded scientist will always be going to work with an upgraded lumberjack
        private static void MakeMinerWorkAloneButScientistCollaborateWithLumberjack(IWorkerFactory factory)
        {
            IMiner miner = factory.CreateMiner();
            ILumberjack lumberjack = factory.CreateLumberjack();
            IScientist scientist = factory.CreateScientist();

            Console.WriteLine(miner.Mine());
            Console.WriteLine(scientist.CollaborateWithLumberjack(lumberjack));
        }
    }
}