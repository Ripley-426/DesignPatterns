namespace DesignPatterns
{
    public class ObserverTester : ITester
    {
        private HungryPerson _npc1 = new HungryPerson();
        private HungryPerson _npc2 = new HungryPerson();
        private Chef _chef = new Chef();
        
        public void Run()
        {
            _chef.Attach(_npc1);
            _chef.Attach(_npc2);
            _chef.Cook();
        }
    }
}