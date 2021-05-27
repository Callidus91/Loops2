using System;

namespace Loops2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowHeight = 4;
            for (int row = 1; row <= rowHeight; row++)
            {
                
                for (int j = 0; j < row; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
