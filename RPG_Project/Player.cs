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
        private KeyboardState state;

        public Animations playerAnimation = new Animations();

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
        public void SetPosition(Vector2 myPosition)
        {
            position = myPosition;
        }

        public void Update(GameTime gameTime)
        {
         state = Keyboard.GetState();
            //movement
            if(state.IsKeyDown(Keys.A))
            {
                position.X-= speed;
            }
            if (state.IsKeyDown(Keys.D))
            {
                position.X+= speed;
            }
            if (state.IsKeyDown(Keys.W))
            {
                position.Y-= speed;

            }
            if (state.IsKeyDown(Keys.S))
            {
                position.Y+= speed;
            }

            playerAnimation.Update(gameTime);
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            playerAnimation.Draw(spriteBatch, MainGame.spriteSheet, position, new Vector2(50, 50));
        }

    }
}
