//Derived class
public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says : Woof Woof!");
    }
}