using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Game
{
    //Map Tile class
    //Stores basic info on what terrain is in a specific location
    class MapTile : MapTileInterface
    {
        private bool Passable; //Can units walk over this tile?
        private String strType; //What type of terrain is here?
        private bool Vissable; //Can the player see this tile?
        private PictureBox pbTileDisplay; //The picture box used to display this tile
        private ImageList imglTextures; //The list of images used for each terrain type;

        public MapTile(String tile_type, PictureBox DisplayBox, ImageList TextureList)
        {
            Vissable = false; //Always start invisable and update later
            Passable = false; //Invisable tiles are always impassable

            pbTileDisplay = DisplayBox;
            imglTextures = TextureList;
            pbTileDisplay.Image = imglTextures.Images[1];

            this.ChangeType(tile_type);
        }

        //Get and set our variables using the interface.
        public void ChangeVissibility(bool vissable)
        {
            Vissable = vissable;

            //If it's now vissable, then display the right texture and check if it should be passable
            if(Vissable)
            {
                if (strType == "Ground")
                {
                    pbTileDisplay.Image = imglTextures.Images[0];
                    Passable = true;
                }
                else if (strType == "Wall")
                {
                    pbTileDisplay.Image = imglTextures.Images[1];
                }
                else
                {
                    //Throw Error
                }
            }
            else //If invisable then it's not passable and looks like wall
            {
                pbTileDisplay.Image = imglTextures.Images[1];
                Passable = false;
            }
        }
        public void ChangeType(string tile_type) //Need to check type is valid
        {
            strType = tile_type;

            //If the tile is vissable, also change the display texture and make passability correct.
            if (Vissable)
            {
                if (strType == "Ground")
                {
                    pbTileDisplay.Image = imglTextures.Images[0];
                    Passable = true;
                }
                else if (strType == "Wall")
                {
                    pbTileDisplay.Image = imglTextures.Images[1];
                    Passable = false;
                }
                else
                {
                    //Throw Error
                }
            }
        }
        public bool IsPassable()
        {
            return Passable;
        }
        public bool IsVissable()
        {
            return Vissable;
        }
        public String GetTileType()
        {
            return strType;
        }
    }
}
