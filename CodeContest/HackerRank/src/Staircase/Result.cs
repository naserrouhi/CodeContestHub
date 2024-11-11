namespace Staircase;

public class Result
{
    public static void PrintStaircase(int size)
    {
        for (var i = 1; i <= size; i++)
        {
            for (var j = 1; j <= size; j++)
            {
                if (j <= size - i)
                    Console.Write(' ');
                else
                    Console.Write('#');
            }

            Console.WriteLine();
        }
    }
}