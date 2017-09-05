using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonoGame.Extended;
namespace RPG_Project
{


    class Tile
    {
        private Vector2 position;
        private Texture2D texture;
        private Size2 size;
        public enum TileType
        {
            wall,
            floor
        }
        public TileType myType;



        public Tile(TileType type, Vector2 pPosition, Size2 pSize)
        {
            position = pPosition;
            myType = type;
            switch (myType)
            {
                case TileType.wall:
                    texture = MainGame.wallTexture;
                    break;
                case TileType.floor:
                    texture = MainGame.floorTexture;
                    break;
            }
            size = pSize;
        }



        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }
    }
}
