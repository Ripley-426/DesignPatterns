namespace DesignPatterns
{
    public class SingletonTester : ITester
    {
        private readonly Link _link = new Link();
        private readonly DarkLink _darkLink = new DarkLink();

        public void Run()
        {
            //We can see the message sent by Dark Link when reading through the messages with Link.
            //There is only one Navi and both Links have access to it instead of having different fairies.
            _link.SendMessageToNavi();
            _link.ReadMessagesFromNavi();
            _darkLink.SendMessageToNavi();
            _link.ReadMessagesFromNavi();
        }
    }
    
    
}