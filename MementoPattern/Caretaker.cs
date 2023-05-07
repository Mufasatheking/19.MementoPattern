namespace MementoPattern
{
    public class Caretaker
    {
        private Stack<Memento> _mementos = new Stack<Memento>();

        public void Save(Originator originator)
        {
            _mementos.Push(originator.GetTheMemento());
        }
        
        public void GetVersion(Originator originator, int version)
        {
            if (_mementos.Count > 0 && _mementos.Count>version)
            {
                originator.RevertToState(_mementos.ElementAt(version));
            }
        }
        
        public void Undo(Originator originator)
        {
            if (_mementos.Count > 0)
            {
                _mementos.Pop();
                originator.RevertToState(_mementos.Pop());
            }
        }
    }
}