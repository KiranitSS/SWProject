using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipsWar.Model
{
    public class Field
    {
        public List<Cell> Cells { get; set; }

        public Field()
        {
            Cells = new List<Cell>();
        }
        public void Add(Cell cell)
        {
            Cells.Add(cell);
        }

        public void Edit(Cell cell)
        {
            Cell foundCell = this.Cells.FirstOrDefault(c => c.Id == cell.Id);
            foundCell.Type = cell.Type;
        }
    }
}
