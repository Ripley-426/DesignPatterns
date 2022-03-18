namespace DesignPatterns
{
    //Worker lets you implement different types of workers easily
    internal abstract class Worker
    {
        //Every worker you create will be able to be sent to work regardless of it's implementation.
        public abstract string GetResources();
    }

    internal class Lumberjack : Worker
    {
        public override string GetResources()
        {
            return "I got 10 wood pieces!";
        }
    }

    internal class Miner : Worker
    {
        public override string GetResources()
        {
            return "I got 10 iron ores!";
        }
    }

    internal class Scientist : Worker
    {
        public override string GetResources()
        {
            return "I got 10 science points!";
        }
    }
}