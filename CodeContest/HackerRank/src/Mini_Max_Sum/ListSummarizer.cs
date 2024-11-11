namespace Mini_Max_Sum;

public static class ListSummarizer
{
    public static void PrintMinAndMaxSumOf4Numbers(List<long> numberList)
    {
        var minNumber = numberList[0];
        var maxNumber = numberList[0];
        var sum = (long)0;

        for (var i = 0; i < numberList.Count; i++)
        {
            var currentNumber = numberList[i];

            if (currentNumber < minNumber)
                minNumber = currentNumber;

            if (currentNumber > maxNumber)
                maxNumber = currentNumber;

            sum += currentNumber;
        }

        var maxSum = sum - minNumber;
        var minSum = sum - maxNumber;

        Console.Write($"{minSum} {maxSum}");
    }
}