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
        private Tile.TileType tileSetter;

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
                    switch (inMap[x, y].R)
                    {
                        case 0:
                            tileSetter = Tile.TileType.wall;
                            break;
                        case 1:
                            tileSetter = Tile.TileType.floor;
                            break;
                        default:
                            tileSetter = Tile.TileType.floor;
                            Console.Write(" \n ERROR: X: {0} y: {1} R: {2} G: {3} B: {4}", x, y, inMap[x, y].R, inMap[x, y].G, inMap[x, y].B);
                            break;
                    }
                    switch (inMap[x, y].B)
                    {
                        case 0:
                            //nothing
                            break;
                        case 1:
                            spawnPos = new Vector2(x, y);
                            Console.Write(" \n SPAWN: X: {0} y: {1} R: {2} G: {3} B: {4}", x, y, inMap[x, y].R, inMap[x, y].G, inMap[x, y].B);
                            break;
                    }

                    myTiles[x, y] = new Tile(tileSetter, new Vector2(x * 16, y * 16), new Size2(tileWidth, tileHeight));
                }

            }
        }
    }
}
            
        


