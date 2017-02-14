using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Game
{
    //The interface for the map tile class.
    //Needs to show we have get and set methods for each of its 3 variables.
    interface MapTileInterface
    {
        void ChangeType(String tile_type);
        void ChangeVissibility(bool vissable);
        bool IsPassable();
        bool IsVissable();
        String GetTileType();
    }
}
