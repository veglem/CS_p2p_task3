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

    protected void Run(uint distance, uint maxDistance)
    {
        if (distance == 0)
        {
            Console.WriteLine($"{Name} остался на месте");
        }
        else if (distance <= maxDistance)
        {
            Console.WriteLine($"{Name} успешно пробежал {distance} м");
        }
        else
        {
            Console.WriteLine($"{Name} не смог пробежать {distance} м");
        }
    }

    public abstract void Swim(uint distance);

    protected void Swim(uint distance, uint maxDistance)
    {
        if (distance == 0)
        {
            Console.WriteLine($"{Name} остался на месте");
        }
        else if (maxDistance == 0)
        {
            Console.WriteLine($"{Name} не умеет плавать");
        }
        else if (distance <= maxDistance)
        {
            Console.WriteLine($"{Name} успешно проплыл {distance} м");
        }
        else
        {
            Console.WriteLine($"{Name} не смог прорлыть {distance} м");
        }
    }
    
    public abstract void Jump(uint height);

    protected void Jump(uint height, uint maxHeight)
    {
        if (height == 0)
        {
            Console.WriteLine($"{Name} остался на месте");
        }
        else if (maxHeight == 0)
        {
            Console.WriteLine($"{Name} не умеет прыгать");
        }
        else if (height <= maxHeight)
        {
            Console.WriteLine($"{Name} успешно прыгнул на {height} м");
        }
        else
        {
            Console.WriteLine($"{Name} не смог прыгнуть {height} м");
        }
    }
}
