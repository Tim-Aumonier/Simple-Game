using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Game
{
    //This is the map class. It exists to store everything about the current game map, and tell everything else what the map layout is while the game is running.
    //The map is made of a 2x2 array of tiles
    class Map : Map_Stuff.MapInterface
    {
        private MapTileInterface[,] mtiGameMap; //The map is made of a square array of individual tiles;
        private int intMapWidth;
        private int intMapHeight;

        public Map(Map_Stuff.MapBuilderInterface mbiLoad, PictureBox[,] DisplayForTiles, ImageList TexturesForTiles)
        {
            //Get the right map size.
            intMapHeight = mbiLoad.GetHeight();
            intMapWidth = mbiLoad.GetWidth();
            mtiGameMap = new MapTileInterface[intMapWidth, intMapHeight];

            //Make each tile in the map the right type.
            String[,] Layout = mbiLoad.GetMapLayout();
            for(int i=0; i<intMapWidth; i++)
            {
                for(int j=0; j<intMapHeight; j++)
                {
                    mtiGameMap[i, j] = new MapTile(Layout[i,j], DisplayForTiles[i,j], TexturesForTiles);
                }
            }

            //Make our starting tile vissable
            MakeTileVissable(mbiLoad.GetStartingLocation());
        }

        public String GetSpicificTileType(int[] location)
        {
            return mtiGameMap[location[0], location[1]].GetTileType();
        }

        private void MakeTileVissable(int[] location)
        {
            mtiGameMap[location[0], location[1]].ChangeVissibility(true);

            //If the tile is also ground, make all it's neighbours vissable as well
            int[] newlocation = new int[] { 0, 0 };

            //If it's ground
            if (GetSpicificTileType(location) == "Ground")
            {
                //Go through neighbours
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        newlocation[0] = location[0] + i;
                        newlocation[1] = location[1] + j;
                        //if tile location is valid place in map
                        if(newlocation[0] >= 0 && newlocation[1] >= 0 && newlocation[0] < intMapWidth && newlocation[1] < intMapHeight)
                        {
                            //check if already vissable
                            if(!mtiGameMap[newlocation[0],newlocation[1]].IsVissable())
                            {
                                //and make it vissable if not
                                MakeTileVissable(newlocation);
                            }
                        }
                    }
                }
            }
        }
    }
}
