using Mini_Max_Sum;

var numberList = Console.ReadLine()?
                        .TrimEnd()
                        .Split(' ')
                        .Select(arrTemp => Convert.ToInt64(arrTemp))
                        .ToList() ?? new();

ListSummarizer.PrintMinAndMaxSumOf4Numbers(numberList);