namespace CS_module_2;

abstract class Animal
{
    public string Name { get; set; }

    public static uint Counter { get; private set; }

    protected Animal(string name)
    {
        Name = name;
        Counter++;
    }

    public abstract void Run(uint distance);
    
    public abstract void Swim(uint distance);
    
    public abstract void Jump(uint height);
}
