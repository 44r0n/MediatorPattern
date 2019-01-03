namespace MediatorPattern
{
    public class ConcreteColleague2 : Colleague
    {

        public ConcreteColleague2(Mediator mediator) : base(mediator)
        {
            Status = false;
        }

        public bool Status { get; private set; }

        public void ChangeStatus(bool status)
        {
            Status = status;
            System.Console.WriteLine("ConcreteColleague2 status changed to: " + Status);
            this.Changed();            
        }

    }
}