namespace CS_module_3;

public class Task2
{
    public static void DictionaryTask()
    {
        List<string> str = new List<string>()
        {
            "unique1", "unique2", "unique3",
            "not unique1", "not unique1", "not unique1",
            "not unique2", "not unique2", "unique4",
            "not unique3", "unique5", "not unique3"
        };
        
        PrintUniqueWords(str);
        Console.WriteLine("");
        PrintCountWords(str);

        Phonebook phonebook = new Phonebook();
        phonebook.AddNumber("Журмилов", "88005553535");
        phonebook.AddNumber("Журмилов", "89147240740");
        phonebook.AddNumber("Журмилов", "89147240740");
        phonebook.AddNumber("Иванов", "89240000000");
        Console.Write("Журмилов: ");
        foreach (var i in phonebook.GetNumbers("Журмилов"))
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine("");
    }

    static void PrintUniqueWords(IEnumerable<string> collection)
    {
        var dictionary = CountWords(collection);
        foreach (var i in dictionary)
        {
            if (i.Value == 1)
            {
                Console.WriteLine($"Уникальный элемент: {i.Key}");
            }
        }
    }

    static void PrintCountWords(IEnumerable<string> collection)
    {
        var dictionary = CountWords(collection);
        foreach (var i in dictionary)
        {
            Console.WriteLine($"{i.Key} : {i.Value}");
        }
    }
    
    static Dictionary<string, int> CountWords(IEnumerable<string> collection)
    {
        Dictionary<string, int> result = new Dictionary<string, int>();
        foreach (var i in collection)
        {
            result[i] = result.ContainsKey(i) ? result[i] + 1 : 1;
        }

        return result;
    }
}