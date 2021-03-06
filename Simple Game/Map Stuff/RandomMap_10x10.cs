﻿using System;
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

        private int[] intStartingLocation; //The starting square. This should be ground and is where visibility spreads out from

        public RandomMap_10x10()
        {
            Map = new String[10, 10];
            Random rnd = new Random();
            int intRandomPercent = 0;

            for(int i=0; i<10; i++)
            {
                for(int j=0; j<10; j++)
                {
                    if(i >0 && i < 9 && j > 0 && j < 9)
                    {

                        intRandomPercent = rnd.Next(0, 99);
                        //40% ground, otherwise wall
                        if(intRandomPercent<40)
                        {
                            Map[i, j] = "Ground";
                        }
                        else
                        {
                            Map[i, j] = "Wall";
                        }
                    }
                    else
                    {
                        Map[i, j] = "Wall"; //All border tiles are Walls
                    }

                }
            }

            //Set the starting location and make sure it's ground
            intStartingLocation = new int[] { 5, 6 };
            Map[intStartingLocation[0], intStartingLocation[1]] = "Ground";
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
        int[] MapBuilderInterface.GetStartingLocation()
        {
            return intStartingLocation;
        }
    }
}
