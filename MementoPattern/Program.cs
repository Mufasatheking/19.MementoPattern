using MementoPattern;

Console.WriteLine("***Memento Pattern Demo***\n");
//Originator is initialized with a state
Originator originatorObject = new Originator();
Caretaker caretaker = new Caretaker();
originatorObject.State = "Initial state";
caretaker.Save(originatorObject);
originatorObject.State = "Second state";
caretaker.Save(originatorObject);
originatorObject.State = "Third state";
caretaker.Save(originatorObject);
originatorObject.State = "Fourth state";
caretaker.Save(originatorObject);
originatorObject.State = "Fifth state";
caretaker.Save(originatorObject);
originatorObject.State = "Sixth state";
caretaker.Save(originatorObject);
originatorObject.State = "Seventh state";
caretaker.Save(originatorObject);

Console.WriteLine($"Originator state: {originatorObject.State}");
Console.WriteLine($"Undo state");
caretaker.Undo(originatorObject);
Console.WriteLine($"Originator state: {originatorObject.State}");
Console.WriteLine($"Revert state to 3");
caretaker.GetVersion(originatorObject,3);
Console.WriteLine($"Originator state: {originatorObject.State}");
// Wait for user's input
Console.ReadKey();