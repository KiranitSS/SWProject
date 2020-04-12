using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipsWar.Model;

namespace BLL

{
    public class Game
    {
        readonly int fieldSize = 10;        

       Random random = new Random();
       public  Field enemyField = new Field();
       public  Field playerField = new Field();

        public Game()
        {

        }

        //    public void GameStart()
        //    {
        //        this.CreateEnemyField(enemyField);
        //        this.DrawEnemyField();
        //        this.CreatePlayerField(playerField);
        //        this.DrawField(50, 50, playerField);
        //    }

        //    private void CreatePlayerField(Field field)
        //    {

        //    }
        //    private void EnemyWarLogics() { }
        //    private void Fire() { }
        //    private void EndOfTurn() { }

        //    private void CreateEnemyField(Field field)
        //    {
        //        CreateEmptyField(field);
        //        ArrangeShips();
        //    }

        //    private void CreateEmptyField(Field field)
        //    {
        //        for (int x = 1; x <= 10; x++)
        //        {
        //            for (int y = 1; y <= 10; y++)
        //            {
        //                Cell cell = new Cell(x, y);
        //                cell.Type = CellType.Sea;
        //                field.Add(cell);
        //            }
        //        }
        //    }

        //    private void ArrangeShips()
        //    {
        //        //Random random = new Random();
        //        //int x = random.Next(1, 10);
        //        //int y = random.Next(1, 10);
        //        //Cell found = field.Cells.Find(cell => cell.X == x && cell.Y == y);
        //        //found.Type = CellType.Ship;
        //    }

        //    /* private void CreateShip()
        //     {
        //         int x = random.Next(1, 10);
        //         int y = random.Next(1, 10);
        //         Cell found = field.Cells.Find(cell => cell.X == x && cell.Y == y);
        //         found.Type = CellType.Ship;
        //     }
        //     */

        //    private List<Direction> GetAvailbleDirections(int x, int y, int shipSize)
        //    {
        //        List<Direction> avaibleDirections = new List<Direction>();
        //        if (x - shipSize >= 0)
        //        {
        //            avaibleDirections.Add(Direction.West);
        //        }
        //        if ((this.fieldSize - x) + 1 >= shipSize)
        //        {
        //            avaibleDirections.Add(Direction.East);
        //        }
        //        if (y - shipSize >= 0)
        //        {
        //            avaibleDirections.Add(Direction.North);
        //        }
        //        if ((this.fieldSize - y) + 1 >= shipSize)
        //        {
        //            avaibleDirections.Add(Direction.South);
        //        }
        //        return avaibleDirections;
        //    }
        //    private bool CheckBounderies(int x, int y, int shipSize)
        //    {
        //        bool canPut = true;
        //        if ((x - shipSize < 0) || ((x + shipSize) - 1 > 10) || (y - shipSize < 0) || ((y + shipSize) - 1 > 10))
        //        {
        //            canPut = false;
        //        }

        //        return canPut;

        //    }
        //    private List<Direction> GetDirections(int x, int y, Field field, int shipSize)
        //    {
        //        List<Direction> directions = new List<Direction>();

        //        Cell cell;
        //        CellType cellType;

        //        for (int i = x; i < shipSize - 1; i++)
        //        {
        //            cell = field.Cells.Find(c => c.X == i && c.Y == y);
        //            cellType = cell.Type;

        //            if (cellType == CellType.Ship)
        //            {
        //                break;
        //            }
        //            if ((i == shipSize - 1))
        //            {
        //                directions.Add(Direction.East);
        //            }
        //        }

        //        for (int i = x; i > x - shipSize; i--)
        //        {
        //            cell = field.Cells.Find(c => c.X == i && c.Y == y);
        //            cellType = cell.Type;

        //            if (cellType == CellType.Ship)
        //            {
        //                break;
        //            }
        //            if ((i == x - shipSize))
        //            {
        //                directions.Add(Direction.West);
        //            }
        //        }

        //        for (int i = y; i < shipSize - 1; i++)
        //        {
        //            cell = field.Cells.Find(c => c.X == x && c.Y == i);
        //            cellType = cell.Type;

        //            if (cellType == CellType.Ship)
        //            {
        //                break;
        //            }
        //            if ((i == shipSize - 1))
        //            {
        //                directions.Add(Direction.South);
        //            }
        //        }
        //        for (int i = y; i < y - shipSize; i--)
        //        {
        //            cell = field.Cells.Find(c => c.X == x && c.Y == i);
        //            cellType = cell.Type;

        //            if (cellType == CellType.Ship)
        //            {
        //                break;
        //            }
        //            if ((i == y - shipSize))
        //            {
        //                directions.Add(Direction.North);
        //            }
        //        }
        //        return directions;
        //    }



        //    private Direction GetRandomDirection(int x, int y, int shipSize)
        //    {
        //        List<Direction> directions = GetAvailbleDirections(x, y, shipSize);
        //        Random random = new Random();
        //        int directionNumber = random.Next(1, directions.Count);
        //        return directions.ElementAt(directionNumber);
        //    }

        public enum Direction : byte
        {
            East, South, West, North
        }
    }
}
