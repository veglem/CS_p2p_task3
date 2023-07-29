namespace CS_module_3;

public class Swim : IAction
{
    public Swim(uint maxDistance)
    {
        MaxDistance = maxDistance;
    }

    private uint MaxDistance { get; }

    public bool Try(Obstacle obstacle)
    {
        if (obstacle.Type == ObstacleType.Swim)
        {
            return obstacle.Value <= MaxDistance;
        }

        return false;
    }
}