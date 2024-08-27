namespace ArrayHelpers;

public static class ArrayExtensions
{
    public static int[] Square(this int[] array)
    {
        var squareArray = new int[array.Length];

        for (var i = 0; i < array.Length; i++)
            squareArray[i] = array[i] * array[i];

        return squareArray;
    }

    public static int[] Cube(this int[] array)
    {
        var cubeArray = new int[array.Length];

        for (var i = 0; i < array.Length; i++)
            cubeArray[i] = array[i] * array[i] * array[i];

        return cubeArray;
    }

    public static double Average(this int[] array)
    {
        var sum = 0;

        for (var i = 0; i < array.Length; i++)
            sum += array[i];

        return (double)sum / array.Length;
    }

    public static int Sum(this int[] array)
    {
        var sum = 0;

        for (var i = 0; i < array.Length; i++)
            sum += array[i];

        return sum;
    }

    public static int[] Even(this int[] array)
    {
        var evenNumbersCount = 0;

        for (var i = 0; i < array.Length; i++)
        {
            if (IsNumberEven(array[i]))
                evenNumbersCount++;
        }

        var evenArray = new int[evenNumbersCount];
        var evenArrayIndex = 0;

        for (var i = 0; i < array.Length; i++)
        {
            if (IsNumberEven(array[i]))
                evenArray[evenArrayIndex++] = array[i];
        }

        return evenArray;
    }

    public static int[] Odd(this int[] array)
    {
        var oddNumbersCount = 0;

        for (var i = 0; i < array.Length; i++)
        {
            if (!IsNumberEven(array[i]))
                oddNumbersCount++;
        }

        var oddArray = new int[oddNumbersCount];
        var oddArrayIndex = 0;

        for (var i = 0; i < array.Length; i++)
        {
            if (!IsNumberEven(array[i]))
                oddArray[oddArrayIndex++] = array[i];
        }

        return oddArray;
    }

    private static bool IsNumberEven(int number) => number % 2 == 0;
}