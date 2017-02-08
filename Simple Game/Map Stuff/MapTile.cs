using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Game
{
    //Map Tile class
    //Stores basic info on what terrain is in a specific location
    class MapTile : MapTileInterface
    {
        private bool Passable; //Can units walk over this tile?
        private String strType; //What type of terrain is here?
        private bool Vissable; //Can the player see this tile?

        public MapTile(String tile_type)
        {
            strType = tile_type;
            Vissable = false; //Always start invisable and update later
            Passable = false; //Invisable tiles are always impassable
        }

        //Get and set our variables using the interface
        void MapTileInterface.ChangePassability(bool passable) //Need to check tile isn't currently invissable
        {
            Passable = passable;
        }
        void MapTileInterface.ChangeVissibility(bool vissable)
        {
            Vissable = vissable;
            Passable = false;
        }
        void MapTileInterface.ChangeType(string tile_type) //Need to check type is valid
        {
            strType = tile_type;
        }
        bool MapTileInterface.IsPassable()
        {
            return Passable;
        }
        bool MapTileInterface.IsVissable()
        {
            return Vissable;
        }
        String MapTileInterface.GetType()
        {
            return strType;
        }
    }
}
