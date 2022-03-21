using System;

namespace DesignPatterns
{
    public class Player
    {
        public bool IsAlive;
        public string Name;
        public Stats Stats;

        public Player(string name)
        {
            Name = name;
            IsAlive = true;
            Stats = new Stats();
        }

        public void DoJob()
        {
            Stats.Experience += 10;
            Stats.Gold += 5;
        }

        public Player GetLinkedCopy()
        {
            return (Player) MemberwiseClone();
        }

        public Player GetUnlinkedCopy()
        {
            Player clone = (Player) MemberwiseClone();
            clone.Stats = new Stats();
            return clone;
        }

        public override string ToString()
        {
            return $"I'm {Name}, I have {Stats.Experience} experience points and {Stats.Gold} gold coins! " +
                   $"It's {IsAlive} that I'm alive";
        }
    }

    public class Stats
    {
        public int Experience;
        public int Gold;

        public Stats()
        {
            Experience = 0;
            Gold = 0;
        }
    }
}