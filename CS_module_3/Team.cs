namespace CS_module_3;

public class Team
{
    public string Name { get; init; }

    public List<Animal> Animals;

    public List<Animal>? AnimalsComplitedObstacles = null;

    public Team(string name, List<Animal> animals)
    {
        Animals = animals;
        Name = name;
    }

    public void PrintResults()
    {
        if (AnimalsComplitedObstacles is null)
        {
            Console.WriteLine("Команда еще не прошла испытания");
        }
        else
        {
            Console.WriteLine($"В команде {Name} испытания прошли:");
            foreach (var i in AnimalsComplitedObstacles)
            {
                Console.WriteLine($"{i.Name} прошёл испытания   ");
            }
            Console.WriteLine("");
        }
    }

    public void PrintAnimals()
    {
        Console.WriteLine($"Команда {Name}:");
        foreach (var i in Animals)
        {
            Console.Write($"{i.Name}  ");
        }
        Console.WriteLine("");
    }
}