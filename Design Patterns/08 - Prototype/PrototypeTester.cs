using System;

namespace DesignPatterns
{
    public class PrototypeTester : ITester
    {
        public void Run()
        {
            
            /*
             * Memberwise Clone only copies values but not addresses, unless the value is another class, then it copies
             * the pointer.
             *
             * In this example, name and IsAlive are not shared with the linked copy nor with the unlinked one,
             * but Stats (another class) gets shared with the linked copy and not with the unlinked one.
             * That's because while the linked copy is a shallow copy, the unlinked one is a deep one (Meaning that
             * instead of copying the Stats pointer i'm generating a new Stats for each copy).
             */
            Player player = new Player("Robin");

            Player linkedCopy = player.GetLinkedCopy();

            Player unlinkedCopy = player.GetUnlinkedCopy();
            
            Console.WriteLine(player.ToString());
            Console.WriteLine(linkedCopy.ToString());
            Console.WriteLine(unlinkedCopy.ToString());
            Console.WriteLine("-------- Changing Player Name");
            player.Name = "Naruto";
            Console.WriteLine(player.ToString());
            Console.WriteLine(linkedCopy.ToString());
            Console.WriteLine(unlinkedCopy.ToString());
            Console.WriteLine("-------- Making player work");
            player.DoJob();
            Console.WriteLine(player.ToString());
            Console.WriteLine(linkedCopy.ToString());
            Console.WriteLine(unlinkedCopy.ToString());
            Console.WriteLine("-------- Making linked copy work 100 times");
            for (int i = 0; i < 100; i++) { linkedCopy.DoJob(); }
            Console.WriteLine(player.ToString());
            Console.WriteLine(linkedCopy.ToString());
            Console.WriteLine(unlinkedCopy.ToString());
            Console.WriteLine("-------- Making Unlinked copy work 15 times");
            for (int i = 0; i < 15; i++) { unlinkedCopy.DoJob(); }
            Console.WriteLine(player.ToString());
            Console.WriteLine(linkedCopy.ToString());
            Console.WriteLine(unlinkedCopy.ToString());
            Console.WriteLine("-------- Killing player");
            player.IsAlive = false;
            Console.WriteLine(player.ToString());
            Console.WriteLine(linkedCopy.ToString());
            Console.WriteLine(unlinkedCopy.ToString());
        }
    }
}