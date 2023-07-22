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

class Cat : Animal
{
    public static uint CatCounter { get; private set; }
    
    public Cat(string name) : base(name)
    {
        CatCounter++;
    }

    public override void Run(uint distance)
    {
        if (distance <= 200)
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
        Console.WriteLine($"{Name} не умеет плавать, это же кот!");
    }

    public override void Jump(uint height)
    {
        if (height <= 2)
        {
            Console.WriteLine($"{Name} успешно прыгнул на {height} м");
        }
        else
        {
            Console.WriteLine($"{Name} не смог прыгнуть {height} м");
        }
    }
}

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
