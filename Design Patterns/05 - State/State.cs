using System;

namespace DesignPatterns
{
    class Boss
    {
        private State _state;

        public Boss(State state)
        {
            TransitionTo(state);
        }

        public void TransitionTo(State state)
        {
            Console.WriteLine($"Changing Boss to state {state.GetType().Name}.");
            _state = state;
            _state.SetBoss(this);
        }

        public void MoveTo()
        {
            _state.MoveTo();
        }

        public void Attack()
        {
            _state.Attack();
        }
    }

    abstract class State
    {
        protected Boss _boss;

        public void SetBoss(Boss boss)
        {
            _boss = boss;
        }

        public abstract void MoveTo();
        public abstract void Attack();
    }
    
    class IdleState : State
    {
        public override void MoveTo() {}

        public override void Attack() {}
    }
    
    class MeleeState : State
    {
        public override void MoveTo()
        {
            Console.WriteLine("Walking to the player.");
        }

        public override void Attack()
        {
            Console.WriteLine("Attacking from melee .");
        }
    }
    
    class RangedState : State
    {
        public override void MoveTo()
        {
            Console.WriteLine("Moving to the center of the room.");
        }

        public override void Attack()
        {
            Console.WriteLine("Spawning fire from bellow the player, making him move or die!");
            _boss.TransitionTo(new MeleeState());
        }
    }
}