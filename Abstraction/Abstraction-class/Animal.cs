//Abstract Class (Cannot be instantiated)
public abstract class Animal
{
    public string Name {get;set;}

    //Abstract Method (must be implemented by subclasses)
    public abstract void MakeSound();
}