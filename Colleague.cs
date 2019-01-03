namespace MediatorPattern
{
    public abstract class Colleague
    {
        private readonly Mediator mediator;

        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public void Changed()
        {
            mediator.ColleagueChanged(this);
        }
    }
}