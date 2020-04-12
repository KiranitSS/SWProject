using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShipsWar.Model;
using BLL;

namespace ShipsWar.UI.WinForms
{
    public partial class Form1 : Form
    {
        readonly int cellSize = 40;
        readonly int enemyFieldStartX = 800;
        readonly int enemyFieldStartY = 50;
        readonly int playerFieldStartX = 50;
        readonly int playerFieldStartY = 50;

        Game _game;
        public Form1()
        {
            InitializeComponent();            
        }

        public Form1(Game game):base()
        {
            _game = game;

            DrawInitialForm();
        }

        private void DrawInitialForm()
        {

        }
        #region Fields
        public void DrawEnemyField()
        {
            DrawField(this.enemyFieldStartX, this.enemyFieldStartY, _game.enemyField);
        }
        public void DrawPlayerField()
        {
            DrawField(this.playerFieldStartX, this.playerFieldStartY, _game.playerField);
        }

        private void DrawField(int startX, int startY, Field field)
        {
            foreach (var cell in field.Cells)
            {
                this.DrawCell(startX, startY, cell, this.cellSize);
            }
        }
        #endregion
        private void DrawCell(int startX, int startY, Cell cell, int size)
        {

            Color color;
            switch (cell.Type)
            {
                case CellType.Sea:
                    color = Color.AliceBlue;
                    break;
                case CellType.ShootedSea:
                    color = Color.Yellow;
                    break;
                case CellType.Ship:
                    color = Color.Black;
                    break;
                case CellType.ShootedShip:
                    color = Color.Red;
                    break;
                default:
                    throw new Exception("Unknown cell type");
            }
            Button button = new Button();
            button.Location = new Point(startX + (cell.X - 1) * size, startY + (cell.Y - 1) * size);
            button.Size = new Size(size, size);
            button.BackColor = color;

            this.Controls.Add(button);
        }

        //    //private void ChangeCellColor(Color color, Button button)
        //    //{
        //    //    button.BackColor = Color.Green;
        //    //}

        //    //private void AttackedCellColor(Color color, Button button)
        //    //{
        //    //    button.BackColor = Color.Red;
        //    //}
        //    //private void Button_Click(object sender, System.EventArgs e)
        //    //{
        //    //    ChangeCellColor(Color.Black, (Button)sender);
        //    //}

        //    private void DrawShip(Direction direction, Cell startCell)
        //    {
        //        switch (direction)
        //        {
        //            case Direction.East:
        //                DrawShipToEast();
        //                break;
        //            case Direction.South:
        //                DrawShipToSouth();
        //                break;
        //            case Direction.West:
        //                DrawShipToWest();
        //                break;
        //            case Direction.North:
        //                DrawShipToNorth();
        //                break;
        //        }
        //    }

        //    private void DrawShipToEast()
        //    {

        //    }
        //    private void DrawShipToSouth()
        //    {

        //    }
        //    private void DrawShipToNorth()
        //    {

        //    }
        //    private void DrawShipToWest()
        //    {

        //    }
        //    /*   private bool CheckCell()
        //       {
        //           switch ()
        //           {
        //               case :
        //           }
        //           return true;
        //       }*/
        //}

    }
}
