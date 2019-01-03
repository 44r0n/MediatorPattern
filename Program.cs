using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator mediator = new ConcreteMediator();
            Console.WriteLine("Program change colleague1 Status to false");
            mediator.colleague1.ChangeStatus(false);
            Console.WriteLine("Program change colleague2 Status to false");
            mediator.colleague2.ChangeStatus(false);
            Console.WriteLine(mediator.colleague1.Status);
        }
    }
}
