namespace CS_module_3;

class Cat : Animal
{
    public static uint CatCounter { get; private set; }
    
    public Cat(string name, List<IAction> actions) : base(name, actions)
    {
        foreach (var i in actions)
        {
            if (i.GetType() == typeof(Swim))
            {
                throw new ArgumentException("Cats can`t swim, wrong action");
            }
        }
        CatCounter++;
    }
    
}