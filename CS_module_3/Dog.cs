namespace CS_module_3;

class Dog : Animal
{
    public static uint DogCounter { get; private set; }
    
    public Dog(string name, List<IAction> actions) : base(name, actions)
    {
        foreach (var i in actions)
        {
            if (i.GetType() == typeof(Jump))
            {
                throw new ArgumentException("Dogs can`t jump, wrong action");
            }
        }
        DogCounter++;
    }
    
}
