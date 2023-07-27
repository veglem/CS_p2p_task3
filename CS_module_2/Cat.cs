namespace CS_module_2;

class Cat : Animal
{
    public static uint CatCounter { get; private set; }
    
    public Cat(string name) : base(name)
    {
        MaxRunDistance = 200;
        MaxJumpHeight = 2;
        CatCounter++;
    }

    public override void Swim(uint distance)
    {
        Console.WriteLine($"{Name} не умеет плавать, это же кот!");
    }
}
