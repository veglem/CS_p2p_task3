using System.Collections;

namespace CS_module_3;

public class Task0
{
    public static void Collections()
    {
        List<int> collection = new List<int>(10);
        for (int i = 0; i < 10; ++i)
        {
            collection.Add(i);
        }
        
        collection.Add(collection.Count());
        Console.WriteLine($"Элемент, добавленный в конец: {collection[collection.Count() - 1]}");
        PrintCollection(collection);
        
        collection.Insert(0, collection[0] - 1);
        Console.WriteLine($"Элемент, добавленный в начало: {collection[0]}");
        PrintCollection(collection);
        
        collection.Insert(new Random().Next(1, collection.Count() - 2), 100);
        Console.WriteLine($"Добавлен элемент \"100\" на позицию {collection.IndexOf(100)}");
        PrintCollection(collection);
        
        collection.RemoveAt(collection.Count - 1);
        Console.WriteLine("Удалён последний элемент");
        PrintCollection(collection);
        
        collection.RemoveAt(0);
        Console.WriteLine("Удалён первый элемент");
        PrintCollection(collection);

        collection.RemoveAt(5);
        Console.WriteLine("Удалён пятый элемент");
        PrintCollection(collection);

        List<int> toAdd = new List<int>(4) { 21, 22, 23, 24 };
        
        collection.AddRange(toAdd);
        Console.WriteLine("Добавлена вторая коллекция");
        PrintCollection(collection);
    
        Console.WriteLine($"Максимальный элемент: {collection.Max()}");
        
        DeleteAllFromCollection(collection, i => i % 2 == 0);
        PrintCollection(collection);
        
        ModifyCollection(collection, i => i * i);
        PrintCollection(collection);

        int sum = 0;
        foreach (var i in collection)
        {
            sum += i;
        }
        Console.WriteLine($"Сумма элементов массива: {sum}");
        
        long mul = 1;
        foreach (var i in collection)
        {
            mul *= i;
        }
        Console.WriteLine($"Произведение элементов массива: {mul}");
    }
    
    static void PrintCollection(IEnumerable collection)
    {
        foreach (var i in collection)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine("");
    }

    static void DeleteAllFromCollection<T>(List<T> list, Predicate<T> predicate)
    {
        for (int i = 0; i < list.Count; ++i)
        {
            if (predicate(list[i]))
            {
                list.RemoveAt(i);
                --i;
            }
        }
    }

    static void ModifyCollection<T>(List<T> list, Func<T, T> func)
    {
        for (int i = 0; i < list.Count; ++i)
        {
            list[i] = func(list[i]);
        }
    }
}