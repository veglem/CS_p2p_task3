namespace CS_module_2;

class Dog : Animal
{
    public static uint DogCounter { get; private set; }
    
    public Dog(string name) : base(name)
    {
        MaxRunDistance = 500;
        MaxSwimDistance = 10;
        DogCounter++;
    }

    public override void Jump(uint height)
    {
        Console.WriteLine($"{Name} не умеет прыгать, это же собака!!");
    }
}
