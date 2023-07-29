namespace CS_module_3;

public struct Obstacle
{
    public Obstacle(int value, ObstacleType type)
    {
        Value = value;
        Type = type;
    }
    public ObstacleType Type { get; set; }
    public int Value;
}


public enum ObstacleType
{
    Run,
    Swim,
    Jump
}