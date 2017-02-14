using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Game
{
    public partial class frmGameWindow : Form
    {
        //Object which controls the actual Game Map
        private Map_Stuff.MapInterface CurrentTerrain;

        public frmGameWindow(Map_Stuff.MapBuilderInterface GameMap)
        {
            InitializeComponent();

            //Build the game display, a 2dimensional array the same size as the game map
            PictureBox[,] GameDisplay = new PictureBox[GameMap.GetWidth(), GameMap.GetHeight()];

            for (int i = 0; i < GameDisplay.GetLength(0); i++)
            {
                for (int j = 0; j < GameDisplay.GetLength(1); j++)
                {
                    GameDisplay[i, j] = new PictureBox();
                    GameDisplay[i, j].Location = new Point(i * 40, j * 40);
                    GameDisplay[i, j].Size = new Size(40, 40);

                    this.Controls.Add(GameDisplay[i, j]);
                }
            }

            CurrentTerrain = new Simple_Game.Map(GameMap, GameDisplay, imglstTileImages);
        }
    }
}
