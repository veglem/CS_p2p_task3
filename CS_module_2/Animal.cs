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

    public virtual void Run(uint distance)
    {
        if (distance == 0)
        {
            Console.WriteLine($"{Name} остался на месте");
        }
        else if (distance <= MaxRunDistance)
        {
            Console.WriteLine($"{Name} успешно пробежал {distance} м");
        }
        else
        {
            Console.WriteLine($"{Name} не смог пробежать {distance} м");
        }
    }

    protected uint MaxRunDistance { get; init; }

    public virtual void Swim(uint distance)
    {
        if (distance == 0)
        {
            Console.WriteLine($"{Name} остался на месте");
        }
        else if (distance <= MaxSwimDistance)
        {
            Console.WriteLine($"{Name} успешно проплыл {distance} м");
        }
        else
        {
            Console.WriteLine($"{Name} не смог прорлыть {distance} м");
        }
    }
    
    protected uint MaxSwimDistance { get; init; }

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

    public virtual void Jump(uint height)
    {
        if (height == 0)
        {
            Console.WriteLine($"{Name} остался на месте");
        }
        else if (height <= MaxJumpHeight)
        {
            Console.WriteLine($"{Name} успешно прыгнул на {height} м");
        }
        else
        {
            Console.WriteLine($"{Name} не смог прыгнуть {height} м");
        }
    }
    
    protected uint MaxJumpHeight { get; init; }
}
