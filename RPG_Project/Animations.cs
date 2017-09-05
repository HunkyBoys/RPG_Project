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
        int step = 0;
        int framesX = 0;
        public void Update(GameTime gameTime)
        {
            step = gameTime.ElapsedGameTime.Seconds;
            if (step > 4) {
                step = 0;
            }
            if(step == 0) { framesX = 0; }
            if (step == 1) { framesX = 50; }
            if (step == 2) { framesX = 100; }
            if (step == 3) { framesX = 150; }
            if (step == 4) { framesX = 200; }
        }

        public void Draw(SpriteBatch spriteBatch, Texture2D SpriteSheet, Vector2 position, Vector2 size)
        {
            
            spriteBatch.Draw(SpriteSheet, position, sourceRectangle: new Rectangle(framesX, 0,  50, 50));
        }
    }
}
