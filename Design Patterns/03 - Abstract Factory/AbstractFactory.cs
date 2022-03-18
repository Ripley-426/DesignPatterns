namespace DesignPatterns
{
    public interface IWorkerFactory
    {
        ILumberjack CreateLumberjack();
        IMiner CreateMiner();
        IScientist CreateScientist();
    }

    internal class NormalWorkersFactory : IWorkerFactory
    {
        public ILumberjack CreateLumberjack()
        {
            return new NormalLumberjack();
        }

        public IMiner CreateMiner()
        {
            return new NormalMiner();
        }

        public IScientist CreateScientist()
        {
            return new NormalScientist();
        }
    }
    
    internal class UpgradedWorkersFactory : IWorkerFactory
    {
        public ILumberjack CreateLumberjack()
        {
            return new UpgradedLumberjack();
        }

        public IMiner CreateMiner()
        {
            return new UpgradedMiner();
        }

        public IScientist CreateScientist()
        {
            return new UpgradedScientist();
        }
    }

    public interface ILumberjack
    {
        string Log();
    }

    internal class NormalLumberjack : ILumberjack
    {
        public string Log()
        {
            return "I got 10 wood pieces";
        }
    }

    internal class UpgradedLumberjack : ILumberjack
    {
        public string Log()
        {
            return "I got 20 wood pieces";
        }
    }
    
    public interface IMiner
    {
        string Mine();
    }

    internal class NormalMiner : IMiner
    {
        public string Mine()
        {
            return "I got 10 iron ores";
        }
    }

    internal class UpgradedMiner : IMiner
    {
        public string Mine()
        {
            return "I got 20 iron ores";
        }
    }

    public interface IScientist
    {
        string Invent();
        string CollaborateWithLumberjack(ILumberjack lumberjack);
        string CollaborateWithMiner(IMiner miner);
    }

    internal class NormalScientist : IScientist
    {
        public string Invent()
        {
            return "I got 10 science points";
        }

        public string CollaborateWithLumberjack(ILumberjack lumberjack)
        {
            return "We obtained 20 wood pieces and 5 science points!";
        }

        public string CollaborateWithMiner(IMiner miner)
        {
            return "We obtained 20 iron ores and 5 science points!";
        }
    }

    internal class UpgradedScientist : IScientist
    {
        public string Invent()
        {
            return "I got 20 science points";
        }

        public string CollaborateWithLumberjack(ILumberjack lumberjack)
        {
            return "We obtained 40 wood pieces and 10 science points!";
        }

        public string CollaborateWithMiner(IMiner miner)
        {
            return "We obtained 40 iron ores and 10 science points!";
        }
    }
}