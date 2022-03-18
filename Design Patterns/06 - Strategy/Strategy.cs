namespace DesignPatterns
{
    public interface IClass
    {
        string Action();
    }

    internal class Warrior : IClass
    {
        public string Action() { return "I'm tanking the boss!"; }
    }

    internal class BlackMage : IClass
    {
        public string Action() { return "I'm casting Firaga!"; }
    }

    internal class WhiteMage : IClass
    {
        public string Action() { return "I'm stressing a lot!"; }
    }
}