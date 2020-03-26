using System;

namespace GameOfLifeKata
{
    class Program
    {
        public static void Main(string[] args)
        {
            //int inputX = int.Parse(Console.ReadLine());
            //int inputY = int.Parse(Console.ReadLine());
            Console.WriteLine("Generating board...");
            bool[,] grid = new bool[15, 15];
            grid[6, 7] = grid[7, 6] = grid[7, 7] = grid[7, 8] = grid[8, 6] = grid[8, 8] = grid[9, 7] = true;
            
            GameOfLife game = new GameOfLife(grid);// new bool[inputX, inputY]);
            Console.WriteLine(game.GenerateAll());
            Console.ReadKey();
        }

    }
}
