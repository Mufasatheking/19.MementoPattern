namespace MementoPattern
{
    /// <summary>
    /// Memento class
    /// </summary>
    public class Memento
    {
        private string state;
        //If we want the state to be same when a memento is created for the //first time, we could prefer a constructor (as shown below)
        //instead of using a setter method in this case.
        //public Memento(string state)
        //{
        //    this.state = state;
        //}
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }
    }
}