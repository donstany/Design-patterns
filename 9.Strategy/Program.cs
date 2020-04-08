using System;
//https://www.dofactory.com/net/strategy-design-pattern
namespace DoFactory.GangOfFour.Strategy.Structural
{
    /// <summary>
    /// MainApp startup class for Structural
    /// Strategy Design Pattern.
    /// </summary>

    class MainApp

    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>

        static void Main()
        {
            Context context;

            // Three contexts following different strategies

            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();

            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'Strategy' abstract class
    /// </summary>

    interface IStrategy
    {
        public void AlgorithmInterface();
    }

    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>

    class ConcreteStrategyA : IStrategy

    {
        public void AlgorithmInterface()
        {
            Console.WriteLine(
              "Called ConcreteStrategyA.AlgorithmInterface()");
        }
    }

    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>

    class ConcreteStrategyB : IStrategy
    {
        public void AlgorithmInterface()
        {
            Console.WriteLine(
              "Called ConcreteStrategyB.AlgorithmInterface()");
        }
    }

    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>

    class ConcreteStrategyC : IStrategy

    {
        public void AlgorithmInterface()
        {
            Console.WriteLine(
              "Called ConcreteStrategyC.AlgorithmInterface()");
        }
    }

    /// <summary>
    /// The 'Context' class
    /// </summary>

    class Context
    {
        private IStrategy _strategy;
        // Constructor
        public Context(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void ContextInterface()
        {
            _strategy.AlgorithmInterface();
        }
    }
}