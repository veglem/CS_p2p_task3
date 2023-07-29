namespace CS_module_3;

public class ArrayException : Exception
{
    public ArrayException(string message, string element) : base(message)
    {
        Element = element;
    }

    public string Element { init; get; }
    
    
}