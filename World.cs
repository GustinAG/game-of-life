using System;

namespace CellGame
{
    internal class World
    {
        internal const int LinearSize = 100;
        private readonly Random _random = new Random(Guid.NewGuid().GetHashCode());
        private readonly bool[,] _cells = new bool[LinearSize, LinearSize];
        private readonly Action<int, int, bool> _cellChangedAction;

        public World(Action<int, int, bool> cellChangedAction)
        {
            _cellChangedAction = cellChangedAction;
        }

        internal void InitGame()
        {
            CleanCells();
            GenerateCells();
            TurnCount++;
        }

        internal void ExecuteCellRulesOneTurn()
        {
            bool[,] newCells = new bool[LinearSize, LinearSize];

            for (int i = 0; i < LinearSize; i++)
                for (int j = 0; j < LinearSize; j++)
                    newCells[i, j] = ApplyRulesOnCell(i, j);

            SetEachCell((i, j) => newCells[i, j]);
            TurnCount++;
        }

        internal int TurnCount { get; private set; }

        internal bool IsCellAlive(int i, int j) => _cells[i, j];

        private void GenerateCells() => SetEachCell(GenerateCell);

        private bool GenerateCell(int i, int j) => _random.Next(1, 10) < 4;

        private bool ApplyRulesOnCell(int i, int j)
        {
            int neighborCount = GetNeighborCount(i, j);
            bool existsAfter = (_cells[i, j] && neighborCount >= 2 && neighborCount <= 3) ||
                               (!_cells[i, j] && neighborCount == 3);

            if (existsAfter != _cells[i, j]) _cellChangedAction(i, j, existsAfter);

            return existsAfter;
        }

        private int GetNeighborCount(int x, int y)
        {
            var xFrom = Math.Max(0, x - 1);
            var xTo = Math.Min(LinearSize - 1, x + 1);
            var yFrom = Math.Max(0, y - 1);
            var yTo = Math.Min(LinearSize - 1, y + 1);

            int count = 0;
            for (int i = xFrom; i <= xTo; i++)
                for (int j = yFrom; j <= yTo; j++)
                    if (_cells[i, j] && !(i == x && j == y))
                        count++;

            return count;
        }

        private void CleanCells() => SetEachCell((i, j) => false);

        private void SetEachCell(Func<int, int, bool> cellFunc)
        {
            for (int i = 0; i < LinearSize; i++)
                for (int j = 0; j < LinearSize; j++)
                    _cells[i, j] = cellFunc(i, j);
        }
    }
}
