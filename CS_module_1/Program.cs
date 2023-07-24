using CS_module_1;

Console.WriteLine("==Task 2==");
Tasks.PrintThreeWords();

Console.WriteLine("==Task 3==");
Tasks.PrintSignOfSum();
Tasks.PrintSignOfSum();
Tasks.PrintSignOfSum();

Console.WriteLine("==Task 4==");
Tasks.PrintValueRange();
Tasks.PrintValueRange();
Tasks.PrintValueRange();

Console.WriteLine("==Task 5==");
Tasks.CompareTwoNumbers();
Tasks.CompareTwoNumbers();
Tasks.CompareTwoNumbers();

Console.WriteLine("==Task 6==");
Console.WriteLine("For `-1 and `-2`: " + Tasks.IsNumInRange(-1, -2));
Console.WriteLine("For `5` and `3`: " + Tasks.IsNumInRange(5, 3));

Console.WriteLine("==Task 7==");
Tasks.PrintSignInfo(-1);
Tasks.PrintSignInfo(1);
Tasks.PrintSignInfo(0);

Console.WriteLine("==Task 8==");
Console.WriteLine("For `0`: " + Tasks.IsNumPositive(0));
Console.WriteLine("For `-1`: " + Tasks.IsNumPositive(-1));
Console.WriteLine("For `1`: " + Tasks.IsNumPositive(1));

Console.WriteLine("==Task 9==");
Tasks.PrintStringNTimes("Hidden string", 0);
Tasks.PrintStringNTimes("visible string", 3);

Console.WriteLine("==Task 10==");
Tasks.PrintIntAsShort(100);
Tasks.PrintIntAsShort(100000);

Console.WriteLine("==Task 11==");
Tasks.PrintByteAsInt(100);

Console.WriteLine("==Task 12==");
Tasks.PrintLeapYear(-46);
Tasks.PrintLeapYear(2000);
Tasks.PrintLeapYear(2001);
Tasks.PrintLeapYear(2024);

Console.WriteLine("==Task 13==");
{
    int[] arr = { 1, 1, 1, 1, 0, 0, 0, 0 };
    Tasks.InvertArray(arr);
    foreach (var i in arr)
    {
        Console.Write(i + " ");
    }

    Console.WriteLine('\n');
}

{
    int[] arr = { 1, 1, 1, 1, 3, 0, 0, 0 };
    Tasks.InvertArray(arr);
    foreach (var i in arr)
    {
        Console.Write(i + " ");
    }

    Console.WriteLine('\n');
}


Console.WriteLine("==Task 14==");
{
    int[] arr = { 4, 3, 2, 1 };
    foreach (var i in arr)
    {
        Console.Write(i + " ");
    }

    Console.WriteLine('\n');
    Tasks.FillArrayWithNElements(ref arr, 5);
    foreach (var i in arr)
    {
        Console.Write(i + " ");
    }

    Console.WriteLine('\n');
}

Console.WriteLine("==Task 15==");
{
    int[] arr = { 4, 5, 6, 7, 8 };
    foreach (var i in arr)
    {
        Console.Write(i + " ");
    }

    Console.WriteLine('\n');
    Tasks.ModifyArray(arr);
    foreach (var i in arr)
    {
        Console.Write(i + " ");
    }

    Console.WriteLine('\n');
}

Console.WriteLine("==Task 16==");
{
    int[,] arr = new int[5, 5];
    Tasks.FillTwoDemArray(arr);
    for (int i = 0; i < arr.GetUpperBound(0) + 1; ++i)
    {
        for (int j = 0; j < arr.GetUpperBound(1) + 1; ++j)
        {
            Console.Write(arr[i, j] + " ");
        }

        Console.Write("\n");
    }
}

Console.WriteLine("==Task 17==");
{
    int[] arr = Tasks.CreateArray(5, 8);
    foreach (var i in arr)
    {
        Console.Write(i + " ");
    }

    Console.Write("\n");
}
{
    int[] arr = Tasks.CreateArray(0, 8);
    foreach (var i in arr)
    {
        Console.Write(i + " ");
    }

    Console.Write("\n");
}

Console.WriteLine("==Task 18==");
{
    int[] arr = { 3, 5, 4, 6, 9, 7, 8 };
    Tasks.PrintMinMaxInArray(arr);
}
{
    int[] arr = { };
    Tasks.PrintMinMaxInArray(arr);
}

Console.WriteLine("==Task 19==");
{
    int[] arr = { 2, 2, 2, 1, 2, 2, 10, 1 };
    Console.WriteLine(Tasks.IsLefRightSumEqual(arr));
}
{
    int[] arr = { 1, 1, 1, 2, 1 };
    Console.WriteLine(Tasks.IsLefRightSumEqual(arr));
}
{
    int[] arr = { 1, 1, 1, 3, 1 };
    Console.WriteLine(Tasks.IsLefRightSumEqual(arr));
}

Console.WriteLine("==Task 20==");
{
    int[] testArray = { 1, 2, 3, 4, 5, 6 };
    Tasks.ShiftArrayOnN(testArray, 2);
    foreach (int i in testArray)
    {
        Console.Write(i + " ");
    }

    Console.Write("\n");
}
{
    int[] testArray = { 1, 2, 3, 4, 5, 6, 7 };
    Tasks.ShiftArrayOnN(testArray, -3);
    foreach (int i in testArray)
    {
        Console.Write(i + " ");
    }

    Console.Write("\n");
}
{
    int[] testArray = { 1, 2, 3, 4, 5, 6, 7, 8 };
    Tasks.ShiftArrayOnN(testArray, -10);
    foreach (int i in testArray)
    {
        Console.Write(i + " ");
    }

    Console.Write("\n");
}
{
    int[] testArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    Tasks.ShiftArrayOnN(testArray, -3);
    foreach (int i in testArray)
    {
        Console.Write(i + " ");
    }

    Console.Write("\n");
}
