using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Game.Map_Stuff
{
    //This is the interface for any class which does the work of constructing a map
    //It can be used for a random map generator, something to load a pre-built level, or something to load save files
    public interface MapBuilderInterface
    {
        String[,] GetMapLayout();
        int GetWidth();
        int GetHeight();
    }
}
