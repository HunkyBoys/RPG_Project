using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Project
{
    class Player
    {
        private Vector2 position;
        private int speed;
        private Color color;
        private KeyboardState state = Keyboard.GetState();

        public Player(Vector2 pPosition, int pSpeed, Color pColor)
        {
            position = pPosition;
            speed = pSpeed;
            color = pColor;
        }

        public Vector2 GetPosition()
        {
            return (position);
        }

        public void Update(GameTime gameTime)
        {
         
            //movement
            if(state.IsKeyDown(Keys.A))
            {
                position.X--;
            }
            else if (state.IsKeyDown(Keys.D))
            {
                position.X++;
            }
            else if (state.IsKeyDown(Keys.W))
            {
                position.Y--;

            }
            else if (state.IsKeyDown(Keys.S))
            {
                position.Y++;
            }

            
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
        }

    }
}
