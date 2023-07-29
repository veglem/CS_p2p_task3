namespace CS_module_3;

public class Run : IAction
{
    public Run(uint maxDistance)
    {
        MaxDistance = maxDistance;
    }

    private uint MaxDistance { get; }

    public bool Try(Obstacle obstacle)
    {
        if (obstacle.Type == ObstacleType.Run)
        {
            return obstacle.Value <= MaxDistance;
        }

        return false;
    }
}
