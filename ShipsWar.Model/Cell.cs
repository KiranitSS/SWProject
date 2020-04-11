using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipsWar.Model
{
    public class Cell
    {
        private int x;
        private int y;
        private int id;
        static int count = 1;

        public int Id { get { return id; } }
        public int X { get { return x; } }
        public int Y { get { return y; } }

        public CellType Type { get; set; }

        public Cell(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.id = count++;
        }
    }
    public enum CellType : byte
    {
        Sea,
        ShootedSea,
        Ship,
        ShootedShip
    }
}
