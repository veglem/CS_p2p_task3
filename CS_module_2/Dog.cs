namespace CS_module_2;

class Dog : Animal
{
    public static uint DogCounter { get; private set; }
    
    public Dog(string name) : base(name)
    {
        DogCounter++;
    }

    public override void Run(uint distance)
    {
        base.Run(distance, 500);
    }

    public override void Swim(uint distance)
    {
        base.Swim(distance, 10);
    }

    public override void Jump(uint height)
    {
        base.Jump(height, 0);
    }
}
