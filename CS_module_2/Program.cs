using CS_module_2;

class Program
{
    static void Main(string[] args)
    {
        // Task 1 test
        Random generator = new Random();
        Employee[] workers = new Employee[]{};
        Array.Resize(ref workers, 30);
        for (int i = 0; i < 30; ++i)
        {
            workers[i] = new Employee(_firstNames[generator.Next(0, 4)],
                _surnames[generator.Next(0, 4)],
                _middleNames[generator.Next(0, 4)],
                _positions[generator.Next(0, 2)],
                null,
                $"+7-924-{generator.Next(0, 9)}{generator.Next(0, 9)}{generator.Next(0, 9)}-07-40",
                (uint)generator.Next(1000, 1000000),
                (byte)generator.Next(18, 60));
        }

        foreach (var person in workers)
        {
            if (person.Age > 30)
            {
                Console.WriteLine(person.Report() + "\n");
            }
        }
        // Task 2 test
        Animal[] animals = new Animal[3];
        animals[0] = new Cat("Барсик");
        animals[1] = new Dog("Шарик");
        animals[2] = new Cat("Пушистик");
        Console.WriteLine("Спортивные испытания домашних питомцев");
        foreach (var i in animals)
        {
            Console.WriteLine("Испытания проходит" + (i is Cat ? " кот " : " пёс ") + i.Name);
            i.Run(180);
            i.Run(250);
            i.Run(520);
            i.Swim(5);
            i.Swim(15);
            i.Jump(1);
            i.Jump(3);
            Console.WriteLine("");
        }
        Console.WriteLine($"Всего участников было {Animal.Counter}, {Cat.CatCounter} котов и {Dog.DogCounter} собак");
    }

    static string[] _firstNames = new string[] { "Артём", "Михаил", "Александр", "Дмитрий", "Иван"};
    static string[] _surnames = new string[] { "Иванов", "Смирнов", "Кузнецов", "Попов", "Петров"};
    static string[] _middleNames = new string[] { "Артёмович", "Михаилович", "Александрович", "Дмитриевич", "Иванович"}; 
    static string[] _positions = new string[] { "Frontend dev", "Backend dev", "Mobile dev" };
}
