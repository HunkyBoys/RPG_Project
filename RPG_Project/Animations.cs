using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Project
{
    class Animations
    {

        public void Draw(SpriteBatch spriteBatch, Texture2D SpriteSheet, Vector2 position, Vector2 size, int framesX, int framesY)
        {
            spriteBatch.Draw(SpriteSheet, position, sourceRectangle: new Rectangle(framesX, framesY, 50, 50));
        }
    }
}
