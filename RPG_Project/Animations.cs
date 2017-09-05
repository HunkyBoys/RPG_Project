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
        static double step = 0;
        static int framesX = 0;
        public static void Update(GameTime gameTime)
        {
            step +=gameTime.ElapsedGameTime.TotalSeconds;
            if (step >2.5) {
                step = 0;
            }
            if (step > 0) { framesX = 0; }
            if (step > 0.5) { framesX = 50; }
            if (step > 1) { framesX = 100; }
            if (step > 1.5) { framesX = 150; }
            if (step > 2) { framesX = 200; }
        }

        public static void Draw(SpriteBatch spriteBatch, Texture2D spriteSheet, Vector2 position, Vector2 size)
        {
            
            spriteBatch.Draw(spriteSheet, position, sourceRectangle: new Rectangle(framesX, 0,  (int)size.X, (int)size.Y));
        }
    }
}
