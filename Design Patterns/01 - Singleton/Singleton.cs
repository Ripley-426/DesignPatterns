using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public sealed class Navi
    {
        //We store the class instance inside itself, making it static so we can access only one version of it
        private static Navi _instance;
        
        //Private constructor means no one can instance a new class but the class itself
        private Navi()
        {
            InitializeTheClass();
        }

        private void InitializeTheClass()
        {
            //Anything we need to initialize the class goes here! (DB connections, variables/properties filling, etc.)
        }

        //GetInstance checks if our instance was already initialized, if not we run the private constructor.
        //After that we return the instance so everyone can use it.
        public static Navi GetInstance()
        {
            _instance ??= new Navi();
            return _instance;
        }

        
        private List<string> _quotes = new List<string>() { "Hello!", "Hey!", "Listen!", "Look!", "Watch out!" };
        private List<string> _messages = new List<string>();

        //Anyone can use these methods, for example if the quotes were loaded from a DB we would reduce the DB calls 
        //to only 1 call instead of n calls if we were creating n classes
        public string Annoy()
        {
            Random random = new Random();
            return _quotes[random.Next(_quotes.Count)];
        }

        //Anyone can add messages
        public void AddMessage(string message)
        {
            _messages.Add(message);
        }
        
        //Anyone can see the messages, even the ones that you didn't add!
        public List<string> GetMessages()
        {
            return _messages;
        }
    }

    internal class Link
    {
        private readonly Navi _navi = Navi.GetInstance();
        public void SendMessageToNavi()
        {
            _navi.AddMessage("I'm Link!");
        }

        public void ReadMessagesFromNavi()
        {
            Console.WriteLine(".-´º-" + _navi.Annoy() + "-º`-.");
            foreach (string message in _navi.GetMessages())
            {
                Console.WriteLine(message);
            }
        }
    }
    
    internal class DarkLink
    {
        private readonly Navi _navi = Navi.GetInstance();

        public void SendMessageToNavi()
        {
            _navi.AddMessage("Link smells like butt.");
        }
    }
}