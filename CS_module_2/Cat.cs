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
