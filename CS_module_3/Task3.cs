namespace CS_module_3;

public class Task3
{
    public static void Interface()
    {

        var course = new Course(new List<Obstacle>()
        {
            new Obstacle(100, ObstacleType.Run),
            new Obstacle(200, ObstacleType.Run),
            new Obstacle(5, ObstacleType.Swim)
        });

        var team = new Team("Питомцы", new List<Animal>()
        {
            new Cat("Пушистик", new List<IAction>() { new Run(250), new Jump(10) }),
            new Dog("Шарик", new List<IAction>() { new Run(250), new Swim(20) }),
            new Dog("Бобик", new List<IAction>() { new Run(300), new Swim(15) })
        });
        
        course.OvercomeObstacles(team);
        
        team.PrintAnimals();
        team.PrintResults();
    }
}