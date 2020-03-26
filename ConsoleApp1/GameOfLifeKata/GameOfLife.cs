using System;
using System.Text;

namespace GameOfLifeKata
{
    public class GameOfLife
    {
        int lengthX;
        int lengthY;
        bool[,] oldGrid;
        bool[,] currentGrid;
        bool[,] newGrid;

        public GameOfLife(bool[,] initialGrid)
        {
            lengthX = initialGrid.GetLength(0);
            lengthY = initialGrid.GetLength(1);
            currentGrid = initialGrid;
            newGrid = new bool[lengthX, lengthY];
            oldGrid = (bool[,]) newGrid.Clone();

            if(lengthX > 15 || lengthX < 1 || lengthY > 15 || lengthY < 1)
            {
                throw new System.Exception("Invalid Input - Dimensions Should be between 1 and 15");
            }
        }

        public string GenerateNext()
        {
            Console.WriteLine(GetOutputString());
            RunOneGeneration();
            currentGrid = (bool[,])newGrid.Clone();
            return GetOutputString();
        }

        public string GenerateAll()
        {
            Console.WriteLine(GetOutputString());
            RunUntilStable();
            return GetOutputString();
        }

        private void RunOneGeneration()
        {
            oldGrid = (bool[,])newGrid.Clone();;
            for (int i = 0; i < lengthX; i++)
            {
                for (int j = 0; j < lengthY; j++)
                {
                    EnactRules(i, j);
                }
            }
        }

        private void RunUntilStable()
        {
            while (GridHasChanged())
            {
                RunOneGeneration();
                currentGrid = (bool[,]) newGrid.Clone();
                Console.WriteLine(GetOutputString());
            }
        }

        private bool GridHasChanged()
        {
            for (int i = 0; i < lengthX; i++)
            {
                for (int j = 0; j < lengthY; j++)
                {
                    if (currentGrid[i, j] != oldGrid[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void EnactRules(int xIndex, int yIndex)
        {
            int liveNeighbours = LiveNeighbours(xIndex, yIndex);

            if (liveNeighbours < 2)
            {
                newGrid[xIndex, yIndex] = false;
            }
            else if (liveNeighbours > 3)
            {
                newGrid[xIndex, yIndex] = false;
            }
            else if (liveNeighbours == 3)
            {
                newGrid[xIndex, yIndex] = true;
            }
            else if (liveNeighbours == 2 && currentGrid[xIndex,yIndex])
            {
                newGrid[xIndex, yIndex] = true;
            }
            else
            {
                newGrid[xIndex, yIndex] = false;
            }
        }

        private int LiveNeighbours(int xIndex, int yIndex)
        {
            int liveNeighbours = 0;
            for(int x = xIndex - 1; x < xIndex + 2; x++)
            {
                for(int y = yIndex - 1; y < yIndex + 2; y++)
                {
                    if( IsValidIndex(x, y) && !(x == xIndex && y == yIndex))
                    {
                        liveNeighbours += (currentGrid[x, y]) ? 1 : 0;
                    }
                }
            }
            return liveNeighbours;
        }

        private bool IsValidIndex(int x, int y)
        {
            return (x >= 0 && y >= 0 && x < lengthX && y < lengthY);
        }

        private string ConvertGridToString()
        {
            char temp;
            StringBuilder builder = new StringBuilder();
            for(int i = 0; i < lengthX; i++)
            {
                builder.Append('\n');
                for(int j = 0; j < lengthY; j++)
                {
                    temp = (currentGrid[i, j]) ? '*' : '.';
                    builder.Append(temp);
                }
            }
            return builder.ToString();
        }

        private string GetOutputString()
        {
            return $@"{lengthX} x {lengthY}{ConvertGridToString()}";
        }
    }
}
