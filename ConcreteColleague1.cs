namespace MediatorPattern
{
    public class ConcreteColleague1 : Colleague
    {

        public ConcreteColleague1(Mediator mediator) : base(mediator)
        {
            Status = false;
        }

        public bool Status { get; private set; }

        public void ChangeStatus(bool status)
        {
            Status = status;
            System.Console.WriteLine("ConcreteColleague1 status changed to: " + Status);
            this.Changed();            
        }

    }
}