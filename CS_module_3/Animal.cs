namespace CS_module_3;

public abstract class Animal
{
    public string Name { get; set; }

    public static uint Counter { get; private set; }

    protected Animal(string name, List<IAction> actions)
    {
        Dictionary<Type, int> actionsCount = new Dictionary<Type, int>();
        foreach (var i in actions)
        {
            actionsCount[i.GetType()] = actionsCount.ContainsKey(i.GetType()) ? actionsCount[i.GetType()] + 1 : 1;
            if (actionsCount[i.GetType()] != 1)
            {
                throw new ArgumentException("too much actions for one animal");
            }
        }

        Actions = actions;
        Name = name;
        Counter++;
    }

    protected List<IAction> Actions;

    public bool TryObstacle(Obstacle obstacle)
    {
        foreach (var i in Actions)
        {
            if (i.Try(obstacle))
            {
                return true;
            }
        }

        return false;
    }
    
}