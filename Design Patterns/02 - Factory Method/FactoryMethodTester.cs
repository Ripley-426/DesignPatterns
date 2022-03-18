using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class FactoryMethodTester : ITester
    {
        List<Worker> workers = new List<Worker> { new Lumberjack(), new Miner(), new Scientist() };
        public void Run()
        {
            //It doesn't matter which type of worker is inside the list, everyone can be sent to work thanks to the factory method.
            foreach (Worker worker in workers)
            {
                Console.WriteLine("I dont know which type of worker i'm sending...");
                Console.WriteLine(worker.GetResources());
            }
        }
    }
}