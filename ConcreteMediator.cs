namespace MediatorPattern
{
    public class ConcreteMediator : Mediator
    {
        public ConcreteColleague1 colleague1 {get;}
        public ConcreteColleague2 colleague2 {get;}

        public ConcreteMediator()
        {
            colleague1 = new ConcreteColleague1(this);
            colleague2 = new ConcreteColleague2(this);

        }

        public void ColleagueChanged(Colleague colleague)
        {
            System.Console.WriteLine("Mediator ColleagueChanged");
            if(colleague == colleague1)
            {
                if(colleague1.Status == colleague2.Status)
                {
                    colleague2.ChangeStatus(!colleague1.Status);
                }
            }
            else if(colleague == colleague2)
            {
                if(colleague2.Status == colleague1.Status)
                {
                    colleague1.ChangeStatus(!colleague2.Status);
                }
            }
        }
    }
}