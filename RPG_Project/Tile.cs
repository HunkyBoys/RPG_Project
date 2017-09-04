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




        public Tile(Texture2D pTexture, Vector2 pPosition, Size2 pSize)
        {
            position = pPosition;
            texture = pTexture;
            size = pSize;
        }



        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }
    }
}
