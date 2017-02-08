using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Game
{
    //This is the map class. It exists to store everything about the current game map, and tell everything else what the map layout is while the game is running.
    //The map is made of a 2x2 array of tiles
    class Map
    {
        private MapTileInterface[,] mtiGameMap; //The map is made of a square array of individual tiles;

        public Map(Map_Stuff.MapBuilderInterface mbiLoad)
        {
            //Get the right map size.
            mtiGameMap = new MapTileInterface[mbiLoad.GetWidth(),mbiLoad.GetHeight()];

            //Make each tile in the map the right type.
            String[,] Layout = mbiLoad.GetMapLayout();
            for(int i=0; i<mbiLoad.GetWidth(); i++)
            {
                for(int j=0; j<mbiLoad.GetHeight(); j++)
                {
                    mtiGameMap[i, j] = new MapTile(Layout[i,j]);
                }
            }
        }
    }
}
