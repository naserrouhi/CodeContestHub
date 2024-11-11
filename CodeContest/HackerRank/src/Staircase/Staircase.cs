namespace Staircase;

public static class Staircase
{
    public static void Print(int size)
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