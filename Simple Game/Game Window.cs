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
        //The pictureboxs used to ghow the game map
        private PictureBox[,] GameDisplay;

        public frmGameWindow(Map_Stuff.MapBuilderInterface GameMap)
        {
            InitializeComponent();

            //Build the game display
            GameDisplay = new PictureBox[GameMap.GetWidth(), GameMap.GetHeight()];
            for(int i=0;i<GameDisplay.GetLength(0) ;i++)
            {
                for(int j=0; j<GameDisplay.GetLength(1) ;j++)
                {
                    GameDisplay[i, j] = new PictureBox();
                    GameDisplay[i, j].Location = new Point(i*40,j*40);
                    GameDisplay[i, j].Size = new Size(40, 40);
                    GameDisplay[i, j].Image = imglstGroundImages.Images[0];
                    this.Controls.Add(GameDisplay[i, j]);
                }
            }
        }
    }
}
