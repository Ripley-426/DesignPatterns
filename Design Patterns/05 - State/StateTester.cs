using System;

namespace DesignPatterns
{
    public class StateTester: ITester
    {
        private Boss _boss = new Boss(new IdleState());
        public void Run()
        {
            Console.WriteLine("The boss is inactive.");
            RunBossActions();
            Console.WriteLine("The player has activated the boss!");
            _boss.TransitionTo(new MeleeState());
            RunBossActions();
            Console.WriteLine("The boss is down to 50% hp, time for a phase change!");
            _boss.TransitionTo(new RangedState());
            RunBossActions();
            Console.WriteLine("The boss ended the ranged phase and returned automatically to melee!");
            RunBossActions();
            Console.WriteLine("You successfully defeated the boss, take this sword +-->");
        }

        private void RunBossActions()
        {
            _boss.MoveTo();
            _boss.Attack();
        }
    }
}