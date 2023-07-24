namespace CS_module_1;

public class Tasks
{
    private static Random _generator = new Random();

    // Task 2
    public static void PrintThreeWords()
    {
        Console.WriteLine("Hello\n" +
                          "Dear\n" +
                          "Friend");
    }

    // Task 3
    public static void PrintSignOfSum()
    {
        int a = _generator.Next(-10, 10);
        Console.WriteLine($"a = {a}");
        int b = _generator.Next(-10, 10);
        Console.WriteLine($"b = {b}");
        Console.WriteLine(a + b >= 0 ? "Сумма положительная" : "Сумма отрицательная");
    }

    // Task 4
    public static void PrintValueRange()
    {
        int value = _generator.Next(-100, 200);
        Console.WriteLine($"value = {value}");
        if (value < 0)
        {
            Console.WriteLine("Отрицательное число");
        }
        else if (value < 100)
        {
            Console.WriteLine("Положительное число в диапазоне от 0 до 99");
        }
        else if (value > 100) // Стоит else if т.к. нужно отсеить ситуацию когда value == 100
        {
            Console.WriteLine("Положительное число, большее 100");
        }
    }

    // Task 5
    public static void CompareTwoNumbers()
    {
        int a = _generator.Next(-10, 10);
        Console.WriteLine($"a = {a}");
        int b = _generator.Next(-10, 10);
        Console.WriteLine($"b = {b}");
        if (a < b)
        {
            Console.WriteLine("Число a меньше числа b");
        }
        else if (a > b)
        {
            Console.WriteLine("Число a больше числа b");
        }
        else
        {
            Console.WriteLine("Число a равно числу b");
        }
    }

    // Task 6
    public static bool IsNumInRange(int a, int b)
    {
        // return a + b >= 1 && a + b <= 10; Так должно быть быстрее
        return Enumerable.Range(1, 10).Contains(a + b); // А это мне нравится с точки зрения читаемости
    }

    // Task 7
    public static void PrintSignInfo(int value)
    {
        if (int.IsNegative(value))
        {
            Console.WriteLine("Число со знакоми `-`");
        }
        else if (value == 0)
        {
            Console.WriteLine("Число равно 0");
        }
        else
        {
            Console.WriteLine("Число со знакоми `+`");
        }
    }

    // Task 8
    public static bool IsNumPositive(int value)
    {
        // return value >= 0; 
        return int.IsPositive(value); // Т.к. синтаксис языка позволяет решил сделать так
    }

    // Task 9
    public static void PrintStringNTimes(string str, uint n)
    {
        while (n != 0)
        {
            Console.WriteLine(str);
            --n;
        }
    }

    // Task 10
    public static void PrintIntAsShort(int value)
    {
        // Т.к. пробрасывается стандартное исключение и оно сразу обрабатывается в методе, не ломая программу,
        // посчитал правильным использовать тут исключение
        try
        {
            short shortedValue = checked((short)value);
            Console.WriteLine(shortedValue);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    // Task 11
    public static void PrintByteAsInt(byte value)
    {
        int extendedValue = value;
        Console.WriteLine(extendedValue);
    }

    // Task 12
    // Функция-обертка для отсева невалидных дат
    public static void PrintLeapYear(short year)
    {
        if (Enumerable.Range(-45, DateTime.Now.Year + 46).Contains(year))
        {
            Console.WriteLine(IsLeapYear(year) ? "Год високосный" : "Год не високосный");
        }
        else if (year > DateTime.Now.Year)
        {
            Console.WriteLine("Поживем - увидим");
        }
        else
        {
            Console.WriteLine("Число не является годом");
        }
    }

    // Функция проверки собственной персоной
    public static bool IsLeapYear(short year)
    {
        return year % 4 == 0 && year % 100 != 0 || year % 4 == 0;
    }

    // Task 13
    public static void InvertArray(int[] array)
    {
        // В случае если массив не соответствует требованиям - не произвожу изменений в нем
        foreach (var i in array)
        {
            if (i != 0 && i != 1)
            {
                return;
            }
        }

        for (uint i = 0; i < array.Length; ++i)
        {
            array[i] = array[i] == 0 ? 1 : 0;
        }
    }

    // Task 14
    public static void
        FillArrayWithNElements(ref int[] array, int n) // передаю по ссылке тк старые данные перезаписываются
        // и в противном случае память не выделяется
    {
        if (n <= 0)
        {
            return;
        }

        // array = new int[n];
        // while (n > 0)
        // {
        //     array[array.Length - n] = array.Length - n;
        //     --n;
        // }
        array = Enumerable.Range(1, n).ToArray(); // Так компактнее и понятнее))
    }

    // Task 15
    public static void ModifyArray(int[] array)
    {
        for (var i = 0; i < array.Length; i++)
        {
            if (array[i] < 6)
            {
                array[i] *= 2;
            }
        }
    }

    // Task 16
    public static void FillTwoDemArray(int[,] array)
    {
        // Не квадратные матрицы не меняются
        if (array.GetUpperBound(0) != array.GetUpperBound(1))
        {
            return;
        }

        // Не сразу догадался, но теперь эта штука работает линейно (в прошлых коммитах было n^2)
        for (uint i = 0; i <= array.GetUpperBound(0); ++i)
        {
            array[i, i] = 1;
            array[i, array.GetUpperBound(0) - i] = 1;
        }
    }

    // Task 17
    public static int[] CreateArray(int length, int initialValue)
    {
        if (length <= 0)
        {
            return new int[0];
        }

        int[] array = new int[length];
        for (uint i = 0; i < array.Length; ++i)
        {
            array[i] = initialValue;
        }

        return array;
    }

    // Task 18
    public static void PrintMinMaxInArray(int[] array)
    {
        // Мой старый вариант, тоже рабочий
        int? min = null;
        int? max = null;
        foreach (var i in array)
        {
            if (i > max || max is null)
            {
                max = i;
            }
        
            if (i < min || min is null)
            {
                min = i;
            }
        }
        
        Console.WriteLine("Min: " + (min is null ? "Underfined" : min));
        Console.WriteLine("Max: " + (max is null ? "Underfined" : max));

        // Эту штуку я услышал на p2p, выриант хороший, но не мой, от меня тут только исключения))
        // try
        // {
        //     Console.WriteLine("Min: " + array.Min());
        //     Console.WriteLine("Max: " + array.Max());
        // }
        // catch (InvalidOperationException ex)
        // {
        //     Console.WriteLine(ex.Message);
        // }
    }

    // Task 19
    public static bool IsLefRightSumEqual(int[] array)
    {
        // Решил методом сканирующей прямой
        int[] leftSum = new int[array.Length];
        int[] rightSum = new int[array.Length];
        for (int i = 0; i < array.Length; ++i)
        {
            leftSum[i] = i == 0 ? array[i] : array[i] + leftSum[i - 1];
            rightSum[array.Length - 1 - i] = i == 0
                ? array[array.Length - 1]
                : array[array.Length - 1 - i] + rightSum[array.Length - i];
        }

        for (int i = 0; i < leftSum.Length - 1; ++i)
        {
            if (leftSum[i] == rightSum[i + 1])
            {
                return true;
            }
        }

        return false;
    }

    // Task 20
    public static void ShiftArrayOnN(int[] array, int n)
    {
        // Алгоритм работает за o(n) :)
        if (n == 0 || array.Length == 0)
        {
            return;
        }

        n %= array.Length;
        if (int.IsNegative(n))
        {
            n = array.Length + n;
        }

        int counter = 0;
        int temp = array[0];
        int iter = 0;
        int beginIndex = 0;
        do
        {
            Swap(ref temp, ref array[(iter + n) % array.Length]);
            iter = (iter + n) % array.Length;
            ++counter;
            if (iter == beginIndex && counter < array.Length)
            {
                ++beginIndex;
                temp = array[beginIndex];
                iter = beginIndex;
            }
        } while (counter < array.Length);
    }

    static void Swap<T>(ref T lhs, ref T rhs)
    {
        T temp;
        temp = lhs;
        lhs = rhs;
        rhs = temp;
    }
}
