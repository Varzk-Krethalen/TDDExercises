using NUnit.Framework;
using System;

namespace GameOfLifeKata
{
    [TestFixture]
    public class GameOfLifeTests
    {
        [Test]
        public void GameOfLife_DoesNotThrowExceptions_OnCorrectInstantiation()
        {
            bool[,] grid = new bool[1,1];
            Assert.DoesNotThrow(() => new GameOfLife(grid));
        }

        [Test]
        public void GameOfLife_ThrowsExceptions_OnDimensionOfZero()
        {
            bool[,] grid = new bool[0, 1];
            Assert.Throws<Exception>(() => new GameOfLife(grid));
        }

        [Test]
        public void GameOfLife_ThrowsExceptions_OnDimensionOver15()
        {
            bool[,] grid = new bool[1, 21];
            Assert.Throws<Exception>(() => new GameOfLife(grid));
        }

        [Test]
        public void GenerateNext_ShouldReturnDimensions()
        {
            bool[,] grid = new bool[5, 5];
            GameOfLife game = new GameOfLife(grid);
            StringAssert.Contains("5 x 5", game.GenerateNext());
        }

        [Test]
        public void GenerateNext_ShouldReturnDifferentDimensions()
        {
            bool[,] grid = new bool[7, 3];
            GameOfLife game = new GameOfLife(grid);
            StringAssert.Contains("7 x 3", game.GenerateNext());
        }

        [Test]
        public void GenerateNext_ShouldReturnAValidGrid()
        {
            bool[,] grid = new bool[3, 3];
            GameOfLife game = new GameOfLife(grid);
            StringAssert.Contains("3 x 3\n...\n...\n...", game.GenerateNext());
        }

        [Test]
        public void GenerateNext_ShouldReturnAValidGrid_ForDifferentInput()
        {
            bool[,] grid = new bool[4, 2];
            GameOfLife game = new GameOfLife(grid);
            StringAssert.Contains("4 x 2\n..\n..\n..\n..", game.GenerateNext());
        }

        [Test]
        public void GenerateNext_ShouldReturnAValidGrid_WithLiveCellsInput()
        {
            bool[,] grid = new bool[4, 4];
            grid[1, 1] = grid[1,2] = grid[2,1] = grid[2,2] = true;
            GameOfLife game = new GameOfLife(grid);
            StringAssert.Contains("4 x 4\n....\n.**.\n.**.\n....", game.GenerateNext());
        }

        [Test]
        public void GenerateNext_ShouldReturnValidGridFromInput_IfNotStable()
        {
            bool[,] grid = new bool[3, 3];
            grid[1, 1] = true;
            GameOfLife game = new GameOfLife(grid);
            StringAssert.Contains("3 x 3\n...\n...\n...", game.GenerateNext());
        }

        [Test]
        public void GenerateNext_ShouldReturnAValidGridFromDifferentInput_IfNotStable()
        {
            bool[,] grid = new bool[4, 4];
            grid[1, 2] = grid[2, 1] = grid[2, 2] = true;
            GameOfLife game = new GameOfLife(grid);
            StringAssert.Contains("4 x 4\n....\n.**.\n.**.\n....", game.GenerateNext());
        }

        [Test]
        public void GenerateAll_ShouldReturnACorrectStableGrid()
        {
            bool[,] grid = new bool[15, 15];
            grid[6,7] = grid[7,6] = grid[7,7] = grid[7,8] = grid[8,6] = grid[8,8] = grid[9,7] = true;
            GameOfLife game = new GameOfLife(grid);
            StringAssert.Contains(
                "15 x 15" +
                "\n..............." +
                "\n.......*......." +
                "\n......*.*......" +
                "\n......*.*......" +
                "\n.......*......." +
                "\n..............." +
                "\n..**.......**.." +
                "\n.*..*.....*..*." +
                "\n..**.......**.." +
                "\n..............." +
                "\n.......*......." +
                "\n......*.*......" +
                "\n......*.*......" +
                "\n.......*......." +
                "\n...............", 
                game.GenerateAll());
        }
    }
}
