using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPatterns
{
    class DuckSimulator
    {
        static void Main(string[] args)
        {
            DuckSimulator simulator = new DuckSimulator();
            AbstractDuckFactory _duckFactory = new CountingDuckFactory();

            simulator.simulate(_duckFactory);
        }

        void simulate(AbstractDuckFactory duckFactory)
        {
            //Quackable mallardDuck = duckFactory.createMallardDuck();
            IQuackable redheadDuck = duckFactory.createRedheadDuck();
            IQuackable duckCall = duckFactory.createDuckCall();
            IQuackable rubberDuck = duckFactory.createRubberDuck();
            IQuackable gooseDuck = new GooseAdapter(new Goose());

            /*
            Quackable mallardDuck = new QuackCounter(new MallardDuck());
            Quackable redheadDuck = new QuackCounter(new RedheadDuck());
            Quackable duckCall = new QuackCounter(new DuckCall());
            Quackable rubberDuck = new QuackCounter(new RubberDuck());
            Quackable gooseDuck = new GooseAdapter(new Goose());
            */

            Console.WriteLine("\nDuck Simulator: With Composite - Flocks");

            Flock flockOfDucks = new Flock();

            flockOfDucks.add(redheadDuck);
            flockOfDucks.add(duckCall);
            flockOfDucks.add(rubberDuck);
            flockOfDucks.add(gooseDuck);

            Flock flockOfMallards = new Flock();

            IQuackable mallardOne = duckFactory.createMallardDuck();
            IQuackable mallardTwo = duckFactory.createMallardDuck();
            IQuackable mallardThree = duckFactory.createMallardDuck();
            IQuackable mallardFour = duckFactory.createMallardDuck();

            flockOfMallards.add(mallardOne);
            flockOfMallards.add(mallardTwo);
            flockOfMallards.add(mallardThree);
            flockOfMallards.add(mallardFour);

            flockOfDucks.add(flockOfMallards);

            /*
            simulate(mallardDuck);
            simulate(redheadDuck);
            simulate(duckCall);
            simulate(rubberDuck);
            simulate(gooseDuck);
            */

            Quackologist quackologist = new Quackologist();
            flockOfDucks.registerObserver(quackologist);

            Console.WriteLine("\nDuck Simulator: Whole Flock Simulation");
            simulate(flockOfDucks);

            Console.WriteLine("\nDuck Simulator: Mallard Flock Simulation");
            simulate(flockOfMallards);

            Console.WriteLine("The ducks quacked " + QuackCounter.getQuacks() + " times");
        }

        void simulate(IQuackable duck)
        {
            duck.quack();
        }
    }
}
