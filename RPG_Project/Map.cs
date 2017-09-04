using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using MonoGame.Extended;
using System;

namespace RPG_Project
{
    class Map
    {
        //map properties
        private int tileWidth, tileHeight;
        //storage of tiles / 2d array
        private Tile[,] myTiles;
        private Color[,] theMap;
        private Texture2D texSetter;

        private Vector2 spawnPos;
        public Vector2 getSpawnPos
        {
            get { return spawnPos; }
        }

        //constructor
        public Map(int pTileWidth, int pTileHeight, Texture2D pTheMap)
        {
            theMap = Calculations.TextureTo2DArray(pTheMap);

            tileWidth = pTileHeight;
            tileHeight = pTileHeight;

            MapBuild(theMap);
        }
        //loop through all tiles and draw them
        public void Draw(SpriteBatch spriteBatch)
        {
            for (int y = 0; y < theMap.GetLength(1); y++)
            {
                for (int x = 0; x < theMap.GetLength(0); x++)
                {
                    myTiles[x, y].Draw(spriteBatch);
                }
            }
        }

        public void MapBuild(Color[,] inMap)
        {

            myTiles = new Tile[inMap.GetLength(0), inMap.GetLength(1)];

            for (int y = 0; y < inMap.GetLength(1); y++)
            {
                for (int x = 0; x < inMap.GetLength(0); x++)
                {
                    texSetter = MainGame.floorTexture;

                    if (inMap[x, y] == Color.White)
                    {
                        texSetter = MainGame.floorTexture;
                    }
                    else if (inMap[x, y] == Color.Black)
                    {
                        texSetter = MainGame.wallTexture;
                    }
                    else
                    {
                        Console.WriteLine("chords: " + x + " " + y + "Color: " + inMap[x, y]);
                    }
                    myTiles[x, y] = new Tile(texSetter, new Vector2(x * 16, y * 16), new Size2(tileWidth, tileHeight));

                    
                }
            }
        }
        public void PopulateMap(Color[,] inMap)
        {
            for (int y = 0; y < inMap.GetLength(1); y++)
            {
                for (int x = 0; x < inMap.GetLength(0); x++)
                { 

                    if (inMap[x, y] == Color.Green)
                    {
                        spawnPos = new Vector2(x, y);
                        Console.WriteLine("Spawn Position: " + "x" + " " + "y");
                    }
                    else if (inMap[x, y] == Color.Red)
                    {
                        //spawn enemies here
                    }
                }
            }
        }
    }
}
