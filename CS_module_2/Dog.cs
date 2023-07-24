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
        if (distance <= 500)
        {
            Console.WriteLine($"{Name} успешно пробежал {distance} м");
        }
        else
        {
            Console.WriteLine($"{Name} не смог пробежать {distance} м");
        }
    }

    public override void Swim(uint distance)
    {
        if (distance <= 10)
        {
            Console.WriteLine($"{Name} успешно проплыл {distance} м");
        }
        else
        {
            Console.WriteLine($"{Name} не смог прорлыть {distance} м");
        }
    }

    public override void Jump(uint height)
    {
        Console.WriteLine($"{Name} не умеет прыгать, это же собака!");
    }
}
