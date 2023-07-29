namespace CS_module_3;

public class Course
{
    public List<Obstacle> Obstacles { private set; get; }

    public Course(List<Obstacle> obstacles)
    {
        Obstacles = obstacles;
    }

    public void OvercomeObstacles(Team team)
    {
        team.AnimalsComplitedObstacles = new List<Animal>();
        foreach (var i in team.Animals)
        {
            bool flag = true;
            foreach (var j in Obstacles)
            {
                if (!i.TryObstacle(j))
                {
                    flag = false;
                }
            }

            if (flag)
            {
                team.AnimalsComplitedObstacles.Add(i);
            }
        }
    }
}