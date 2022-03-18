namespace DesignPatterns
{
    public class CommandTester: ITester
    {
        private Shop _shop = new Shop();
        private Shopkeeper _shopkeeper = new Shopkeeper();
        
        public void Run()
        {
            //In this example we created two commands for a shop in-game. The first one makes the shopkeeper npc greet
            //the player, while the second bids farewell while mentioning the shop name. If we implemented a shop
            //accessible by phone we could reuse these commands to greet and dismiss the player. 
            _shop.SetCommandOnEnter(new SayHello(_shopkeeper, "Red"));
            _shop.SetCommandOnExit(new SayGoodbye(_shopkeeper, "Red", "PokeMart"));
            
            _shop.ExecuteOnEnter();
            _shop.ExecuteOnExit();
        }
    }
}