using System;

namespace DesignPatterns
{
    public interface ICommand
    {
        void Execute();
    }

    internal class SayHello : ICommand
    {
        private Shopkeeper _shopkeeper;
        private readonly string _name;
        
        public SayHello(Shopkeeper shopkeeper, string name)
        {
            _shopkeeper = shopkeeper;
            _name = name;
        }
        
        public void Execute()
        {
            _shopkeeper.Greet($"Hello {_name}!");
        }
    }
    
    internal class SayGoodbye : ICommand
    {
        private Shopkeeper _shopkeeper;
        private string _name;
        private string _shopName;

        public SayGoodbye(Shopkeeper shopkeeper, string name, string shopName)
        {
            _shopkeeper = shopkeeper;
            _name = name;
            _shopName = shopName;
        }
        
        public void Execute()
        {
            _shopkeeper.Dismiss($"Goodbye {_name}, thanks for shopping at {_shopName}!");
        }
    }

    class Shopkeeper
    {
        public void Greet(string greeting)
        {
            Console.WriteLine(greeting);
        }

        public void Dismiss(string dismissal)
        {
            Console.WriteLine(dismissal);
        }
    }

    class Shop
    {
        private ICommand _commandOnEnter;
        private ICommand _commandOnExit;

        public void SetCommandOnEnter(ICommand command)
        {
            _commandOnEnter = command;
        }
        
        public void SetCommandOnExit(ICommand command)
        {
            _commandOnExit = command;
        }

        public void ExecuteOnEnter()
        {
            _commandOnEnter.Execute();
        }

        public void ExecuteOnExit()
        {
            _commandOnExit.Execute();
        }
    }
}