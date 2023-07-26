namespace CS_module_2;

class Cat : Animal
{
    public static uint CatCounter { get; private set; }
    
    public Cat(string name) : base(name)
    {
        CatCounter++;
    }

    public override void Run(uint distance)
    {
        base.Run(distance, 200);
    }

    public override void Swim(uint distance)
    {
        base.Swim(distance, 0);
    }

    public override void Jump(uint height)
    {
        base.Jump(height, 2);
    }
}
