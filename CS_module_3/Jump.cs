namespace CS_module_3;

public class Jump : IAction
{
    public Jump(uint maxDistance)
    {
        MaxDistance = maxDistance;
    }

    private uint MaxDistance { get; }

    public bool Try(Obstacle obstacle)
    {
        if (obstacle.Type == ObstacleType.Jump)
        {
            return obstacle.Value <= MaxDistance;
        }

        return false;
    }
}