namespace MementoPattern
{
    public class Originator
    {
        private string state;
        Memento myMemento;
        //public Originator()
        //{
        //    //this.State = "Initial state";
        //}
        public string State
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine("Current State : {0}", state);
            }
        }
        // Originator will supply the memento in respond to caretaker's //request
        public Memento GetTheMemento()
        {
            //Creating a memento with the current state
            myMemento = new Memento();
            myMemento.State = state;
            return myMemento;
        }
        // Back to old state (Restore)
        public void RevertToState(Memento previousMemento)
        {
            Console.WriteLine("Restoring to previous state...");
            this.state = previousMemento.State;
            Console.WriteLine("Current State : {0}", state);
        }
    }
}