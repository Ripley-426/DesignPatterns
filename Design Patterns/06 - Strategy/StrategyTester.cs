using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class StrategyTester: ITester
    {
        private readonly List<IClass> _party = new List<IClass> { new Warrior(), new BlackMage(), new WhiteMage() };

        public void Run()
        {
            foreach (IClass character in _party)
            {
                Console.WriteLine(character.Action());
            }
        }
    }
}