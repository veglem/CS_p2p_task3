namespace CS_module_3;

public class Task1
{
    public static void Exceptions()
    {
        
        
        List<string> strToInt = new List<string>() { "1    ", "2    ", "11   ", "12   ", "13   " };
        try
        {
            Console.WriteLine($"Сумма элементов = {CastAndSum(strToInt)}");
            strToInt.Remove("13   ");
            strToInt.Add("n num");
            Console.WriteLine($"Сумма элементов = {CastAndSum(strToInt)}");
        }
        catch (ArrayException ex)
        {
            Console.WriteLine($"{ex.Message} in element: {ex.Element}");
        }
        try
        {
            strToInt.Remove("n num");
            strToInt.Add("10000000000");
            Console.WriteLine($"Сумма элементов = {CastAndSum(strToInt)}");
        }
        catch (ArraySizeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static int CastAndSum(IEnumerable<string> array)
    {
        uint count = 0;
        int sum = 0;
        foreach (var i in array)
        {
            if (i.Count() != 5)
            {
                throw new ArraySizeException("Wrong size");
            }
            try
            {
                sum += Convert.ToInt32(i);
            }
            catch (FormatException)
            {
                throw new ArrayException("Wrong format", i);
            }
            ++count;
        }

        if (count != 5)
        {
            throw new ArraySizeException("Wrong size");
        }
        return sum;
    }
}