using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Game.Map_Stuff
{
    //Generates a random 10x10 map
    class RandomMap_10x10 : MapBuilderInterface
    {
        private String[,] Map;

        public RandomMap_10x10()
        {
            Map = new String[10, 10];

            for(int i=0; i<10; i++)
            {
                for(int j=0; j<10; j++)
                {
                    Map[i, j] = "Ground"; //Needs random function
                }
            }
        }

        //Interface methods
        String[,] MapBuilderInterface.GetMapLayout()
        {
            return Map;
        }
        int MapBuilderInterface.GetHeight()
        {
            return 10;
        }
        int MapBuilderInterface.GetWidth()
        {
            return 10;
        }
    }
}
